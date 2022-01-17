using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Zawodnik z = new Zawodnik()
            {
                Imie = "jan",
                Nazwisko = "kowalski"
            };
            

            object o = new object();

            z.PrzedstawSie();
           
        }
    }
}
