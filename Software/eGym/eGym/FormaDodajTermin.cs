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
    public partial class FormaDodajTermin : Form
    {
        public FormaDodajTermin()
        {
            InitializeComponent();
        }

        private void FormaDodajTermin_Load(object sender, EventArgs e)
        {
            
            DohvatiVrsteTreninga();
            DohvatiVrsteVjezbi();
            DohvatiZaposlenika();
        }

        private void DohvatiVrsteVjezbi()
        {
            using (var context = new Entities5())
            {
                var query = from vv in context.VrstaVjezbes.Include("Termins")

                            select vv.naziv;
                cmbVrstaVjezbeD.DataSource = query.Distinct().ToList();

            }
        }

        private void DohvatiVrsteTreninga()
        {
            using (var context = new Entities5())
            {
                var query = from vt in context.Trenings.Include("RezervacijaTreningas").Include("Termins")

                            select vt.naziv;
                cmbVrstaTreningaD.DataSource = query.Distinct().ToList();

            }
        }

        private void DohvatiZaposlenika()
        {
            using (var context = new Entities5())
            {
                var query = from k in context.Korisniks.Include("Clanarinas").Include("UlogaUTeretani").Include("NaruceniSuplements").Include("NovacKorisnikas").Include("RezervacijaTreningas").Include("SmjenaZaposlenikas").Include("Termins")
                            where k.uloga_id == 2
                            select k.prezime;
                cmbZaposlenikD.DataSource = query.Distinct().ToList();

            }
        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {
       
            using (var context = new Entities5())
            {
                Korisnik korisnik = cmbZaposlenikD.SelectedItem as Korisnik;
                VrstaVjezbe vrstaVjezbe = cmbVrstaVjezbeD.SelectedItem as VrstaVjezbe;
                Trening trening = cmbVrstaTreningaD.SelectedItem as Trening;
                DateTime od = DateTime.Parse(dtpDatumTerminaOdD.Text);
                DateTime do1 = DateTime.Parse(dtpDatumTerminaOdD.Text);
                int brojMjesta = int.Parse(txtBrojMjestaD.Text);


                context.Korisniks.Attach(korisnik);
                context.VrstaVjezbes.Attach(vrstaVjezbe);
                context.Trenings.Attach(trening);


                Termin noviTermin = new Termin
                {

                    od = od,
                    @do = do1,
                    broj_mjesta = brojMjesta,
                    zaposlenik_korisnickoIme = korisnik.prezime,
                    vrstaVjezbe_id = vrstaVjezbe.ID,
                    trening_id = trening.ID


                };

                context.Termins.Add(noviTermin);
                context.SaveChanges();
            }
            MessageBox.Show("Uspješno dodan termin!");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaTermina formaEvidencijaTermina = new FormaEvidencijaTermina();
            formaEvidencijaTermina.Show();
            this.Hide();
        }
    }
}
