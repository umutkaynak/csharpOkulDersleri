using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sesliharf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(textBox1.Text);

            switch (x[0].ToString().ToLower())
            {
                case "e":label1.Text="sesli harf ile başladı"; break;
                case "a": label1.Text = "sesli harf ile başladı"; break; 
                case "ı": label1.Text = "sesli harf ile başladı"; break;
                case "i": label1.Text = "sesli harf ile başladı"; break;
                case "u": label1.Text = "sesli harf ile başladı"; break;
                case "ü": label1.Text = "sesli harf ile başladı"; break;
                case "o": label1.Text = "sesli harf ile başladı"; break;
                case "ö": label1.Text = "sesli harf ile başladı"; break;
                default:label1.Text= "sessiz harf girdiniz "; break;
            }
        }
    }
}
