using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7
{
  class Ogrencii
    {
        public string adSoyad;
        public int sinif_adi;
        public string ders_adi;
        public string tcno;
        public int dersnotu;

        public void not_kontrol(int dersnotu)
        {
            if (dersnotu >= 50)
            {
                Console.WriteLine("Dersten geçtiniz");

            }
            else
            {
                Console.WriteLine("Dersten kaldınız");
            }

        }
       public void bilgiYaz()
        {
            
                

            Console.WriteLine("Öğrenci Adı Soyadı {0} Sınıf {1} Ders Adı {2} TC {3} Ders Notu {4} ",adSoyad,sinif_adi,ders_adi,tcno,dersnotu);
           
        }


    }
}
