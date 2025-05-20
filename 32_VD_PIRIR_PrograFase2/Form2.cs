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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void centimetrosAPulgadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            double per1 = n * 4;
            double per2 = n / 2.54;

            textBox2.Text = per1.ToString();
            textBox3.Text = per2.ToString();
        }

        private void perimetroDeCuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pulgadasACentimetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 p = new Form3();
            p.Show();
        }

        private void centimetrosAMetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 p = new Form4();
            p.Show();
        }

        private void metrosACentimetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 p = new Form5();
            p.Show();
        }

        private void pulgadasACentimetrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 p = new Form6();
            p.Show();
        }
    }
}
