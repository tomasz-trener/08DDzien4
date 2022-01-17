using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieDziedziczenie
{
    class PlikCSV : Plik
    {
        public override void Zapisz()
        {
            Tresc = Tresc.Replace(" ", ";");
            rozszerzenie = ".csv";
            base.Zapisz();
        }
    }
}
