using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05ZadanieZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy = mz.WygenerujZawodnikow();

            // kontroka listobx jest podobna do combobox 

            // rezygnuje z dodwania elment element po elemencie
            ////foreach (var z in zawodnicy)
            ////    lbDane.Items.Add(z.PrzedstawSie());


            // zamiast tego skorzystam z mechanizmu data binding 
            lbDane.DisplayMember = "Nazwisko";
            lbDane.DataSource = zawodnicy;
         
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            // co sie zadzieje gdy ktos kliknie w inny element 

            // sprawdzic kto jest zaznaczony ? 
          
             Zawodnik s = (Zawodnik)lbDane.SelectedItem;
            //  MessageBox.Show(s.DataUrodzenia.ToString());

            txtImie.Text = s.Imie;
            txtNazwisko.Text = s.Nazwisko;
            txtKraj.Text = s.Kraj;
            dtpDataUrodzenia.Value = s.DataUrodzenia;
            numWaga.Value = s.Waga;
            nunWzrost.Value = s.Wzrost;
        }
    }
}
