using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5hafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iki sayının çarpımını veren metot
            //int sayi1, sayi2;
            //Console.Write("Sayi 1'i giriniz :");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayi 2'i giriniz :");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //carpma(sayi1,sayi2);
            // ****************************************************
            // Kunlanıcıdan alınan 2 değriden büyük olanını yazdırma
            //int a, b;
            //Console.Write("Sayı 1 giriniz.");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayı 2'i giriniz.");
            //b = Convert.ToInt32(Console.ReadLine());
            //int sonuc = buyukSayi(a,b);
            //Console.Write(sonuc);
            //***************************************************
            //Bir sayının (x) y.kuvvetini alna metodu yazın (math.pox)
            //Console.Write("Sayıyı giriniz :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Kuvvet giriniz");
            //int b = Convert.ToInt32(Console.ReadLine());
            //kuvvetAlma(a,b);
            //**************************************************************
            // konsoldo girilen bir metni konsolda alt alta 10 kere yazdırma.
            //Console.Write("Metin giriniz :");
            //string a = Convert.ToString(Console.ReadLine());
            //metinYazdır(a);
            //****************************************************************
            //Taban uzunluğu ve yüksekliğini kulanıcıdan aldığın üçgenin alanını hesapla.
            //Console.Write("Taban uzunluğunu giriniz :");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Yüksekliği giriniz : ");
            //double y = Convert.ToDouble(Console.ReadLine());
            //ucgenAlanı(x,y);
            //***********************************************
            // Girilen bir kelimenin uzunluğunu bulan  metotu yazın.
            //Console.Write("Metin giriniz :");
            //string a = Convert.ToString(Console.ReadLine());
            //metinUzunluğu(a);
            //*******************************************
            //kullanıncı ıd numarasını  girdiği zaman  o id numarasına kayıtlı  kişinin adının yazdır.
            /* static int kullaninciidileAdiGöster(int id)
             {
                 int sonuc = id;


                 switch (id)
                 {
                     case 1: Console.Write("Ahmet"); break;
                     case 2: Console.Write("Mehmet"); break;
                     case 3: Console.Write("Ali"); break;
                     case 4: Console.Write("Veli"); break;

                 }
                 return sonuc; */

            //Console.Write("Id giriniz :");
            //int a = Convert.ToInt32(Console.ReadLine());

            //string sonuc =kullaninciidileAdiGöster(a);
            //Console.Write(sonuc);
            //**************************************************
            //kullanıcıdan bir mail isteyin, mail adresindw @ işareti varsa  true, yoksa false deger döndür. 
            Console.Write("Email giriniz :");
            string mailadresi = Convert.ToString(Console.ReadLine());
            var sonuc =mailKontrol(mailadresi);
            Console.Write(sonuc);
            bekle();


        }
        static bool mailKontrol(string email)
        {
            bool ilkdeger = default(bool);

            if (email.Contains("@") ){
                ilkdeger = true;

            }
            else
            {
                ilkdeger = false;
            }
            return ilkdeger;    
        }
        static string  kullaninciidileAdiGöster(int id)
        {
            string c_ad = string.Empty;
            
            switch (id) { 
                case 1:c_ad = "Ahmet"; break; 
                case 2: c_ad = "Mehmet"; break;
                case 3: c_ad = "Ali"; break;
                case 4: c_ad = "Veli";break;
                default :Console.Write("Unknown"); break;
                    
            }
            return c_ad;
            
            
        }
         static int metinUzunluğu(string metin)
        {
            int sonuc = metin.Length;
            Console.Write("Uzunluk :" + metin);
            return sonuc;

        }
        
        static double ucgenAlanı(double a , double h)
            // a = taban  h = yükseklik 
        {
            double sonuc = 0;
            double alan = (a * h) / 2;
             sonuc = alan;
            Console.WriteLine("Üçgen alanı = " + sonuc);
            return sonuc;
            

        }
        static void metinYazdır(string metin)
        {
            for (int i = 0; i<10; i++ )
            {
                Console.WriteLine(metin);
               

            }
        }
         static double kuvvetAlma(int x, int y) {
            // x = sayı y = kuvvet değeri
            double kuvvetAl = Math.Pow(x, y);
            
            Console.Write("Kuvvet: " + kuvvetAl);
            return kuvvetAl;
            
            
           
        }

        static int buyukSayi(int sayi1,int sayi2)
        {

            //if (sayi1 > sayi2) Console.Write("Sayi 1 büyüktür.");
            //else if (sayi1 == sayi2) Console.Write("Sayılar eşittir.");
            //else Console.Write("Sayi 2 büyüktür");

            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else if (sayi1 == sayi2)
            {
                return sayi1;
            }
            else
                return sayi2;
            
        }
        static void bekle()
        {
            Console.ReadLine();
        }
        
        static void carpma(int a, int  b)
            // a = 1.sayi b = 2.sayi
        {
            int carpım = 1;
            carpım = a * b;
            Console.Write("Çarpım = "+ carpım);
        }
    }
}
