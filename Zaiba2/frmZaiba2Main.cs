using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Zaiba2.Common;

namespace Zaiba2
{
    public partial class frmZaiba2Main : Form
    {
        string constring = string.Empty;
        int commandtimeout = Properties.Settings.Default.CommandTimeout;
        System.Timers.Timer timer = new System.Timers.Timer();

        public frmZaiba2Main()
        {
            InitializeComponent();
            txtConnectionString.Text = ConfigurationManager.ConnectionStrings["Zaiba2.Properties.Settings.DBConnection"].ConnectionString;

            BaseQuery query = new BaseQuery();
            txtQuery.Text = query.QueryTemplate[0];
            Dictionary<String, int> TempLateList = query.GetTemplateList();
            foreach(var _Template in TempLateList.Keys)
            {
                dataSetQueryTemplate.DataTableQueryTemplate.AddDataTableQueryTemplateRow(_Template,TempLateList[_Template] );
            }
        }


        private void GetData(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand(txtQuery.Text, con);
                cmd.CommandTimeout = commandtimeout;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                SetGrid(ref dt);
            }
        }

        delegate void SetGridDelegate(ref DataTable dt);

        private void SetGrid(ref DataTable dt)
        {
            if (InvokeRequired)
            {
                Invoke(new SetGridDelegate(SetGrid),dt);
                return;
            }

            try
            {
                int gridrowindex = dataGridQueryResult.FirstDisplayedScrollingRowIndex;
                int gridcolindex = dataGridQueryResult.FirstDisplayedScrollingColumnIndex;

                lblDataGetTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");

                if (dt.Rows.Count != 0 || chkContinue.Checked == false)
                {
                    dataGridQueryResult.DataSource = null;
                    dataGridQueryResult.DataSource = dt;
                    if (dataGridQueryResult.RowCount >= gridrowindex && gridrowindex > 0)
                    {
                        dataGridQueryResult.FirstDisplayedScrollingRowIndex = gridrowindex;
                    }
                    if (dataGridQueryResult.ColumnCount >= gridcolindex && gridcolindex > 0)
                    {
                        dataGridQueryResult.FirstDisplayedScrollingColumnIndex = gridcolindex;
                    }
                }
                else
                {
                    lblEndTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
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
            //timerQuery.Interval = int.Parse(txtInterval.Text);
            //timerQuery.Start();


            timer.Elapsed += new ElapsedEventHandler(GetData);
            timer.Interval = int.Parse(txtInterval.Text);
            timer.Start();

        }
        private void TimerStop()
        {
            //timerQuery.Stop();
            timer.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try {
                lblStatus.Text = "取得中";
                btnStart.Enabled = false;
                lblStartTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                lblEndTime.Text = "";

                // 接続文字列を設定
                constring = txtConnectionString.Text;

                // バージョン情報を取得
                SetVersionInfo();

                // タイマーが起動する前の初回実行を明示的に実行
                GetData(sender, e);

                TimerStart();

            }
            catch(Exception ex)
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

        private void txtAllSelect(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.A) {
                TextBox _txt = (TextBox)sender;
                _txt.SelectAll();
            }
        }


        private void SetQueryText(object sender, EventArgs e)
        {
            RadioButton _radio = (RadioButton)sender;

            BaseQuery query = new BaseQuery();
            txtQuery.Text = query.QueryTemplate[int.Parse(_radio.Tag.ToString())];
        }

        private void dataGridQueryResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView _grid = (DataGridView)sender;
            int _sessionid;
            if (e.RowIndex != -1)
            {
                for (int i = 0; i < _grid.ColumnCount; i++)
                {

                    if (_grid.Columns[i].HeaderText == "session_id" || _grid.Columns[i].HeaderText == "sessionid")
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
            BaseQuery query = new BaseQuery();
            txtQuery.Text = query.QueryTemplate[int.Parse(_combo.SelectedValue.ToString())];
        }

        private void dataGridQueryResult_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dataGridQueryResult.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = e.Exception.Message;
        }
    }
}
