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
            using (var context = new Entities6())
            {
                context.Korisniks.Attach(OdabraniKorisnik);
                OdabraniKorisnik.ime = txtImeClanaA.Text;
                OdabraniKorisnik.prezime = txtPrezimeClanaA.Text;
                OdabraniKorisnik.email = txtEmailClanaA.Text;
                OdabraniKorisnik.brojtelefona = txtBrojTelefonaClanaA.Text;
                OdabraniKorisnik.stanjeNaRacunu = decimal.Parse(txtIznosNaRacunuA.Text);
                context.SaveChanges();
            }
            
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
            txtIznosNaRacunuA.Text = OdabraniKorisnik.stanjeNaRacunu.ToString();

        }

      

        
    }
}
