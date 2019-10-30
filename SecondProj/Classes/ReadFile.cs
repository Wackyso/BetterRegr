using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProj
{
    public class ReadFile
    {
        public static double[] YMain;
        public static double[,] XMain;
        public static string[] Lines;

        public void XYMaking()
        {
            Regression.Watches = 0;
            Regression.Variables = 0;
            string[] _line = Lines[0].Split(' ', '	');

            Regression.Variables = _line.Length;
            Regression.Watches = Lines.Length;

            YMain = new double[Regression.Watches];
            XMain = new double[Regression.Watches, Regression.Variables];


            for (int _i = 0; _i < Regression.Watches; _i++)
            {
                _line = Lines[_i].Split(' ', '	');
                for (int _j = 0; _j < Regression.Variables; _j++)
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
}
