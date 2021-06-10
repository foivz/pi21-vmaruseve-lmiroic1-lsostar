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

        private void btnAzurirajClanaE_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = dgvEvidencijaClanova.CurrentRow.DataBoundItem as Korisnik;
            FormaAzurirajClana formaAzurirajClana = new FormaAzurirajClana(korisnik);
            formaAzurirajClana.Show();
            this.Close();
            Osvjezi();
        }
        private void Osvjezi()
        {
            using (var context = new Entities5())
            {
                var upit = from k in context.Korisniks
                           where k.uloga_id == 3
                           orderby k.korisnickoIme ascending
                           select k;
                dgvEvidencijaClanova.DataSource = upit.ToList();

            }
        }

        private void btnObrisiClanaE_Click(object sender, EventArgs e)
        {
            if (dgvEvidencijaClanova.CurrentRow != null)
            {
                Korisnik korisnik = dgvEvidencijaClanova.CurrentRow.DataBoundItem as Korisnik;
                if (korisnik != null)
                {
                    using (var context = new Entities5())
                    {
                        context.Korisniks.Attach(korisnik);
                        context.Korisniks.Remove(korisnik);
                        context.SaveChanges();
                    }

                    Osvjezi();
                }
            }

        }

        private void FormaEvidencijaClanova_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnNatragClanovi_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formaZaposlenik = new FormProfilZaposlenika();
            formaZaposlenik.Show();
            this.Hide();
            Osvjezi();

        }
    }
}
