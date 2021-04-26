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
    public partial class FormaAzurirajZaposlenika : Form
    {
        public FormaAzurirajZaposlenika()
        {
            InitializeComponent();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAzurirajZaposlenikaNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.Show();
            this.Hide();
        }

        private void btnAzuriraj_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Korisnik uspješno ažuriran!!");
            FormaEvidencijaZaposlenika formaEvidencijaZaposlenika = new FormaEvidencijaZaposlenika();
            formaEvidencijaZaposlenika.Show();
            this.Hide();
        }
    }
}
