using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SecondProj
{
    public partial class Form1 : Form
    {
        private const string FileFilter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        static private string[] lines; 
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

            //Regression reg = new Regression();
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

            Regression reg = new Regression();
            reg.Analyt(lines, InputRedTextAsk, LinearChart);
        }

        private void InputRedButt_Click(object sender, EventArgs e)
        {
            Regression reg = new Regression();
            string red = InputRedBox.Text;
            reg.Analyt(lines,InputRedTextAsk,LinearChart, red);
        }
    }
}