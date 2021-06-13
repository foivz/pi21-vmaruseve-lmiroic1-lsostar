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

    
        private void btnNaruci_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                Pristup_podacima.Suplement odabraniSuplement = dgvNazivSuplementa.CurrentRow.DataBoundItem as Pristup_podacima.Suplement;
                context.Suplements.Attach(odabraniSuplement);
                context.Korisniks.Attach(OdabraniKorisnik);
                int kolicina = int.Parse(txtKolicina.Text);
                NaruceniSuplement naruceniSuplement = new NaruceniSuplement
                {
                    korisnik_korisnickoIme = OdabraniKorisnik.korisnickoIme,
                    suplement_id = odabraniSuplement.ID,
                    kolicina = kolicina,
                    datum_narudzbe=DateTime.Now
                };
                OdabraniKorisnik.stanjeNaRacunu = OdabraniKorisnik.stanjeNaRacunu - (odabraniSuplement.cijena * kolicina);
                odabraniSuplement.stanje = odabraniSuplement.stanje - kolicina;
                
                context.NaruceniSuplements.Add(naruceniSuplement);
                context.SaveChanges();

            }
            MessageBox.Show("Uspješno naručen suplement.");
            Osvjezi();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            formProfilClana profilClana = new formProfilClana();
            profilClana.Show();
            this.Hide();
        }
        private void Osvjezi()
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

      

        private void FormaNaruciSuplement_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }


      
        private void dgvNazivSuplementa_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvKosarica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            Pristup_podacima.Suplement odabraniSuplement = dgvNazivSuplementa.CurrentRow.DataBoundItem as Pristup_podacima.Suplement;
            int kolicina = int.Parse(txtKolicina.Text);
            decimal iznos = kolicina * odabraniSuplement.cijena;
            txtUkupanIznos.Text = iznos.ToString();

            
        }
    }

 }


