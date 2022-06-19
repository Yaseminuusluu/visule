using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta9
{
         //Personel p1 = new Personel();
        //    Personel P2 = new Personel();
        //    Console.WriteLine("Personel sayısı : "+Personel.PersonelSayisi);
        //    Console.Read();            
        //Kedi.Miyav();
          //Console.Read();

        class Kedi
    {
        public static void Miyav()
        {
            Console.WriteLine("Miyaaavvvvvv");
        }
    }
    class Personel
    {  
      

        public static int PersonelSayisi = 0;
        public Personel()
        {
            PersonelSayisi++;
        }
        class Metot
        {
            public void Elma()
            {
                Console.WriteLine("Elma");
            }
            public void Portakal()
            {
                Console.WriteLine("Portakal");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
