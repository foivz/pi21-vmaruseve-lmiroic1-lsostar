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
    public partial class FormaEvidencijaClanova : Form
    {
        public FormaEvidencijaClanova()
        {
            InitializeComponent();
        }

        private void btnNatragEvidencijaClanova_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Hide();
        }

        private void btnAzurirajClanaE_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = dgvEvidencijaClanova.CurrentRow.DataBoundItem as Korisnik;

            FormaAzurirajClana formaAzurirajClana = new FormaAzurirajClana(korisnik);
            formaAzurirajClana.Show();
            this.Hide();
        }

        private void btnObrisiClanaE_Click(object sender, EventArgs e)
        {
           Korisnik korisnik = dgvEvidencijaClanova.CurrentRow.DataBoundItem as Korisnik;
           
            Osvjezi();
            MessageBox.Show("Uspješno obrisan član!");
        }

        public void Osvjezi()
        {
            using (var context = new Entities())
            {
                var upit = from k in context.Korisniks
                           where k.uloga_id == 3
                           orderby k.korisnickoIme ascending
                           select k;
                dgvEvidencijaClanova.DataSource = upit.ToList();

            }

        }

        private void dtgEvidencijaClanova_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormaEvidencijaClanova_Load(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var upit = from k in context.Korisniks
                           where k.uloga_id==3
                           orderby k.korisnickoIme ascending
                           select k;
                dgvEvidencijaClanova.DataSource = upit.ToList();

            }
        }

    }
}
