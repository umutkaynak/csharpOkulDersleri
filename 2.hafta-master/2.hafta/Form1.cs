using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            double top = a + b;

           listBox1.Items.Add(top);
            this.Text = Convert.ToString(top);
            MessageBox.Show("sonuc eklendi: " + top);

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (textBox3.Text==label3.Text)
            {
                timer2.Enabled = false;
                textBox3 = null;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int x = 0;
        private void button2_Click(object sender, EventArgs e)
        {
        
            x++;
            label4.Text=x.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            x--;
            label4.Text = x.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int say= Convert.ToInt32(textBox4.Text);
            bool bayrak=false;
            for (int i = 2; i < say; i++)
            {
                if (say % i==0)
                {
                    bayrak=true;
                }
                if (bayrak==true)
                {
                    label7.Text = "asal değildir";
                }
                else
                {
                    label7.Text = "asaldır";
                }
              
            }

            textBox4.Text = say.ToString(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] y = new string[5];
            y[0] = "ömer ";
            y[1] = "2.yazı ";
            y[2] = "göstermelik ";
            y[3] = "kağıt ";
            y[4] = "zömer ";

            int say = Convert.ToInt32(textBox5.Text);
            label8.Text = y[say].ToString();





        }

        private void button6_Click(object sender, EventArgs e)
        {
            int say = Convert.ToInt32(textBox5.Text);
            string[] gun = {" ","pazartesi","salı","çarşamba","perşembe","cuma","cumartesi","pazar"};
            label9.Text = gun[say].ToString();
            Array.Sort(gun);
            Array.Reverse(gun);
            MessageBox.Show(gun[1]);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] liste =new int[10];

            for (int i = 0; i < 10; i++)
            {
                liste[i] = r.Next(100); 
            }

            listBox2.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add (liste[i]);
            }
            Array.Sort(liste);  
            for (int x = 0; x < 10; x++)
            {
                for (int y = x+1; y < 10; y++)
                {
                    if (liste[x] > liste[y])
                    {
                        int bos = liste[x];
                        liste[x] = liste[y];
                        liste[y] = bos;
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    listBox3.Items.Add(liste[i]);
                }
            }

        }
    }
}
