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
    public partial class PocetnaStranica1 : Form
    {
        public PocetnaStranica1()
        {
            InitializeComponent();
        }

        private void btnOdaberiPrijava_Click(object sender, EventArgs e)
        {
            FormaPrijava formaPrijava = new FormaPrijava();
            formaPrijava.Show();
            this.Hide();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FormaRegistracija formaRegistracija = new FormaRegistracija();
            formaRegistracija.Show();
            this.Hide();
        }
    }
}
