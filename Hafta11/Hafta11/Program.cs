using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hafta11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Deneme;Integrated Security=True");
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("Select  * from Personel" , baglanti);
            //SqlDataReader oku = komut.ExecuteReader();
            //int sayac = 0;
            //while (oku.Read())
            //{
            //    sayac++;

            //    Console.WriteLine(oku[0]+ "    \t" + oku[1] + "   \t"+ oku[2] + "   \t");
            //}
            //baglanti.Close();
            //Console.WriteLine(" ");
            //Console.WriteLine(sayac + " kayıt listelendi");

            //Console.ReadLine();
            SqlConnection baglanti = new SqlConnection("Data Source=.;Integrated Security=True");
            Console.WriteLine("");
        }
    }
}
