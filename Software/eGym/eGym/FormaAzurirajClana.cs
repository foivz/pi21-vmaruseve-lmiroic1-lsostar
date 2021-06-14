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
            OdabraniKorisnik.ime = txtImeClana.Text;
            OdabraniKorisnik.prezime = txtPrezimeClana.Text;
            OdabraniKorisnik.email = txtEmailClana.Text;
            OdabraniKorisnik.brojtelefona = txtBrojTelefonaClana.Text;
            OdabraniKorisnik.stanjeNaRacunu = decimal.Parse(txtIznosNaRacunu.Text);
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeKorisnicimaDAL.AzuriranjeClana(OdabraniKorisnik);
            
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
            txtBrojTelefonaClana.Text = OdabraniKorisnik.brojtelefona;
            txtEmailClana.Text = OdabraniKorisnik.email;
            txtImeClana.Text = OdabraniKorisnik.ime;
            txtPrezimeClana.Text = OdabraniKorisnik.prezime;
            txtIznosNaRacunu.Text = OdabraniKorisnik.stanjeNaRacunu.ToString();

        }

        private void FormaAzurirajClana_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
