using System;

namespace SecondProj
{
    public class Regression
    {
        public static int Watches;
        public static int Variables;
        public double[] Y;
        public double[,] X;
        public double[] Average;
        public double[] Coeff;
        public double Det;
        public double Aprox = 0;
        public bool FStat;
        public string Stud;
        public double[] elast;

        public Regression()
        {
            Y = new double[Watches];
            X = new double[Watches, Variables];
            Coeff = new double[Variables];
            Average = new double[Variables];
            elast = new double[Variables - 1];
        }

        public void Linest()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    X[i, j] = FileReader.XMain[i, j];
                Y[i] = FileReader.YMain[i];
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
                    X[i, j] = FileReader.XMain[i, j];
                Y[i] = Math.Log(FileReader.YMain[i]);
            }

            SLE();
            Coeff[0] = Math.Exp(Coeff[0]);
            for (int i = 0; i < Watches; i++)
            {
                Y[i] = Coeff[0] * Math.Exp(X[i, 1] * Coeff[1]);
            }

            EvalQual();
        }

        public void Power()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    X[i, j] = FileReader.XMain[i, j];
                Y[i] = Math.Log(FileReader.YMain[i]);
            }

            SLE();
            Coeff[0] = Math.Exp(Coeff[0]);
            Coeff[1] = Math.Exp(Coeff[1]);
            for (int i = 0; i < Watches; i++)
            {
                Y[i] = Coeff[0] * Math.Pow(Coeff[1], X[i, 1]);
            }

            EvalQual();
        }

        public void Repres()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    X[i, j] = j==0 ? (1) : (Math.Log(FileReader.XMain[i, j]));
                Y[i] = Math.Log(FileReader.YMain[i]);
            }

            SLE();
            Coeff[0] = Math.Exp(Coeff[0]);

            for (int i = 0; i < Watches; i++)
            {
                Y[i] = Coeff[0] * Math.Pow(FileReader.XMain[i, 1], Coeff[1]);
            }

            EvalQual();
        }
        
        private void SLE()
        {
            double a = 0;
            double c = 0;
            double[,] sl = new double[Variables, Variables];

            for (int i = 0; i < Variables; i++)
            {
                for (int j = i; j < Variables; j++)
                {
                    for (int g = 0; g < Watches; g++)
                    {
                        a += X[g, i] * X[g, j];
                        if (i == j) c += X[g, i] * Y[g];
                    }
                    sl[i, j] = sl[j, i] = a / Watches;
                    if (i == j) Coeff[i] = c / Watches;
                    a = 0;
                    c = 0;
                }

            }

            Average[0] = Coeff[0];
            for (int i = 1; i < Variables; i++)
                Average[i] = sl[0, i];

            for (int i = 0; i < Variables; i++)
            {
                double d = sl[i, i];

                for (int j = 0; j < Variables; j++)
                {
                    sl[i, j] /= d;
                }
                Coeff[i] /= d;

                for (int j = 0; j < Variables; j++)
                {
                    if (j != i)
                    {
                        Coeff[j] -= Coeff[i] * sl[j, i];

                        double p = sl[j, i];
                        for (int k = 0; k < Variables; k++)
                        {
                            sl[j, k] -= sl[i, k] * p;
                        }
                    }
                }
            }
        }
        
        private void EvalQual()
        {
            double nom = 0;
            double denom = 0;
            
            for(int i = 0; i < Watches; i++)
            {
                nom += Math.Pow(FileReader.YMain[i] - Y[i], 2);
                denom += Math.Pow(FileReader.YMain[i] - Average[0], 2);
            }

            Det = 1 - nom / denom;

            for (int i = 0; i < Watches; i++)
            {
                Aprox += Math.Abs((FileReader.YMain[i] - Y[i])/ FileReader.YMain[i]);
            }
            
            Aprox /= Watches;
        }

        private void YTempMake()
        {
            for (int i = 0; i < Watches; i++)
            {
                Y[i] = 0;
                for (int _j = 0; _j < Variables; _j++)
                {
                    Y[i] += X[i, _j] * Coeff[_j];
                }
            }
        }

        public void Elast()
        {

        }

        public double[,] Matrix()
        {
            double[,] matrix = new double[0,0];
            
            return matrix;
        }
    }
}
