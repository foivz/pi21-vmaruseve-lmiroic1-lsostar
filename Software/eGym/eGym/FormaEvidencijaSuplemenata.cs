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
    public partial class FormaEvidencijaSuplemenata : Form
    {
        public FormaEvidencijaSuplemenata()
        {
            InitializeComponent();
        }

        private void btnNatragSuplement_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Hide();
        }

        private void btnDodajSSuplementE_Click(object sender, EventArgs e)
        {
            FormaDodajSuplement formaDodajSuplement = new FormaDodajSuplement();
            formaDodajSuplement.Show();
            this.Hide();
        }

        private void btnAzurirajSuplementE_Click(object sender, EventArgs e)
        {
            FormaAzurirajSuplement formaAzurirajSuplement = new FormaAzurirajSuplement();
            formaAzurirajSuplement.Show();
            this.Hide();
        }

        private void btnObrisiSuplementE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste obrisali suplement!");
        }
    }
}
