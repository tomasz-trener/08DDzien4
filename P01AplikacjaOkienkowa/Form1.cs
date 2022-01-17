using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKomunikat_Click(object sender, EventArgs e)
        {
            string s = "ala ma kota";


            // z poziou kodu chce odowalsc sie do przycisku 

            btnKomuniakt.Top = btnKomuniakt.Top + 20;

            MessageBox.Show(s);

            txtKomuniakt.Text = s;
            lblKomunikat.Text = s;
        }

        private void btnWyswietlTekst_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtKomuniakt.Text,"Informacja",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
        }
    }
}
