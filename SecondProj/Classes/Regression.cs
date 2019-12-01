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
        public double[] YMul;
        public double[,] X;
        double[,] _x;//промежуточный икс в которомхранятся значения деленные на что-либо и по которым будут найдены коефы
        double[] _y;
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
        public int Shift;//наблюдение с момента которого призощел сдвиг
        public string Shifts;
        public ChartManager chart;
        public FileReader file;
        public string text;//то, что вернет метод в форму 


        public void Analyt(string[] lines,Label txt, Chart linear,  string red = "")//нужнр создать событие и в его делегат потом забивать последовательность методов которорые должны быть выполнены или мб просто чтобы срабатывали после нажатия некоторые хз наверно первое лучше
        {
            _key = false; // ключ на наличие качественных переменных =1 значит есть 
            file = new FileReader(lines);
            if (string.Compare(red, "") != 0) { file = new FileReader(lines, red); _key = true; }

            

            file.XYMaking();
            
            if (_key) 
                Qualit();
            else
                Linest();

            SLE(X, Y, Variables, Watches);
            YTempMake(X,Y,Variables);
            EvalQual(Y, YMain);

            chart = new ChartManager(linear);
            chart.FormChart();
            chart.ChartBuild(linear, Y, file);

            //if (ShiftKey)txt.Text = $"olololo {Coeff[0]} { Coeff[ 1] } { Coeff[2] } ";
        }


        public void Linest()
        {
            Watches = file.Watches;
            Variables = file.Variables;

            YMain = new double[Watches];
            XMain = new double[Watches, Variables];

            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    XMain[i, j] = file.XMain[i, j];
                YMain[i] = file.YMain[i];
            }

            Y = new double[Watches];
            X = new double[Watches, Variables];

            elast = new double[Variables - 1];
            _y = new double[Watches];
            YMul= new double[Watches];
            _x = new double[Watches, Variables];

            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                {
                    X[i, j] = XMain[i, j];

                    //for (int b = 0; b < colum; b++)
                    // if (string.Compare(XMainFake[i, b], FakeVarsMas[j - Variables + FakeVarsNum]) == 0)
                    //X[i, j] = 1;
                }
                Y[i] = YMain[i];
                X[i, 0] = 1;
            }

            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                {
                    _x[i, j] = X[i, j];
                }
                _y[i] = Y[i];
            }

        }

        public void Qualit()
        {
            colum = file.ind;//количество столбцов с фиктивными показателями
            FakeVarsNum = file.red_args.Count;//общее количество разных фиктивных показателей 
            FakeVarsMas = new string[FakeVarsNum];//массив с значениями фиктивных показателей 
            for (int i = 0; i < FakeVarsNum; i++)
                FakeVarsMas[i] = file.red_args[i];

            Watches = file.Watches;
            Variables = file.Variables+FakeVarsNum;

            XMainFake = new string[Watches, colum];
            for (int i = 0; i < Watches; i++)
                for (int j = 0; j < colum; j++)
                    XMainFake[i, j] = file.XFake[i, j];

            YMain = new double[Watches];
            XMain = new double[Watches, Variables];

            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < file.Variables; j++)
                    XMain[i, j] = file.XMain[i, j];
                YMain[i] = file.YMain[i];
            }

            Y = new double[Watches];
            X = new double[Watches, Variables];

            elast = new double[Variables - 1];
            _y = new double[Watches];
            _x = new double[Watches, Variables];

            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                {
                    if (j<Variables-FakeVarsNum)
                    X[i, j] = XMain[i, j];
                    else 
                    { 
                        for (int b = 0; b < colum; b++)
                        if (string.Compare(XMainFake[i, b], FakeVarsMas[j - file.Variables]) == 0)
                            X[i, j] = 1;
                        else
                            X[i, j] = 0;
                    }
                }
                Y[i] = YMain[i];
                X[i, 0] = 1;
            }

            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                {
                    _x[i, j] = X[i, j];
                }
                _y[i] = Y[i];
            }
        }
        
        private void SLE(double[,] X_, double[] Y_, int Variables_, int Watches_) //первая переменная всегда должна быть равна 1, весь столбец
        {
            double a = 0;
            double c = 0;
            double[,] sl = new double[Variables_, Variables_];
            Coeff = new double[Variables_];
            Average = new double[Variables_];
            //Coeff = new double[Variables];

            for (int i = 0; i < Variables_; i++)
            {
                Coeff[i] = 0;
                for (int j = i; j < Variables_; j++)
                {
                    for (int g = 0; g < Watches_; g++)
                    {
                        a += X_[g, i] * X_[g, j];
                        if (i == j) c += X_[g, i] * Y_[g];
                    }
                    sl[i, j] = sl[j, i] = a / Watches_;
                    if (i == j) Coeff[i] = c / Watches_;
                    a = 0;
                    c = 0;
                }

            }

            Average[0] = Coeff[0];
            for (int i = 1; i < Variables_; i++)
                Average[i] = sl[0, i];

            for (int i = 0; i < Variables_; i++)
            {
                double d = sl[i, i];

                for (int j = 0; j < Variables_; j++)
                {
                    sl[i, j] /= d;
                }
                Coeff[i] /= d;

                for (int j = 0; j < Variables_; j++)
                {
                    if (j != i)
                    {
                        Coeff[j] -= Coeff[i] * sl[j, i];

                        double p = sl[j, i];
                        for (int k = 0; k < Variables_; k++)
                        {
                            sl[j, k] -= sl[i, k] * p;
                        }
                    }
                }
            }
        }
        
        private void EvalQual(double[] y1,double[] y1main)//р квадрат коеф детерминации 
        {
            double nom = 0;
            double denom = 0;
            
            for(int i = 0; i < Watches; i++)
            {
                nom += Math.Pow(y1main[i] - y1[i], 2);
                denom += Math.Pow(y1main[i] - Average[0], 2);
            }

            Det = 1 - nom / denom;

            for (int i = 0; i < Watches; i++)
            {
                Aprox += Math.Abs((y1main[i] - y1[i])/ y1main[i]);
            }
            
            Aprox /= Watches;

            double a = Ftest(Det,Variables,Watches);
            if (a>8) FStat=true;
             else
                FStat = false;
        }

        private void YTempMake( double[,] _x1, double[] _y1, double variables)//засоряет основной Y
        {

            for (int i = 0; i < Watches; i++)
            {
                _y1[i] = 0;
                for (int _j = 0; _j < variables; _j++)
                {
                    _y1[i] += _x1[i, _j] * Coeff[_j];
                }
            }
        }

        public void Elast()
        {

        }

        public double[,] Matrix()//пока не нужно
        {
            double[,] matrix = new double[0,0];
            
            return matrix;
        }

        public void XsquareCheck(Chart linear)
        {
            double[,] XTab; // хи табличное берем из массива создающего при запуске, копируется из корневой папки 
            double R = 1; // детерминант матрицы коеф попарной корреляции 

            double[] Rs = new double[Variables];
            double[,] RMat = new double[Variables, Variables];
            for (int i = 1; i < Variables; i++)
            {
                Rs[i] = 0;
                for (int j = 1; j < Variables; j++)
                {
                    double _a = 0;
                    double _b = 0;
                    double _c = 0;
                    if (i != j)
                    {
                        for (int k = 0; k < Watches; k++)
                        {
                            _a += (X[k, i] - Average[i]) * (X[k, j] - Average[j]);
                            _b += Math.Pow((X[k, i] - Average[i]), 2);
                            _c += Math.Pow((X[k, j] - Average[j]), 2);
                        }
                        Rs[i] += RMat[i,j]=RMat[j,i]=Math.Abs(_a / Math.Pow(_b * _c, 0.5));
                    }
                    else
                        RMat[i, j] = 1;
                }
            }



            for (int i = 0; i < Variables; i++)
            {
                double d = RMat[i, i];

                for (int j = 0; j < Variables; j++)
                {
                    RMat[i, j] /= d;
                }
                for (int j = 0; j < Variables; j++)
                {
                    if (j != i)
                    {
                        double p = RMat[j, i];
                        for (int k = 0; k < Variables; k++)
                        {
                            RMat[j, k] -= RMat[i, k] * p;
                        }
                    }
                }
                R *= d;
            }

            double XX = ((Watches - 1) * (2 * Variables + 3) / 6) * Math.Log(Math.Abs(R));//найден хи квадрат далее сравниваем его с значением из таблицы
            /* if (XX < XTab[5, (Variables - 1) * (Variables - 2) / 2]) return false;
             else */
             MultiColl(linear, Rs);
        }

        public void MultiColl(Chart linear, double[] Rs)//устранение мультиколлинеарности
        {
            

            int l = 0;
            double p1 = Rs[0];
            for (int i=1;i<file.Variables;i++)
            {
                if (p1 < Rs[i])
                { 
                    l = i; 
                    p1 = Rs[i]; 
                }
            }

            double[] p = new double[Watches];
            for (int i = 0; i < Watches; i++)
            {
                p[i] = _x[i, l];
                for (int j = 0; j < Variables; j++)
                {
                    _x[i, j] = _x[i, j] / p[i];
                }
                _y[i] = _y[i]/p[i];
            }
            SLE(_x, _y, Variables, Watches);

            YMul = new double[Watches];

            YTempMake(X, YMul, Variables);
            EvalQual(YMul, YMain);

            TextManager text = new TextManager();
            chart = new ChartManager(linear);
            chart.FormChart();
            chart.ChartBuild(linear, YMul, file);
        }

        public void GeteroSkedCheck(Chart repres)//проверка на гетероскедостичность 
        {
            double[] E = new double[Watches];
            double[] EE = new double[Watches];
            double[] EEeval = new double[Watches];
            double[,] Xtest = new double[Watches, (Variables-1) * 2+1]; 
            
            for (int i = 1; i < Watches; i++)
            {
                E[i] = YMain[i] - Y[i];
                EE[i] = E[i] * E[i];
            }

            for (int i = 0; i < Watches; i++)
                for (int j = 0; j < (Variables - 1) * 2 + 1; j++)
                {
                    if (j<Variables)
                        Xtest[i, j] = X[i, j];
                    else
                        Xtest[i, j] = X[i, (j-1)/2+1]* X[i, (j - 1) / 2 + 1];
                }
            SLE(Xtest, EE, (Variables-1)*2+1, Watches);
            YTempMake(Xtest,EEeval, Variables);
            EvalQual(EEeval, EE);
            if (Ftest(Det,Variables,Watches)>10) GeteroSked(EEeval, repres);

        }

        public void GeteroSked(double[] EEeval,Chart repres)//устранение гетероскедостичности
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                {
                    _x[i, j] = _x[i, j] / EEeval[i];
                }
                _y[i] = _y[i] / EEeval[i];
            }

            SLE(_x, _y, Variables, Watches);

            YMul = new double[Watches];


            YTempMake(X, YMul, Variables);
            EvalQual(YMul, YMain);



            TextManager text = new TextManager();
            chart = new ChartManager(repres);
            chart.FormChart();
            chart.ChartBuild(repres, YMul, file);
        }

        public string AutoCorrCheck(Chart expchart) // проверка на автокорреляцию
        {
            double[] E= new double[Watches];
            double[] ESi = new double[Watches];

            double Vtab=Math.Round(Watches/2+1-1.96*Math.Pow(Watches-1,0.5));
            double Ktab=1.43*Math.Log(Watches-1);
            double Vem=0;
            double Kem=0;

            for (int i = 0; i < Watches; i++)
                E[i] = YMain[i] - YMul[i];

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
            { 
                AutoCorr(E, expchart); 
                return "автокорреляция убрана"; 
            }
            else return "автокорелляции нету";
        }

        public void AutoCorr(double[] E,Chart ExpChart)//устранение автокорреляции
        {
            double[,] EX = new double[Watches - 1,1];
            double[] E1 = new double[Watches - 1];
            for (int i = 1; i < Watches - 1; i++)
            {
                EX[i - 1, 0] = E[i];
                E1[i - 1] = E[i-1];
            }


            SLE(EX, E1, 1 , Watches - 1);

            double co = Coeff[0];
            SLE(_x, _y, Variables, Watches);

            Y[0] = 0;

            for (int _j = 0; _j < Variables; _j++)
            {
                Y[0] += X[0, _j] * Coeff[_j];
            }

            for (int i = 1; i < Watches; i++)
            {
                Y[i] = co*(YMain[i-1]-Y[i-1]);
                for (int _j = 0; _j < Variables; _j++)
                {
                    Y[i] += X[i, _j] * Coeff[_j];
                }
            }

            EvalQual(Y, YMain);

            TextManager text = new TextManager();
            chart = new ChartManager(ExpChart);
            chart.FormChart();
            chart.ChartBuild(ExpChart, Y, file);
        }

        

        public void Exp()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    X[i, j] = XMain[i, j];
                Y[i] = Math.Log(YMain[i]);
            }

            SLE(X, Y, Variables, Watches);
            Coeff[0] = Math.Exp(Coeff[0]);
            for (int i = 0; i < Watches; i++)
            {
                Y[i] = Coeff[0] * Math.Exp(X[i, 1] * Coeff[1]);
            }

            EvalQual(Y,YMain);
        }

        public void Power()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    X[i, j] = XMain[i, j];
                Y[i] = Math.Log(YMain[i]);
            }

            SLE(X, Y, Variables, Watches);
            Coeff[0] = Math.Exp(Coeff[0]);
            Coeff[1] = Math.Exp(Coeff[1]);
            for (int i = 0; i < Watches; i++)
            {
                Y[i] = Coeff[0] * Math.Pow(Coeff[1], X[i, 1]);
            }

            EvalQual(Y, YMain);
        }

        public void Repres()
        {
            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < Variables; j++)
                    X[i, j] = j == 0 ? (1) : (Math.Log(XMain[i, j]));
                Y[i] = Math.Log(YMain[i]);
            }

            SLE(X, Y, Variables, Watches);
            Coeff[0] = Math.Exp(Coeff[0]);

            for (int i = 0; i < Watches; i++)
            {
                Y[i] = Coeff[0] * Math.Pow(XMain[i, 1], Coeff[1]);
            }

            EvalQual(Y, YMain);
        }

        public double Ftest(double det, double variables, double watches)
        {
            return (det / (variables - 1-1)) / ((1 - det) / (watches - variables-1));
        }

        public void ShiftFunk(Chart linear, Label txt, string Shifts = "")
        {
            if (string.Compare(Shifts, "") != 0 && ShiftKey)
            {
                string[] Shiftsa = Shifts.Split(' ', '	');
                this.Shift = Convert.ToInt32(Shiftsa[0]);
            }

            int variables = Variables * 2;
            double[,] x1 = new double[Watches, variables];
            double[,] X1 = new double[Watches, variables];

            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < variables; j++)
                {
                    if (i < Shift)
                        if (j < Variables)
                            x1[i, j] = _x[i, j];
                        else
                            x1[i, j] = 0;
                    else
                        if (j >= Variables)
                            x1[i, j] = _x[i, j - Variables];
                        else 
                            x1[i, j]=0;
                }
                x1[i, 0] = _x[i, 0];
                if (i >= Shift) x1[i, Variables] = _x[i, 0];
                else x1[i, Variables] = 0;
            }

            for (int i = 0; i < Watches; i++)
            {
                for (int j = 0; j < variables; j++)
                {
                    if (i < Shift)
                        if (j < Variables)
                            X1[i, j] = X[i, j];
                        else
                            X1[i, j] = 0;
                    else
                        if (j > Variables)
                        X1[i, j] = X[i, j - Variables];
                    else
                        X1[i, j] = 0;
                }
                X1[i, 0] = X[i,0];
                if (i >= Shift) X1[i, Variables] = X[i,0];
                else X1[i, Variables] = 0;
            }

            /*txt.Text = $"{x1[0, 0]} {x1[0, 1]} {x1[0, 2]} {x1[0, 3]} {x1[0, 4]} {x1[0, 5]}\n" +
                $"{x1[1, 0]} {x1[1, 1]} {x1[1, 2]} {x1[1, 3]} {x1[1, 4]} {x1[1, 5]}\n" +
                $"{x1[10, 0]} {x1[10, 1]} {x1[10, 2]} {x1[10, 3]} {x1[10, 4]} {x1[10, 5]}\n"+
                $"{Shift}";*/

            SLE(x1, _y, variables, Watches);
            YTempMake(X1, Y,variables);


            EvalQual(Y, YMain);

            TextManager text = new TextManager();
            chart = new ChartManager(linear);
            chart.FormChart();
            chart.ChartBuild(linear, Y, file);
        }
    }
}
