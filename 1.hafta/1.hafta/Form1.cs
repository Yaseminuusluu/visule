using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //2.pi.r
            double pi = 3.14;
            double yariçap = Convert.ToDouble (textBox1.Text);

            double cevre = 2 * pi * yariçap;
            label2.Text = cevre.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // pi.r kare

            double pi = 3.14;
            double yaricap = Convert.ToDouble(textBox1.Text);
            //double alan = pi*yaricap*yaricap;
            double alan = pi * Math.Pow(yaricap, 2);
            label3.Text = alan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double fiyati = Convert.ToDouble(textBox2.Text);
            int adet = Convert.ToInt32(textBox3.Text);
            double kdvmiktarı =0.18;
            double sonuc = adet*(fiyati + (fiyati * kdvmiktarı));
            label6.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox4.Text);
            if (sayi <= 100 && sayi >= 85)
            {
                label8.Text = "Not: 5";
            } else if (sayi < 85 && sayi >= 70)
            {
                label8.Text = "Not: 4";
            } else if (sayi < 70 && sayi >= 50)
            {
                label8.Text = "Not: 3";
            } else if (sayi < 50 && sayi >= 35)
            {
                label8.Text = "Not: 2";
            } else if (sayi < 35 && sayi >= 20)
            {
                label8.Text = "Not: 1";
            }else if (sayi < 20 && sayi >= 0)
            {
                label8.Text = "Not: 0";
            }else
            {
                MessageBox.Show("100 ile o arası bir sayı giriniz");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox5.Text);
            if(sayi % 2 == 0)
            {
                MessageBox.Show("Sayı çiftir.");
            }
            else
            {
                MessageBox.Show("Sayı Tektir");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox6.Text);
            int sayi2 = Convert.ToInt32(textBox8.Text);
            int sayi3 = Convert.ToInt32(textBox7.Text);

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                MessageBox.Show("Sayı 1 büyüktür.");
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                MessageBox.Show("Sayı 2 büyüktür.");
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                MessageBox.Show("Sayı 3 büyüktür.");
            }
            else
            {
                MessageBox.Show("Sayıla eşittir.");
            }
           
        }
    }
}
