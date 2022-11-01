using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboboxEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = (comboBox1.Text) & (comboBox2.Text);
            //label1.Text = comboBox1.Text +" " +comboBox2.Text;
            label1.Text = comboBox1.Text + " -" + comboBox2.Text + " -" + a.ToString() + "" + b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "renault")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("megan");
                comboBox2.Items.Add("kadjar");
                comboBox2.Items.Add("clio");
            }
            else if (comboBox1.Text == "skoda")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("fabia");
                comboBox2.Items.Add("superb");
                
            }
           
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        string a = "";
        string b = "";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //string a = "";
            if (checkBox1.Checked==true)
            {
                a = a + " otomatik vites";
            }
            //else if (checkBox1.Checked==false)
            //{
             //  a = a ;
            //}
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                a = a + " koltuk ısıtma  - " ;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                a = a + " park sensörü  - ";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                a = a + " sessizlik  - ";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                b = b + radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                b = b + radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                b = b + radioButton3.Text;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
            a = "";
            label1.Text = a;
        }
    }
}
