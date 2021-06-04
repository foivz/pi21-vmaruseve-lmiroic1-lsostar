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
        public Korisnik Korisnik { get; set; }
        public FormaAzurirajClana(Korisnik korisnik)
        {
            InitializeComponent();
            Korisnik = korisnik;
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
            txtBrojTelefonaClanaA.Text = Korisnik.brojtelefona;
            txtEmailClanaA.Text = Korisnik.email;
            txtImeClanaA.Text = Korisnik.ime;
           
            txtPrezimeClanaA.Text = Korisnik.prezime;
            
        }
    }
}
