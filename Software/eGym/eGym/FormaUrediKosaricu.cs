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
        public Suplement OdabraniSuplement { get; set; }
        public FormaUrediKosaricu(Suplement suplement)
        {
            InitializeComponent();
            OdabraniSuplement = suplement;
        }

        private void FormaUrediKosaricu_Load(object sender, EventArgs e)
        {
            txtNazivSuplementa.Text = OdabraniSuplement.naziv;

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPopisSuplemenata_Click(object sender, EventArgs e)
        {

        }
    }
}
