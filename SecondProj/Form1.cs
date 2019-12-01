using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SecondProj
{
    public partial class Form1 : Form
    {
        private const string FileFilter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        static private string[] lines;
        string red;
        public Regression reg = new Regression();
        public Form1()
        {
            InitializeComponent();

            ButtYes1.Hide();
            ButtNo1.Hide();
            ButtYes2.Hide();
            ButtNo2.Hide();
            InputRedBox.Hide();
            InputRedButt.Hide();
            InputRedTextAsk.Hide();
            ShiftText.Hide();
            ShiftTextBox.Hide();
            ShiftTextButt.Hide();

            openFileDialog.Filter = FileFilter;

            
        }

        private void ButTextInp_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            
            if (dialogResult == DialogResult.Cancel)
                return;

            string filename = openFileDialog.FileName;
            lines = System.IO.File.ReadAllLines(filename);

            ButTextInp.Hide();
            TextFileReader.Text = "Есть ли качественные признаки или факторы среди данных?";
            ButtYes1.Show();
            ButtNo1.Show();

            reg = new Regression();
            //reg.Analyt(lines);

            //TextFileReader.Text = "Есть ли структурные сдвиги в данной модели?";
        }

        private void ButtYes1_Click(object sender, EventArgs e)
        {
            InputRedBox.Show();
            InputRedButt.Show();
            InputRedTextAsk.Show();
        }

        private void ButtNo1_Click(object sender, EventArgs e)
        {
            ButtYes1.Hide();
            ButtNo1.Hide();
            
            //ButtYes2.Show();
            //ButtNo2.Show();

            //Regression reg = new Regression();


            reg.Analyt(lines, InputRedTextAsk, LinearChart);// первый варинт первого рисунка
            TextManager.TextBuild(LinearLabel, reg);

            ShiftText.Show();
            ShiftTextBox.Show();
            ShiftTextButt.Show();
        }

        private void InputRedButt_Click(object sender, EventArgs e)
        {
            reg = new Regression();
            red = InputRedBox.Text;
            reg.Analyt(lines,InputRedTextAsk,LinearChart, red);// первый рисунок c качесвтенными переменными
            TextManager.TextBuild(LinearLabel, reg);

            InputRedBox.Hide();
            InputRedButt.Hide();
            InputRedTextAsk.Hide();

            ShiftText.Show();
            ShiftTextBox.Show();
            ShiftTextButt.Show();
        }

        private void ShiftTextButt_Click(object sender, EventArgs e)
        {
            ShiftText.Hide();
            ShiftTextBox.Hide();
            ShiftTextButt.Hide();
            InputRedTextAsk.Show();
            string Shift = InputRedBox.Text;

            reg.ShiftKey = true;
            reg.Shifts = Shift;

            reg.ShiftFunk(Shift, LinearChart);//вариант первого рисунка с сдвигом
            TextManager.TextBuild(LinearLabel, reg);
        }

        private void MultCheck_Click(object sender, EventArgs e)
        {
            reg.XsquareCheck(PowerChart);
            TextManager.TextBuild(PowerLabel, reg);//третий рисунок
        }

        private void GeteroskedCheckButt_Click(object sender, EventArgs e)
        {
            reg.XsquareCheck(RepresChart);
            TextManager.TextBuild(RepresLabel, reg);//четвертый рисунок
        }

        private void AutocorrCheckButt_Click(object sender, EventArgs e)
        {
            reg.AutoCorrCheck(ExpChart);
            TextManager.TextBuild(ExpLabel, reg);//второй риснок
        }
    }
}