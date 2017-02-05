using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Zaiba2
{
    public partial class frmMonitor : Form
    {
        public string constring { get; set; }
        System.Timers.Timer BatchTimer = new System.Timers.Timer();
        System.Timers.Timer CPUTimer = new System.Timers.Timer();
        System.Timers.Timer IOPSTimer = new System.Timers.Timer();
        System.Timers.Timer ThroughputTimer = new System.Timers.Timer();

        bool isBatchTimerRunning = false;
        bool isCPUTimerRunning = false;
        bool isIOPSTimerRunning = false;
        bool isThroughputTimerRunning = false;


        #region フォームの制御
        public frmMonitor()
        {
            InitializeComponent();
            BatchTimer.Interval = Properties.Settings.Default.MonitorInitialInterval;
            BatchTimer.Elapsed += new ElapsedEventHandler(GetBatchRequest);
            BatchTimer.Start();

            CPUTimer.Interval = Properties.Settings.Default.MonitorInitialInterval;
            CPUTimer.Elapsed += new ElapsedEventHandler(GetCPURequest);
            CPUTimer.Start();

            IOPSTimer.Interval = Properties.Settings.Default.MonitorInitialInterval;
            IOPSTimer.Elapsed += new ElapsedEventHandler(GetIOPSRequest);
            IOPSTimer.Start();

            ThroughputTimer.Interval = Properties.Settings.Default.MonitorInitialInterval;
            ThroughputTimer.Elapsed += new ElapsedEventHandler(GetThroughputRequest);
            ThroughputTimer.Start();
        }

        private void frmMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            BatchTimer.Stop();
            CPUTimer.Stop();
            IOPSTimer.Stop();
        }
        #endregion

        #region バッチ実行状態
        private void GetBatchRequest(object sender, EventArgs e)
        {
            string sql = @"
DECLARE @previous_time datetime, @current_time datetime
DECLARE @previous_count bigint, @current_count bigint

SELECT @previous_time = GETDATE(), @previous_count = cntr_value from sys.dm_os_performance_counters where counter_name ='Batch Requests/sec'

WAITFOR DELAY '00:00:01'

SELECT @current_time = GETDATE(), @current_count = cntr_value from sys.dm_os_performance_counters where counter_name ='Batch Requests/sec'

SELECT CAST((@current_count - @previous_count ) / (DATEDIFF(ms, @previous_time, @current_time) / 1000.0) AS bigint) AS batch_request
";
            if (isBatchTimerRunning == true){return;}
            else{isBatchTimerRunning = true;
            }
            long data;
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = constring;
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, con);
                var dr = cmd.ExecuteReader();

                dr.Read();

                data = dr.GetInt64(0);

                System.Data.SqlClient.SqlConnection.ClearPool(con); // 単一接続で複数のモニターの情報を取得するまでのセッション数節約の暫定対応
            }
            
            SetBatchChart(data);
            isBatchTimerRunning = false;
        }
        delegate void SetBatchChartDelegate(double data);
        private void SetBatchChart(double data)
        {
            if (!this.IsHandleCreated) return;
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new SetBatchChartDelegate(SetBatchChart), data);
                    return;
                }
                chartBatch.Series[0].Points.Add(data);
                double max = 0;
                foreach (var point in chartBatch.Series[0].Points)
                {
                    if (max < point.YValues[0])
                    {
                        max = point.YValues[0];
                    }
                }
                chartBatch.ChartAreas[0].AxisY.Maximum = max + 10;

                if (chartBatch.Series[0].Points.Count > 60)
                {
                    chartBatch.Series[0].Points.RemoveAt(0);
                }

            }
            // 後で治しますが、握りつぶしてごめんなさい。。。。
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }
        #endregion

        #region CPU 使用状況
        private void GetCPURequest(object sender, EventArgs e)
        {
            string sql = @"
IF CHARINDEX('SQL Azure', CAST(SERVERPROPERTY('Edition') AS nvarchar(255))) = 0
BEGIN
	SELECT 
		1 AS No,
		RTRIM(pr.object_name) AS object_name,
		'CPU usage %' AS counter_name,
		RTRIM(pr.instance_name) AS instance_name,
		CASE
			WHEN pr.cntr_value = 0 THEN 0
			ELSE CAST((CAST(pr.cntr_value AS FLOAT) / pb.cntr_value) * 100 AS numeric(5,2))
		END AS 'cpu_usage'                                                                                           
	FROM 
		sys.dm_os_performance_counters pr
		INNER JOIN
		sys.dm_os_performance_counters pb
		ON
		pr.object_name = pb.object_name
		AND
		pr.instance_name = pb.instance_name
		AND
		pb.counter_name = 'CPU usage % base'
	WHERE 
		pr.object_name like '%Resource Pool Stats%' AND pr.counter_name = 'CPU usage %'
		And
		pr.instance_name = 'default'
	UNION
	SELECT
		2 AS No,
		RTRIM(pr.object_name) AS object_name,
		'CPU usage %' AS counter_name,
		RTRIM(pr.instance_name) AS instance_name,
		CASE
			WHEN pr.cntr_value = 0 THEN 0
			ELSE CAST((CAST(pr.cntr_value AS FLOAT) / pb.cntr_value) * 100 AS numeric(5,2))
		END AS 'cpu_usage'                                                                                           
	FROM 
		sys.dm_os_performance_counters pr
		INNER JOIN
		sys.dm_os_performance_counters pb
		ON
		pr.object_name = pb.object_name
		AND
		pr.instance_name = pb.instance_name
		AND
		pb.counter_name = 'CPU usage % base'
	WHERE 
		pr.object_name like '%Resource Pool Stats%' AND pr.counter_name = 'CPU usage %'
		And
		pr.instance_name = 'internal'
	ORDER BY 1 ASC
END
ELSE
BEGIN
	SELECT 
		1 AS No,
		RTRIM(pr.object_name) AS object_name,
		'CPU usage %' AS counter_name,
		RTRIM(pr.instance_name) AS instance_name,
		CASE
			WHEN pr.cntr_value = 0 THEN 0
			ELSE CAST((CAST(pr.cntr_value AS FLOAT) / pb.cntr_value) * 100 AS numeric(5,2))
		END AS 'cpu_usage'                                                                                           
	FROM 
		sys.dm_os_performance_counters pr
		INNER JOIN
		sys.dm_os_performance_counters pb
		ON
		pr.object_name = pb.object_name
		AND
		pr.instance_name = pb.instance_name
		AND
		pb.counter_name = 'CPU usage % base'
	WHERE 
		pr.object_name like '%Resource Pool Stats%' AND pr.counter_name = 'CPU usage %'
		And
		pr.instance_name = 'SloSharedPool1' 
        Or
		pr.instance_name LIKE 'SloPool%' 
	UNION
	SELECT 
		2 AS No,
		RTRIM(pr.object_name) AS object_name,
		'CPU usage %' AS counter_name,
		RTRIM(pr.instance_name) AS instance_name,
		CASE
			WHEN pr.cntr_value = 0 THEN 0
			ELSE CAST((CAST(pr.cntr_value AS FLOAT) / pb.cntr_value) * 100 AS numeric(5,2))
		END AS 'cpu_usage'                                                                                           
	FROM 
		sys.dm_os_performance_counters pr
		INNER JOIN
		sys.dm_os_performance_counters pb
		ON
		pr.object_name = pb.object_name
		AND
		pr.instance_name = pb.instance_name
		AND
		pb.counter_name = 'CPU usage % base'
	WHERE 
		pr.object_name like '%Resource Pool Stats%' AND pr.counter_name = 'CPU usage %'
		And
		pr.instance_name = 'internal' 
	ORDER BY 1
END
";
            if (isCPUTimerRunning == true){return;}
            else{isCPUTimerRunning = true;}

            List<double> data = new List<double>();

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = constring;
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, con);
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    data.Add((double)dr.GetDecimal(4));
                }

                System.Data.SqlClient.SqlConnection.ClearPool(con); // 単一接続で複数のモニターの情報を取得するまでのセッション数節約の暫定対応
            }
            SetCPUChart(data);

            isCPUTimerRunning = false;
        }

        delegate void SetCPUChartDelegate(List<double> data);

        private void SetCPUChart(List<double> data)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new SetCPUChartDelegate(SetCPUChart), data);
                    return;
                }
                chartCPU.Series[0].Points.Add(data[0]);
                chartCPU.Series[1].Points.Add(data[1]);

                if (chartCPU.Series[0].Points.Count > 60)
                {
                    chartCPU.Series[0].Points.RemoveAt(0);
                    chartCPU.Series[1].Points.RemoveAt(0);

                }

            }
            // 後で治しますが、握りつぶしてごめんなさい。。。。
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        #endregion

        #region データベース IOPS
        private void GetIOPSRequest(object sender, EventArgs e)
        {
            string sql = @"
DECLARE @previous_time datetime, @current_time datetime
DECLARE @previous_read_count bigint, @current_read_count bigint
DECLARE @previous_write_count bigint, @current_write_count bigint

SELECT
	@previous_time = GETDATE(),
	@previous_read_count = SUM([fn_virtualfilestats].[NumberReads]),
	@previous_write_count = SUM([fn_virtualfilestats].[NumberWrites])
FROM
	fn_virtualfilestats(NULL, NULL)

WAITFOR DELAY '00:00:01'

SELECT
	@current_time = GETDATE(),
	@current_read_count = SUM([fn_virtualfilestats].[NumberReads]),
	@current_write_count = SUM([fn_virtualfilestats].[NumberWrites])
FROM
	fn_virtualfilestats(NULL, NULL)
SELECT
	CAST((@current_read_count - @previous_read_count ) / (DATEDIFF(ms, @previous_time, @current_time) / 1000.0) AS bigint) AS NumberReads,
	CAST((@current_write_count - @previous_write_count ) / (DATEDIFF(ms, @previous_time, @current_time) / 1000.0) AS bigint) AS NumberWrites
";
            if (isIOPSTimerRunning == true){return;}
            else{isIOPSTimerRunning = true;}
            List<long> data = new List<long>();

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = constring;
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, con);
                var dr = cmd.ExecuteReader();

                dr.Read();

                data.Add(dr.GetInt64(0));
                data.Add(dr.GetInt64(1));

                System.Data.SqlClient.SqlConnection.ClearPool(con); // 単一接続で複数のモニターの情報を取得するまでのセッション数節約の暫定対応

            }
            SetIOPSChart(data);

            isIOPSTimerRunning = false;
        }
        delegate void SetIOPSChartDelegate(List<long> data);
        private void SetIOPSChart(List<long> data)
        {
            if (!this.IsHandleCreated) return;
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new SetIOPSChartDelegate(SetIOPSChart), data);
                    return;
                }
                chartIOPS.Series[0].Points.Add(data[0]);
                chartIOPS.Series[1].Points.Add(data[1]);

                double max = 0;
                foreach (var point in chartIOPS.Series[0].Points)
                {
                    if (max < point.YValues[0])
                    {
                        max = point.YValues[0];
                    }
                }
                foreach (var point in chartIOPS.Series[1].Points)
                {
                    if (max < point.YValues[0])
                    {
                        max = point.YValues[0];
                    }
                }
                chartIOPS.ChartAreas[0].AxisY.Maximum = max + 10;

                if (chartIOPS.Series[0].Points.Count > 60)
                {
                    chartIOPS.Series[0].Points.RemoveAt(0);
                    chartIOPS.Series[1].Points.RemoveAt(0);
                }

            }
            // 後で治しますが、握りつぶしてごめんなさい。。。。
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }
        #endregion

        #region データベーススループット
        private void GetThroughputRequest(object sender, EventArgs e)
        {
            string sql = @"
DECLARE @previous_time datetime, @current_time datetime
DECLARE @previous_readbyte bigint, @current_readbyte bigint
DECLARE @previous_writebyte bigint, @current_writebyte bigint

SELECT
	@previous_time = GETDATE(),
	@previous_readbyte = SUM([fn_virtualfilestats].[BytesRead]),
	@previous_writebyte = SUM([fn_virtualfilestats].[BytesWritten])
FROM
	fn_virtualfilestats(NULL, NULL)

WAITFOR DELAY '00:00:01'

SELECT
	@current_time = GETDATE(),
	@current_readbyte = SUM([fn_virtualfilestats].[BytesRead]),
	@current_writebyte = SUM([fn_virtualfilestats].[BytesWritten])
FROM
	fn_virtualfilestats(NULL, NULL)

SELECT
	CAST((@current_readbyte - @previous_readbyte ) / (DATEDIFF(ms, @previous_time, @current_time) / 1000.0) AS bigint) / POWER(1024,2) AS [MBytesRead],
	CAST((@current_writebyte - @previous_writebyte ) / (DATEDIFF(ms, @previous_time, @current_time) / 1000.0) AS bigint) / POWER(1024,2) AS [MBytesWritten]
";
            if (isThroughputTimerRunning == true)
            {
                return;
            }
            else
            {
                isThroughputTimerRunning = true;
            }
            List<long> data = new List<long>();

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = constring;
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, con);
                var dr = cmd.ExecuteReader();

                dr.Read();

                data.Add(dr.GetInt64(0));
                data.Add(dr.GetInt64(1));

                System.Data.SqlClient.SqlConnection.ClearPool(con); // 単一接続で複数のモニターの情報を取得するまでのセッション数節約の暫定対応

            }
            SetThroughputChart(data);

            isThroughputTimerRunning = false;
        }
        delegate void SetThroughputChartDelegate(List<long> data);
        private void SetThroughputChart(List<long> data)
        {
            if (!this.IsHandleCreated) return;
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new SetThroughputChartDelegate(SetThroughputChart), data);
                    return;
                }
                chartThroughput.Series[0].Points.Add(data[0]);
                chartThroughput.Series[1].Points.Add(data[1]);

                double max = 0;
                foreach (var point in chartThroughput.Series[0].Points)
                {
                    if (max < point.YValues[0])
                    {
                        max = point.YValues[0];
                    }
                }
                foreach (var point in chartThroughput.Series[1].Points)
                {
                    if (max < point.YValues[0])
                    {
                        max = point.YValues[0];
                    }
                }
                chartThroughput.ChartAreas[0].AxisY.Maximum = max + 10;

                if (chartThroughput.Series[0].Points.Count > 60)
                {
                    chartThroughput.Series[0].Points.RemoveAt(0);
                    chartThroughput.Series[1].Points.RemoveAt(0);
                }

            }
            // 後で治しますが、握りつぶしてごめんなさい。。。。
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }
        #endregion
    }
}
