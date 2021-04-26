using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eGym
{
    public partial class VerifikacijskiKod : Form
    {
        public VerifikacijskiKod()
        {
            InitializeComponent();
        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješna registracija!");
            FormaPrijava formaPrijava = new FormaPrijava();
            formaPrijava.Show();
            this.Hide();
        }

        private void btnVerifiKodNatrag_Click(object sender, EventArgs e)
        {
            FormaRegistracija formaRegistracija = new FormaRegistracija();
            formaRegistracija.Show();
            this.Hide();
        }
    }
}
