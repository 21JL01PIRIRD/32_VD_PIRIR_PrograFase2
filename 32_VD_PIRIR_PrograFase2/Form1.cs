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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 p = new Form7();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form17 p = new Form17();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 p = new Form12();
            p.Show();
        }
    }
}
