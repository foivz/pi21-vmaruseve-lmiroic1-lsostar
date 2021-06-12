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
            odabraniKorisnik.ime = txtImeZaposlenikaAzuriranje.Text;
            odabraniKorisnik.prezime = txtPrezimeZaposlenikaAzuriranje.Text;
            odabraniKorisnik.email = txtEmailZaposlenikaAzuriranje.Text;
            odabraniKorisnik.brojtelefona = txtBrojTelefonaZaposlenikaAzuriranje.Text;
            odabraniKorisnik.lozinka = txtLozinka.Text;
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeKorisnicimaDAL.AzuriranjeZaposlenika(odabraniKorisnik);
            MessageBox.Show("Korisnik uspješno ažuriran!!");
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.Show();
            Close();
        }

        private void FormaAzurirajZaposlenika_Load(object sender, EventArgs e)
        {
            txtImeZaposlenikaAzuriranje.Text = odabraniKorisnik.ime;
            txtPrezimeZaposlenikaAzuriranje.Text = odabraniKorisnik.prezime;
            txtEmailZaposlenikaAzuriranje.Text = odabraniKorisnik.email;
            txtBrojTelefonaZaposlenikaAzuriranje.Text = odabraniKorisnik.brojtelefona;
            txtLozinka.Text = odabraniKorisnik.lozinka;
        }
    }
}
