namespace Zaiba2
{
    partial class frmSessionQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuerySession = new System.Windows.Forms.TextBox();
            this.lblQuerySessionID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.セッションの終了LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuerySession
            // 
            this.txtQuerySession.Location = new System.Drawing.Point(12, 66);
            this.txtQuerySession.Multiline = true;
            this.txtQuerySession.Name = "txtQuerySession";
            this.txtQuerySession.ReadOnly = true;
            this.txtQuerySession.Size = new System.Drawing.Size(483, 199);
            this.txtQuerySession.TabIndex = 18;
            this.txtQuerySession.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAllSelect);
            // 
            // lblQuerySessionID
            // 
            this.lblQuerySessionID.AutoSize = true;
            this.lblQuerySessionID.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuerySessionID.Location = new System.Drawing.Point(100, 31);
            this.lblQuerySessionID.Name = "lblQuerySessionID";
            this.lblQuerySessionID.Size = new System.Drawing.Size(0, 23);
            this.lblQuerySessionID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "SessionID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 25);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.セッションの終了LToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // セッションの終了LToolStripMenuItem
            // 
            this.セッションの終了LToolStripMenuItem.Name = "セッションの終了LToolStripMenuItem";
            this.セッションの終了LToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.セッションの終了LToolStripMenuItem.Text = "セッションの終了(&K)";
            this.セッションの終了LToolStripMenuItem.Click += new System.EventHandler(this.SessionKill);
            // 
            // frmSessionQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuerySession);
            this.Controls.Add(this.lblQuerySessionID);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSessionQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "セッションのクエリ情報";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuerySession;
        private System.Windows.Forms.Label lblQuerySessionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem セッションの終了LToolStripMenuItem;
    }
}