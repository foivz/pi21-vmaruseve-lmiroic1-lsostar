using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Pristup_podacima;
using Poslovna_logika;


namespace eGym
{
    public partial class FormaIzvjesce : Form
    {
        public FormaIzvjesce()
        {
            InitializeComponent();
        }

        private void btnNatragIzvjesce_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Hide();
        }

        private void FormaIzvjesce_Load(object sender, EventArgs e)
        {
            List<NaruceniSuplement> sviNaruceniSuplementi = new List<NaruceniSuplement>();
            using (var context = new Entities())
            {
                var upit = from ns in context.NaruceniSuplements.Include("Korisnik").Include("Suplement")
                           select ns;
                 sviNaruceniSuplementi= upit.ToList();         
            }
            NaruceniSuplementBindingSource.DataSource = null;
            NaruceniSuplementBindingSource.DataSource = sviNaruceniSuplementi;
            this.reportViewer1.RefreshReport(); 

           
        }
        
    }
}
