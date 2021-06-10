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
    public partial class FormaAzurirajSmjenu : Form
    {
        public FormaAzurirajSmjenu()
        {
            InitializeComponent();
        }

        private void btnAzurirajSmjenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ažurirana smjena.");
            FormaEvidencijaSmjena formaEvidencijaSmjena = new FormaEvidencijaSmjena();
            formaEvidencijaSmjena.Show();
            this.Hide();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSmjena formaEvidencijaSmjena = new FormaEvidencijaSmjena();
            formaEvidencijaSmjena.Show();
            this.Hide();
        }

        private void FormaAzurirajSmjenu_Load(object sender, EventArgs e)
        {

        }
    }
}
