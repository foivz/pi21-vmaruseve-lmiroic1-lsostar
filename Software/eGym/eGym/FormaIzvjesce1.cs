using Pristup_podacima;
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
    public partial class FormaIzvjesce1 : Form
    {
       
        public FormaIzvjesce1()
        {
            InitializeComponent();
            
        }

        private void FormaIzvjesce1_Load(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var upit = from ns in db.NaruceniSuplements
                           select ns;
                bsNaruceniSuplement.DataSource = upit.ToList();
            }
            this.rwNaruceniSuplementi.RefreshReport();
        }

        private void btnNatragIzvjesce_Click(object sender, EventArgs e)
        {
            FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
            formProfilZaposlenika.Show();
            this.Close();
        }
    }
}
