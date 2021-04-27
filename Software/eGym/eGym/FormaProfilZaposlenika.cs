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
    public partial class FormProfilZaposlenika : Form
    {
        public FormProfilZaposlenika()
        {
            InitializeComponent();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PocetnaStranica1 pocetnaStranica = new PocetnaStranica1();
            pocetnaStranica.Show();
            this.Hide();
        }

        private void btnSmjene_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSmjena formaEvidencijaSmjena = new FormaEvidencijaSmjena();
            formaEvidencijaSmjena.Show();
            this.Hide();
        }

        private void btnClanovi_Click(object sender, EventArgs e)
        {
            FormaEvidencijaClanova formaEvidencijaClanova = new FormaEvidencijaClanova();
            formaEvidencijaClanova.Show();
            this.Hide();
        }

        private void btnSuplementi_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void btnIzvjesce_Click(object sender, EventArgs e)
        {
            FormaIzvjesce formaIzvjesce = new FormaIzvjesce();
            formaIzvjesce.Show();
            this.Hide();
        }

        private void btnUrediProfil_Click(object sender, EventArgs e)
        {
            FormaUrediProfilZaposlenika formaUrediProfilZaposlenika = new FormaUrediProfilZaposlenika();
            formaUrediProfilZaposlenika.Show();
            this.Hide();
        }
    }
}
