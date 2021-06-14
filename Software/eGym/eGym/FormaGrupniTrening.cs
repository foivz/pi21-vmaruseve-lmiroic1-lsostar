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
    public partial class FormaGrupniTrening : Form
    {
        public FormaGrupniTrening()
        {
            InitializeComponent();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            Termin odabraniTermin = dgvGrupniTrening.CurrentRow.DataBoundItem as Termin;
            RezervacijaTreninga rezervacijaTreninga = new RezervacijaTreninga
            {
                trening_id = 2,
                korisnik_korisnickoIme = Sesija.PrijavljeniKorisnik.korisnickoIme,
                vrijemeRezervacije = DateTime.Now

            };
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.Rezerviraj(rezervacijaTreninga);
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTermine(odabraniTermin);
            MessageBox.Show("Uspješno rezerviran trening!");

            VrstaVjezbe vrstaVjezbe = cmbVrstaVjezbe.SelectedItem as VrstaVjezbe;
            DateTime zeljenidatum = dtpOdaberiDatum.Value.Date;
            dgvGrupniTrening.DataSource = null;
            dgvGrupniTrening.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTerminePremaVrstiVjezbe(vrstaVjezbe, zeljenidatum);
            Mailer.PosaljiObavijestNaMail(Sesija.PrijavljeniKorisnik, "Obavijest o uspjesnoj rezervaciji termina grupnog treninga koji počinje " + odabraniTermin.od + " h, a vrsta vježbe je "+ vrstaVjezbe.naziv, " Rezervacija individualnog terninga");
            
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaRezervacijaTreninga formaRezervacijaTreninga = new FormaRezervacijaTreninga();
            formaRezervacijaTreninga.Show();
            this.Hide();
        }


        private void cmbVrstaVjezbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            VrstaVjezbe vrstaVjezbe = cmbVrstaVjezbe.SelectedItem as VrstaVjezbe;
            DateTime zeljenidatum = dtpOdaberiDatum.Value.Date;
           
            dgvGrupniTrening.DataSource = null;
            dgvGrupniTrening.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTerminePremaVrstiVjezbe(vrstaVjezbe, zeljenidatum); 
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormaGrupniTrening_Load(object sender, EventArgs e)
        {
            
            cmbVrstaVjezbe.DataSource = null;
            cmbVrstaVjezbe.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiVrsteVjezbi();
            cmbVrstaVjezbe.DisplayMember = "naziv";
            cmbVrstaVjezbe.ValueMember = "ID";
        }

        private void dtpOdaberiDatumGrupni_ValueChanged(object sender, EventArgs e)
        {
            VrstaVjezbe vrstaVjezbe = cmbVrstaVjezbe.SelectedItem as VrstaVjezbe;
            DateTime zeljenidatum = dtpOdaberiDatum.Value.Date;
            
            dgvGrupniTrening.DataSource = null;
            dgvGrupniTrening.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeRezervacijamaDAL.VratiTerminePremaVrstiVjezbe(vrstaVjezbe, zeljenidatum);
                
        }

        private void FormaGrupniTrening_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
