﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Zaiba2.Common;

namespace Zaiba2
{
    public partial class frmZaiba2Main : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["Zaiba2.Properties.Settings.DBConnection"].ConnectionString;
        DataTable dt = new DataTable();
        int commandtimeout = Properties.Settings.Default.CommandTimeout;


        public frmZaiba2Main()
        {
            BaseQuery query = new BaseQuery();
            InitializeComponent();
            txtQuery.Text = query.QueryTemplate[0];
        }

        public void SetGrid(object sender, EventArgs e)
        {
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(constring))
            {
                lblStatus.Text = "開始";
                SqlCommand cmd = new SqlCommand(txtQuery.Text, con);
                cmd.CommandTimeout = commandtimeout;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                int gridrowindex = dataGridQueryResult.FirstDisplayedScrollingRowIndex;

                dt.Clear();
                sda.Fill(dt);
                lblDataGetTime.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff");
                if (dt.Rows.Count != 0 || chkContinue.Checked ==  false)
                {
                    dataGridQueryResult.DataSource = dt;
                    if (dataGridQueryResult.RowCount >= gridrowindex && gridrowindex > 0)
                    {
                        dataGridQueryResult.FirstDisplayedScrollingRowIndex = gridrowindex;
                    }

                }
                else
                {
                    lblEndTime.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff");
                    btnStart.Enabled = true;
                    lblStatus.Text  = "停止";
                    timerQuery.Stop();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            lblStartTime.Text =  DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff");
            lblEndTime.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff");
            SetGrid(sender, e);
            timerQuery.Interval = int.Parse(txtInterval.Text);
            timerQuery.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            lblStatus.Text = "停止";
            timerQuery.Stop();
        }

        private void txtAllSelect(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.A) {
                TextBox _txt = (TextBox)sender;
                _txt.SelectAll();
            }
        }

        private void dataGridQueryResult_Click(object sender, EventArgs e)
        {
            DataGridView _grid = (DataGridView)sender;
            int _sessionid;

            if (_grid.Columns[0].HeaderText == "session_id" || _grid.Columns[0].HeaderText == "sessionid")
            {
                _sessionid = int.Parse(_grid.CurrentRow.Cells[0].Value.ToString());
                lblQuerySessionID.Text = _sessionid.ToString();
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(String.Format("DBCC INPUTBUFFER({0})", _sessionid.ToString()), con);
                    cmd.CommandTimeout = commandtimeout;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtQuerySession.Text = dr[2].ToString();
                    }
                }
            }
        }
    }
}
