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
using Zaiba2.Common;

namespace Zaiba2
{
    public partial class frmZaiba2Main : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["Zaiba2.Properties.Settings.DBConnection"].ConnectionString;
        int commandtimeout = Properties.Settings.Default.CommandTimeout;

        public frmZaiba2Main()
        {
            InitializeComponent();

            BaseQuery query = new BaseQuery();
            txtQuery.Text = query.QueryTemplate[0];
            Dictionary<String, int> TempLateList = query.GetTemplateList();
            foreach(var _Template in TempLateList.Keys)
            {
                dataSetQueryTemplate.DataTableQueryTemplate.AddDataTableQueryTemplateRow(_Template,TempLateList[_Template] );
            }
        }

        public void SetGrid(object sender, EventArgs e)
        {
            string CmdString = string.Empty;

            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    lblStatus.Text = "開始";
                    SqlCommand cmd = new SqlCommand(txtQuery.Text, con);
                    cmd.CommandTimeout = commandtimeout;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    int gridrowindex = dataGridQueryResult.FirstDisplayedScrollingRowIndex;
                    int gridcolindex = dataGridQueryResult.FirstDisplayedScrollingColumnIndex;

                    sda.Fill(dt);
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
                        btnStart.Enabled = true;
                        lblEndTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                        lblStatus.Text = "停止";
                        timerQuery.Stop();
                    }
                }

            }
            catch{
                throw;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try {
                btnStart.Enabled = false;
                lblStartTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                lblEndTime.Text = "";

                // タイマーが起動する前の初回実行を明示的に実行
                SetGrid(sender, e);

                // タイマーを起動
                timerQuery.Interval = int.Parse(txtInterval.Text);
                timerQuery.Start();
            }
            catch(Exception ex)
            {
                timerQuery.Stop();
                MessageBox.Show(String.Format("エラーが発生しました。\r\n{0}", ex.Message));

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            lblEndTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            lblStatus.Text = "停止";
            timerQuery.Stop();
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
                            Form SessoinQuery = new frmSessionQuery(_sessionid);
                            SessoinQuery.Show();
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
