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
            using (var context = new Entities())
            {
                Termin query = (from t in context.Termins
                                where t.ID == odabraniTermin.ID
                                select t).SingleOrDefault();
                context.Termins.Attach(query);
                query.broj_mjesta = query.broj_mjesta - 1;
                context.SaveChanges();
            }
            MessageBox.Show("Uspješno rezerviran trening!");
            VrstaVjezbe vrstaVjezbe = cmbVrstaVjezbe.SelectedItem as VrstaVjezbe;
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
            DateTime zeljenidatum = dtpOdaberiDatumGrupni.Value.Date;
            List<Termin> terminiGrupnogTreninga = new List<Termin>();
            using (var context = new Entities())
            {
                var upit = (from t in context.Termins
                            where t.vrstaVjezbe_id == vrstaVjezbe.ID &&  t.od.Month == zeljenidatum.Month && t.od.Day == zeljenidatum.Day && t.broj_mjesta >= 1
                             select t).ToList();
                terminiGrupnogTreninga = upit;
            }
            dgvGrupniTrening.DataSource = null;
            dgvGrupniTrening.DataSource = terminiGrupnogTreninga; 
        
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
            List<VrstaVjezbe> listaVjezbi = new List<VrstaVjezbe>();
            using (var context = new Entities())
            {
                var upit = (from vv in context.VrstaVjezbes.Include("Termins")
                             select vv).ToList();
                listaVjezbi = upit;
             
            }
            cmbVrstaVjezbe.DataSource = null;
            cmbVrstaVjezbe.DataSource = listaVjezbi;
            cmbVrstaVjezbe.DisplayMember = "naziv";
            cmbVrstaVjezbe.ValueMember = "ID";
        }

        private void dtpOdaberiDatumGrupni_ValueChanged(object sender, EventArgs e)
        {
            VrstaVjezbe vrstaVjezbe = cmbVrstaVjezbe.SelectedItem as VrstaVjezbe;
            DateTime zeljenidatum = dtpOdaberiDatumGrupni.Value.Date;
            List<Termin> terminiGrupnogTreninga = new List<Termin>();
            using (var context = new Entities())
            {
                var query = (from t in context.Termins
                             where t.vrstaVjezbe_id == vrstaVjezbe.ID && t.trening_id == 2 && t.od.Month == zeljenidatum.Month && t.od.Day == zeljenidatum.Day && t.broj_mjesta >= 1
                             select t).ToList();
                terminiGrupnogTreninga = query;
            }
            dgvGrupniTrening.DataSource = null;
            dgvGrupniTrening.DataSource = terminiGrupnogTreninga;
        }
    }
}
