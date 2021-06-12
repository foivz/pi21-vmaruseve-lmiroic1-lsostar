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
    public partial class FormaNaruciSuplement : Form
    {
        BindingList<NaruceniSuplement> listaSuplementa = new BindingList<NaruceniSuplement>();
       
        public Korisnik OdabraniKorisnik { get; set; }

        public FormaNaruciSuplement(Korisnik korisnik)
        {
            InitializeComponent();
            OdabraniKorisnik = korisnik;
        }

        private void btnObrisiKosaricu_Click(object sender, EventArgs e)
        {
            if (dgvKosarica.CurrentRow != null)
            {
                foreach (DataGridViewRow item in this.dgvKosarica.SelectedRows)
                {
                    listaSuplementa.Remove(dgvKosarica.CurrentRow.DataBoundItem as NaruceniSuplement);
                }
            } 

            MessageBox.Show("Uspješno obrisan suplement u košarici.");
            
        }
        private void btnNaruci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno naručen suplement.");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            formProfilClana profilClana = new formProfilClana();
            profilClana.Show();
            this.Hide();
        }

        private void btnUrediKosaricu_Click(object sender, EventArgs e)
        {
            Pristup_podacima.Suplement suplement = dgvKosarica.CurrentRow.DataBoundItem as Pristup_podacima.Suplement;
            FormaUrediKosaricu formaUrediKosaricu = new FormaUrediKosaricu(suplement);
            formaUrediKosaricu.Show();
            this.Hide();
        }

        private void FormaNaruciSuplement_Load(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var query = from k in context.Korisniks.Include("Clanarinas").Include("UlogaUTeretani").Include("NaruceniSuplements").Include("RezervacijaTreningas").Include("SmjenaZaposlenikas").Include("Termins")
                            where k.korisnickoIme == OdabraniKorisnik.korisnickoIme
                            select k.stanjeNaRacunu;
                txtIznosNaRacunu.Text = query.FirstOrDefault().ToString();
            }

            using (var context = new Entities())
            {
                var upit = from su in context.Suplements.Include("NaruceniSuplements")
                           select su;
                dgvNazivSuplementa.DataSource = upit.ToList();
            }
        }


        private void btnDodajSuplement_Click(object sender, EventArgs e)
        {
            Pristup_podacima.Suplement suplement = dgvNazivSuplementa.CurrentRow.DataBoundItem as Pristup_podacima.Suplement;
            int kolicina = int.Parse(txtKolicina.Text);
            using (var context = new Entities())
            {
                var upit = from s in context.NaruceniSuplements.Include("Suplement").Include("Korisnik")
                           where s.suplement_id == suplement.ID 
                           select s;
                dgvKosarica.DataSource = upit.ToList();

               
            }
            
        }
        private void dgvNazivSuplementa_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvKosarica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

 }


