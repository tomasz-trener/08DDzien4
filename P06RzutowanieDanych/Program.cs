using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06RzutowanieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota";
            int i = 5;

            object o1 = "ala ma kota"; // rzutowanie niejawne 
            object o2 = i;

            // rzutowanie z typu bardziej szczegowego na ogolny jest zawsze mozliwe i 
            // nie trzeba tego specialnie zapisywac 

            object o3 = (object)"ala ma kota";

          //  int i2 = (int)o1; //invaild cast exepction
                              //


            int a = 4;
            var b = 4;

            DateTime d = DateTime.Now;
            var d2 = DateTime.Now; // NIE JEST TO TYP DYNAMICZNY!!!

            var o = new object();
            o = "as";
            var o10 = "ala ma kota";

            object o5 = "123";
            int i5 = Convert.ToInt32(o5);

            // po co ? do czego moze sie nam przydac object 
            // do zego moze nam sie przydac mechanizm rzutowania ? 

        }
    }
}
