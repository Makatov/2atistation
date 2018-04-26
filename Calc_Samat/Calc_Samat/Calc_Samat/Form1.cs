using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Samat
{
    public partial class Form1 : Form
    {
        double first, second, result;
        char operation;
        bool zero = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       
        private void button35_Click(object sender, EventArgs e)
        {
            second = double.Parse(textBox1.Text);
            if (operation == '+')
            {
                result = first + second;
            }
            if (operation == '-')
            {
                result = first - second;
            }
            if (operation == '/')
            {
                if (second != 0)
                {
                    result = first / second;
                    zero = false;
                }
                else zero = true;
            }
            if (operation == 'х')
            {
                result = first * second;
            }
            if (zero == false) textBox1.Text = result.ToString();
            else textBox1.Text = "Деление на ноль невозможно";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            first = 0;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text == "")
                    textBox1.Text = "0";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = "-" + textBox1.Text; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int factor = 1;
            first = double.Parse(textBox1.Text);
            for (int i = 1; i <= first; i++)
            {
                factor = factor * i; 
            }
            textBox1.Text = factor.ToString();
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            first = double.Parse(textBox1.Text);
            textBox1.Text = Math.PI.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            first = double.Parse(textBox1.Text);
            operation = (sender as Button).Text[0];
            textBox1.Text = "0";
        }


        private void button33_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

    }
}
