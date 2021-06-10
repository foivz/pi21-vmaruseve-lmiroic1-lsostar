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
    public partial class FormaDodajSmjenu : Form
    {
        public FormaDodajSmjenu()
        {
            InitializeComponent();
        }

        private void btnDodajSmjenu_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = cmbPrezime.SelectedItem as Korisnik;
            Smjena smjena = cmbNaziv.SelectedItem as Smjena;
            using (var context = new Entities5())
            {
                context.Korisniks.Attach(korisnik);
                context.Smjenas.Attach(smjena);
                SmjenaZaposlenika newSmjena = new SmjenaZaposlenika
                {

                    smjena_id = smjena.ID,
                    zaposlenik_korisnickoIme = korisnik.prezime,
                    datum = DateTime.Now
                };

                context.SmjenaZaposlenikas.Add(newSmjena);
                context.SaveChanges();
            }
            Close();

       
            MessageBox.Show("Uspješno dodana smjena.");
            FormaEvidencijaSmjena formaEvidencijaSmjena = new FormaEvidencijaSmjena();
            formaEvidencijaSmjena.Show();
            this.Hide();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSmjena formaEvidencijaSmjena = new FormaEvidencijaSmjena();
            formaEvidencijaSmjena.Show();
            this.Hide();
        }

        private void FormaDodajSmjenu_Load(object sender, EventArgs e)
        {
            DohvatiZaposlenike();
            DohvatiSmjene();
        }

        private void DohvatiSmjene()
        {
            using (var context = new Entities5())
            {
                var query = from s in context.Smjenas.Include("SmjenaZaposlenikas")

                            select s.naziv;
                cmbNaziv.DataSource = query.Distinct().ToList();

            }
        }

        private void DohvatiZaposlenike()
        {


            using (var context = new Entities5())
            {
                var query = from k in context.Korisniks.Include("Clanarinas").Include("UlogaUTeretani").Include("NaruceniSuplements").Include("NovacKorisnikas").Include("RezervacijaTreningas").Include("SmjenaZaposlenikas").Include("Termins")
                            where k.uloga_id == 2
                            select k.prezime;
                cmbPrezime.DataSource = query.Distinct().ToList();

            }
        }
    }
}
