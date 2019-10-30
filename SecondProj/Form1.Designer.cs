namespace SecondProj
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            this.Back = new System.Windows.Forms.Panel();
            this.RepresLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.LinarLabel = new System.Windows.Forms.Label();
            this.ExpChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RepresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PowerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LinearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButTextInp = new System.Windows.Forms.Button();
            this.DescriptLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OneVarFourCharts = new System.Windows.Forms.Button();
            this.Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepresChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Controls.Add(this.OneVarFourCharts);
            this.Back.Controls.Add(this.RepresLabel);
            this.Back.Controls.Add(this.PowerLabel);
            this.Back.Controls.Add(this.ExpLabel);
            this.Back.Controls.Add(this.LinarLabel);
            this.Back.Controls.Add(this.ExpChart);
            this.Back.Controls.Add(this.RepresChart);
            this.Back.Controls.Add(this.PowerChart);
            this.Back.Controls.Add(this.LinearChart);
            this.Back.Controls.Add(this.ButTextInp);
            this.Back.Controls.Add(this.DescriptLabel);
            this.Back.Location = new System.Drawing.Point(-1, -2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(1620, 968);
            this.Back.TabIndex = 0;
            // 
            // RepresLabel
            // 
            this.RepresLabel.Location = new System.Drawing.Point(947, 672);
            this.RepresLabel.Name = "RepresLabel";
            this.RepresLabel.Size = new System.Drawing.Size(161, 190);
            this.RepresLabel.TabIndex = 11;
            this.RepresLabel.Text = "label5";
            // 
            // PowerLabel
            // 
            this.PowerLabel.Location = new System.Drawing.Point(780, 672);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(161, 190);
            this.PowerLabel.TabIndex = 10;
            this.PowerLabel.Text = "label4";
            // 
            // ExpLabel
            // 
            this.ExpLabel.Location = new System.Drawing.Point(613, 672);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(161, 190);
            this.ExpLabel.TabIndex = 9;
            this.ExpLabel.Text = "label3";
            // 
            // LinarLabel
            // 
            this.LinarLabel.Location = new System.Drawing.Point(446, 672);
            this.LinarLabel.Name = "LinarLabel";
            this.LinarLabel.Size = new System.Drawing.Size(161, 190);
            this.LinarLabel.TabIndex = 8;
            this.LinarLabel.Text = "label2";
            // 
            // ExpChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ExpChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ExpChart.Legends.Add(legend1);
            this.ExpChart.Location = new System.Drawing.Point(1101, 14);
            this.ExpChart.Name = "ExpChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ExpChart.Series.Add(series1);
            this.ExpChart.Size = new System.Drawing.Size(507, 300);
            this.ExpChart.TabIndex = 7;
            this.ExpChart.Text = "chart4";
            // 
            // RepresChart
            // 
            chartArea2.Name = "ChartArea1";
            this.RepresChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.RepresChart.Legends.Add(legend2);
            this.RepresChart.Location = new System.Drawing.Point(1101, 317);
            this.RepresChart.Name = "RepresChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.RepresChart.Series.Add(series2);
            this.RepresChart.Size = new System.Drawing.Size(507, 300);
            this.RepresChart.TabIndex = 6;
            this.RepresChart.Text = "chart3";
            // 
            // PowerChart
            // 
            chartArea3.Name = "ChartArea1";
            this.PowerChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.PowerChart.Legends.Add(legend3);
            this.PowerChart.Location = new System.Drawing.Point(566, 317);
            this.PowerChart.Name = "PowerChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.PowerChart.Series.Add(series3);
            this.PowerChart.Size = new System.Drawing.Size(507, 300);
            this.PowerChart.TabIndex = 5;
            this.PowerChart.Text = "chart2";
            // 
            // LinearChart
            // 
            chartArea4.Name = "ChartArea1";
            this.LinearChart.ChartAreas.Add(chartArea4);
            this.LinearChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend4.Name = "Legend1";
            this.LinearChart.Legends.Add(legend4);
            this.LinearChart.Location = new System.Drawing.Point(566, 11);
            this.LinearChart.Name = "LinearChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.LinearChart.Series.Add(series4);
            this.LinearChart.Size = new System.Drawing.Size(507, 300);
            this.LinearChart.TabIndex = 4;
            this.LinearChart.Text = "chart1";
            // 
            // ButTextInp
            // 
            this.ButTextInp.Location = new System.Drawing.Point(17, 150);
            this.ButTextInp.Name = "ButTextInp";
            this.ButTextInp.Size = new System.Drawing.Size(153, 98);
            this.ButTextInp.TabIndex = 3;
            this.ButTextInp.Text = "Выбрать файл с данными";
            this.ButTextInp.UseVisualStyleBackColor = true;
            this.ButTextInp.Click += new System.EventHandler(this.ButTextInp_Click);
            // 
            // DescriptLabel
            // 
            this.DescriptLabel.AutoSize = true;
            this.DescriptLabel.Location = new System.Drawing.Point(13, 14);
            this.DescriptLabel.Name = "DescriptLabel";
            this.DescriptLabel.Size = new System.Drawing.Size(422, 100);
            this.DescriptLabel.TabIndex = 2;
            this.DescriptLabel.Text = "Выберите ваш файл\r\n1 столбец должен состоять из наблюдений \r\nзависящей величины\r\n" +
    "Остальные столбцы состоят из наблюдений величин,\r\nот которрых зависит первый сто" +
    "лбец\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OneVarFourCharts
            // 
            this.OneVarFourCharts.Location = new System.Drawing.Point(17, 254);
            this.OneVarFourCharts.Name = "OneVarFourCharts";
            this.OneVarFourCharts.Size = new System.Drawing.Size(245, 98);
            this.OneVarFourCharts.TabIndex = 12;
            this.OneVarFourCharts.Text = "Одна переменная, модели линейная,степенная, экспоненциальная, показательная";
            this.OneVarFourCharts.UseVisualStyleBackColor = true;
            this.OneVarFourCharts.Click += new System.EventHandler(this.OneVarFourCharts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 963);
            this.Controls.Add(this.Back);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Back.ResumeLayout(false);
            this.Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepresChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Back;
        private System.Windows.Forms.Label RepresLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.Label LinarLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RepresChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PowerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LinearChart;
        private System.Windows.Forms.Button ButTextInp;
        private System.Windows.Forms.Label DescriptLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OneVarFourCharts;
    }
}

