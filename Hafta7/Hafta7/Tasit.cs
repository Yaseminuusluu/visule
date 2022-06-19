using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7
{
     class Tasit
    {
        public string yakit;
        public int hiz;
        public string renk;
        public string marka;

        public void Bilgiyaz()
        {
            // string tasityaz = "Yakit :"+yakit+"Hız" +hiz+"Renk :"+renk +"Marka :" + marka;
            string tasityaz = yakit + "Yakit: " + + hiz + "Hız: "+ renk+ "Renk: "+marka+"Marka: ";
            Console.Write(tasityaz);
            
                
        }
    }
}
