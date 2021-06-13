using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pristup_podacima;
using Poslovna_logika;


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
           
                string naziv = txtNazivDodajSuplement.Text;
                decimal cijena = decimal.Parse(txtCijenaDodajSuplement.Text);
                int kolicina = int.Parse(txtKolicinaDodajSuplement.Text);
             

                Pristup_podacima.Suplement noviSuplement = new Pristup_podacima.Suplement
                {
                    
                    naziv = naziv,
                    cijena = cijena,
                    stanje = kolicina
                  
                };
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeSuplementimaDAL.UnosSuplementa(noviSuplement);

               
            
            MessageBox.Show("Uspješno ste dodali suplement!");
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void FormaDodajSuplement_Load(object sender, EventArgs e)
        {

        }

        private void FormaDodajSuplement_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
