using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();
            string[] parts = input.Split('x');
            double a, b, c;
            a = Convert.ToDouble(parts[0]);
            b = Convert.ToDouble(parts[1]);
            c = a* b;
            label3.Text = c.ToString();
            textBox1.Text = c.ToString();
            textBox2.Text = c.ToString();
        }

            
    }
}
