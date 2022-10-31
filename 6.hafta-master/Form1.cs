using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(textBox1.Text);   
            if (x%3==0 && x % 4 == 0)
            {
                    MessageBox.Show("3ün ve 4ün katı");   
            }
            else
            {
                MessageBox.Show("3ün ve 4ün katı değil");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox2.Text);
            if (a<0)
            {
                MessageBox.Show("negatif");
            }
            if (a==0)
            {
                MessageBox.Show("nötr");
            }
            else
            {
                MessageBox.Show("pozitif");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox3.Text);
            if (s % 4 == 0 )
            {
                this.BackColor = Color.DeepPink;   
            }
             if(s % 5 == 0 )
            {
                this.BackColor = Color.Blue;
            }
             if ((s % 5 == 0) &(s % 4 == 0))
            {
                this.BackColor = Color.GreenYellow;
            }
            else
            {
                MessageBox.Show("harici değer girdiniz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int q=Convert.ToInt32(textBox4.Text);
            int top = 0;
            for (int i = 1; i < q; i++)
            {
                if (q % i == 0)
                {
                    top = top + i;
                }
            }
                if (top==q)
                {

                    MessageBox.Show("mükkemmel sayi");
                listBox1.Items.Add(q);
                }
                else
                {
                    MessageBox.Show("mükemmel sayı değil");
                }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int a=1; int b = 1; int c;
            int x = Convert.ToInt32(textBox5.Text);
            listBox2.Items.Add(a);
            listBox2.Items.Add(b);
            for (int i = 3; i < x; i++)
                
            {
                c = a + b;
                a = b;
                b = c;
                listBox2.Items.Add(c);
            }
            listBox2.Items.Add("");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="skoda")
            {
                comboBox2.Items.Add("fabia");
                comboBox2.Items.Add("kod");
            }
            if (comboBox1.Text == "renault")
            {
                comboBox2.Items.Add("megan");
                comboBox2.Items.Add("clio");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
