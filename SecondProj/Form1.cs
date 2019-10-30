using System;
using System.Windows.Forms;


namespace SecondProj
{
    public partial class Form1 : Form
    {
        private const string FileFilter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        public Form1()
        {
            InitializeComponent();
            
            openFileDialog.Filter = FileFilter;
        }

        private void ButTextInp_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            
            if (dialogResult == DialogResult.Cancel)
                return;

            string filename = openFileDialog.FileName;
            var lines = System.IO.File.ReadAllLines(filename);
            var fileReader = new FileReader(lines);
            fileReader.XYMaking();
        }

        private void OneVarFourCharts_Click(object sender, EventArgs e)
        {
            ChartManager charts = new ChartManager(LinearChart, ExpChart, PowerChart, RepresChart);
            charts.FormChart();

            Regression linest = new Regression();
            linest.Linest();
            charts.ChartBuild(LinearChart, linest);
            TextManager.TextBuild(LinarLabel, linest);

            Regression exp = new Regression();
            exp.Exp();
            charts.ChartBuild(ExpChart, exp);
            TextManager.TextBuild(ExpLabel, exp);

            Regression power = new Regression();
            power.Power();
            charts.ChartBuild(PowerChart, power);
            TextManager.TextBuild(PowerLabel, power);

            Regression repres = new Regression();
            repres.Repres();
            charts.ChartBuild(RepresChart, repres);
            TextManager.TextBuild(RepresLabel, repres);
        }
    }
}