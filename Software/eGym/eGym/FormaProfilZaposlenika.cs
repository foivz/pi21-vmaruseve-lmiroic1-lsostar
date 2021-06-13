using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pristup_podacima;
using Poslovna_logika;


namespace eGym
{
    public partial class FormProfilZaposlenika : Form
    {
        public FormProfilZaposlenika()
        {
            InitializeComponent();
        }

        

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Sesija.PrijavljeniKorisnik = null;
            PocetnaStranica1 pocetnaStranica = new PocetnaStranica1();
            pocetnaStranica.Show();
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

      

        private void btnTermini_Click(object sender, EventArgs e)
        {
            FormaEvidencijaTermina formaEvidencijaTermina = new FormaEvidencijaTermina();
            formaEvidencijaTermina.Show();
            this.Hide();
        }

        private void FormProfilZaposlenika_Load(object sender, EventArgs e)
        {
            lblImeIPrezimeClana.Text = Sesija.PrijavljeniKorisnik.ime + " " + Sesija.PrijavljeniKorisnik.prezime;

            txtImeZaposlenika.Text = Sesija.PrijavljeniKorisnik.ime;
            txtPrezimeZaposlenika.Text = Sesija.PrijavljeniKorisnik.prezime;
            txtBrojTelefonaZaposlenika.Text = Sesija.PrijavljeniKorisnik.brojtelefona;
            txtEmailZaposlenika.Text = Sesija.PrijavljeniKorisnik.email;
        }

       
        private void FormProfilZaposlenika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
