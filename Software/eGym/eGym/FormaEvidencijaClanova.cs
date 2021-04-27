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
            FormaAzurirajClana formaAzurirajClana = new FormaAzurirajClana();
            formaAzurirajClana.Show();
            this.Hide();
        }

        private void btnObrisiClanaE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno obrisan član!");
        }
    }
}
