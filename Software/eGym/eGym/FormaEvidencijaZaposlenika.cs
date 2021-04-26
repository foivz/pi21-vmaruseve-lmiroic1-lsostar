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
    public partial class FormaEvidencijaZaposlenika : Form
    {
        public FormaEvidencijaZaposlenika()
        {
            InitializeComponent();
        }

        private void btnAzurirajZaposlenika_Click(object sender, EventArgs e)
        {
            FormaAzurirajZaposlenika formaAzurirajZaposlenika = new FormaAzurirajZaposlenika();
            formaAzurirajZaposlenika.Show();
            this.Hide();
        }

        private void btnEvidencijaZaposlenikaNatrag_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Hide();
        }

        private void btnObrisiZaposlenika_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaposlenik uspješno obrisan!");
            
        }
    }
}
