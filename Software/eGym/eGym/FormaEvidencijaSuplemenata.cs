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
    public partial class FormaEvidencijaSuplemenata : Form
    {
        public FormaEvidencijaSuplemenata()
        {
            InitializeComponent();
        }

        private void btnNatragSuplement_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Hide();
        }

        private void btnDodajSSuplementE_Click(object sender, EventArgs e)
        {

            FormaDodajSuplement formaDodajSuplement = new FormaDodajSuplement();
            formaDodajSuplement.Show();
            this.Hide();
        }

        private void btnAzurirajSuplementE_Click(object sender, EventArgs e)
        {
            Pristup_podacima.Suplement suplement = dgvEvidencijaSuplemenata.CurrentRow.DataBoundItem as Pristup_podacima.Suplement;
            FormaAzurirajSuplement formaAzurirajSuplement = new FormaAzurirajSuplement(suplement);
            formaAzurirajSuplement.Show();
            this.Hide();
        }

        private void btnObrisiSuplementE_Click(object sender, EventArgs e)
        {
            if (dgvEvidencijaSuplemenata.CurrentRow != null)
            {
                Pristup_podacima.Suplement suplement = dgvEvidencijaSuplemenata.CurrentRow.DataBoundItem as Pristup_podacima.Suplement;
                if (suplement != null)
                {
                    using (var db = new Entities())
                    {
                        db.Suplements.Attach(suplement);
                        db.Suplements.Remove(suplement);
                        Pristup_podacima.Dohvaćanje_podataka.UpravljanjeSuplementimaDAL.ObrisiSuplement(suplement);
                    }

                    Osvjezi();
                }
            }
            MessageBox.Show("Uspješno ste obrisali suplement!");
        }

        private void FormaEvidencijaSuplemenata_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {
            using (var db = new Entities())
            {
                var upit = from s in db.Suplements.Include("NaruceniSuplements")
                           select s;
                dgvEvidencijaSuplemenata.DataSource = upit.ToList();

            }
        }

        private void FormaEvidencijaSuplemenata_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
