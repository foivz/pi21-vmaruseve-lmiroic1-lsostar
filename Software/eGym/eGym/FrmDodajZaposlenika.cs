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

namespace eGym
{
    public partial class FrmDodajZaposlenika : Form
    {
        public FrmDodajZaposlenika()
        {
            InitializeComponent();
        }

        private void FrmDodajZaposlenika_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            using(var context = new Entities())
            {
                string korisnickoIme = txtUsernameRegistracija.Text;
                string ime = txtImeRegistracija.Text;
                string prezime = txtPrezimeRegistracija.Text;
                string email = txtEmailRegistracija.Text;
                string brojMobitela = txtBrojMobRegistracija.Text;
                string lozinka = txtLozinkaRegistracija.Text;

                Korisnik noviKorisnik = new Korisnik
                {
                    korisnickoIme = korisnickoIme,
                    ime = ime,
                    prezime = prezime,
                    email = email,
                    brojtelefona = brojMobitela,
                    lozinka = lozinka,
                    uloga_id = 2,
                    datum_registracije = DateTime.Now,
                    stanjeNaRacunu = null                    

                };

                Pristup_podacima.Dohvaćanje_podataka.UpravljanjeKorisnicimaDAL.UnosZaposlenika(noviKorisnik);
            }
            MessageBox.Show("Uspješna registracija");
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.Show();
            this.Hide();
        }

        private void btnRegistracijaNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.ShowDialog();
            this.Close();
        }
    }
}
