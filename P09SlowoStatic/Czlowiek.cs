using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09SlowoStatic
{
    class Czlowiek
    {
        public string Imie;
        public static string Nazwisko;

        public void UstawNazwisko(string nazwisko)
        {
            Nazwisko = nazwisko;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine($"nazywam sie {Imie} {Nazwisko}");
        }

        public static void MetodaStatyczna()
        {
            Console.WriteLine(Nazwisko);
        }
    }
}
