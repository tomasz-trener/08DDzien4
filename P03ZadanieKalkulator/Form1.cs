using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03ZadanieKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnJeden_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "1";
        }

        private void btnCyfra_Click(object sender, EventArgs e)
        {
            //w jaki sposób moge sprawdzić w co kliknąłem ? 

            // ja musze wypakować z object na button 

            //bo wiem , ze to button 

            Button b = (Button)sender;

            txtWyswietlacz.Text += b.Text;
        }

        private void btnRownaSie_Click(object sender, EventArgs e)
        {
            KalkulatorObliczen ko = new KalkulatorObliczen();
            txtWyswietlacz.Text= Convert.ToString(ko.PodajWynik(txtWyswietlacz.Text));
        }

        private void btnCZysc_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = "";
        }
    }
}
