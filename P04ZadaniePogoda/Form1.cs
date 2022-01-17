using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04ZadaniePogoda
{
    public partial class Form1 : Form
    {
        ManagerMiast managerMiast;
        public Form1()
        {
            InitializeComponent();
            OdswiezMiasta();
            managerMiast = new ManagerMiast();
        }

        private void OdswiezMiasta()
        {
            cbMiasta.Items.Clear();
            
            var miasta = managerMiast.PodajMiasta();
            foreach (var m in miasta)
                cbMiasta.Items.Add(m);
        }
 
        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerPogody mp = new ManagerPogody(Jednostka.Celsjusz);
            double tmp = mp.PodajTemperature(txtNazwaMiasta.Text);

            lblWynik.Text = tmp.ToString();

            managerMiast.DodajMiasto(txtNazwaMiasta.Text);
            OdswiezMiasta();
        }

        private void cbMiasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNazwaMiasta.Text = cbMiasta.Text;
        }
    }
}
