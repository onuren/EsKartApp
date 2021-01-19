using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsKartApp
{
    class EsKart
    {
        private double bakiye;
        public string Tur;

        public void Yukle(double miktar)
        {
            bakiye += miktar;
            Console.WriteLine("Bakiye: "+bakiye);
        }

        public void Ode()
        {
            double dusulecek = 0;
            if (Tur=="Öğrenci")
            {
                dusulecek = 1.60;
            }
            if (Tur=="Tam")
            {
                dusulecek = 2.60;
            }
            if (bakiye>=dusulecek)
            {
                bakiye -= dusulecek;
                Console.Beep(1000, 200);
                Console.WriteLine("Bakiye: "+bakiye);
            }
            else
            {
                Console.WriteLine("Bakiye Yetersiz");
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep(500, 500);
                }
                Console.WriteLine("Bakiye: "+bakiye);
            }
        }


    }
}
