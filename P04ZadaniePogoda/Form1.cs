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
        public Form1()
        {
            InitializeComponent();

            //if (checkBox1.Checked)
            //{

            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerPogody mp = new ManagerPogody(Jednostka.Celsjusz);
            double tmp = mp.PodajTemperature(txtNazwaMiasta.Text);

            lblWynik.Text = tmp.ToString();
        }
    }
}
