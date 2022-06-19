using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10
{
    struct Personel
    {
        public string ad;
        public string soyad;
        public string meslekOzellikleri;

       public Personel(string ad,string soyad,string meslekOzellikleri)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.meslekOzellikleri = meslekOzellikleri;

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Personel p1 = new Personel("Yasemin","Uslu","Öğrenci");
            Console.WriteLine("Ad: " + p1.ad + "Soyad: "+ p1.soyad  + "Meslek: " + p1.meslekOzellikleri);
    
            
            Console.Read();

        }
    }
}
