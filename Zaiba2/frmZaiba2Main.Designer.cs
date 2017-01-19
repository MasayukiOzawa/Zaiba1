namespace Zaiba2
{
    partial class frmZaiba2Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblIntervalms = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.dataGridQueryResult = new System.Windows.Forms.DataGridView();
            this.timerQuery = new System.Windows.Forms.Timer(this.components);
            this.lblStartTimeTitle = new System.Windows.Forms.Label();
            this.lblEndTimeTitle = new System.Windows.Forms.Label();
            this.lblDataGetTimeTitle = new System.Windows.Forms.Label();
            this.lblDataGetTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.dataSetQueryTemplate = new Zaiba2.DataSetQueryTemplate();
            this.comboQueryTemplate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTemplate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQueryTemplate)).BeginInit();
            this.panelTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStop.Location = new System.Drawing.Point(12, 52);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInterval.Location = new System.Drawing.Point(13, 106);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(61, 20);
            this.lblInterval.TabIndex = 2;
            this.lblInterval.Text = "更新間隔";
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtInterval.Location = new System.Drawing.Point(75, 103);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(52, 27);
            this.txtInterval.TabIndex = 3;
            this.txtInterval.Text = "1000";
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIntervalms
            // 
            this.lblIntervalms.AutoSize = true;
            this.lblIntervalms.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIntervalms.Location = new System.Drawing.Point(130, 106);
            this.lblIntervalms.Name = "lblIntervalms";
            this.lblIntervalms.Size = new System.Drawing.Size(27, 20);
            this.lblIntervalms.TabIndex = 4;
            this.lblIntervalms.Text = "ms";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus.Location = new System.Drawing.Point(106, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(138, 72);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "停止";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(450, 13);
            this.txtQuery.MaxLength = 0;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(456, 171);
            this.txtQuery.TabIndex = 6;
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAllSelect);
            // 
            // dataGridQueryResult
            // 
            this.dataGridQueryResult.AllowUserToAddRows = false;
            this.dataGridQueryResult.AllowUserToDeleteRows = false;
            this.dataGridQueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridQueryResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridQueryResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQueryResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridQueryResult.Location = new System.Drawing.Point(14, 206);
            this.dataGridQueryResult.MultiSelect = false;
            this.dataGridQueryResult.Name = "dataGridQueryResult";
            this.dataGridQueryResult.ReadOnly = true;
            this.dataGridQueryResult.RowHeadersVisible = false;
            this.dataGridQueryResult.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataGridQueryResult.RowTemplate.Height = 21;
            this.dataGridQueryResult.Size = new System.Drawing.Size(1289, 240);
            this.dataGridQueryResult.TabIndex = 7;
            this.dataGridQueryResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQueryResult_CellClick);
            this.dataGridQueryResult.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridQueryResult_DataError);
            // 
            // timerQuery
            // 
            this.timerQuery.Interval = 1000;
            this.timerQuery.Tick += new System.EventHandler(this.SetGrid);
            // 
            // lblStartTimeTitle
            // 
            this.lblStartTimeTitle.AutoSize = true;
            this.lblStartTimeTitle.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStartTimeTitle.Location = new System.Drawing.Point(172, 105);
            this.lblStartTimeTitle.Name = "lblStartTimeTitle";
            this.lblStartTimeTitle.Size = new System.Drawing.Size(52, 17);
            this.lblStartTimeTitle.TabIndex = 8;
            this.lblStartTimeTitle.Text = "開始日時";
            // 
            // lblEndTimeTitle
            // 
            this.lblEndTimeTitle.AutoSize = true;
            this.lblEndTimeTitle.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEndTimeTitle.Location = new System.Drawing.Point(172, 125);
            this.lblEndTimeTitle.Name = "lblEndTimeTitle";
            this.lblEndTimeTitle.Size = new System.Drawing.Size(52, 17);
            this.lblEndTimeTitle.TabIndex = 9;
            this.lblEndTimeTitle.Text = "停止日時";
            // 
            // lblDataGetTimeTitle
            // 
            this.lblDataGetTimeTitle.AutoSize = true;
            this.lblDataGetTimeTitle.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDataGetTimeTitle.Location = new System.Drawing.Point(172, 145);
            this.lblDataGetTimeTitle.Name = "lblDataGetTimeTitle";
            this.lblDataGetTimeTitle.Size = new System.Drawing.Size(85, 17);
            this.lblDataGetTimeTitle.TabIndex = 10;
            this.lblDataGetTimeTitle.Text = "データ取得日時";
            // 
            // lblDataGetTime
            // 
            this.lblDataGetTime.AutoSize = true;
            this.lblDataGetTime.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDataGetTime.Location = new System.Drawing.Point(276, 145);
            this.lblDataGetTime.Name = "lblDataGetTime";
            this.lblDataGetTime.Size = new System.Drawing.Size(0, 17);
            this.lblDataGetTime.TabIndex = 13;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEndTime.Location = new System.Drawing.Point(276, 125);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(0, 17);
            this.lblEndTime.TabIndex = 12;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStartTime.Location = new System.Drawing.Point(276, 105);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(0, 17);
            this.lblStartTime.TabIndex = 11;
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Checked = true;
            this.chkContinue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkContinue.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkContinue.Location = new System.Drawing.Point(14, 145);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(146, 22);
            this.chkContinue.TabIndex = 14;
            this.chkContinue.Text = "0 件の場合に処理停止";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // dataSetQueryTemplate
            // 
            this.dataSetQueryTemplate.DataSetName = "DataSetQueryTemplate";
            this.dataSetQueryTemplate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboQueryTemplate
            // 
            this.comboQueryTemplate.DataSource = this.dataSetQueryTemplate;
            this.comboQueryTemplate.DisplayMember = "DataTableQueryTemplate.TemplateName";
            this.comboQueryTemplate.FormattingEnabled = true;
            this.comboQueryTemplate.Location = new System.Drawing.Point(7, 25);
            this.comboQueryTemplate.Name = "comboQueryTemplate";
            this.comboQueryTemplate.Size = new System.Drawing.Size(272, 20);
            this.comboQueryTemplate.TabIndex = 16;
            this.comboQueryTemplate.ValueMember = "DataTableQueryTemplate.TemplateIndex";
            this.comboQueryTemplate.SelectedIndexChanged += new System.EventHandler(this.comboQueryTemplate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "クエリテンプレート";
            // 
            // panelTemplate
            // 
            this.panelTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTemplate.Controls.Add(this.comboQueryTemplate);
            this.panelTemplate.Controls.Add(this.label1);
            this.panelTemplate.Location = new System.Drawing.Point(944, 13);
            this.panelTemplate.Name = "panelTemplate";
            this.panelTemplate.Size = new System.Drawing.Size(295, 72);
            this.panelTemplate.TabIndex = 15;
            // 
            // frmZaiba2Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 465);
            this.Controls.Add(this.panelTemplate);
            this.Controls.Add(this.chkContinue);
            this.Controls.Add(this.lblDataGetTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblDataGetTimeTitle);
            this.Controls.Add(this.lblEndTimeTitle);
            this.Controls.Add(this.lblStartTimeTitle);
            this.Controls.Add(this.dataGridQueryResult);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIntervalms);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "frmZaiba2Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaiba2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQueryResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQueryTemplate)).EndInit();
            this.panelTemplate.ResumeLayout(false);
            this.panelTemplate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblIntervalms;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.DataGridView dataGridQueryResult;
        private System.Windows.Forms.Timer timerQuery;
        private System.Windows.Forms.Label lblStartTimeTitle;
        private System.Windows.Forms.Label lblEndTimeTitle;
        private System.Windows.Forms.Label lblDataGetTimeTitle;
        private System.Windows.Forms.Label lblDataGetTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.CheckBox chkContinue;
        private DataSetQueryTemplate dataSetQueryTemplate;
        private System.Windows.Forms.ComboBox comboQueryTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTemplate;
    }
}

