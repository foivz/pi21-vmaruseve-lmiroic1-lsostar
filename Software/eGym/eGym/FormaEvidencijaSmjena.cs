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
            FormaAzurirajSmjenu formaAzurirajSmjenu = new FormaAzurirajSmjenu();
            formaAzurirajSmjenu.Show();
            this.Hide();
        }

        private void btnObrisiSmjenuE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno obrisana smjena.");
        }

        private void btnNatragSmjena_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Hide();
        }

        private void FormaEvidencijaSmjena_Load(object sender, EventArgs e)
        {

        }
    }
}
