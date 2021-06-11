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
            using (var context = new Entities_())
            {
                context.Korisniks.Attach(odabraniKorisnik);
                odabraniKorisnik.ime = txtImeZaposlenikaAzuriranje.Text;
                odabraniKorisnik.prezime = txtPrezimeZaposlenikaAzuriranje.Text;
                odabraniKorisnik.email = txtEmailZaposlenikaAzuriranje.Text;
                odabraniKorisnik.brojtelefona = txtBrojTelefonaZaposlenikaAzuriranje.Text;
                odabraniKorisnik.korisnickoIme = txtKorisnickoIme.Text;
                odabraniKorisnik.lozinka = txtLozinka.Text;
                context.SaveChanges();
            }
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
            txtKorisnickoIme.Text = odabraniKorisnik.korisnickoIme;
            txtLozinka.Text = odabraniKorisnik.lozinka;
        }
    }
}
