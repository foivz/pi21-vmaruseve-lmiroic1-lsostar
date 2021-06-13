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

            dtpDatumTerminaOdD.Format = DateTimePickerFormat.Time;
            dtpDatumDoD.Format = DateTimePickerFormat.Time;

            dtpDatumDoD.ShowUpDown = true;
            dtpDatumTerminaOdD.ShowUpDown = true;

        }

        private void DohvatiVrsteVjezbi()
        {
            using (var context = new Entities())
            {
                var query = from vv in context.VrstaVjezbes.Include("Termins")

                            select vv;
                dgvVrstaVjezbe.DataSource = query.ToList();

            }
        }

        private void DohvatiVrsteTreninga()
        {
            using (var context = new Entities())
            {
                var query = from vt in context.Trenings.Include("RezervacijaTreningas").Include("Termins")
                            select vt;
                cbVrstaTreninga.DataSource = null;
                cbVrstaTreninga.DataSource = query.Distinct().ToList();
                cbVrstaTreninga.DisplayMember = "naziv";
                cbVrstaTreninga.ValueMember = "ID";

            }
        }

        private void DohvatiZaposlenika()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Korisniks.Include("Clanarinas").Include("UlogaUTeretani").Include("NaruceniSuplements").Include("RezervacijaTreningas").Include("SmjenaZaposlenikas").Include("Termins")
                            where k.uloga_id == 2
                            select k;
                dgvZaposlenici.DataSource = query.Distinct().ToList();

            }
        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {

            dtpDatumTerminaOdD.Format = DateTimePickerFormat.Time;
            dtpDatumDoD.Format = DateTimePickerFormat.Time;

            dtpDatumDoD.ShowUpDown = true;
            dtpDatumTerminaOdD.ShowUpDown = true;

            Korisnik korisnik = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;
            VrstaVjezbe vrstaVjezbe = dgvVrstaVjezbe.CurrentRow.DataBoundItem as VrstaVjezbe;
            Pristup_podacima.Trening trening = cbVrstaTreninga.SelectedItem as Pristup_podacima.Trening;
            DateTime od = this.dtpDatumTerminaOdD.Value.ToLocalTime();
            DateTime do1 = this.dtpDatumDoD.Value.ToLocalTime();
            int brojMjesta = int.Parse(txtBrojMjestaD.Text);

            Termin noviTermin = new Termin
            {
                od = od,
                @do = do1,
                broj_mjesta = brojMjesta,
                zaposlenik_korisnickoIme = korisnik.korisnickoIme,
                vrstaVjezbe_id = vrstaVjezbe.ID,
                trening_id = trening.ID
            };
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeTerminimaDAL.UnosTermina(noviTermin);
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
