using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zaiba2
{
    public partial class frmSessionQuery : Form
    {
        int commandtimeout = Properties.Settings.Default.CommandTimeout;
        public string constring { get; set; }

        public void GetSessionQuery(int SessionID)
        {
            InitializeComponent();
            lblQuerySessionID.Text = SessionID.ToString();

            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(this.constring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(String.Format("DBCC INPUTBUFFER({0})", SessionID.ToString()), con);
                    cmd.CommandTimeout = commandtimeout;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtQuerySession.Text = dr[2].ToString();
                    }
                }catch(SqlException)
                {
                    throw;
                }
            }
        }

        private void txtAllSelect(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                TextBox _txt = (TextBox)sender;
                _txt.SelectAll();
            }
        }


    }
}
