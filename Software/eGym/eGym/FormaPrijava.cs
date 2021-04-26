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
    public partial class FormaPrijava : Form
    {
        public FormaPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            formProfilClana formProfilClana = new formProfilClana();
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();

            formProfilClana.Show();
            formProfilZaposlenika.Show();
            this.Hide();

        }

        private void btnPrijavaNatrag_Click(object sender, EventArgs e)
        {
            PocetnaStranica1 pocetnaStranica = new PocetnaStranica1();
            pocetnaStranica.Show();
            this.Hide();
        }
    }
}
