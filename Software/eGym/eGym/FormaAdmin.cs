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
    public partial class FormaAdmin : Form
    {
        public FormaAdmin()
        {
            InitializeComponent();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.Show();
            this.Hide();
        }

        private void btnSmjene_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSmjena formaEvidencijaSmjena = new FormaEvidencijaSmjena();
            formaEvidencijaSmjena.Show();
            this.Hide();
        }

        private void FormaAdmin_Load(object sender, EventArgs e)
        {

            lblImeIPrezimeAdmina.Text = Sesija.PrijavljeniKorisnik.ime + " " + Sesija.PrijavljeniKorisnik.prezime;

            txtImeAdmina.Text = Sesija.PrijavljeniKorisnik.ime;
            txtPrezimeAdmina.Text = Sesija.PrijavljeniKorisnik.prezime;
            txtBrojTelefonaAdmina.Text = Sesija.PrijavljeniKorisnik.brojtelefona;
            txtEmailAdmina.Text = Sesija.PrijavljeniKorisnik.email;
            
            

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {


        }
    }
}
