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
            this.GeteroskedCheckButt = new System.Windows.Forms.Button();
            this.MultCheck = new System.Windows.Forms.Button();
            this.ShiftTextButt = new System.Windows.Forms.Button();
            this.ShiftTextBox = new System.Windows.Forms.TextBox();
            this.ShiftText = new System.Windows.Forms.Label();
            this.InputRedTextAsk = new System.Windows.Forms.Label();
            this.InputRedButt = new System.Windows.Forms.Button();
            this.InputRedBox = new System.Windows.Forms.TextBox();
            this.ButtNo2 = new System.Windows.Forms.Button();
            this.ButtYes2 = new System.Windows.Forms.Button();
            this.ButtNo1 = new System.Windows.Forms.Button();
            this.ButtYes1 = new System.Windows.Forms.Button();
            this.RepresLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.LinearLabel = new System.Windows.Forms.Label();
            this.RepresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PowerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExpChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LinearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButTextInp = new System.Windows.Forms.Button();
            this.TextFileReader = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AutocorrCheckButt = new System.Windows.Forms.Button();
            this.Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepresChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Controls.Add(this.AutocorrCheckButt);
            this.Back.Controls.Add(this.GeteroskedCheckButt);
            this.Back.Controls.Add(this.MultCheck);
            this.Back.Controls.Add(this.ShiftTextButt);
            this.Back.Controls.Add(this.ShiftTextBox);
            this.Back.Controls.Add(this.ShiftText);
            this.Back.Controls.Add(this.InputRedTextAsk);
            this.Back.Controls.Add(this.InputRedButt);
            this.Back.Controls.Add(this.InputRedBox);
            this.Back.Controls.Add(this.ButtNo2);
            this.Back.Controls.Add(this.ButtYes2);
            this.Back.Controls.Add(this.ButtNo1);
            this.Back.Controls.Add(this.ButtYes1);
            this.Back.Controls.Add(this.RepresLabel);
            this.Back.Controls.Add(this.PowerLabel);
            this.Back.Controls.Add(this.ExpLabel);
            this.Back.Controls.Add(this.LinearLabel);
            this.Back.Controls.Add(this.RepresChart);
            this.Back.Controls.Add(this.PowerChart);
            this.Back.Controls.Add(this.ExpChart);
            this.Back.Controls.Add(this.LinearChart);
            this.Back.Controls.Add(this.ButTextInp);
            this.Back.Controls.Add(this.TextFileReader);
            this.Back.Location = new System.Drawing.Point(-2, -2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(2261, 1241);
            this.Back.TabIndex = 0;
            // 
            // GeteroskedCheckButt
            // 
            this.GeteroskedCheckButt.Location = new System.Drawing.Point(18, 950);
            this.GeteroskedCheckButt.Name = "GeteroskedCheckButt";
            this.GeteroskedCheckButt.Size = new System.Drawing.Size(263, 95);
            this.GeteroskedCheckButt.TabIndex = 36;
            this.GeteroskedCheckButt.Text = "Проверка на гетероскедостичность";
            this.GeteroskedCheckButt.UseVisualStyleBackColor = true;
            this.GeteroskedCheckButt.Click += new System.EventHandler(this.GeteroskedCheckButt_Click);
            // 
            // MultCheck
            // 
            this.MultCheck.Location = new System.Drawing.Point(18, 836);
            this.MultCheck.Name = "MultCheck";
            this.MultCheck.Size = new System.Drawing.Size(263, 95);
            this.MultCheck.TabIndex = 35;
            this.MultCheck.Text = "Проверка на мультиколлинеарность";
            this.MultCheck.UseVisualStyleBackColor = true;
            this.MultCheck.Click += new System.EventHandler(this.MultCheck_Click);
            // 
            // ShiftTextButt
            // 
            this.ShiftTextButt.Location = new System.Drawing.Point(18, 684);
            this.ShiftTextButt.Name = "ShiftTextButt";
            this.ShiftTextButt.Size = new System.Drawing.Size(263, 95);
            this.ShiftTextButt.TabIndex = 34;
            this.ShiftTextButt.Text = "Ввести";
            this.ShiftTextButt.UseVisualStyleBackColor = true;
            this.ShiftTextButt.Click += new System.EventHandler(this.ShiftTextButt_Click);
            // 
            // ShiftTextBox
            // 
            this.ShiftTextBox.Location = new System.Drawing.Point(18, 652);
            this.ShiftTextBox.Name = "ShiftTextBox";
            this.ShiftTextBox.Size = new System.Drawing.Size(285, 26);
            this.ShiftTextBox.TabIndex = 33;
            // 
            // ShiftText
            // 
            this.ShiftText.AutoSize = true;
            this.ShiftText.Location = new System.Drawing.Point(14, 538);
            this.ShiftText.Name = "ShiftText";
            this.ShiftText.Size = new System.Drawing.Size(418, 100);
            this.ShiftText.TabIndex = 32;
            this.ShiftText.Text = "Есть ли структурные сдвиги в данной модели?\r\nВведите номер наблюдения, с которого" +
    " пошел сдвиг\r\n\r\n\r\n\r\n";
            // 
            // InputRedTextAsk
            // 
            this.InputRedTextAsk.AutoSize = true;
            this.InputRedTextAsk.Location = new System.Drawing.Point(14, 273);
            this.InputRedTextAsk.Name = "InputRedTextAsk";
            this.InputRedTextAsk.Size = new System.Drawing.Size(456, 100);
            this.InputRedTextAsk.TabIndex = 31;
            this.InputRedTextAsk.Text = "Введите номера столбцов с качественными переменными\r\nчерез пробел\r\n(счет факторов" +
    " идет начиная с 1)\r\nОБЯЗАТЕЛЬНО в данных указывать их названия\r\nна латинской рас" +
    "кладке клавиатуры\r\n";
            // 
            // InputRedButt
            // 
            this.InputRedButt.Location = new System.Drawing.Point(18, 430);
            this.InputRedButt.Name = "InputRedButt";
            this.InputRedButt.Size = new System.Drawing.Size(263, 95);
            this.InputRedButt.TabIndex = 30;
            this.InputRedButt.Text = "Ввести";
            this.InputRedButt.UseVisualStyleBackColor = true;
            this.InputRedButt.Click += new System.EventHandler(this.InputRedButt_Click);
            // 
            // InputRedBox
            // 
            this.InputRedBox.Location = new System.Drawing.Point(18, 388);
            this.InputRedBox.Name = "InputRedBox";
            this.InputRedBox.Size = new System.Drawing.Size(285, 26);
            this.InputRedBox.TabIndex = 29;
            // 
            // ButtNo2
            // 
            this.ButtNo2.Location = new System.Drawing.Point(236, 149);
            this.ButtNo2.Name = "ButtNo2";
            this.ButtNo2.Size = new System.Drawing.Size(200, 118);
            this.ButtNo2.TabIndex = 28;
            this.ButtNo2.Text = "Нет\r\n";
            this.ButtNo2.UseVisualStyleBackColor = true;
            // 
            // ButtYes2
            // 
            this.ButtYes2.Location = new System.Drawing.Point(18, 149);
            this.ButtYes2.Name = "ButtYes2";
            this.ButtYes2.Size = new System.Drawing.Size(200, 118);
            this.ButtYes2.TabIndex = 27;
            this.ButtYes2.Text = "Да";
            this.ButtYes2.UseVisualStyleBackColor = true;
            // 
            // ButtNo1
            // 
            this.ButtNo1.Location = new System.Drawing.Point(236, 149);
            this.ButtNo1.Name = "ButtNo1";
            this.ButtNo1.Size = new System.Drawing.Size(200, 118);
            this.ButtNo1.TabIndex = 26;
            this.ButtNo1.Text = "Нет\r\n";
            this.ButtNo1.UseVisualStyleBackColor = true;
            this.ButtNo1.Click += new System.EventHandler(this.ButtNo1_Click);
            // 
            // ButtYes1
            // 
            this.ButtYes1.Location = new System.Drawing.Point(18, 149);
            this.ButtYes1.Name = "ButtYes1";
            this.ButtYes1.Size = new System.Drawing.Size(200, 118);
            this.ButtYes1.TabIndex = 25;
            this.ButtYes1.Text = "Да";
            this.ButtYes1.UseVisualStyleBackColor = true;
            this.ButtYes1.Click += new System.EventHandler(this.ButtYes1_Click);
            // 
            // RepresLabel
            // 
            this.RepresLabel.Location = new System.Drawing.Point(1860, 824);
            this.RepresLabel.Name = "RepresLabel";
            this.RepresLabel.Size = new System.Drawing.Size(387, 408);
            this.RepresLabel.TabIndex = 23;
            this.RepresLabel.Text = "label5";
            // 
            // PowerLabel
            // 
            this.PowerLabel.Location = new System.Drawing.Point(1471, 824);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(383, 408);
            this.PowerLabel.TabIndex = 22;
            this.PowerLabel.Text = "label4";
            // 
            // ExpLabel
            // 
            this.ExpLabel.Location = new System.Drawing.Point(1086, 824);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(379, 408);
            this.ExpLabel.TabIndex = 21;
            this.ExpLabel.Text = "label3";
            // 
            // LinearLabel
            // 
            this.LinearLabel.Location = new System.Drawing.Point(697, 824);
            this.LinearLabel.Name = "LinearLabel";
            this.LinearLabel.Size = new System.Drawing.Size(383, 408);
            this.LinearLabel.TabIndex = 20;
            this.LinearLabel.Text = "label2";
            // 
            // RepresChart
            // 
            chartArea1.Name = "ChartArea1";
            this.RepresChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RepresChart.Legends.Add(legend1);
            this.RepresChart.Location = new System.Drawing.Point(1533, 379);
            this.RepresChart.Name = "RepresChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.RepresChart.Series.Add(series1);
            this.RepresChart.Size = new System.Drawing.Size(717, 359);
            this.RepresChart.TabIndex = 19;
            this.RepresChart.Text = "chart3";
            // 
            // PowerChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PowerChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PowerChart.Legends.Add(legend2);
            this.PowerChart.Location = new System.Drawing.Point(810, 379);
            this.PowerChart.Name = "PowerChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.PowerChart.Series.Add(series2);
            this.PowerChart.Size = new System.Drawing.Size(717, 359);
            this.PowerChart.TabIndex = 18;
            this.PowerChart.Text = "chart2";
            // 
            // ExpChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ExpChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ExpChart.Legends.Add(legend3);
            this.ExpChart.Location = new System.Drawing.Point(1533, 14);
            this.ExpChart.Name = "ExpChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ExpChart.Series.Add(series3);
            this.ExpChart.Size = new System.Drawing.Size(717, 359);
            this.ExpChart.TabIndex = 17;
            this.ExpChart.Text = "chart4";
            // 
            // LinearChart
            // 
            chartArea4.Name = "ChartArea1";
            this.LinearChart.ChartAreas.Add(chartArea4);
            this.LinearChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend4.Name = "Legend1";
            this.LinearChart.Legends.Add(legend4);
            this.LinearChart.Location = new System.Drawing.Point(810, 14);
            this.LinearChart.Name = "LinearChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.LinearChart.Series.Add(series4);
            this.LinearChart.Size = new System.Drawing.Size(717, 359);
            this.LinearChart.TabIndex = 16;
            this.LinearChart.Text = "chart1";
            // 
            // ButTextInp
            // 
            this.ButTextInp.Location = new System.Drawing.Point(16, 149);
            this.ButTextInp.Name = "ButTextInp";
            this.ButTextInp.Size = new System.Drawing.Size(420, 118);
            this.ButTextInp.TabIndex = 3;
            this.ButTextInp.Text = "Выбрать файл с данными";
            this.ButTextInp.UseVisualStyleBackColor = true;
            this.ButTextInp.Click += new System.EventHandler(this.ButTextInp_Click);
            // 
            // TextFileReader
            // 
            this.TextFileReader.AutoSize = true;
            this.TextFileReader.Location = new System.Drawing.Point(14, 14);
            this.TextFileReader.Name = "TextFileReader";
            this.TextFileReader.Size = new System.Drawing.Size(422, 100);
            this.TextFileReader.TabIndex = 2;
            this.TextFileReader.Text = "Выберите ваш файл\r\n1 столбец должен состоять из наблюдений \r\nзависящей величины\r\n" +
    "Остальные столбцы состоят из наблюдений величин,\r\nот которрых зависит первый сто" +
    "лбец\r\n";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // AutocorrCheckButt
            // 
            this.AutocorrCheckButt.Location = new System.Drawing.Point(18, 1051);
            this.AutocorrCheckButt.Name = "AutocorrCheckButt";
            this.AutocorrCheckButt.Size = new System.Drawing.Size(263, 95);
            this.AutocorrCheckButt.TabIndex = 37;
            this.AutocorrCheckButt.Text = "Проверка на автокорелляцию";
            this.AutocorrCheckButt.UseVisualStyleBackColor = true;
            this.AutocorrCheckButt.Click += new System.EventHandler(this.AutocorrCheckButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2260, 1239);
            this.Controls.Add(this.Back);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Back.ResumeLayout(false);
            this.Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepresChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Back;
        private System.Windows.Forms.Button ButTextInp;
        private System.Windows.Forms.Label TextFileReader;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label RepresLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.Label LinearLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart RepresChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PowerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LinearChart;
        private System.Windows.Forms.Button ButtYes1;
        private System.Windows.Forms.Button ButtNo1;
        private System.Windows.Forms.Button ButtNo2;
        private System.Windows.Forms.Button ButtYes2;
        private System.Windows.Forms.Button InputRedButt;
        private System.Windows.Forms.TextBox InputRedBox;
        private System.Windows.Forms.Label InputRedTextAsk;
        private System.Windows.Forms.Button ShiftTextButt;
        private System.Windows.Forms.TextBox ShiftTextBox;
        private System.Windows.Forms.Label ShiftText;
        private System.Windows.Forms.Button MultCheck;
        private System.Windows.Forms.Button GeteroskedCheckButt;
        private System.Windows.Forms.Button AutocorrCheckButt;
    }
}

