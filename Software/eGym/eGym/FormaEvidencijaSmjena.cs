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
            if (dtgEvidencijaSmjena.CurrentRow != null)
            {
                SmjenaZaposlenika smjena = dtgEvidencijaSmjena.CurrentRow.DataBoundItem as SmjenaZaposlenika;
                if (smjena != null)
                {
                    using (var context = new Entities6())
                    {
                        context.SmjenaZaposlenikas.Attach(smjena);
                        context.SmjenaZaposlenikas.Remove(smjena);
                        context.SaveChanges();
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
            using (var context = new Entities6())
            {
                var upit = from s in context.SmjenaZaposlenikas.Include("Smjena").Include("Korisnik")
                           select s;
                dtgEvidencijaSmjena.DataSource = upit.ToList();

            }
        }
    }
}
