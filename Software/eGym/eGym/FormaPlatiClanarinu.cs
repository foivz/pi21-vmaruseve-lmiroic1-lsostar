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
            NovacKorisnika novac = null;
            
                using (var context = new Entities_())
                {
                    if (novac.stanjeNaRacunu>0)
                    {
                        VrstaClanarine vrstaClanarine = cboxVrstaClanarine.SelectedItem as VrstaClanarine;
                        DateTime vrijedi_od = DateTime.Now;
                        DateTime vrijedi_do = DateTime.Now;
                        Korisnik korisnik = odabraniKorisnik;
                        context.VrstaClanarines.Attach(vrstaClanarine);
                        context.Korisniks.Attach(korisnik);

                        Clanarina novaClanarina = new Clanarina
                        {
                            vrijedi_do = vrijedi_do,
                            vrijedi_od = vrijedi_od,
                            vrsta_id = vrstaClanarine.ID,
                            korisnik_korisnickoIme = korisnik.korisnickoIme,
                            placeno = "Da"
                            
                        };
                        context.Clanarinas.Add(novaClanarina);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new ApplicationException("Ne možete platiti račun");
                    }
                }
                    
            


            MessageBox.Show("Članarina uspješno plaćena!");
            formProfilClana formProfilClana = new formProfilClana();
            formProfilClana.Show();
            this.Close();
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
                            select vc.naziv;
                cboxVrstaClanarine.DataSource = query.Distinct().ToList();

            }



        }

        private void cboxVrstaClanarine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vrsta = cboxVrstaClanarine.SelectedItem.ToString();
            using (var context = new Entities_())
            {
                var query = from vc in context.VrstaClanarines.Include("Clanarinas")
                            where vc.naziv == vrsta
                            select new VrstaClanarineView { Cijena = vc.cijena, Naziv = vc.naziv };
                txtIznosClanarine.Text = query.FirstOrDefault().Cijena.ToString();
                
            }
        }
    }
}
