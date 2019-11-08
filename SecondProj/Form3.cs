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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            ChartManager charts = new ChartManager(MultiChart);
            charts.FormChart();

            Regression linest = new Regression();
            linest.Linest();
            charts.ChartBuild(MultiChart, linest);
            TextManager.TextBuild(MultiLabel, linest);
        }
    }
    
}
