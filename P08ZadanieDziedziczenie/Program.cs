using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plik> pliki = new List<Plik>();
            pliki.Add(new PlikCSV() { Tresc="ala ma kota", Sciezka = @"c:\dane\pliki\p1" });
            pliki.Add(new PlikSQL() { Tresc = "ala ma kota", Sciezka = @"c:\dane\pliki\p2" });
            pliki.Add(new PlikHTML() { Tresc = "ala ma kota", Sciezka = @"c:\dane\pliki\p3" });

            foreach (var p in pliki)
                p.Zapisz();

           // Plik plik = new Plik();

            

             


        }
    }
}
