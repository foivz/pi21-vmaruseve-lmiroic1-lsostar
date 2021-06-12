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
    public partial class FormaEvidencijaZaposlenika : Form
    {
        public FormaEvidencijaZaposlenika()
        {
            InitializeComponent();
        }

        private void btnAzurirajZaposlenika_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = dgvEvidencijaZaposlenika.CurrentRow.DataBoundItem as Korisnik;
            FormaAzurirajZaposlenika formaAzurirajZaposlenika = new FormaAzurirajZaposlenika(korisnik);
            formaAzurirajZaposlenika.Show();
            this.Close();
            Osvjezi();
        }

        private void btnEvidencijaZaposlenikaNatrag_Click(object sender, EventArgs e)
        {
            FormaAdmin formaAdmin = new FormaAdmin();
            formaAdmin.Show();
            this.Hide();
            Osvjezi();
        }

        private void btnObrisiZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvEvidencijaZaposlenika.CurrentRow != null)
            {
                Korisnik korisnik = dgvEvidencijaZaposlenika.CurrentRow.DataBoundItem as Korisnik;
                if (korisnik != null)
                {
                    using (var context = new Entities())
                    {
                        context.Korisniks.Attach(korisnik);
                        context.Korisniks.Remove(korisnik);
                        Pristup_podacima.Dohvaćanje_podataka.UpravljanjeKorisnicimaDAL.ObrisiZaposlenika(korisnik);
                    }

                    Osvjezi();
                }
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajZaposlenika frmDodajZaposlenika = new FrmDodajZaposlenika();
            frmDodajZaposlenika.Show();
            this.Hide();
        }

        private void FormaEvidencijaZaposlenika_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var context = new Entities())
            {
                var upit = from k in context.Korisniks
                           where k.uloga_id == 2
                           orderby k.korisnickoIme ascending
                           select k;
                dgvEvidencijaZaposlenika.DataSource = upit.ToList();

            }
        }

        
        
    }
}
