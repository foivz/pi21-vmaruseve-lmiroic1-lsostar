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
    public partial class FormaEvidencijaSmjena : Form
    {
        public FormaEvidencijaSmjena()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajSmjenuE_Click(object sender, EventArgs e)
        {
            FormaDodajSmjenu formaDodajSmjenu = new FormaDodajSmjenu();
            formaDodajSmjenu.Show();
            this.Hide();
        }

        private void btnAzurirajSmjenuE_Click(object sender, EventArgs e)
        {
           
        }

        private void btnObrisiSmjenuE_Click(object sender, EventArgs e)
        {
            if (dgvEvidencijaSmjena.CurrentRow != null)
            {
                SmjenaZaposlenika smjena = dgvEvidencijaSmjena.CurrentRow.DataBoundItem as SmjenaZaposlenika;
                if (smjena != null)
                {
                    using (var db = new Entities())
                    {
                        db.SmjenaZaposlenikas.Attach(smjena);
                        db.SmjenaZaposlenikas.Remove(smjena);

                        Pristup_podacima.Dohvaćanje_podataka.UpravljanjeSmjenamaDAL.ObrisiSmjenuKorisnika(smjena);
                    }

                    Osvjezi();
                }
            }
            
            MessageBox.Show("Uspješno obrisana smjena.");
        }

        private void btnNatragSmjena_Click(object sender, EventArgs e)
        {
            FormaAdmin formAdmin = new FormaAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void FormaEvidencijaSmjena_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var db = new Entities())
            {
                var upit = (from s in db.SmjenaZaposlenikas.Include("Smjena").Include("Korisnik")
                            select s).ToList();
                dgvEvidencijaSmjena.DataSource = null;
                dgvEvidencijaSmjena.DataSource = upit;
            }
        }

        private void FormaEvidencijaSmjena_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
