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
    public partial class FormaAzurirajSuplement : Form
    {
        public Pristup_podacima.Suplement OdabraniSuplement { get; set; }
        public FormaAzurirajSuplement(Pristup_podacima.Suplement suplement)
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

            OdabraniSuplement.naziv = txtNazivSuplementa.Text;
            OdabraniSuplement.stanje = int.Parse(txtKolicinaSuplementa.Text);
            OdabraniSuplement.cijena = decimal.Parse(txtCijenaSuplementa.Text);
            Pristup_podacima.Dohvaćanje_podataka.UpravljanjeSuplementimaDAL.AzuriranjeSuplementa(OdabraniSuplement);
            MessageBox.Show("Uspješno ste ažurirali suplement!");
            FormaEvidencijaSuplemenata formaEvidencijaSuplemenata = new FormaEvidencijaSuplemenata();
            formaEvidencijaSuplemenata.Show();
            this.Hide();
        }

        private void FormaAzurirajSuplement_Load(object sender, EventArgs e)
        {
            txtNazivSuplementa.Text = OdabraniSuplement.naziv;
            txtKolicinaSuplementa.Text = OdabraniSuplement.stanje.ToString();
            txtCijenaSuplementa.Text = OdabraniSuplement.cijena.ToString();

        }

        private void FormaAzurirajSuplement_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
