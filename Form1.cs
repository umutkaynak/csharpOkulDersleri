using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            comboBox1.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);
            double top = a + b;
            double çıkart = a - b;
            double böl = a / b;
            double carp = a * b;

            if (comboBox1.Text=="toplama")
            {
                label2.Text=Convert.ToString(top);
            }

            if (comboBox1.Text == "çıkartma")
            {
                label2.Text = Convert.ToString(çıkart);
            }

            if (comboBox1.Text == "çarpma")
            {
                label2.Text = Convert.ToString(carp);
            }

            if (comboBox1.Text == "bölme")
            {
                label2.Text = Convert.ToString(böl);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
