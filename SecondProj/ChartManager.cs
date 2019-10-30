using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SecondProj
{
    public class ChartManager
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

        public void ChartBuild(Chart _chart, Regression _temp)
        {


            for (int j = 0; j < Regression.Watches; j++)
            {
                _chart.Series["y esmitated"].Points.Add(_temp.YTemp[j], ReadFile.XMain[j, 1]);
                _chart.Series["y fact"].Points.Add(ReadFile.YMain[j], ReadFile.XMain[j, 1]);
            }
        }
    }
}
