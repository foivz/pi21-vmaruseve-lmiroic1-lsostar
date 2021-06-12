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
    public partial class FormIndividualniTrening : Form
    {
        
        public FormIndividualniTrening()
        {
            InitializeComponent();
        }

        private void btnRezervirajIT_Click(object sender, EventArgs e)
        {
            Termin odabraniTermin = dgvIndividualniTrening.CurrentRow.DataBoundItem as Termin;
            using (var context = new Entities6())
            {
                Termin query = (from t in context.Termins
                             where t.ID==odabraniTermin.ID
                             select t).SingleOrDefault();
                context.Termins.Attach(query);
                query.broj_mjesta = query.broj_mjesta - 1;
                context.SaveChanges();
            }
            MessageBox.Show("Uspješno rezerviran trening!");
        }

        private void btnNatragIT_Click(object sender, EventArgs e)
        {
            FormaRezervacijaTreninga formaRezervacijaTreninga = new FormaRezervacijaTreninga();
            formaRezervacijaTreninga.Show();
            this.Hide();
        }

        private void FormIndividualniTrening_Load(object sender, EventArgs e)
        {
            List<Korisnik> treneri = new List<Korisnik>();
            using (var context = new Entities6())
            {
                var query = (from k in context.Korisniks
                             where k.uloga_id == 2
                             select k).ToList();
                treneri = query;
            }
            cmbOdabirTrenera.DataSource = null;
            cmbOdabirTrenera.DataSource = treneri;
            cmbOdabirTrenera.DisplayMember = "ime" + "prezime";
            cmbOdabirTrenera.ValueMember = "korisnickoIme";

        }

        private void cmbOdabirTrenera_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Korisnik trener = cmbOdabirTrenera.SelectedItem as Korisnik;
            DateTime zeljenidatum = dtpOdaberiDatumIndividualni.Value.Date;
            List<Termin> terminiIndividualnihTreninga = new List<Termin>();
            using (var context = new Entities6())
            {
                var query = (from t in context.Termins
                             where t.zaposlenik_korisnickoIme == trener.korisnickoIme && t.vrstaVjezbe_id == 1 && t.od.Month == zeljenidatum.Month && t.od.Day == zeljenidatum.Day&&t.broj_mjesta>=1
                             select t).ToList();
                terminiIndividualnihTreninga = query;
            }
            dgvIndividualniTrening.DataSource = null;
            dgvIndividualniTrening.DataSource = terminiIndividualnihTreninga;
        }

        private void dtpOdaberiDatumIndividualni_ValueChanged(object sender, EventArgs e)
        {
            Korisnik trener = cmbOdabirTrenera.SelectedItem as Korisnik;
            DateTime zeljenidatum = dtpOdaberiDatumIndividualni.Value.Date;
            List<Termin> terminiIndividualnihTreninga = new List<Termin>();
            using (var context = new Entities6())
            {
                var query = (from t in context.Termins
                             where t.zaposlenik_korisnickoIme == trener.korisnickoIme && t.vrstaVjezbe_id == 1 && t.od.Month== zeljenidatum.Month&&t.od.Day==zeljenidatum.Day&&t.broj_mjesta>=1
                             select t).ToList();
                terminiIndividualnihTreninga = query;
            }
            dgvIndividualniTrening.DataSource = null;
            dgvIndividualniTrening.DataSource = terminiIndividualnihTreninga;
        }
    }
}
