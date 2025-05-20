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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            double per1 = n * 4;
            double per2 = n / 100;

            textBox2.Text = per1.ToString();
            textBox3.Text = per2.ToString();
        }
    }
}
