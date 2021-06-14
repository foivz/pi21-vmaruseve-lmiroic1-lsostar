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
    public partial class FormIndividualniTrening : Form
    {
        
        public FormIndividualniTrening()
        {
            InitializeComponent();
        }

        private void btnRezervirajIT_Click(object sender, EventArgs e)
        {
            Termin odabraniTermin = dgvIndividualniTrening.CurrentRow.DataBoundItem as Termin;
            
            RezervacijaTreninga rezervacijaTreninga = new RezervacijaTreninga
            {
                trening_id = 1,
                korisnik_korisnickoIme = Sesija.PrijavljeniKorisnik.korisnickoIme,
                vrijemeRezervacije = DateTime.Now

            };
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.Rezerviraj(rezervacijaTreninga);
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTermine(odabraniTermin);
            MessageBox.Show("Uspješno rezerviran trening!");
            Korisnik trener = cmbOdabirTrenera.SelectedItem as Korisnik;
            DateTime zeljenidatum = dtpOdaberiDatumIndividualni.Value.Date;
            dgvIndividualniTrening.DataSource = null;
            dgvIndividualniTrening.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTerminePremaTreneru(trener, zeljenidatum);
            Mailer.PosaljiObavijestNaMail(Sesija.PrijavljeniKorisnik, "Obavijest o uspjesnoj rezervaciji termina individualnog treninga koji počinje "+ odabraniTermin.od+" h, a vodi ga "+trener.ime +" "+trener.prezime, "Rezervacija individualnog terninga");
        }

        private void btnNatragIT_Click(object sender, EventArgs e)
        {
            FormaRezervacijaTreninga formaRezervacijaTreninga = new FormaRezervacijaTreninga();
            formaRezervacijaTreninga.Show();
            this.Hide();
        }

        private void FormIndividualniTrening_Load(object sender, EventArgs e)
        {
    
            cmbOdabirTrenera.DataSource = null;
            cmbOdabirTrenera.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTrenere();
            cmbOdabirTrenera.DisplayMember = "ime" + "prezime";
            cmbOdabirTrenera.ValueMember = "korisnickoIme";

        }

        private void cmbOdabirTrenera_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Korisnik trener = cmbOdabirTrenera.SelectedItem as Korisnik;
            DateTime zeljenidatum = dtpOdaberiDatumIndividualni.Value.Date;
            
            dgvIndividualniTrening.DataSource = null;
            dgvIndividualniTrening.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTerminePremaTreneru(trener, zeljenidatum);
        }

        private void dtpOdaberiDatumIndividualni_ValueChanged(object sender, EventArgs e)
        {
            Korisnik trener = cmbOdabirTrenera.SelectedItem as Korisnik;
            DateTime zeljenidatum = dtpOdaberiDatumIndividualni.Value.Date;
            
            dgvIndividualniTrening.DataSource = null;
            dgvIndividualniTrening.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTerminePremaTreneru(trener, zeljenidatum);
        }

        private void FormIndividualniTrening_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
