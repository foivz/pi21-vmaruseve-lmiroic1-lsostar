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
    public partial class FormaUrediProfilZaposlenika : Form
    {
        public FormaUrediProfilZaposlenika()
        {
            InitializeComponent();
        }

        private void btnNatrahUrediProfilZaposlenika_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Hide();
        }

        private void btnSpremiUrediProfilZaposlenika_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste spremili promjene!");
        }

        private void FormaUrediProfilZaposlenika_Load(object sender, EventArgs e)
        {

        }
    }
}
