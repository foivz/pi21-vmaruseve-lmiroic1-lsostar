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

        private void btnPlatiClanarinu_Click(object sender, EventArgs e)
        {
            VrstaClanarine vrstaClanarine = dgvClanarina.CurrentRow.DataBoundItem as VrstaClanarine;
            

            using (var context = new Entities_())
                {
                    

                        DateTime vrijedi_od = DateTime.Now;
                        DateTime vrijedi_do = DateTime.Now;

                        
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
                        context.Clanarinas.Add(novaClanarina);
                        SkiniNovacSRacuna();
                        context.SaveChanges();
                    
                   
                }
                    
            


            MessageBox.Show("Članarina uspješno plaćena!");
            formProfilClana formProfilClana = new formProfilClana();
            formProfilClana.Show();
            this.Close();
        }

        private void SkiniNovacSRacuna()
        {
            
        }

        private void FormaPlatiClanarinu_Load(object sender, EventArgs e)
        {
            DohvatiVrsteClanarine();
            using (var context = new Entities_())
            {
                var query = from nk in context.NovacKorisnikas.Include("Korisnik")
                            where nk.korisnik_korisnickoIme == odabraniKorisnik.korisnickoIme
                            select new NovacKorisnikaView { StanjeNaRacunu = nk.stanjeNaRacunu };
                lblIznosNaRacunuClanarina.Text = query.FirstOrDefault().StanjeNaRacunu.ToString();
            }
        }

        private void DohvatiVrsteClanarine()
        {
           
            
            using (var context = new Entities_())
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
