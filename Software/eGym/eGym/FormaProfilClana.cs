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
    public partial class formProfilClana : Form
    {
        public formProfilClana()
        {
            InitializeComponent();
        }

        private void lblVrijediDo_Click(object sender, EventArgs e)
        {

        }

        private void btnPlatiClanarinu_Click(object sender, EventArgs e)
        {
            FormaPlatiClanarinu formaPlatiClanarinu = new FormaPlatiClanarinu();
            formaPlatiClanarinu.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PocetnaStranica1 pocetnaStranica = new PocetnaStranica1();
            pocetnaStranica.Show();
            this.Hide();
        }

        private void btnNaruciSuplement_Click(object sender, EventArgs e)
        {
            FormaNaruciSuplement formaNaruciSuplement = new FormaNaruciSuplement();
            formaNaruciSuplement.Show();
            this.Hide();
        }

        private void btnRezervacijaTreninga_Click(object sender, EventArgs e)
        {
            FormaRezervacijaTreninga formaRezervacijaTreninga = new FormaRezervacijaTreninga();
            formaRezervacijaTreninga.Show();
            this.Hide();
        }
    }
}
