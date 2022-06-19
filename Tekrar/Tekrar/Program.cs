using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar
{
    class Dikdörtgen
    {
        public int uzunluk;
        public int genislik;

        public double, Alan(int a,int b)
        {
            int alanHeplama = a * gb;
            return alanHeplama;
        }
        public double Cevre(int a,int b)
        {
            int cevreHesaplama = 2*(a + b);
            return cevreHesaplama;
        }
    }
    class daire
    {
        public double r;

        public double Alan()
        {
            double daireninalanı = r * r * Math.PI;
            return daireninalanı;
        }
    }
    class insan
    {
        public string adi;
        public string soyadi;
        public int yas;
        public int tc;
        public int dersnotu;

        public void konusma()
        {

        }
        public void yürüme()
        {

        }
        public void yemekyeme()
        {

        }

    }
    internal class Program
    {
        static void Main(string[] args)

        {
            //daire alanHesaplama = new daire();

            //Console.Write("Yariçap giriniz :");
            //alanHesaplama.r = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Daire alan " + alanHesaplama.Alan());
            Dikdörtgen alanveCevreHesaplama = new Dikdörtgen();

            Console.Write("Uzunluk giriniz :");
            alanveCevreHesaplama.uzunluk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genişlik giriniz :");
            alanveCevreHesaplama.genislik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Alan :" + alanveCevreHesaplama.Alan(alanveCevreHesaplama.uzunluk,alanveCevreHesaplama.genislik) +"Cevre :"+ alanveCevreHesaplama.Cevre(alanveCevreHesaplama.uzunlık
                ,alanveCevreHesaplama.genislik));
            



            Console.ReadLine();
        }
    }
}
