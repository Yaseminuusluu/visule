using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayının karesini bulma

            /* int sayi, kare;

             Console.Write("Sayı giriniz :");
             sayi = Convert.ToInt32(Console.ReadLine());
             kare = sayi * sayi;

             Console.Write("Sayının karesi :" + kare );
            *********************************************
            *
            // 
            *********************************************
              // çemberin alanı ve çevresi
            double yaricap, alan, cevre;
            const double pi = 3.14;
            Console.Write("Yarıçapı giriniz :");
            yaricap = Convert.ToDouble(Console.ReadLine());
            alan = pi * yaricap * yaricap;
            cevre = pi * 2 * yaricap;
            Console.Write("Alan :" + alan + "Çevre" + cevre);
            ************************************************
           int yas;
            Console.Write("Yaş giriniz :");
            yas = Convert.ToInt32(Console.ReadLine());
            if (yas < 18) Console.Write("Yaşınız küçüktür.");
            else Console.Write("Yaşınız büyüktür.");
            ***************************************************
            // girilen sayıdan hangisi büyüktür.
            int sayi1, sayi2;

            Console.Write("Sayi1 giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayi2 giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2) Console.Write("Sayi1 büyüktür.");
            else Console.Write("Sayi2 büyüktür.");
           else if (sayi1 == sayi2) Console.Write("Sayılar eşittir.");
            *****************************************************
           // Vize final ortalma (60 geçiş notu)
            int vize, final, ort;
            vize:
            Console.Write("Vize notunu giriniz :");
            vize = Convert.ToInt32(Console.ReadLine());
            if (vize < 0 || vize > 100) goto vize;
            // goto metotu yanlış yazılan degeri geri döndürür.
            final:
            Console.Write("Final notunu giriniz :");
            final = Convert.ToInt32(Console.ReadLine());
            if (final < 0 || final > 100) goto final;
            ort = (vize + final) / 2;
            if (ort < 60) Console.Write("Kaldınız.");
            else Console.Write("Geçtiniz");
            ****************************************
            // haftanın günlerini swic case yapısıyla yazdırın

            byte gunNo;
            gunNo:
            Console.Write("Gün no giriniz.");
           gunNo= Convert.ToByte(Console.ReadLine());
            if (gunNo < 0 || gunNo > 7) goto gunNo;
            switch (gunNo)
            {
                case 1: Console.Write("Pazartesi");
                    break;
                case 2: Console.Write("Salı");
                    break;
                case 3: Console.Write("Çarşamba");
                    break;
                case 4: Console.Write("Perşembe");
                    break;
                case 5:Console.Write("Cuma");
                    break;
                case 6: Console.Write("Cumartesi");
                    break;
                case 7: Console.Write("Pazar");
                    break;


            }
            ****************************************
            //faktöriyel hesaplama (for ve while döngüsü ile)
            int sayi,faktoriyel = 1;

            Console.Write("Faktöriyel alınıcak sayı giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=sayi; i ++) 
            {
                faktoriyel = faktoriyel * i;
            }
            Console.Write("For döngüsü ile " + sayi + "!=" + faktoriyel);
           
            
            int a = 1, f = 1;

            Console.Write("Sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (a <= sayi)
            {
                f = f * a;
                a++;
            }
            Console.Write("While döngüsü ile " + sayi + "!=" + f);
            *******************************************************
        // girilen  iki sayı arasında ki sayıları ekrana yazdır.
            int sayi1, sayi2;
            Console.Write("Sayı 1'i giriniz :");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2'i giriniz :");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            for(; sayi1<= sayi2; sayi1++)
            {
                Console.WriteLine(sayi1);
            }
            **************************************************

            */
            // girilen  iki sayı arasında ki değerlerin toplamı.
            //int sayi1, sayi2, toplam = 0;
            //Console.Write("Sayi 1'i giriniz : ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayi 2'i giriniz : ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //for (; sayi1 <= sayi2; sayi1++)
            //{
            //    toplam += sayi1;
            
            //}
            //  Console.Write( "Toplam =" +toplam );


            int sayi1, sayi2, sayi3, ortalama;
            Console.Write(" ilk sayıyı giriniz:" );
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz:");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            ortalama = (sayi1 + sayi2 + sayi3) / 3;
            Console.Write("Ortalama :" + ortalama);


            Console.ReadLine();
          
            

            
            

            




        }
    }
}
