using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaiba2.Common
{
    public class BaseQuery
    {
        public string[] QueryTemplate = new string[]
        {
@"DECLARE @starttime datetime = (SELECT sqlserver_start_time FROM sys.dm_os_sys_info)
SELECT
    qp.session_id, 
	DB_NAME(qp.database_id) AS db_name,
    qp.request_id, 
    ot.task_state,
    qp.physical_operator_name, 
    qp.node_id, 
    qp.thread_id, 
    qp.row_count,
    qp.estimate_row_count,
    CASE 
        WHEN row_count = 0 OR estimate_row_count = 0 THEN 0.0
        ELSE convert(float,qp.row_count) / qp.estimate_row_count * 100.0
    END as progress,
	DATEADD(ms, qp.first_active_time, @starttime) AS FirstActiveTime,
	DATEADD(ms, qp.last_active_time, @starttime) AS LastActiveTime,
	CASE qp.open_time
		WHEN 0 THEN NULL
		ELSE DATEADD(ms, qp.open_time, @starttime) 
	END AS OpenTime,
	CASE qp.close_time
		WHEN 0 THEN NULL
		ELSE DATEADD(ms, qp.close_time, @starttime) 
	END AS CloseTime,
	qp.elapsed_time_ms,
	qp.cpu_time_ms
FROM
    sys.dm_exec_query_profiles qp
    CROSS APPLY
    sys.dm_exec_sql_text (sql_handle) t
    CROSS APPLY
    sys.dm_exec_query_plan(plan_handle) p
    LEFT JOIN
    sys.dm_os_tasks ot
ON
    qp.task_address = ot.task_address
WHERE
	qp.session_id <> @@SPID
ORDER BY
    session_id, request_id, node_id, thread_id",
@"SELECT
    qp.session_id, 
	DB_NAME(qp.database_id) AS db_name,
    qp.request_id, 
    ot.task_state,
    qp.physical_operator_name, 
    qp.node_id, 
    qp.thread_id, 
    qp.row_count,
    qp.estimate_row_count,
	qp.elapsed_time_ms,
	qp.cpu_time_ms
FROM
    sys.dm_exec_query_profiles qp
    CROSS APPLY
    sys.dm_exec_sql_text (sql_handle) t
    CROSS APPLY
    sys.dm_exec_query_plan(plan_handle) p
    LEFT JOIN
    sys.dm_os_tasks ot
ON
    qp.task_address = ot.task_address
WHERE
	qp.session_id <> @@SPID
ORDER BY
    session_id, request_id, node_id, thread_id",
@"SELECT
	DB_NAME([sys].[master_files].[database_id]) AS [DatabaseName], 
	type_desc,
	SUM([fn_virtualfilestats].[NumberReads]) AS [NumberReads],
	SUM([fn_virtualfilestats].[IoStallReadMS]) AS [IoStallReadMS],
	SUM([fn_virtualfilestats].[BytesRead]) AS [BytesRead], 
	SUM([fn_virtualfilestats].[NumberWrites]) AS [NumberWrites], 
	SUM([fn_virtualfilestats].[IoStallWriteMS]) AS [IoStallWriteMS],
	SUM([fn_virtualfilestats].[BytesWritten]) AS [BytesWritten], 
	SUM([fn_virtualfilestats].[BytesOnDisk]) AS [BytesOnDisk]
FROM
	fn_virtualfilestats(NULL, NULL)
	LEFT JOIN
	[sys].[master_files]  WITH (NOLOCK)
	ON
		fn_virtualfilestats.DbId = [sys].[master_files].[database_id]
		AND
		fn_virtualfilestats.FileId = [sys].[master_files].[file_id]
GROUP BY
	database_id,
	type_desc,
	type
ORDER BY
	database_id,
	type
OPTION (RECOMPILE)",
@"SELECT 
	[database_files].[name], 
	[database_files].[type_desc],
	[database_files].[size] * 8.0 AS size,  
	[database_files].[max_size] * 8.0 AS max_size_KB,  
	[database_files].[growth],
	CASE [is_percent_growth]
		WHEN 0 THEN [database_files].[growth] * 8.0 
		ELSE [growth]
	END AS [converted_growth],
	[database_files].[is_percent_growth],
	[fn_virtualfilestats].[NumberReads], 
	[fn_virtualfilestats].[IoStallReadMS], 
	[fn_virtualfilestats].[BytesRead],  
	[fn_virtualfilestats].[NumberWrites],  
	[fn_virtualfilestats].[IoStallWriteMS], 
	[fn_virtualfilestats].[BytesWritten],  
	[fn_virtualfilestats].[BytesOnDisk] 
FROM 
	fn_virtualfilestats(DB_ID(), NULL) 
	LEFT JOIN
	sys.database_files
	ON
	database_files.file_id  = fn_virtualfilestats.FileId
OPTION (RECOMPILE)",
@"
SELECT
    es.session_id,
    er.request_id,
    er.start_time,
    es.last_request_start_time,
    es.last_request_end_time,
    er.command,
    es.status,
    er.wait_type,
    er.last_wait_type,
    er.wait_resource,
    er.wait_time,
    es.total_elapsed_time,
    er.total_elapsed_time AS exec_requests_total_elapsed_time,
    es.cpu_time,
    er.cpu_time AS exec_requests_cpu_time,
    er.database_id,
    DB_NAME(DB_ID()) AS database_name,
    er.user_id,
    er.open_resultset_count,
    er.open_resultset_count,
    er.percent_complete,
    er.estimated_completion_time,
    es.memory_usage,
    es.total_scheduled_time,
    es.reads,
    er.reads AS exec_requests_reads,
    es.writes,
    er.writes AS exec_requests_writes,
    es.logical_reads,
    er.logical_reads AS exec_requests_logical_reads,
    es.row_count,
    er.row_count AS exec_requests_row_count,
    er.granted_query_memory,
    er.scheduler_id,
    er.transaction_isolation_level,
    er.executing_managed_code,
    es.lock_timeout,
    er.lock_timeout as exec_requests_lock_timeout,
    es.deadlock_priority,
    er.deadlock_priority AS exec_requests_deadlock_priority,
    es.host_name,
    es.program_name,
    es.login_time,
    es.login_name,
    es.client_version,
    es.client_interface_name
FROM
    sys.dm_exec_sessions es
    LEFT JOIN
    sys.dm_exec_requests er
    ON
    es.session_id = er.session_id
    LEFT JOIN
    (SELECT * FROM sys.dm_exec_connections WHERE most_recent_sql_handle <> 0x0) AS ec
    ON
    es.session_id = ec.session_id
    OUTER APPLY
    sys.dm_exec_sql_text(er.sql_handle) AS er_text
    OUTER APPLY
    sys.dm_exec_sql_text(ec.most_recent_sql_handle) AS ec_text
WHERE
	er.session_id > 50
	AND
    es.session_id <> @@SPID
ORDER BY

    session_id ASC"
        };
        public Dictionary<string, int> GetTemplateList()
        {
            Dictionary<String, int> TemplateList = new Dictionary<string, int>();
            TemplateList.Add("クエリ実行状況の取得 (SQL Server)", 0);
            TemplateList.Add("クエリ実行状況の取得 (SQL Database)", 1);
            TemplateList.Add("ファイル I/O の取得 (SQL Server)", 2);
            TemplateList.Add("ファイル I/O の取得 (SQL Database)", 3);
            TemplateList.Add("利用状況モニター (SQL Server/SQL Database)", 4);
            return TemplateList;
        }
        
    }


}
