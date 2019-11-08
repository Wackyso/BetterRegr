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
            this.Back = new System.Windows.Forms.Panel();
            this.MultiColl = new System.Windows.Forms.Button();
            this.OneVarFourCharts = new System.Windows.Forms.Button();
            this.ButTextInp = new System.Windows.Forms.Button();
            this.DescriptLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Controls.Add(this.MultiColl);
            this.Back.Controls.Add(this.OneVarFourCharts);
            this.Back.Controls.Add(this.ButTextInp);
            this.Back.Controls.Add(this.DescriptLabel);
            this.Back.Location = new System.Drawing.Point(-1, -1);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(1080, 629);
            this.Back.TabIndex = 0;
            // 
            // MultiColl
            // 
            this.MultiColl.Location = new System.Drawing.Point(556, 73);
            this.MultiColl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MultiColl.Name = "MultiColl";
            this.MultiColl.Size = new System.Drawing.Size(229, 64);
            this.MultiColl.TabIndex = 13;
            this.MultiColl.Text = "Более 1-й переменной\r\n, модели линейная,степенная, экспоненциальная, показательна" +
    "я";
            this.MultiColl.UseVisualStyleBackColor = true;
            this.MultiColl.Click += new System.EventHandler(this.MultiColl_Click);
            // 
            // OneVarFourCharts
            // 
            this.OneVarFourCharts.Location = new System.Drawing.Point(323, 73);
            this.OneVarFourCharts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OneVarFourCharts.Name = "OneVarFourCharts";
            this.OneVarFourCharts.Size = new System.Drawing.Size(229, 64);
            this.OneVarFourCharts.TabIndex = 12;
            this.OneVarFourCharts.Text = "Одна переменная, модели линейная,степенная, экспоненциальная, показательная";
            this.OneVarFourCharts.UseVisualStyleBackColor = true;
            this.OneVarFourCharts.Click += new System.EventHandler(this.OneVarFourCharts_Click);
            // 
            // ButTextInp
            // 
            this.ButTextInp.Location = new System.Drawing.Point(11, 97);
            this.ButTextInp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButTextInp.Name = "ButTextInp";
            this.ButTextInp.Size = new System.Drawing.Size(205, 64);
            this.ButTextInp.TabIndex = 3;
            this.ButTextInp.Text = "Выбрать файл с данными";
            this.ButTextInp.UseVisualStyleBackColor = true;
            this.ButTextInp.Click += new System.EventHandler(this.ButTextInp_Click);
            // 
            // DescriptLabel
            // 
            this.DescriptLabel.AutoSize = true;
            this.DescriptLabel.Location = new System.Drawing.Point(9, 9);
            this.DescriptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptLabel.Name = "DescriptLabel";
            this.DescriptLabel.Size = new System.Drawing.Size(280, 65);
            this.DescriptLabel.TabIndex = 2;
            this.DescriptLabel.Text = "Выберите ваш файл\r\n1 столбец должен состоять из наблюдений \r\nзависящей величины\r\n" +
    "Остальные столбцы состоят из наблюдений величин,\r\nот которрых зависит первый сто" +
    "лбец\r\n";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 626);
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Back.ResumeLayout(false);
            this.Back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Back;
        private System.Windows.Forms.Button ButTextInp;
        private System.Windows.Forms.Label DescriptLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button OneVarFourCharts;
        private System.Windows.Forms.Button MultiColl;
    }
}

