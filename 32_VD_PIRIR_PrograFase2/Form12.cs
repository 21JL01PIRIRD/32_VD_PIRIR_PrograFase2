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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void centimetrosAPulgadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 p = new Form12();
            p.Show();
        }

        private void pulgadasACentimetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 p = new Form13();
            p.Show();
        }

        private void centimetrosAMetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 p = new Form14();
            p.Show();
        }

        private void metrosACentimetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 p = new Form15();
            p.Show();
        }

        private void pulgadasACentimetrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form16 p = new Form16();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            double per1 = n * 8;
            double per2 = n / 2.54;

            textBox2.Text = per1.ToString();
            textBox3.Text = per2.ToString();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
