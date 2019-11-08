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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

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
