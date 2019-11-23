using System.Windows.Forms.DataVisualization.Charting;

namespace SecondProj
{
    public class ChartManager
    {
        private Chart _linearChart;
        private Chart _expChart;
        private Chart _powerChart;
        private Chart _represChart;

        public ChartManager(Chart linearChart, Chart expChart, Chart powerChart, Chart represChart)
        {
            _linearChart = linearChart;
            _expChart = expChart;
            _powerChart = powerChart;
            _represChart = represChart;
        }


        public ChartManager(Chart linearChart)
        {
            _linearChart = linearChart;
        }

        public void FormChart()
        {
            if (_linearChart != null)
            {
                _linearChart.Series.Clear();
                _linearChart.Series.Add("y fact");
                _linearChart.Series.Add("y esmitated");
                _linearChart.Series["y fact"].ChartType = SeriesChartType.Line;
                _linearChart.Series["y esmitated"].ChartType = SeriesChartType.Line;
            }
            if (_expChart != null)
            {
                _expChart.Series.Clear();
                _expChart.Series.Add("y fact");
                _expChart.Series.Add("y esmitated");
                _expChart.Series["y fact"].ChartType = SeriesChartType.Line;
                _expChart.Series["y esmitated"].ChartType = SeriesChartType.Line;
            }
            if (_powerChart != null)
            {
                _powerChart.Series.Clear();
                _powerChart.Series.Add("y fact");
                _powerChart.Series.Add("y esmitated");
                _powerChart.Series["y fact"].ChartType = SeriesChartType.Line;
                _powerChart.Series["y esmitated"].ChartType = SeriesChartType.Line;
            }
            if (_represChart != null)
            {
                _represChart.Series.Clear();
                _represChart.Series.Add("y fact");
                _represChart.Series.Add("y esmitated");
                _represChart.Series["y fact"].ChartType = SeriesChartType.Line;
                _represChart.Series["y esmitated"].ChartType = SeriesChartType.Line;
            }
        }

        public void ChartBuild(Chart chart, double[]Y, FileReader file)
        {
            for (int j = 0; j < file.Watches; j++)
            {
                chart.Series["y esmitated"].Points.Add(Y[j], file.XMain[j, 1]);
                chart.Series["y fact"].Points.Add(file.YMain[j], file.XMain[j, 1]);
            }
        }
    }
}
