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
        int _sessionid;

        public void GetSessionQuery(int SessionID)
        {
            InitializeComponent();
            this._sessionid = SessionID;
            lblQuerySessionID.Text = this._sessionid.ToString();

            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(this.constring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(String.Format("DBCC INPUTBUFFER({0})", this._sessionid.ToString()), con);
                    cmd.CommandTimeout = commandtimeout;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtQuerySession.Text = dr[2].ToString();
                    }
                }catch(SqlException ex)
                {
                    MessageBox.Show(String.Format("セッションのクエリ取得でエラーが発生しました。\r\n{0}", ex.Message));
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

        private void SessionKill(object sender, EventArgs e)
        {
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(this.constring))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(String.Format("kill {0}", this._sessionid.ToString()), con);
                    cmd.CommandTimeout = commandtimeout;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(String.Format("セッション ID {0} を終了しました", this._sessionid.ToString()));
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(String.Format("セッションの終了でエラーが発生しました。\r\n{0}", ex.Message));
                }
            }
        }
    }
}