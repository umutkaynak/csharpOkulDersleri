using System.Net.Sockets;
using System.Reflection.Emit;

namespace _24.ekm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int enb = Convert.ToInt32(listBox1.Items[0]), say;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                say = Convert.ToInt32(listBox1.Items[i]);
                if (say > enb)
                {
                    enb = say;
                }
            }
            label1.Text = enb.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int enk = Convert.ToInt32(listBox1.Items[0]), say;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                say = Convert.ToInt32(listBox1.Items[i]);
                if (enk > say)
                {
                    enk = say;
                }
            }
            label1.Text = enk.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rsay;
            Random rnd = new Random();
            rsay = rnd.Next(10);
            for (int i = 0; i < rsay; i++)
            {
                listBox1.Items.Add(textBox2.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (true & (5 > 1))
            {
                MessageBox.Show("tamam");
            }
            else
            {
                MessageBox.Show("olmadý");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(textBox3.Text);
            switch (not)
            {
                case 8:
                case 10:
                    MessageBox.Show("FF");
                    break;
                case 50:
                    MessageBox.Show("DD");
                    break;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(textBox3.Text);
            if (not>50)
            {
                MessageBox.Show("geçtin");
            }
            else
            {
                MessageBox.Show("kaldýn");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
    }
}