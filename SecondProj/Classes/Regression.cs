using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
namespace SecondProj
{
    public class Regression
    {
        public int Watches = 0;
        public int Variables = 0;
        public double[] Y;
        public double[,] X;
        public double[] Average;
        public double[] Coeff;
        public double Det;
        public double Aprox = 0;
        public bool FStat;
        public string Stud;
        public double[] elast;
        public double[] YMain;
        public double[,] XMain;
        public int FakeVarsNum;
        public string[,] XMainFake;
        public bool _key;
        public string[] FakeVarsMas;
        public int colum;
        public bool ShiftKey;
        public int Shift;
        public string Shifts;
        public ChartManager chart;
        public FileReader file;


        public void Analyt(string[] lines,Label txt, Chart linear,  string red = "")//перегрузка для всех моделей в которых более 1-й переменной
        {
            _key = false; // ключ на наличие качественных переменных =1 значит есть 
            file = new FileReader(lines);
            if (string.Compare(red, "") != 0) { file = new FileReader(lines, red); _key = true; }

            if (string.Compare(Shifts, "") != 0 && ShiftKey)
            {
                string[] Shiftsa = Shifts.Split(' ', '	');
                this.Shift = Convert.ToInt32(Shiftsa[0]);
            }

            file.XYMaking();
            if (_key) 
            { 

                FakeVarsNum = file.red_args.Count;
                FakeVarsMas = new string[FakeVarsNum];
                for (int i = 0; i < FakeVarsNum; i++)
                    FakeVarsMas[i] = file.red_args[i];
                XMainFake = file.XFake;
            }
            XMain = file.XMain;
            
            YMain = file.YMain;

            if (_key)
            {
                Watches = file.Watches;
                if (ShiftKey)
                    Variables = file.Variables*2 + FakeVarsNum;//каждый сдвиг удваивает количество переменных(множественные сдвиги это пиздец, нужно будет описывать с помощью рекурсии каждый параметр, которых уже на втором сдвиге будет в 4 раза больше, то есть минимум 8 с константой)
                else
                    Variables = file.Variables + FakeVarsNum;
                colum = file.ind;
            }
            else
            {
                Watches = file.Watches;
                if (ShiftKey) Variables = file.Variables * 2;
                else Variables = file.Variables;
            }

            

            Y = new double[Watches];
            X = new double[Watches, Variables];
            Coeff = new double[Variables];
            Average = new double[Variables];
            elast = new double[Variables - 1];

            Linest();
            
            chart = new ChartManager(linear);
            chart.FormChart();
            chart.ChartBuild(linear, Y,file);
            
            if (ShiftKey)txt.Text = $"olololo {X[0,0]} { X[0, 1] } {X[0, 2]} {X[0, 3]} {X[10, 0]} {X[10, 1]} {X[10, 2]} {X[10, 3]}";
        }

        public void Analyt(string[] lines, Label txt, Chart linear,Chart Exp,Chart Power, Chart Repr) //перегрузка для стандартной линейной модели с 1м Х
        {
            _key = false; // ключ на наличие качественных переменных =1 значит есть 
            FileReader file = new FileReader(lines);

            if (string.Compare(Shifts, "") != 0 && ShiftKey)
            {
                string[] Shiftsa = Shifts.Split(' ', '	');
                this.Shift = Convert.ToInt32(Shiftsa[0]);
            }

            file.XYMaking();
            
            XMain = file.XMain;

            YMain = file.YMain;

            Watches = file.Watches;
            if (ShiftKey)
                Variables = file.Variables*2;
            else
                Variables = file.Variables;

            Y = new double[Watches];
            X = new double[Watches, Variables];
            Coeff = new double[Variables];
            Average = new double[Variables];
            elast = new double[Variables - 1];

            if (Variables == 2)
            {
                Linest();
                ChartManager chart = new ChartManager(linear, Exp, Power, Repr);
                chart.FormChart();
                chart.ChartBuild(linear, Y, file);
            }
        }

        public void Linest()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                {
                    if (ShiftKey)
                    {
                        if (j >= (Variables - FakeVarsNum) / 2)
                        {
                            if (j >= (Variables - FakeVarsNum) / 2 + FakeVarsNum)
                            {
                                if (i > Shift) X[i, j] = XMain[i, j - Variables / 2 - FakeVarsNum]; else X[i, j] = 0;
                            }
                            else
                                X[i, j] = 0;
                            for (int b = 0; b < colum; b++)
                                if (string.Compare(XMainFake[i, b], FakeVarsMas[j - Variables + FakeVarsNum]) == 0)
                                    X[i, j] = 1;

                        }
                        else
                           if (i <= Shift) X[i, j] = XMain[i, j]; else X[i, j] = 0;
                        X[i, 0] = 1;
                    }
                    else
                    if (j >= Variables - FakeVarsNum)
                    {
                        X[i, j] = 0;
                        for (int b = 0; b < colum; b++)
                            if (string.Compare(XMainFake[i, b], FakeVarsMas[j - Variables + FakeVarsNum]) == 0)
                                X[i, j] = 1;

                    }
                    else
                        X[i, j] = XMain[i, j];//заполнение массива иксов стандартными переменнымии с начала и фиктивными в крайние ряды 
                }
                Y[i] = YMain[i];
            }
        
            SLE();
            YTempMake();
            double d = EvalQual();
        }

        public void Exp()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    X[i, j] = XMain[i, j];
                Y[i] = Math.Log(YMain[i]);
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
                    X[i, j] = XMain[i, j];
                Y[i] = Math.Log(YMain[i]);
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
                    X[i, j] = j==0 ? (1) : (Math.Log(XMain[i, j]));
                Y[i] = Math.Log(YMain[i]);
            }

            SLE();
            Coeff[0] = Math.Exp(Coeff[0]);

            for (int i = 0; i < Watches; i++)
            {
                Y[i] = Coeff[0] * Math.Pow(XMain[i, 1], Coeff[1]);
            }

            EvalQual();
        }
        
        private void SLE()
        {
            double a = 0;
            double c = 0;
            double[,] sl = new double[Variables, Variables];
            //Coeff = new double[Variables];

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
        
        private double EvalQual()//р квадрат коеф детерминации 
        {
            double nom = 0;
            double denom = 0;
            
            for(int i = 0; i < Watches; i++)
            {
                nom += Math.Pow(YMain[i] - Y[i], 2);
                denom += Math.Pow(YMain[i] - Average[0], 2);
            }

            Det = 1 - nom / denom;

            for (int i = 0; i < Watches; i++)
            {
                Aprox += Math.Abs((YMain[i] - Y[i])/ YMain[i]);
            }
            
            Aprox /= Watches;
            return Det;
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

        public bool XsquareCheck()
        {
            double[,] XTab;
           
            double XX = ((Watches - 1) * (2 * Variables + 3) / 6) * Math.Log(Math.Pow(Det,0.5));
           /* if (XX < XTab[5, (Variables - 1) * (Variables - 2) / 2]) return false;
            else*/ return true;
        }

        public void MultiColl(Chart linear)//большая погрешность вычислений, узнать как уменьшить, иначее полностью бесполезный метод. Так что пока я решил хер забить на эту ебанину, потому что проебал уже натуралньо 3 часа в пустую на поиск ошибки, с теорией в этом методе все хорошо.
        {
            
            double[] Rs = new double[Variables];
            for (int i=1; i<Variables;i++)
            {
                Rs[i] = 0;
                for (int j=1;j< Variables; j++)
                {
                    double _x = 0;
                    double _y = 0;
                    double _y2 = 0;
                    if (i != j)
                    {
                        for (int k = 0; k < Watches; k++)
                        {
                            _x += (X[k, i] - Average[i]) * (X[k, j] - Average[j]);
                            _y += Math.Pow((X[k, i] - Average[i]), 2);
                            _y2 += Math.Pow((X[k, j] - Average[j]), 2);
                        }
                        Rs[i] += Math.Abs(_x / Math.Pow(_y * _y2, 0.5));
                    }
                }
            }
            int l = 0;
            double p1 = 0;
            for (int i=1;i<Variables;i++)
            {
                if (p1 < Rs[i])
                { 
                    l = i; 
                    p1 = Rs[i]; 
                }
            }

            double a;

            double[] p = new double[Watches];
            for (int i = 0; i < Watches; i++)
            {
                p[i] = X[i, l];
                for (int j = 0; j < Variables; j++)
                {
                    X[i, j] /= p[i];
                }
                a = X[i, l];
                X[i, l] = X[i, 0];
                X[i, 0] = a;
                Y[i] /= p[i];
            }
            SLE();


            
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                {
                    X[i, j] *= p[i];
                }
            }

            

            YTempMake();
            EvalQual();

            

            TextManager text = new TextManager();
            chart = new ChartManager(linear);
            chart.FormChart();
            chart.ChartBuild(linear, Y, file);
        }

        public void AutoCorrCheck() // проверка на автокорреляцию
        {
            double[] E= new double[Watches];
            double[] ESi = new double[Watches];

            double Vtab=Math.Round(Watches/2+1-1.96*Math.Pow(Watches-1,0.5));
            double Ktab=1.43*Math.Log(Watches-1);
            double Vem=0;
            double Kem=0;

            for (int i = 0; i < Watches; i++)
                E[i] = YMain[i] - Y[i];

            for (int i=0;i<Watches;i++)
                if (E[i]>0)
                {
                    ESi[i] = 1;
                    if (i > 10)
                        if (ESi[i] == ESi[i - 1])
                            Vem += 1;
                        else
                            Kem += 1;
                }
            if (Vem > Vtab && Kem < Ktab)
                AutoCorr(E);
        }

        public void AutoCorr(double[] E)//устранение автокорреляции
        {

        }

        public void GeteroSkedCheck()//проверка на гетероскедостичность 
        {

        }

        public void GeteroSked()//устранение гетероскедостичности
        {

        }
    }
}
