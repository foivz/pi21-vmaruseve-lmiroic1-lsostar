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
    public partial class formProfilClana : Form
    {

        public Korisnik Korisnik { get; set; }
        public formProfilClana()
        {
            InitializeComponent();
            

        }

        private void lblVrijediDo_Click(object sender, EventArgs e)
        {

        }

        private void btnPlatiClanarinu_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = Sesija.PrijavljeniKorisnik;
            FormaPlatiClanarinu formaPlatiClanarinu = new FormaPlatiClanarinu(korisnik);
            formaPlatiClanarinu.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Sesija.PrijavljeniKorisnik = null;
            PocetnaStranica1 pocetnaStranica = new PocetnaStranica1();
            pocetnaStranica.Show();
            this.Hide();
        }

        private void btnNaruciSuplement_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = Sesija.PrijavljeniKorisnik;
            FormaNaruciSuplement formaNaruciSuplement = new FormaNaruciSuplement(korisnik);
            formaNaruciSuplement.Show();
            this.Hide();
        }

        private void btnRezervacijaTreninga_Click(object sender, EventArgs e)
        {
            FormaRezervacijaTreninga formaRezervacijaTreninga = new FormaRezervacijaTreninga();
            formaRezervacijaTreninga.Show();
            this.Hide();
        }

        private void txtClanarinaPlacena_TextChanged(object sender, EventArgs e)
        {
           
        }
        List<Clanarina> clanarinas = new List<Clanarina>();

        private void formProfilClana_Load(object sender, EventArgs e)
        {
            lblImeIPrezimeClana.Text = Sesija.PrijavljeniKorisnik.ime + " " + Sesija.PrijavljeniKorisnik.prezime;
            txtImeClana.Text = Sesija.PrijavljeniKorisnik.ime;
            txtPrezimeClana.Text = Sesija.PrijavljeniKorisnik.prezime;
            txtBrojTelefonaClana.Text = Sesija.PrijavljeniKorisnik.brojtelefona;
            txtEmailClana.Text = Sesija.PrijavljeniKorisnik.email;
            using (var context = new Entities())
            {
                var query = from c in context.Clanarinas.Include("Korisnik")
                            where c.korisnik_korisnickoIme == Sesija.PrijavljeniKorisnik.korisnickoIme
                            orderby c.ID
                            select c;

                foreach (var item in query)
                {
                    clanarinas.Add(item);
                }

                DateTime vrijediDo = clanarinas.Last().vrijedi_do;
                DateTime vrijediOd = clanarinas.Last().vrijedi_od;

                lblOd.Text = vrijediOd.Date.ToString();
                lblDo.Text = vrijediDo.Date.ToString();
            }
            

            
            
            
            


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void formProfilClana_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
