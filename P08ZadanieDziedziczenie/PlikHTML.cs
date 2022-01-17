using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieDziedziczenie
{
    class PlikHTML : Plik
    {

        string szablon = "<HTML><BODY><P>{0}</P></BODY></HTML>";

        public override void Zapisz()
        {
            Tresc = string.Format(szablon, Tresc);
            rozszerzenie = ".html";
            base.Zapisz();
        }
    }
}
