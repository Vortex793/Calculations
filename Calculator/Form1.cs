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
            lblMinus.Visible = false;
            lblDivide.Visible = false;
            lblMultiply.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMinus.Text = "12 - 12 = " + (12 - 12);
            lblMinus.Visible = true;
            lblPlus.Visible = false;
            lblDivide.Visible = false;
            lblMultiply.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblDivide.Text = "12 / 12 = " + (12 / 12);
            lblDivide.Visible = true;
            lblMinus.Visible = false;
            lblPlus.Visible = false;
            lblMultiply.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMultiply.Text = "12 x 12 = " + (12 * 12);
            lblMultiply.Visible = true;
            lblMinus.Visible = false;
            lblDivide.Visible = false;
            lblPlus.Visible = false;
        }


    }
}
