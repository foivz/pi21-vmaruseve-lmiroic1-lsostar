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
           /* using (var context = new Entities())
            {
                var upit = from ns in context.NaruceniSuplements
                           select new NaruceniSuplementView
                           {
                               SuplementID = ns.suplement_id,
                               Kolicina = ns.kolicina,
                               KorisnickoIme = ns.korisnik_korisnickoIme,
                               DatumNarudzbe = ns.datum_narudzbe
                           };
                List<NaruceniSuplementView> sviNaruceniSuplementi = upit.ToList();
                foreach (NaruceniSuplementView rezultat in sviNaruceniSuplementi)
                {
                    rezultat.DatumNarudzbe = rezultat.DatumNarudzbe.Date;
                }
                NaruceniSuplementBindingSource.DataSource = sviNaruceniSuplementi;

            }
            this.reportViewer1.Refresh(); */

            List<Pristup_podacima.Suplement> naruceniSuplementi = new List<Pristup_podacima.Suplement>();
            naruceniSuplementi = VratiListuNarucenihSuplemenata();
            NaruceniSuplementBindingSource.DataSource = null;
            NaruceniSuplementBindingSource.DataSource = naruceniSuplementi;
            this.reportViewer1.RefreshReport();

        }
        private int VratiBrojProdanihSuplemenata(Pristup_podacima.Suplement suplement)
        {
            int brojac = 0;
            using (var db = new Entities())
            {
                int brojProdanihSuplemeneta = (from ns in db.NaruceniSuplements
                                               where ns.suplement_id == suplement.ID
                                               select ns.kolicina).FirstOrDefault();
                brojac = brojac+brojProdanihSuplemeneta;
            }
            return brojac;
        }
        private List<Pristup_podacima.Suplement> VratiListuNarucenihSuplemenata()
        {
            List<Pristup_podacima.Suplement> NaruceniSuplementi = new List<Pristup_podacima.Suplement>();
            using (var db = new Entities())
            {
                var ProdaniSuplementi = (from ns in db.NaruceniSuplements
                                         from s in db.Suplements
                                               where ns.suplement_id == s.ID
                                               select s).ToList();
                NaruceniSuplementi = ProdaniSuplementi;
            }
            return NaruceniSuplementi;
        }


        private void btnPrintajIzvjesce_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void NaruceniSuplementBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
