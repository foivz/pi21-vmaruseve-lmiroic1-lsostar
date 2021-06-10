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
    public partial class FormaAzurirajSuplement : Form
    {
        public Suplement OdabraniSuplement { get; set; }
        public FormaAzurirajSuplement(Suplement suplement)
        {
            
            InitializeComponent();
            OdabraniSuplement = suplement;
        }

        private void btnNatragAzurirajSuplement_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void btnAzurirajSuplementA_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Suplements.Attach(OdabraniSuplement);
                OdabraniSuplement.naziv = txtNazivAzurirajSuplement.Text;
                OdabraniSuplement.stanje = int.Parse(txtKolicinaAzurirajSuplement.Text);
                OdabraniSuplement.cijena = decimal.Parse(txtCijenaAzurirajSuplement.Text);
       
                context.SaveChanges();
            }
            MessageBox.Show("Uspješno ste ažurirali suplement!");
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void FormaAzurirajSuplement_Load(object sender, EventArgs e)
        {
            txtNazivAzurirajSuplement.Text = OdabraniSuplement.naziv;
            txtKolicinaAzurirajSuplement.Text = OdabraniSuplement.stanje.ToString();
            txtCijenaAzurirajSuplement.Text = OdabraniSuplement.cijena.ToString();

        }
    }
}
