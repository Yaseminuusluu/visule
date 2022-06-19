using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta8
{
   class Ogrenci

    {
        public string AdSoyad;
        public int numara;
        public int sinif;
        
        public void Bilgi()

        {
            Console.WriteLine("Ogrenci Adi Soyadi : {0}",AdSoyad);
            Console.WriteLine("Ogrencinin Numarası : {0}", numara);
            Console.WriteLine("Öğrencinin sınıfı : {0}", sinif);

        }

    }
}
