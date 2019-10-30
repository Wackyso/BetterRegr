using System;

namespace SecondProj
{
    public class FileReader
    {
        private string[] _lines;

        public static double[] YMain;
        public static double[,] XMain;

        public FileReader(string[] lines)
        {
            _lines = lines;
        }

        public void XYMaking()
        {
            Regression.Watches = 0;
            Regression.Variables = 0;
            string[] lines = _lines[0].Split(' ', '	');

            Regression.Variables = lines.Length;
            Regression.Watches = _lines.Length;

            YMain = new double[Regression.Watches];
            XMain = new double[Regression.Watches, Regression.Variables];

            for (int i = 0; i < Regression.Watches; i++)
            {
                lines = _lines[i].Split(' ', '	');
                for (int j = 0; j < Regression.Variables; j++)
                {
                    if (j == 0)
                    {
                        YMain[i] = Convert.ToDouble(lines[j]);
                        XMain[i, j] = 1f;
                    }
                    else
                        XMain[i, j] = Convert.ToDouble(lines[j]);
                }
            }
        }
    }
}