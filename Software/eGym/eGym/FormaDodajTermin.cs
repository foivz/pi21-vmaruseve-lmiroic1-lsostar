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
    public partial class FormaDodajTermin : Form
    {
        public FormaDodajTermin()
        {
            InitializeComponent();
        }

        private void FormaDodajTermin_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno dodan termin!");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaEvidencijaTermina formaEvidencijaTermina = new FormaEvidencijaTermina();
            formaEvidencijaTermina.Show();
            this.Hide();
        }
    }
}
