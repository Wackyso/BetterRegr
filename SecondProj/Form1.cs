using System;
using System.Windows.Forms;


namespace SecondProj
{
    public partial class Form1 : Form
    {
        private const string FileFilter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        public Form1()
        {
            InitializeComponent();
            
            openFileDialog.Filter = FileFilter;
        }

        private void ButTextInp_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            
            if (dialogResult == DialogResult.Cancel)
                return;

            string filename = openFileDialog.FileName;
            var lines = System.IO.File.ReadAllLines(filename);
            var fileReader = new FileReader(lines);
            fileReader.XYMaking();
        }

        private void OneVarFourCharts_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void MultiColl_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }   
    }
}