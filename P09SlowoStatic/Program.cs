using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09SlowoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c1 = new Czlowiek();
            c1.Imie = "Jan";
            // c1.Nazwisko = "Kowalski";

            Czlowiek.Nazwisko = "Kowalski";

            c1.PrzedstawSie();

            Czlowiek c2 = new Czlowiek()
            {
                Imie = "Adam"
            };

            c2.UstawNazwisko("Nowak");
            c2.PrzedstawSie();


            Czlowiek.MetodaStatyczna();
            Console.WriteLine("to jest metoda statyczna");

            

            // jezeli nie zalezy nam na tym aby programista
            // tworzyl rozne instancje obiektow
            // mozemy stworzyc metode statyczna 





        }
    }
}
