namespace SecondProj
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MultiChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MultiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MultiChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MultiChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MultiChart.ChartAreas.Add(chartArea1);
            this.MultiChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.MultiChart.Legends.Add(legend1);
            this.MultiChart.Location = new System.Drawing.Point(11, 11);
            this.MultiChart.Margin = new System.Windows.Forms.Padding(2);
            this.MultiChart.Name = "MultiChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MultiChart.Series.Add(series1);
            this.MultiChart.Size = new System.Drawing.Size(407, 259);
            this.MultiChart.TabIndex = 6;
            this.MultiChart.Text = "chart1";
            // 
            // MultiLabel
            // 
            this.MultiLabel.Location = new System.Drawing.Point(11, 272);
            this.MultiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MultiLabel.Name = "MultiLabel";
            this.MultiLabel.Size = new System.Drawing.Size(156, 218);
            this.MultiLabel.TabIndex = 14;
            this.MultiLabel.Text = "label3";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 550);
            this.Controls.Add(this.MultiLabel);
            this.Controls.Add(this.MultiChart);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.MultiChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MultiChart;
        private System.Windows.Forms.Label MultiLabel;
    }
}