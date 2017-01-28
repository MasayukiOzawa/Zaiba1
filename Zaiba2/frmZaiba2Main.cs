using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Timers;
using Zaiba2.Common;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace Zaiba2
{
    public partial class frmZaiba2Main : Form
    {
        string constring = string.Empty;
        int commandtimeout = Properties.Settings.Default.CommandTimeout;
        System.Timers.Timer GridTimer = new System.Timers.Timer();
        XMLBaseQuery model;

        public frmZaiba2Main()
        {
            InitializeComponent();
            txtConnectionString.Text = ConfigurationManager.ConnectionStrings["Zaiba2.Properties.Settings.DBConnection"].ConnectionString;

            XmlSerializer serializer = new XmlSerializer(typeof(XMLBaseQuery));
            FileStream fs = new FileStream(@".\QueryTemplate.xml", FileMode.Open);

            model = (XMLBaseQuery)serializer.Deserialize(fs);
            model.Query.Sort((a, b) => a.index - b.index);

            foreach (Query query in model.Query)
            {
                dataSetQueryTemplate.DataTableQueryTemplate.AddDataTableQueryTemplateRow(query.name, query.index);
            }

            txtQuery.Text = model.Query[0].sql;
            txtInterval.Text = Properties.Settings.Default.InitialInterval.ToString();

            //BaseQuery query = new BaseQuery();
            //txtQuery.Text = query.QueryTemplate[0];
            //Dictionary<String, int> TempLateList = query.GetTemplateList();
            //foreach(var _Template in TempLateList.Keys)
            //{
            //    dataSetQueryTemplate.DataTableQueryTemplate.AddDataTableQueryTemplateRow(_Template,TempLateList[_Template] );
            //}
        }


        private void GetData(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try {
                    SqlCommand cmd = new SqlCommand(txtQuery.Text, con);
                    cmd.CommandTimeout = commandtimeout;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    SetGrid(ref dt);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(String.Format("データの取得時にエラーが発生しました。\r\n{0}", ex.Message));
                    TimerStop();
                }
            }
        }

        delegate void SetGridDelegate(ref DataTable dt);

        private void SetGrid(ref DataTable dt)
        {
            if (InvokeRequired)
            {
                Invoke(new SetGridDelegate(SetGrid), dt);
                return;
            }

            try
            {
                int gridrowindex = btnMonitor.FirstDisplayedScrollingRowIndex;
                int gridcolindex = btnMonitor.FirstDisplayedScrollingColumnIndex;

                lblDataGetTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");

                if (dt.Rows.Count != 0 || chkContinue.Checked == false)
                {
                    btnMonitor.DataSource = null;
                    btnMonitor.DataSource = dt;
                    if (btnMonitor.RowCount >= gridrowindex && gridrowindex > 0)
                    {
                        btnMonitor.FirstDisplayedScrollingRowIndex = gridrowindex;
                    }
                    if (btnMonitor.ColumnCount >= gridcolindex && gridcolindex > 0)
                    {
                        btnMonitor.FirstDisplayedScrollingColumnIndex = gridcolindex;
                    }
                }
                else
                {
                    lblEndTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                    lblStatus.Text = "停止";

                    btnStart.Enabled = true;

                    TimerStop();
                }

            }
            catch
            {
                throw;
            }

        }

        private void TimerStart()
        {
            // タイマーを起動
            GridTimer.Elapsed += new ElapsedEventHandler(GetData);
            GridTimer.Interval = int.Parse(txtInterval.Text);
            GridTimer.Start();

        }
        private void TimerStop()
        {
            GridTimer.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                btnStart.Enabled = false;
                lblStatus.Text = "取得中";
                lblStartTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                lblEndTime.Text = "";

                // 接続文字列を設定
                constring = txtConnectionString.Text;

                // バージョン情報を取得
                SetVersionInfo();

                // タイマーが起動する前の初回実行を明示的に実行
                GetData(sender, e);

                // 連続実行する設定の場合は、タイマーを開始
                if(chkRunOnce.Checked == false) {
                    TimerStart();
                }else
                {
                    lblEndTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                    btnStart.Enabled = true;
                    lblStatus.Text = "停止";
                }

            }
            catch (Exception ex)
            {
                TimerStop();
                MessageBox.Show(String.Format("エラーが発生しました。\r\n{0}", ex.Message));

            }
        }

        private void SetVersionInfo()
        {
            using (SqlConnection con = new SqlConnection(this.constring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT @@VERSION AS C1", con);
                    cmd.CommandTimeout = commandtimeout;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lblVersion.Text = dr[0].ToString();
                    }
                }
                catch (SqlException)
                {
                    TimerStop();
                    throw;
                }
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            lblEndTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            lblStatus.Text = "停止";
            TimerStop();
        }

        private void txtAllSelect(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                TextBox _txt = (TextBox)sender;
                _txt.SelectAll();
            }
        }


        private void dataGridQueryResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView _grid = (DataGridView)sender;
            int _sessionid;
            string[] _sessioncolumns = {"session_id", "sessiondi", "Session ID"};
            if (e.RowIndex != -1)
            {
                for (int i = 0; i < _grid.ColumnCount; i++)
                {

                    if (_sessioncolumns.Any(_grid.Columns[i].HeaderText.Contains))
                    {
                        _sessionid = int.Parse(_grid.CurrentRow.Cells[0].Value.ToString());
                        try
                        {
                            frmSessionQuery SessionQuery = new frmSessionQuery();
                            SessionQuery.constring = txtConnectionString.Text;
                            SessionQuery.GetSessionQuery(_sessionid);
                            SessionQuery.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(String.Format("セッションのクエリ取得でエラーが発生しました。\r\n{0}", ex.Message));
                        }
                    }
                }
            }
        }

        private void comboQueryTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox _combo = (ComboBox)sender;
            txtQuery.Text = (model.Query.Find(x => x.name.Equals(_combo.Text))).sql;

            //BaseQuery query = new BaseQuery();
            //txtQuery.Text = query.QueryTemplate[int.Parse(_combo.SelectedValue.ToString())];
            //txtQuery.Text = model.Query[int.Parse(_combo.SelectedValue.ToString())].sql;
        }

        private void dataGridQueryResult_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            btnMonitor.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = e.Exception.Message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMonitor Monitor = new frmMonitor();
            Monitor.constring = txtConnectionString.Text;
            Monitor.Show();
        }
    }
}
