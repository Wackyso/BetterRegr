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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            AllVar.Lines = System.IO.File.ReadAllLines(filename);


        }
    }

    public class AllVar
    {
        public static string[] Lines;
        public static int Watches;
        public static int Variables;
        public static double[] YMain;
        public AllVar()
        {
            Watches = 0;
            Variables = 0;
            string[] _line = Lines[0].Split(' ', '	');

            Variables = _line.Length;
            Watches = Lines.Length;

            double[] YMain = new double[Watches];
            double[,] XMain = new double[Watches, Variables];

            for (int _i = 0; _i < Watches; _i++)
            {
                _line = Lines[_i].Split(' ', '	');
                for(int _j = 0; _j < Variables; _j++)
                {
                    if (_j == 0)
                        YMain[_i] = Convert.ToDouble(_line[_j]);
                    else
                        XMain[_i, _j] = Convert.ToDouble(_line[_j]);
                }
            }
        }
    }

    public class Regression : AllVar
    {

    }

    public class CharManager : AllVar
    {

    }

    public class TextManager : AllVar
    {

    }
    
}