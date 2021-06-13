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
    public partial class FormaPlatiClanarinu : Form
    {
        Korisnik odabraniKorisnik;

        public FormaPlatiClanarinu(Korisnik korisnik)
        {
            InitializeComponent();
            odabraniKorisnik = korisnik;

        }

        private void btnPlatiClanarinuOdustani_Click(object sender, EventArgs e)
        {
            formProfilClana formProfilClana = new formProfilClana();
            formProfilClana.Show();
            this.Hide();
        }

        List<Clanarina> clanarinas = new List<Clanarina>();
        private void btnPlatiClanarinu_Click(object sender, EventArgs e)
        {
            Pristup_podacima.VrstaClanarine vrstaClanarine = dgvClanarina.CurrentRow.DataBoundItem as Pristup_podacima.VrstaClanarine;

            bool clanarinaPlacena = false;

            using (var contex = new Entities())
            {
                var query = from c in contex.Clanarinas.Include("Korisnik")
                            where c.korisnik_korisnickoIme == odabraniKorisnik.korisnickoIme
                            orderby c.ID
                            select c;

                foreach (var item in query)
                {
                    clanarinas.Add(item);
                }

                DateTime vrijediDo = clanarinas.Last().vrijedi_do;

                if (vrijediDo > DateTime.Now)
                {
                    clanarinaPlacena = true;
                }
            }

            

            if (!clanarinaPlacena)
            {
                using (var context = new Entities())
                {


                    DateTime vrijedi_od = DateTime.Now;
                    DateTime vrijedi_do = vrijedi_od.AddDays(30); // provjeri

                    // id korisnika +
                    // trenutno stanje njegoca računa +
                    // prema vrsti čl. oduzmi novac +
                    // izvrši update table nad tablicom u kojoj se nalazi stanje korisnikova računa
                    // UPDATE korisnik SET stanje = {novoStanje} WHERE userId = 123;

                    context.Korisniks.Attach(odabraniKorisnik);
                    context.VrstaClanarines.Attach(vrstaClanarine);

                    Clanarina novaClanarina = new Clanarina
                    {
                        vrijedi_do = vrijedi_do,
                        vrijedi_od = vrijedi_od,
                        vrsta_id = vrstaClanarine.ID,
                        korisnik_korisnickoIme = odabraniKorisnik.korisnickoIme,
                        placeno = "Da"

                    };


                    odabraniKorisnik.stanjeNaRacunu = odabraniKorisnik.stanjeNaRacunu - vrstaClanarine.cijena;

                    context.Clanarinas.Add(novaClanarina);
                    context.SaveChanges();

                }
                MessageBox.Show("Članarina uspješno plaćena!");
            }
            else
            {
                MessageBox.Show("Članarina još traje");
            }
            Mailer.PosaljiObavijestNaMail(Sesija.PrijavljeniKorisnik, "Obavijest o uspjesnoj plaćenoj članarini.", "eGym - plaćena članarina");

            formProfilClana formProfilClana = new formProfilClana();
            formProfilClana.Show();
            this.Close();
        }

        private void FormaPlatiClanarinu_Load(object sender, EventArgs e)
        {
            DohvatiVrsteClanarine();
            using (var context = new Entities())
            {
                var query = from k in context.Korisniks.Include("Clanarinas").Include("UlogaUTeretani").Include("NaruceniSuplements").Include("RezervacijaTreningas").Include("SmjenaZaposlenikas").Include("Termins")
                            where k.korisnickoIme == odabraniKorisnik.korisnickoIme
                            select k.stanjeNaRacunu;
                lblIznosNaRacunuClanarina.Text = query.FirstOrDefault().ToString();
            }
        }

        private void DohvatiVrsteClanarine()
        {


            using (var context = new Entities())
            {
                var query = from vc in context.VrstaClanarines.Include("Clanarinas")
                            select vc;
                dgvClanarina.DataSource = query.ToList();

            }



        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtIznosClanarine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        
            

            
                    
            


            
      

        

       
