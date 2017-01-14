using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zaiba2
{
    public partial class frmSessionQuery : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["Zaiba2.Properties.Settings.DBConnection"].ConnectionString;
        int commandtimeout = Properties.Settings.Default.CommandTimeout;

        public frmSessionQuery(int SessionID)
        {
            InitializeComponent();
            lblQuerySessionID.Text = SessionID.ToString();

            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(constring))
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
                }catch(SqlException e)
                {
                    MessageBox.Show("セッションのクエリ取得でエラーが発生しました。");

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
