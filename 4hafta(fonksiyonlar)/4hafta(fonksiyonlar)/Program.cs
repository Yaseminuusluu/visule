using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4hafta_fonksiyonlar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Değer giriniz :");
            n = Convert.ToInt32(Console.ReadLine());
            yaz(n);

            Console.ReadLine();

        }
        static void yaz(int x)
        {
            
            for(int i= 1; i<=x; i++)
            {
             Console.WriteLine("Merhaba");
            }
            
        }
    }
}
