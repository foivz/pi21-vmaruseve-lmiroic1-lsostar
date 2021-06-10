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
    public partial class FormaUrediProfilClana : Form
    {
        public FormaUrediProfilClana()
        {
            InitializeComponent();
        }

        private void btnSpremiUrediProfilClana_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste spremili promjene!");
        }

        private void btnNatragUrediProfilClana_Click(object sender, EventArgs e)
        {
            formProfilClana formaProfilClana = new formProfilClana();
            formaProfilClana.Show();
            this.Hide();
        }

        private void FormaUrediProfilClana_Load(object sender, EventArgs e)
        {

        }
    }
}
