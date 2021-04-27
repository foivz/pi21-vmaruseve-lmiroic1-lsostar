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
    public partial class FormaNaruciSuplement : Form
    {
        public FormaNaruciSuplement()
        {
            InitializeComponent();
        }

        private void btnObrisiKosaricu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno obrisan suplement u košarici.");
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno naručen suplement.");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            formProfilClana profilClana = new formProfilClana();
            profilClana.Show();
            this.Hide();
        }

        private void btnUrediKosaricu_Click(object sender, EventArgs e)
        {
            FormaUrediKosaricu formaUrediKosaricu = new FormaUrediKosaricu();
            formaUrediKosaricu.Show();
            this.Hide();
        }
    }
}
