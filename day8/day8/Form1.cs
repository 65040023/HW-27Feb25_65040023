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
            string input = textBox1.Text;
            if (input.Length < 3)  
            {
                MessageBox.Show("โปรดกรอกข้อมูลที่ถูกต้อง (เช่น 3+5)");
                return;
            }

            string input1 = input[1].ToString();
            double a, b, c;

            a = Convert.ToDouble(input[0].ToString());
            b = Convert.ToDouble(input[2].ToString());

            if (input1 == "+")
            {
                c = a + b;
                label3.Text = c.ToString();
                textBox2.Text = c.ToString();
            }
            else if (input1 == "-")
            {
                c = a - b;
                label3.Text = c.ToString();
                textBox2.Text = c.ToString();
            }
            else if (input1 == "x")  
            {
                c = a * b;
                label3.Text = c.ToString();
                textBox2.Text = c.ToString();
            }
            else if (input1 == "/")
            {
                if (b != 0) 
                {
                    c = a / b;
                    label3.Text = c.ToString();
                    textBox2.Text = c.ToString();
                }
                else
                {
                    MessageBox.Show("ไม่สามารถหารด้วยศูนย์ได้");
                }
            }
            else
            {
                MessageBox.Show("โปรดใช้เครื่องหมาย +, -, *, หรือ /");
            }
        }

            
    }
}
