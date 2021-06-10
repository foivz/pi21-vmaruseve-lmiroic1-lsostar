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
    public partial class FormaAzurirajTermin : Form
    {
        public FormaAzurirajTermin()
        {
            InitializeComponent();
        }

        private void btnAzurirajTermin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ažuriran termin!");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaTermina formaEvidencijaTermina = new FormaEvidencijaTermina();
            formaEvidencijaTermina.Show();
            this.Hide();
        }

        private void FormaAzurirajTermin_Load(object sender, EventArgs e)
        {

        }
    }
}
