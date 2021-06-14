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

        
        private void btnPlatiClanarinu_Click(object sender, EventArgs e)
        {
            Pristup_podacima.VrstaClanarine vrstaClanarine = dgvClanarina.CurrentRow.DataBoundItem as Pristup_podacima.VrstaClanarine;

            if (!Pristup_podacima.Dohvaćanje_podataka.UpravljanjeClanarinamaDAL.VratiVrijemePlacanja(odabraniKorisnik))
            {
                using (var context = new Entities())
                {
                    DateTime vrijedi_od = DateTime.Now;
                    DateTime vrijedi_do = vrijedi_od.AddDays(30); 

                    context.Korisniks.Attach(odabraniKorisnik);

                    Clanarina novaClanarina = new Clanarina
                    {
                        vrijedi_do = vrijedi_do,
                        vrijedi_od = vrijedi_od,
                        vrsta_id = vrstaClanarine.ID,
                        korisnik_korisnickoIme = odabraniKorisnik.korisnickoIme,
                        placeno = "Da"

                    };
                    
                    Pristup_podacima.Dohvaćanje_podataka.UpravljanjeClanarinamaDAL.PlatiClanarinu(novaClanarina);
                    odabraniKorisnik.stanjeNaRacunu = odabraniKorisnik.stanjeNaRacunu - vrstaClanarine.cijena;
                    lblIznosNaRacunuClanarina.Text = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeClanarinamaDAL.PrikaziStanjeNaRacunu(odabraniKorisnik);
                    context.SaveChanges();
                }
                Mailer.PosaljiObavijestNaMail(Sesija.PrijavljeniKorisnik, "Obavijest o uspjesnoj plaćenoj članarini.", "eGym - plaćena članarina");
                MessageBox.Show("Članarina uspješno plaćena!");
            }
            else
            {
                MessageBox.Show("Članarina još traje");
            }
            

            formProfilClana formProfilClana = new formProfilClana();
            formProfilClana.Show();
            this.Close();
        }

        private void FormaPlatiClanarinu_Load(object sender, EventArgs e)
        {
            dgvClanarina.DataSource = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeClanarinamaDAL.DohvatiVrsteClanarine();
            lblIznosNaRacunuClanarina.Text = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeClanarinamaDAL.PrikaziStanjeNaRacunu(odabraniKorisnik);
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

        private void FormaPlatiClanarinu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}

        
            

            
                    
            


            
      

        

       
