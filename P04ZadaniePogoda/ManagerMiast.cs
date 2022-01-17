using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadaniePogoda
{
    class ManagerMiast
    {
        private const string nazwaPliku = "miasta.txt";

        public void DodajMiasto(string miasto)
        {
            if (!File.Exists(nazwaPliku))
            {
                File.WriteAllText(nazwaPliku, miasto + Environment.NewLine);
                return;
            }

            // juz plik istnieje 
            if (!CzyMiastoJuzJestWPliku(miasto))
                File.AppendAllLines(nazwaPliku, new string[] {  miasto });
            
        }

        private bool CzyMiastoJuzJestWPliku(string miasto)
        {
            string[] miasta= File.ReadAllLines(nazwaPliku);
            return miasta.Contains(miasto);
        }

        public string[] PodajMiasta()
        {
            return File.ReadAllLines(nazwaPliku);
        }
    }
}
