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
    public partial class FormaRegistracija : Form
    {
        public FormaRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
                string korisnickoIme = txtKorisnickoIme.Text;
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string email = txtEmail.Text;
                string brojMobitela = txtBrojMob.Text;
                string lozinka = txtLozinka.Text;
            if (Poslovna_logika.Provjere_unosa.Upravljanje_korisnicima.ProvjeraUnosaKodRegistracije(korisnickoIme, ime, prezime, brojMobitela, email, lozinka)&&Poslovna_logika.Provjere_unosa.Upravljanje_korisnicima.ProvjeraKorisnikaKodRegistracije(korisnickoIme,lozinka))
            {
                Korisnik noviKorisnik = new Korisnik
                {
                    korisnickoIme = korisnickoIme,
                    ime = ime,
                    prezime = prezime,
                    email = email,
                    brojtelefona = brojMobitela,
                    lozinka = lozinka,
                    uloga_id = 3,
                    datum_registracije = DateTime.Now,
                    stanjeNaRacunu = 0
                };
                Pristup_podacima.Dohvaćanje_podataka.UpravljanjeKorisnicimaDAL.UnosKorisnika(noviKorisnik);
                Clanarina clanarina = new Clanarina
                {
                    korisnik_korisnickoIme = noviKorisnik.korisnickoIme,
                    vrijedi_od = DateTime.Now,
                    vrijedi_do = DateTime.Now.AddDays(30),
                    vrsta_id = 1,
                    placeno = "da"
                };
                Pristup_podacima.Dohvaćanje_podataka.UpravljanjeKorisnicimaDAL.UnosPrveClanarine(clanarina);
                MessageBox.Show("Uspješna registracija");
                FormaPrijava formaPrijava = new FormaPrijava();
                formaPrijava.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Morate popuniti sva polja sa vrijednostima ili ste unijeli postojećeg korisnika!");
                     

            
        }

        private void btnRegistracijaNatrag_Click(object sender, EventArgs e)
        {
            PocetnaStranica1 pocetnaStranica = new PocetnaStranica1();
            pocetnaStranica.Show();
            this.Hide();
        }

        private void FormaRegistracija_Load(object sender, EventArgs e)
        {

        }

        private void FormaRegistracija_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
