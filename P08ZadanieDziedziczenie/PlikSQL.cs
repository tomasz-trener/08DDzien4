using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieDziedziczenie
{
    class PlikSQL : Plik
    {
        public override void Zapisz()
        {
            Tresc = "SELECT " + Tresc + " FROM DANE";
            rozszerzenie = ".sql";
            base.Zapisz();
        }
    }
}
