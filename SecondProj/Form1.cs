using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            AllVar.Lines = System.IO.File.ReadAllLines(filename);

            AllVar _obj1 = new AllVar();
            _obj1.XYMaking();

            Regression reg = new Regression();

            ChartManager Charts = new ChartManager(LinearChart, ExpChart, PowerChart, RepresChart);
            Charts.FormChart();
            
            reg.Linest();
            Charts.ChartBuild(LinearChart);

            
        }
    }

    public class AllVar
    {
        public static string[] Lines;
        public static int Watches;
        public static int Variables;
        public static double[] YMain;
        public static double[,] XMain;
        public static double[] YTemp;
        public static double[,] XTemp;
        public static double[] AverageTemp;
        public static double[] CoeffTemp;
        public void XYMaking ()
        {
            Watches = 234;
            Variables = 0;
            string[] _line = Lines[0].Split(' ', '	');

            Variables = _line.Length;
            Watches = Lines.Length;

            YMain = new double[Watches];
            XMain = new double[Watches, Variables];
            YTemp = new double[Watches];
            XTemp= new double [Watches, Variables];
            AverageTemp= new double[Variables];
            CoeffTemp= new double [Variables];
            
            for (int _i = 0; _i < Watches; _i++)
            {
                _line = Lines[_i].Split(' ', '	');
                for(int _j = 0; _j < Variables; _j++)
                {
                    if (_j == 0)
                    {
                        YMain[_i] = Convert.ToDouble(_line[_j]);
                        XMain[_i, _j] = 1f;
                    }
                    else
                        XMain[_i, _j] = Convert.ToDouble(_line[_j]);
                }
            }
        }
    }

    public class Regression : AllVar
    {
        public void SLE()
        {
            double _a = 0;
            double _c = 0;
            double[,] _sl = new double[Variables, Variables];

            for (int i = 0; i < Variables; i++)
            {
                for (int j = i; j < Variables; j++)
                {
                    for (int g = 0; g < Watches; g++)
                    {
                        _a += XTemp[g, i] * XTemp[g, j];
                        if (i == j) _c += XTemp[g, i] * YTemp[g];
                    }
                    _sl[i, j] = _sl[j, i] = _a / Watches;
                    if (i == j) CoeffTemp[i] = _c / Watches;
                    _a = 0;
                    _c = 0;
                }

            }

            AverageTemp[0] = CoeffTemp[0];
            for (int i = 1; i < Variables; i++)
                AverageTemp[i] = _sl[0, i];

            for (int i = 0; i < Variables; i++)
            {
                double d = _sl[i, i];

                for (int j = 0; j < Variables; j++)
                {
                    _sl[i, j] /= d;
                }
                CoeffTemp[i] /= d;

                for (int j = 0; j < Variables; j++)
                {
                    if (j != i) 
                    {
                        CoeffTemp[j] -= CoeffTemp[i] * _sl[j, i];

                        double p = _sl[j, i];
                        for (int k = 0; k < Variables; k++)
                        {
                            _sl[j, k] -= _sl[i, k] * p;
                        }
                    }
                }
            }
        } 

        public void YTempMaker()
        {
            for (int _i=0; _i< Watches; _i++)
            {
                YTemp[_i] = 0;
                for (int _j = 0; _j < Variables; _j++) 
                {
                    YTemp[_i] += XTemp[_i, _j] * CoeffTemp[_j];
                }
            }
        }

        public void Linest()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    XTemp[i, j] = XMain[i, j];
                YTemp[i] = YMain[i];
            }
            SLE();

            YTempMaker();

            //ChartManager.ChartBuild(LinearChart);
        }

        public void Exp()
        {
            
        }

        public void Power()
        {

        }

        public void Repres()
        {

        }
    }

    public class ChartManager : AllVar
    {
        public readonly Chart LinearChart;
        public readonly Chart ExpChart;
        public readonly Chart PowerChart;
        public readonly Chart RepresChart;

        public ChartManager(Chart LinearChart, Chart ExpChart, Chart PowerChart, Chart RepresChart)
        {
            this.LinearChart = LinearChart;
            this.ExpChart = ExpChart;
            this.PowerChart = PowerChart;
            this.RepresChart = RepresChart;
        }

        public void FormChart()
        {
            LinearChart.Series.Clear();
            LinearChart.Series.Add("y fact");
            LinearChart.Series.Add("y esmitated");
            LinearChart.Series["y fact"].ChartType = SeriesChartType.Line;
            LinearChart.Series["y esmitated"].ChartType = SeriesChartType.Line;

            ExpChart.Series.Clear();
            ExpChart.Series.Add("y fact");
            ExpChart.Series.Add("y esmitated");
            ExpChart.Series["y fact"].ChartType = SeriesChartType.Line;
            ExpChart.Series["y esmitated"].ChartType = SeriesChartType.Line;

            PowerChart.Series.Clear();
            PowerChart.Series.Add("y fact");
            PowerChart.Series.Add("y esmitated");
            PowerChart.Series["y fact"].ChartType = SeriesChartType.Line;
            PowerChart.Series["y esmitated"].ChartType = SeriesChartType.Line;

            RepresChart.Series.Clear();
            RepresChart.Series.Add("y fact");
            RepresChart.Series.Add("y esmitated");
            RepresChart.Series["y fact"].ChartType = SeriesChartType.Line;
            RepresChart.Series["y esmitated"].ChartType = SeriesChartType.Line;
        }

        public void ChartBuild(Chart _chart1)
        {
            for (int j = 0; j < Watches; j++)
            {
                _chart1.Series["y esmitated"].Points.Add(YTemp[j], XMain[j, 1]);
                _chart1.Series["y fact"].Points.Add(YMain[j], XMain[j, 1]);
            }
        }
    }

    public class TextManager : AllVar
    {

    }
    
}