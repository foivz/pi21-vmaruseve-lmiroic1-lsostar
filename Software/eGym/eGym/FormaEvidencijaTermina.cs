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
    public partial class FormaEvidencijaTermina : Form
    {
        public FormaEvidencijaTermina()
        {
            InitializeComponent();
        }

        private void btnObrisiTermin_Click(object sender, EventArgs e)
        {

            if (dgvEvidencijaTermina.CurrentRow != null)
            {
                Termin termin = dgvEvidencijaTermina.CurrentRow.DataBoundItem as Termin;
                if (termin != null)
                {
                    using (var context = new Entities_())
                    {
                        context.Termins.Attach(termin);
                        context.Termins.Remove(termin);
                        context.SaveChanges();
                    }

                    Osvjezi();
                }
            }
            MessageBox.Show("Uspješno obrisan termin!");
        }

        private void btnNatragSuplement_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Hide();
        }

        private void btnDodajTerminE_Click(object sender, EventArgs e)
        {
            FormaDodajTermin formaDodajTermin = new FormaDodajTermin();
            formaDodajTermin.Show();
            this.Hide();
        }

        private void btnAzurirajTerminE_Click(object sender, EventArgs e)
        {
            
        }

        private void FormaEvidencijaTermina_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var context = new Entities_())
            {
                var upit = from t in context.Termins.Include("Trening").Include("Korisnik").Include("VrstaVjezbe")
                           select t;
                dgvEvidencijaTermina.DataSource = upit.ToList();

            }
        }
    }
}
