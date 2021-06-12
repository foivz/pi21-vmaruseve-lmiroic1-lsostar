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
            foreach (Suplement s in VratiListuNarucenihSuplemenata())
            {
                
            }
        }
        private int VratiBrojProdanihSuplemenata(Suplement suplement)
        {
            int brojac = 0;
            using (var db = new Entities6())
            {
                int brojProdanihSuplemeneta = (from ns in db.NaruceniSuplements
                                               where ns.suplement_id == suplement.ID
                                               select ns.kolicina).FirstOrDefault();
                brojac = brojac+brojProdanihSuplemeneta;
            }
            return brojac;
        }
        private List<Suplement> VratiListuNarucenihSuplemenata()
        {
            List<Suplement> NaruceniSuplement = new List<Suplement>();
            using (var db = new Entities6())
            {
                var ProdaniSuplementi = (from ns in db.NaruceniSuplements
                                         from s in db.Suplements
                                               where ns.suplement_id == s.ID
                                               select s).ToList();
                NaruceniSuplement = ProdaniSuplementi;
            }
            return NaruceniSuplement;
        }
    }
}
