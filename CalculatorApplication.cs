using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Sayı 1";
            label2.Text = "sayı 2";
            label3.Text = "Sonuc=";
            button1.Text = "sin";
            button2.Text = "cos";
            button3.Text = "tan";
            button4.Text = "x^y";
            button5.Text = "x^3";
            button6.Text = "x^2;";
            button7.Text = "ln";
            button8.Text = "log";
            button9.Text = "1/x";
            button10.Text = "+";
            button11.Text = "-";
            button12.Text = "*";
            button13.Text = "/";
            button14.Text = "Temizle";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            double sin = Math.Sin(sayi1);
            textBox3.Text = sin.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            double cos = Math.Cos(sayi1);
            textBox3.Text = cos.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            double tan = Math.Sin(sayi1)/Math.Cos(sayi1);
            textBox3.Text = tan.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            double xy = Math.Pow(sayi1, sayi2);
            textBox3.Text = xy.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double x3 = Math.Pow(sayi1, 3);
            textBox3.Text = x3.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double ln = Math.Pow(sayi1,2);
            textBox3.Text = ln.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double ln = Math.Exp(sayi1);
            textBox3.Text = ln.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double log = Math.Log(sayi1);
            textBox3.Text = log.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double bir = 1 / sayi1;
            textBox3.Text = bir.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double toplam = sayi1 + sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double fark = sayi1 - sayi2;
            textBox3.Text = fark.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double carpim = sayi1 * sayi2;
            textBox3.Text = carpim.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            Double bolum = sayi1 / sayi2;
            textBox3.Text = bolum.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
