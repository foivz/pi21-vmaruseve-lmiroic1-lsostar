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
    public partial class FormaGrupniTrening : Form
    {
        public FormaGrupniTrening()
        {
            InitializeComponent();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno rezerviran trening.");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaRezervacijaTreninga formaRezervacijaTreninga = new FormaRezervacijaTreninga();
            formaRezervacijaTreninga.Show();
            this.Hide();
        }
    }
}
