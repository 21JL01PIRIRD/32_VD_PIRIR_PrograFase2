using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_VD_PIRIR_PrograFase2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            double per1 = n * 3;
            double per2 = n / 2.54;

            textBox2.Text = per1.ToString();
            textBox3.Text = per2.ToString();
        }

        private void centimetrosAPulgadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 p = new Form7();
            p.Show();
        }

        private void pulgadasACentimetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 p = new Form8();
            p.Show();
        }

        private void centimetrosAMetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 p = new Form9();
            p.Show();
        }

        private void metrosACentimetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 p = new Form10();
            p.Show();
        }

        private void pulgadasACentimetrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 p = new Form11();
            p.Show();
        }
    }
}
