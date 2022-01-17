using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieDziedziczenie
{
    class Plik
    {
        public string Tresc;
        public int Rozmiar;
        public string Autor;
        public string Sciezka;
        public string rozszerzenie;

        // virtual - pozwalam na nadpisywanie
        public virtual void Zapisz()
        {
            File.WriteAllText(Sciezka + rozszerzenie, Tresc);
        }

    }
}
