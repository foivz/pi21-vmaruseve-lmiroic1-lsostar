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
    public partial class FormaDodajSuplement : Form
    {
        public FormaDodajSuplement()
        {
            InitializeComponent();
        }

        private void btnNatragDodajSuplement_Click(object sender, EventArgs e)
        {
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void btnDodajSuplementD_Click(object sender, EventArgs e)
        {
            using (var context = new Entities5())
            {
                string naziv = txtNazivDodajSuplement.Text;
                decimal cijena = decimal.Parse(txtCijenaDodajSuplement.Text);
                int kolicina = int.Parse(txtKolicinaDodajSuplement.Text);
             

                Suplement noviSuplement = new Suplement
                {
                    
                    naziv = naziv,
                    cijena = cijena,
                    stanje = kolicina
                  
                };

                context.Suplements.Add(noviSuplement);
                context.SaveChanges();
            }
            MessageBox.Show("Uspješno ste dodali suplement!");
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void FormaDodajSuplement_Load(object sender, EventArgs e)
        {

        }
    }
}
