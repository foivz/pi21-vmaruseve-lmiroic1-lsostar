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
    public partial class FormaPlatiClanarinu : Form
    {
        public FormaPlatiClanarinu()
        {
            InitializeComponent();
        }

        private void btnPlatiClanarinuOdustani_Click(object sender, EventArgs e)
        {
            formProfilClana formProfilClana = new formProfilClana();
            formProfilClana.Show();
            this.Hide();
        }

        private void btnPlatiClanarinu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Članarina uspješno plaćena!");
            formProfilClana formProfilClana = new formProfilClana();
            formProfilClana.Show();
            this.Hide();
        }
    }
}
