using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPlus.Text = "12 + 12 = " + (12 + 12);
            lblPlus.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMinus.Text = "12 - 12 = " + (12 - 12);
            lblMinus.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblDivide.Text = "12 / 12 = " + (12 / 12);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMultiply.Text = "12 x 12 = " + (12 * 12);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
