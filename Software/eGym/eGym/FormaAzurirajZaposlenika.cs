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
    public partial class FormaAzurirajZaposlenika : Form
    {
        private Korisnik odabraniKorisnik;
        

        public FormaAzurirajZaposlenika(Korisnik korisnik)
        {
            InitializeComponent();
            odabraniKorisnik = korisnik;

        }

        

        private void btnAzurirajZaposlenikaNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.Show();
            this.Hide();
        }

        private void btnAzuriraj_Click_1(object sender, EventArgs e)
        {
            odabraniKorisnik.ime = txtImeZaposlenika.Text;
            odabraniKorisnik.prezime = txtPrezimeZaposlenika.Text;
            odabraniKorisnik.email = txtEmailZaposlenika.Text;
            odabraniKorisnik.brojtelefona = txtBrojTelefonaZaposlenika.Text;
            odabraniKorisnik.lozinka = txtLozinka.Text;
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeKorisnicimaDAL.AzuriranjeZaposlenika(odabraniKorisnik);
            MessageBox.Show("Korisnik uspješno ažuriran!!");
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.Show();
            Close();
        }

        private void FormaAzurirajZaposlenika_Load(object sender, EventArgs e)
        {
            txtImeZaposlenika.Text = odabraniKorisnik.ime;
            txtPrezimeZaposlenika.Text = odabraniKorisnik.prezime;
            txtEmailZaposlenika.Text = odabraniKorisnik.email;
            txtBrojTelefonaZaposlenika.Text = odabraniKorisnik.brojtelefona;
            txtLozinka.Text = odabraniKorisnik.lozinka;
        }

        private void FormaAzurirajZaposlenika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
