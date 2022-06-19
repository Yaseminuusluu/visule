using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2h
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sifre;
            int hak;

            sifre = Convert.ToInt32(textBox1.Text);



            if (sifre == 1234)
            {
                textBox1.Text="Giriş Doğrudur.";
            }
            else if (sifre != 1234)
            {


                for(hak = 0; hak<3; hak++)

                {
                    if (hak == 0)
                    {
                        textBox1.Text="Şifre hatalı 2 hakkınız kaldı. ";
                        
                    }
                    else if (hak == 1)
                    {
                        textBox1.Text="Şifre hatalı 1 hakkınız kaldı. ";
                        
                    }
                    else if (hak == 2)
                    {
                        textBox1.Text= "Şifre hatalı  şifreniz bloke oldu";
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz bloke oluştur giremezsiniz.");
                    }

                }
            }
            
            
               

                
            
        
            
           
            

           
           


                
            

        }
    }
}
