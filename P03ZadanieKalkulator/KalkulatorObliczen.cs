using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieKalkulator
{
    class KalkulatorObliczen
    {
        public double PodajWynik(string rownanie)
        {
            string[] t1 = rownanie.Split('+');
            string[] t2 = rownanie.Split('-');
            string[] t3 = rownanie.Split('*');
            string[] t4 = rownanie.Split('/');

            if (t1.Length == 2)
            {
                return Convert.ToInt32(t1[0]) + Convert.ToInt32(t1[1]);
            }
            else if (t2.Length == 2)
            {
                return Convert.ToInt32(t2[0]) - Convert.ToInt32(t2[1]);
            }
            else if (t3.Length == 2)
            {
                return Convert.ToInt32(t3[0]) * Convert.ToInt32(t3[1]);
            }
            else if (t4.Length == 2)
            {
                return Convert.ToInt32(t4[0]) / Convert.ToInt32(t4[1]);
            }
            else
            {
                throw new Exception("nienany znak");
            }
        }
    }
}
