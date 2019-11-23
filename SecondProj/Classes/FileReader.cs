using System;
using System.Collections.Generic;

namespace SecondProj
{
    public class FileReader
    {
        private string[] _lines;
        public double[] YMain;
        public double[,] XMain;
        public string[,] XFake;
        public int Watches = 0;
        public int Variables = 0;
        public int[] red= new int [0];
        public List<string> red_args= new List<string> ();
        public int ind;

        public FileReader(string[] lines)
        {
            _lines = lines;
        }

        public FileReader(string[] lines, string red_)
        {
            _lines = lines;
            string[] red1 = red_.Split(' ', '	');
            
            red = new int[red1.Length];
            for (int j = 0; j < red1.Length; j++)
            red[j] = Convert.ToInt32(red1[j]);
        }

        public void XYMaking()
        {
            string[] lines = _lines[0].Split(' ', '	');
            Variables = lines.Length;
            Watches = _lines.Length;

            YMain = new double[Watches];
            XMain = new double[Watches, Variables - red.Length];
            XFake = new string[Watches, red.Length];

            if (red.Length == 0)
            {
                for (int i = 0; i < Watches; i++)
                {
                    lines = _lines[i].Split(' ', '	');
                    for (int j = 0; j < Variables; j++)
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
            else
            {
                int d = red[0];
                red_args.Add(lines[d]);
                ind = 0;
                for (int i = 0; i < Watches; i++)
                {
                    lines = _lines[i].Split(' ', '	');
                    ind = 0;
                    for (int j = 0; j < Variables; j++)
                    {
                        
                        if (j == 0)
                        {
                            YMain[i] = Convert.ToDouble(lines[j]);
                            XMain[i, j] = 1f;
                        }
                        else
                            if (!Comp(j, red))//мне самому не нравится проверять 138238907 раз на каждой строке, но тогда возникает проблема прохода массива не по русски, а по японски, что грузит,вероятно, сильнее, ведь вычеркивать будем столбцы
                                XMain[i, j-ind] = Convert.ToDouble(lines[j]);
                            else
                            {
                                XFake[i, ind] = lines[j];
                                int u = 0;
                                for (int o = 0; o < red_args.Count; o++)
                                    if (string.Compare(lines[j], red_args[o]) == 0) 
                                        u = 1;
                                if (u == 0) red_args.Add(lines[j]);
                                ind++;
                            }

                    }
                }
                Variables -= ind;
            }
        }

        /*private Boolean Comp<T>(T y, T[] mas)
        {
            String.Compare
            for (int i = 0; i < red.Length; i++)
            {
                if (y == mas[i]) return true;
            }
            return false;
        }*/

        private Boolean Comp(int y, int[] mas)
        {
            for (int i = 0; i < red.Length; i++)
            {
                if (y == mas[i]) return true;
            }
            return false;
        }

        private Boolean Comp(string y, string[] mas)
        {
            for (int i = 0; i < red.Length; i++)
            {
                if (string.Compare(y,mas[i])==0) return true;
            }
            return false;
        }

    }
}