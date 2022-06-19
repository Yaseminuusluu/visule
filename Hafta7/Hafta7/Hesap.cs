using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7
{
     class Hesap
    {

        private double toplam = 0;

        public void Ekle(double b)
        {
            toplam = toplam + b;
        }

        public double goster()
        {
            return toplam;
        }
    }
}
