using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sinifekle yeni = new Sinifekle();
            //yeni.adi = "Yasemin;";
            //yeni.soyadi = "Uslu";
            //yeni.yas = 19;

            //Tasit arac1 = new Tasit();
            //arac1.yakit = "Benzin";
            //arac1.marka = "BMW";
            //arac1.hiz = 100;
            //arac1.renk = "Beyaz";
            //arac1.Bilgiyaz();


            //    Ogrencii ogr1 = new Ogrencii();
            //    Console.WriteLine("Ad soyad giriniz:");
            //    ogr1.adSoyad = Convert.ToString(Console.ReadLine());

            //    Console.WriteLine("Sınıf adı giriniz :");
            //    ogr1.sinif_adi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Ders adı giriniz :");
            //    ogr1.ders_adi = Convert.ToString(Console.ReadLine());

            //    Console.WriteLine("Tc no giriniz :");
            //    ogr1.tcno = Convert.ToString(Console.ReadLine());

            //    Console.WriteLine("Ders notu giriniz :");
            //    ogr1.dersnotu = Convert.ToInt32(Console.ReadLine());

            //    ogr1.not_kontrol(ogr1.dersnotu);

            //    ogr1.bilgiYaz();

            //    Console.ReadLine();

            //Daire d = new Daire();

            //Console.WriteLine("Alan :" + d.alan(d.r));
            //Console.Read();

            // Personel1 pr1 = new Personel1();

            Hesap h = new Hesap();
            h.Ekle(5);
            Console.WriteLine("toplam = " + h.goster());
            Console.ReadLine();
        }

    }
}
