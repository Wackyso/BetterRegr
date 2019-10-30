using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SecondProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void ButTextInp_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            ReadFile.Lines = System.IO.File.ReadAllLines(filename);

            ReadFile read = new ReadFile();
            read.XYMaking();

            
        }

        private void OneVarFourCharts_Click(object sender, EventArgs e)
        {
            ChartManager Charts = new ChartManager(LinearChart, ExpChart, PowerChart, RepresChart);
            Charts.FormChart();

            Regression linest = new Regression();
            linest.Linest();
            Charts.ChartBuild(LinearChart, linest);

            Regression exp = new Regression();
            exp.Linest();
            Charts.ChartBuild(ExpChart, exp);

            Regression power = new Regression();
            power.Linest();
            Charts.ChartBuild(PowerChart, power);

            Regression repres = new Regression();
            repres.Linest();
            Charts.ChartBuild(RepresChart, repres);
        }
    }

    

    

    

    /**/
    
}