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
    public partial class FormaDodajSmjenu : Form
    {
        public FormaDodajSmjenu()
        {
            InitializeComponent();
        }

        private void btnDodajSmjenu_Click(object sender, EventArgs e)
        {
            Pristup_podacima.Smjena odabranaSmjena = cmbNaziv.SelectedItem as Pristup_podacima.Smjena;
            Korisnik odabraniKorisnik = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;
            DateTime odabraniDatum = this.dtpDatum.Value.Date;

            using (var context = new Entities())
            {
                context.Smjenas.Attach(odabranaSmjena);
                context.Korisniks.Attach(odabraniKorisnik);
               
                    SmjenaZaposlenika novaSmjena = new SmjenaZaposlenika
                    {
                        zaposlenik_korisnickoIme = odabraniKorisnik.korisnickoIme,
                        smjena_id = odabranaSmjena.ID,
                        datum = odabraniDatum

                    };
                Pristup_podacima.Dohvaćanje_podataka.UpravljanjeSmjenamaDAL.UnosSmjene(novaSmjena);
            }




            MessageBox.Show("Smjena uspješno dodana");
            FormaEvidencijaSmjena formaEvidencijaSmjena = new FormaEvidencijaSmjena();
            formaEvidencijaSmjena.Show();
            this.Close();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSmjena formaEvidencijaSmjena = new FormaEvidencijaSmjena();
            formaEvidencijaSmjena.Show();
            this.Hide();
        }

        private void FormaDodajSmjenu_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private object DohvatiSmjene()
        {

            using (var context = new Entities())
            {
                return context.Smjenas.ToList();

            }
            
        }

        private object DohvatiZaposlenike()
        {


            using (var context = new Entities())
            {
                var query = from k in context.Korisniks.Include("Clanarinas").Include("UlogaUTeretani").Include("NaruceniSuplements").Include("RezervacijaTreningas").Include("SmjenaZaposlenikas").Include("Termins")
                            where k.uloga_id == 2
                            select k;

                return query.ToList();

            }
        }

        private void Osvjezi()
        {
            cmbNaziv.DataSource = null;
            cmbNaziv.DataSource = DohvatiSmjene();
            cmbNaziv.DisplayMember = "naziv";
            cmbNaziv.ValueMember = "ID";
            dgvZaposlenici.DataSource = null;
            dgvZaposlenici.DataSource = DohvatiZaposlenike();            
        }
    }
}
