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
    public partial class FormaAzurirajSuplement : Form
    {
        public FormaAzurirajSuplement()
        {
            InitializeComponent();
        }

        private void btnNatragAzurirajSuplement_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void btnAzurirajSuplementA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste ažurirali suplement!");
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }
    }
}
