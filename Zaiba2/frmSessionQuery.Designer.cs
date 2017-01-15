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
            this.SuspendLayout();
            // 
            // txtQuerySession
            // 
            this.txtQuerySession.Location = new System.Drawing.Point(12, 50);
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
            this.lblQuerySessionID.Location = new System.Drawing.Point(100, 9);
            this.lblQuerySessionID.Name = "lblQuerySessionID";
            this.lblQuerySessionID.Size = new System.Drawing.Size(0, 23);
            this.lblQuerySessionID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "SessionID";
            // 
            // frmSessionQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuerySession);
            this.Controls.Add(this.lblQuerySessionID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSessionQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "セッションのクエリ情報";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuerySession;
        private System.Windows.Forms.Label lblQuerySessionID;
        private System.Windows.Forms.Label label1;
    }
}