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
    public partial class FormaAzurirajClana : Form
    {
        public Korisnik OdabraniKorisnik { get; set; }
        public FormaAzurirajClana(Korisnik korisnik)
        {
            InitializeComponent();
            OdabraniKorisnik = korisnik;
        }

        private void btnAzurirajClanaA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste ažurirali člana!");
            FormaEvidencijaClanova formaEvidencijaClanova = new FormaEvidencijaClanova();
            formaEvidencijaClanova.Show();
            this.Hide();
        }

        private void btnNatragAzuriranjeClana_Click(object sender, EventArgs e)
        {
            FormaEvidencijaClanova formaEvidencijaClanova = new FormaEvidencijaClanova();
            formaEvidencijaClanova.Show();
            this.Hide();
        }

        private void FormaAzurirajClana_Load(object sender, EventArgs e)
        {
            txtBrojTelefonaClanaA.Text = OdabraniKorisnik.brojtelefona;
            txtEmailClanaA.Text = OdabraniKorisnik.email;
            txtImeClanaA.Text = OdabraniKorisnik.ime;
            txtPrezimeClanaA.Text = OdabraniKorisnik.prezime;
            cbClanarinaPlacenaAzurirajClana.Items.Add("Da");
            cbClanarinaPlacenaAzurirajClana.Items.Add("Ne");
            if (OdabraniKorisnik != null)
            {
                using (var context = new Entities1())
                {
                    var query1 = from nk in context.NovacKorisnikas.Include("Korisnik")
                                where nk.korisnik_korisnickoIme == OdabraniKorisnik.korisnickoIme
                                select new NovacKorisnikaView { StanjeNaRacunu = nk.stanjeNaRacunu };
                    //lblIznosNaRacunu.Text = query1.FirstOrDefault().StanjeNaRacunu.ToString();

                }
            }



        }

      

        
    }
}
