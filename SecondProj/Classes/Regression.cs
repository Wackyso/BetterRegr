using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProj
{
    public class Regression
    {

        public static int Watches;
        public static int Variables;
        public double[] YTemp;
        public double[,] XTemp;
        public double[] AverageTemp;
        public double[] CoeffTemp;
        public double Det;
        public double Aprox = 0;
        public bool Fstat;
        public string Stud;

        public Regression()
        {
            YTemp = new double[Watches];
            XTemp = new double[Watches, Variables];
            CoeffTemp = new double[Variables];
            AverageTemp = new double[Variables];
        }
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

        public void YTempMake()
        {
            for (int _i = 0; _i < Watches; _i++)
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
                    XTemp[i, j] = ReadFile.XMain[i, j];
                YTemp[i] = ReadFile.YMain[i];
            }

            SLE();
            YTempMake();

            EvalQual();
        }

        public void Exp()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    XTemp[i, j] = ReadFile.XMain[i, j];
                YTemp[i] = Math.Log(ReadFile.YMain[i]);
            }

            SLE();
            CoeffTemp[0] = Math.Exp(CoeffTemp[0]);
            for (int _i = 0; _i < Watches; _i++)
            {
                YTemp[_i] = CoeffTemp[0] * Math.Exp(XTemp[_i, 1] * CoeffTemp[1]);
            }

            EvalQual();
        }

        public void Power()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    XTemp[i, j] = ReadFile.XMain[i, j];
                YTemp[i] = Math.Log(ReadFile.YMain[i]);
            }

            SLE();
            CoeffTemp[0] = Math.Exp(CoeffTemp[0]);
            CoeffTemp[1] = Math.Exp(CoeffTemp[1]);
            for (int _i = 0; _i < Watches; _i++)
            {
                YTemp[_i] = CoeffTemp[0] * Math.Pow(CoeffTemp[1], XTemp[_i, 1]);
            }

            EvalQual();
        }

        public void Repres()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    XTemp[i, j] = j==0 ? (1) : (Math.Log(ReadFile.XMain[i, j]));
                YTemp[i] = Math.Log(ReadFile.YMain[i]);
            }

            SLE();
            CoeffTemp[0] = Math.Exp(CoeffTemp[0]);

            for (int _i = 0; _i < Watches; _i++)
            {
                YTemp[_i] = CoeffTemp[0] * Math.Pow(ReadFile.XMain[_i, 1], CoeffTemp[1]);
            }

            EvalQual();
        }

        public void EvalQual()
        {
            double _nom = 0;
            double _denom = 0;
            
            for(int i = 0; i < Watches; i++)
            {
                _nom += Math.Pow(ReadFile.YMain[i] - YTemp[i], 2);
                _denom += Math.Pow(ReadFile.YMain[i] - AverageTemp[0], 2);
            }

            Det = 1 - _nom / _denom;

            for (int i = 0; i < Watches; i++)
            {
                Aprox += Math.Abs((ReadFile.YMain[i] - YTemp[i])/ ReadFile.YMain[i]);
            }
            
            Aprox /= Watches;


        }
    }
}
