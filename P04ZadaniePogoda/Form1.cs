using P04ZadaniePogoda.Properties;
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
            managerMiast = new ManagerMiast();
            OdswiezMiasta();
            pcObrazek.Image = null;
        }

        private void OdswiezMiasta()
        {
            cbMiasta.Items.Clear();
             
            var miasta = managerMiast.PodajMiasta();
            if(miasta != null)
                foreach (var m in miasta)
                    cbMiasta.Items.Add(m);
        }
 
        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Jednostka jd;
            if (rbCelsjusz.Checked)
                jd = Jednostka.Celsjusz;
            else if (rbFahrenheit.Checked)
                jd = Jednostka.Fahrenheit;
            else if (rbKelvin.Checked)
                jd = Jednostka.Kelvin;
            else
                throw new Exception("nieznana jednostka");

            ManagerPogody mp = new ManagerPogody(jd);
            double tmp = mp.PodajTemperature(txtNazwaMiasta.Text);

            lblWynik.Text = tmp.ToString();

            managerMiast.DodajMiasto(txtNazwaMiasta.Text);
            OdswiezMiasta();
            UstawObrazek(tmp);
        }

        private void UstawObrazek(double tmp)
        {
            if (tmp < 0)
                pcObrazek.Image = Resources.snow;
            else if (tmp < 10)
                pcObrazek.Image = Resources.cloud;
            else
                pcObrazek.Image = Resources.sun;
        }


        private void cbMiasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNazwaMiasta.Text = cbMiasta.Text;
        }
    }
}
