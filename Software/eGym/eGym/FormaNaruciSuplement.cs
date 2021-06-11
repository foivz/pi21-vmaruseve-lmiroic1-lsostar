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
    public partial class FormaNaruciSuplement : Form
    {
        public Korisnik OdabraniKorisnik { get; set; }
        public Entities5 Entities { get; set; }

        public FormaNaruciSuplement(Korisnik korisnik)
        {
            InitializeComponent();
            OdabraniKorisnik = korisnik;
        }

        private void btnObrisiKosaricu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno obrisan suplement u košarici.");
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno naručen suplement.");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            formProfilClana profilClana = new formProfilClana();
            profilClana.Show();
            this.Hide();
        }

        private void btnUrediKosaricu_Click(object sender, EventArgs e)
        {
            FormaUrediKosaricu formaUrediKosaricu = new FormaUrediKosaricu();
            formaUrediKosaricu.Show();
            this.Hide();
        }

        private void FormaNaruciSuplement_Load(object sender, EventArgs e)
        {
            using (var context = new Entities5())
            {
                var upit = from nk in context.NovacKorisnikas.Include("Korisnik")
                            where nk.korisnik_korisnickoIme == OdabraniKorisnik.korisnickoIme
                            select new NovacKorisnikaView { StanjeNaRacunu = nk.stanjeNaRacunu };
                txtIznosNaRacunu.Text = upit.FirstOrDefault().StanjeNaRacunu.ToString();
            }

            using (var context = new Entities5())
            {
                var upit = from su in context.Suplements.Include("NaruceniSuplements")
                           select su;
                dgvNazivSuplementa.DataSource = upit.ToList();
            }
        }


        private void btnDodajSuplement_Click(object sender, EventArgs e)
        {
            Suplement suplement = dgvNazivSuplementa.CurrentRow.DataBoundItem as Suplement;
           
            using (var context = new Entities5())
            {
                var upit = from s in context.Suplements.Include("NaruceniSuplements")
                           where s.ID == suplement.ID
                           select s;
                dgvKosarica.DataSource = upit.ToList();

               
            }

            OsvjeziKosaricu();
            
        }

        private void OsvjeziKosaricu()
        {
            List<Suplement> listaSuplementi = new List<Suplement>();
            Suplement suplement = dgvNazivSuplementa.CurrentRow.DataBoundItem as Suplement;

            foreach (Suplement item in Entities.Suplements)
            {
                if (item.ID == suplement.ID)
                {
                    listaSuplementi.Add(item);
                }
            }
            
            dgvKosarica.DataSource = listaSuplementi;
        }
    

        private void dgvNazivSuplementa_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }

 }


