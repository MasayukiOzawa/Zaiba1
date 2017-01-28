namespace Zaiba2
{
    partial class frmMonitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBatch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartIOPS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartThroughput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIOPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThroughput)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBatch
            // 
            this.chartBatch.BackColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.LabelStyle.Enabled = false;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea5.AxisX.Maximum = 60D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.LabelStyle.Format = "{0:#,0}";
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea5.BackColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea";
            this.chartBatch.ChartAreas.Add(chartArea5);
            this.chartBatch.Location = new System.Drawing.Point(12, 24);
            this.chartBatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartBatch.Name = "chartBatch";
            series8.BackSecondaryColor = System.Drawing.Color.White;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.RoyalBlue;
            series8.IsVisibleInLegend = false;
            series8.Name = "Series";
            this.chartBatch.Series.Add(series8);
            this.chartBatch.Size = new System.Drawing.Size(273, 145);
            this.chartBatch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(121, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "バッチ実行数";
            // 
            // chartCPU
            // 
            this.chartCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCPU.BackColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea6.AxisX.Maximum = 60D;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea6.AxisY.Maximum = 100D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.Name = "ChartArea";
            this.chartCPU.ChartAreas.Add(chartArea6);
            legend4.Alignment = System.Drawing.StringAlignment.Far;
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.chartCPU.Legends.Add(legend4);
            this.chartCPU.Location = new System.Drawing.Point(290, 24);
            this.chartCPU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartCPU.Name = "chartCPU";
            series9.BackSecondaryColor = System.Drawing.Color.White;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.RoyalBlue;
            series9.Legend = "Legend1";
            series9.LegendText = "User";
            series9.Name = "User";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.LegendText = "Internal";
            series10.Name = "Internal";
            this.chartCPU.Series.Add(series9);
            this.chartCPU.Series.Add(series10);
            this.chartCPU.Size = new System.Drawing.Size(273, 180);
            this.chartCPU.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(406, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPU 使用状況";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(108, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "データベース IOPS";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(354, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "データベース スループット (MB)";
            // 
            // chartIOPS
            // 
            this.chartIOPS.BackColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea7.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.LabelStyle.Enabled = false;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea7.AxisX.Maximum = 60D;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisY.LabelStyle.Format = "{0:#,0}";
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea7.BackColor = System.Drawing.Color.Black;
            chartArea7.Name = "ChartArea";
            this.chartIOPS.ChartAreas.Add(chartArea7);
            legend5.Alignment = System.Drawing.StringAlignment.Far;
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.chartIOPS.Legends.Add(legend5);
            this.chartIOPS.Location = new System.Drawing.Point(12, 221);
            this.chartIOPS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartIOPS.Name = "chartIOPS";
            series11.BackSecondaryColor = System.Drawing.Color.White;
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.RoyalBlue;
            series11.Legend = "Legend1";
            series11.LegendText = "Read";
            series11.Name = "Series";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series12.Legend = "Legend1";
            series12.LegendText = "Write";
            series12.Name = "Series2";
            this.chartIOPS.Series.Add(series11);
            this.chartIOPS.Series.Add(series12);
            this.chartIOPS.Size = new System.Drawing.Size(273, 180);
            this.chartIOPS.TabIndex = 6;
            // 
            // chartThroughput
            // 
            this.chartThroughput.BackColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea8.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.LabelStyle.Enabled = false;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea8.AxisX.Maximum = 60D;
            chartArea8.AxisX.Minimum = 0D;
            chartArea8.AxisY.LabelStyle.Format = "{0:#,0}";
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea8.BackColor = System.Drawing.Color.Black;
            chartArea8.Name = "ChartArea";
            this.chartThroughput.ChartAreas.Add(chartArea8);
            legend6.Alignment = System.Drawing.StringAlignment.Far;
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Name = "Legend1";
            this.chartThroughput.Legends.Add(legend6);
            this.chartThroughput.Location = new System.Drawing.Point(298, 221);
            this.chartThroughput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartThroughput.Name = "chartThroughput";
            series13.BackSecondaryColor = System.Drawing.Color.White;
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.RoyalBlue;
            series13.Legend = "Legend1";
            series13.LegendText = "Read";
            series13.Name = "Series";
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series14.Legend = "Legend1";
            series14.LegendText = "Write";
            series14.Name = "Series2";
            this.chartThroughput.Series.Add(series13);
            this.chartThroughput.Series.Add(series14);
            this.chartThroughput.Size = new System.Drawing.Size(273, 180);
            this.chartThroughput.TabIndex = 7;
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(572, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartThroughput);
            this.Controls.Add(this.chartIOPS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartCPU);
            this.Controls.Add(this.chartBatch);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMonitor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "リソースモニター";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMonitor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chartBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIOPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThroughput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIOPS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThroughput;
    }
}