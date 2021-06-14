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

            dtpDatumTerminaOd.Format = DateTimePickerFormat.Time;
            dtpDatumDo.Format = DateTimePickerFormat.Time;

            dtpDatumDo.ShowUpDown = true;
            dtpDatumTerminaOd.ShowUpDown = true;

        }

        private void DohvatiVrsteVjezbi()
        {
            using (var db = new Entities())
            {
                var upit = from vv in db.VrstaVjezbes.Include("Termins")
                            select vv;
                dgvVrstaVjezbe.DataSource = upit.ToList();

            }
        }

        private void DohvatiVrsteTreninga()
        {
            using (var db = new Entities())
            {
                var upit = from vt in db.Trenings.Include("RezervacijaTreningas").Include("Termins")
                            select vt;
                cbVrstaTreninga.DataSource = null;
                cbVrstaTreninga.DataSource = upit.Distinct().ToList();
                cbVrstaTreninga.DisplayMember = "naziv";
                cbVrstaTreninga.ValueMember = "ID";

            }
        }

        private void DohvatiZaposlenika()
        {
            using (var db = new Entities())
            {
                var upit = from k in db.Korisniks.Include("Clanarinas").Include("UlogaUTeretani").Include("NaruceniSuplements").Include("RezervacijaTreningas").Include("SmjenaZaposlenikas").Include("Termins")
                            where k.uloga_id == 2
                            select k;
                dgvZaposlenici.DataSource = upit.Distinct().ToList();

            }
        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {

            dtpDatumTerminaOd.Format = DateTimePickerFormat.Time;
            dtpDatumDo.Format = DateTimePickerFormat.Time;

            dtpDatumDo.ShowUpDown = true;
            dtpDatumTerminaOd.ShowUpDown = true;

            Korisnik korisnik = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;
            VrstaVjezbe vrstaVjezbe = dgvVrstaVjezbe.CurrentRow.DataBoundItem as VrstaVjezbe;
            Pristup_podacima.Trening trening = cbVrstaTreninga.SelectedItem as Pristup_podacima.Trening;
            DateTime datumOd = this.dtpDatumTerminaOd.Value.ToLocalTime();
            DateTime datumDo = this.dtpDatumDo.Value.ToLocalTime();
            int brojMjesta = int.Parse(txtBrojMjesta.Text);

            Termin noviTermin = new Termin
            {
                od = datumOd,
                @do = datumDo,
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

        private void FormaDodajTermin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
