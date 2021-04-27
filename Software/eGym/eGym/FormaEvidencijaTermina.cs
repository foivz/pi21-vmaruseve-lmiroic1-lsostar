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
            FormaAzurirajTermin formaAzurirajTermin = new FormaAzurirajTermin();
            formaAzurirajTermin.Show();
            this.Hide();
        }
    }
}
