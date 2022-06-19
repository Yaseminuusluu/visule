using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6hafta
{
    class Daire
    {
        public double r;
       
        public double alan()
        {
            return Math.PI* r * r  ;
        }
    }
    class Insan
    {
        public string ad;
        public string soyad;
        public int yas;  
        public int tc;
        public int dersnotu;

        public void konusma()
        {
        }
        public void yurume()
        {
        }
        public void yemekyeme()
        {
        }
    }
    class Dikdörtgen
    {
        public double uzunluk, genislik;

        public double alan()
        {
            return uzunluk * genislik;
        }
        


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // metotlar ()(parantez) kullanılır.  
            //Dikdörtgen hesap = new Dikdörtgen();
            //Console.Write("Uzunluk giriniz");
            //hesap.uzunluk = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Genişlik giriniz");
            //hesap.genislik = Convert.ToDouble(Console.ReadLine()); 
            //Console.Write("Alan" + hesap.uzunluk * hesap.genislik);

            Daire alanhesaplama = new Daire();
            Console.Write("Yarıçap giriniz :");
            alanhesaplama.r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dairenin Alan :" + alanhesaplama.alan());
            
            
            
            Console.Read();
        }
       

        
    }
}
