using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*jpg)|*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string fname;
            file1.ShowDialog();
            fname = file1.FileName;
            pct.Image = Image.FromFile(fname);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog file1 = new SaveFileDialog();
            file1.Filter = "(*jpg)|*.jpg";
            if (file1.ShowDialog()== DialogResult.OK)
            {
                pct.Image.Save(file1.FileName);
            }

        }
    }
}
