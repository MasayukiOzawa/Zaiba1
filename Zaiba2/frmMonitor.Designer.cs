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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBatch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartIOPS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartThroughput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIOPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThroughput)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBatch
            // 
            this.chartBatch.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisX.Maximum = 60D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.LabelStyle.Format = "{0:#,0}";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea";
            this.chartBatch.ChartAreas.Add(chartArea1);
            this.chartBatch.Location = new System.Drawing.Point(12, 24);
            this.chartBatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartBatch.Name = "chartBatch";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series";
            this.chartBatch.Series.Add(series1);
            this.chartBatch.Size = new System.Drawing.Size(273, 145);
            this.chartBatch.TabIndex = 0;
            // 
            // chartCPU
            // 
            this.chartCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCPU.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea2.AxisX.Maximum = 60D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea";
            this.chartCPU.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartCPU.Legends.Add(legend1);
            this.chartCPU.Location = new System.Drawing.Point(290, 24);
            this.chartCPU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartCPU.Name = "chartCPU";
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.Legend = "Legend1";
            series2.LegendText = "User";
            series2.Name = "User";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.LegendText = "Internal";
            series3.Name = "Internal";
            this.chartCPU.Series.Add(series2);
            this.chartCPU.Series.Add(series3);
            this.chartCPU.Size = new System.Drawing.Size(273, 180);
            this.chartCPU.TabIndex = 2;
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
            // chartIOPS
            // 
            this.chartIOPS.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea3.AxisX.Maximum = 60D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.LabelStyle.Format = "{0:#,0}";
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea";
            this.chartIOPS.ChartAreas.Add(chartArea3);
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartIOPS.Legends.Add(legend2);
            this.chartIOPS.Location = new System.Drawing.Point(12, 221);
            this.chartIOPS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartIOPS.Name = "chartIOPS";
            series4.BackSecondaryColor = System.Drawing.Color.White;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.RoyalBlue;
            series4.Legend = "Legend1";
            series4.LegendText = "Read";
            series4.Name = "Series";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.Legend = "Legend1";
            series5.LegendText = "Write";
            series5.Name = "Series2";
            this.chartIOPS.Series.Add(series4);
            this.chartIOPS.Series.Add(series5);
            this.chartIOPS.Size = new System.Drawing.Size(273, 180);
            this.chartIOPS.TabIndex = 6;
            // 
            // chartThroughput
            // 
            this.chartThroughput.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea4.AxisX.Maximum = 60D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.LabelStyle.Format = "{0:#,0}";
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea";
            this.chartThroughput.ChartAreas.Add(chartArea4);
            legend3.Alignment = System.Drawing.StringAlignment.Far;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chartThroughput.Legends.Add(legend3);
            this.chartThroughput.Location = new System.Drawing.Point(298, 221);
            this.chartThroughput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartThroughput.Name = "chartThroughput";
            series6.BackSecondaryColor = System.Drawing.Color.White;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.RoyalBlue;
            series6.Legend = "Legend1";
            series6.LegendText = "Read";
            series6.Name = "Series";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.Legend = "Legend1";
            series7.LegendText = "Write";
            series7.Name = "Series2";
            this.chartThroughput.Series.Add(series6);
            this.chartThroughput.Series.Add(series7);
            this.chartThroughput.Size = new System.Drawing.Size(273, 180);
            this.chartThroughput.TabIndex = 7;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIOPS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThroughput;
        private System.Windows.Forms.Label label4;
    }
}