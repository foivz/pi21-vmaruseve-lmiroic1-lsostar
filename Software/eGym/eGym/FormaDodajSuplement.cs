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
    public partial class FormaDodajSuplement : Form
    {
        public FormaDodajSuplement()
        {
            InitializeComponent();
        }

        private void btnNatragDodajSuplement_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void btnDodajSuplementD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste dodali suplement!");
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }
    }
}
