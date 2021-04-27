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
    public partial class FormaUrediKosaricu : Form
    {
        public FormaUrediKosaricu()
        {
            InitializeComponent();
        }

        private void FormaUrediKosaricu_Load(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ažurirana košarica.");
            FormaNaruciSuplement formaNaruciSuplement = new FormaNaruciSuplement();
            formaNaruciSuplement.Show();
            this.Hide();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaNaruciSuplement formaNaruciSuplement = new FormaNaruciSuplement();
            formaNaruciSuplement.Show();
            this.Hide();
        }
    }
}
