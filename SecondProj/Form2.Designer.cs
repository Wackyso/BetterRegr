namespace SecondProj
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LinearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExpChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PowerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RepresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RepresLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.LinarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LinearChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepresChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LinearChart
            // 
            chartArea1.Name = "ChartArea1";
            this.LinearChart.ChartAreas.Add(chartArea1);
            this.LinearChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.LinearChart.Legends.Add(legend1);
            this.LinearChart.Location = new System.Drawing.Point(11, 11);
            this.LinearChart.Margin = new System.Windows.Forms.Padding(2);
            this.LinearChart.Name = "LinearChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.LinearChart.Series.Add(series1);
            this.LinearChart.Size = new System.Drawing.Size(338, 195);
            this.LinearChart.TabIndex = 5;
            this.LinearChart.Text = "chart1";
            // 
            // ExpChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ExpChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ExpChart.Legends.Add(legend2);
            this.ExpChart.Location = new System.Drawing.Point(383, 11);
            this.ExpChart.Margin = new System.Windows.Forms.Padding(2);
            this.ExpChart.Name = "ExpChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ExpChart.Series.Add(series2);
            this.ExpChart.Size = new System.Drawing.Size(338, 195);
            this.ExpChart.TabIndex = 8;
            this.ExpChart.Text = "chart4";
            // 
            // PowerChart
            // 
            chartArea3.Name = "ChartArea1";
            this.PowerChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.PowerChart.Legends.Add(legend3);
            this.PowerChart.Location = new System.Drawing.Point(11, 210);
            this.PowerChart.Margin = new System.Windows.Forms.Padding(2);
            this.PowerChart.Name = "PowerChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.PowerChart.Series.Add(series3);
            this.PowerChart.Size = new System.Drawing.Size(338, 195);
            this.PowerChart.TabIndex = 9;
            this.PowerChart.Text = "chart2";
            // 
            // RepresChart
            // 
            chartArea4.Name = "ChartArea1";
            this.RepresChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.RepresChart.Legends.Add(legend4);
            this.RepresChart.Location = new System.Drawing.Point(383, 210);
            this.RepresChart.Margin = new System.Windows.Forms.Padding(2);
            this.RepresChart.Name = "RepresChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.RepresChart.Series.Add(series4);
            this.RepresChart.Size = new System.Drawing.Size(338, 195);
            this.RepresChart.TabIndex = 10;
            this.RepresChart.Text = "chart3";
            // 
            // RepresLabel
            // 
            this.RepresLabel.Location = new System.Drawing.Point(560, 417);
            this.RepresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RepresLabel.Name = "RepresLabel";
            this.RepresLabel.Size = new System.Drawing.Size(161, 218);
            this.RepresLabel.TabIndex = 15;
            this.RepresLabel.Text = "label5";
            // 
            // PowerLabel
            // 
            this.PowerLabel.Location = new System.Drawing.Point(380, 417);
            this.PowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(159, 218);
            this.PowerLabel.TabIndex = 14;
            this.PowerLabel.Text = "label4";
            // 
            // ExpLabel
            // 
            this.ExpLabel.Location = new System.Drawing.Point(11, 417);
            this.ExpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(156, 218);
            this.ExpLabel.TabIndex = 13;
            this.ExpLabel.Text = "label3";
            // 
            // LinarLabel
            // 
            this.LinarLabel.Location = new System.Drawing.Point(190, 416);
            this.LinarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinarLabel.Name = "LinarLabel";
            this.LinarLabel.Size = new System.Drawing.Size(159, 218);
            this.LinarLabel.TabIndex = 12;
            this.LinarLabel.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 656);
            this.Controls.Add(this.RepresLabel);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.ExpLabel);
            this.Controls.Add(this.LinarLabel);
            this.Controls.Add(this.RepresChart);
            this.Controls.Add(this.PowerChart);
            this.Controls.Add(this.ExpChart);
            this.Controls.Add(this.LinearChart);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.LinearChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepresChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LinearChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PowerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RepresChart;
        private System.Windows.Forms.Label RepresLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.Label LinarLabel;
    }
}