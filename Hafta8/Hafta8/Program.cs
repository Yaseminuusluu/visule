using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.AdSoyad = "Ahmet";
            ogr1.numara = 134;
            ogr1.sinif = 1;
            ogr1.Bilgi();

            Console.WriteLine(new String('-', 30));

            Ogrenci ogr2 = new Ogrenci();
            ogr2.AdSoyad = "Mehmet";
            ogr2.numara = 134;
            ogr2.sinif = 2;
            ogr2.Bilgi();

        }
    }
}
