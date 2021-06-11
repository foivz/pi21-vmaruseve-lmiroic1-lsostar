using eGym.Iznimke;
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
    public partial class FormaPrijava : Form
    {
        public FormaPrijava()
        {
            InitializeComponent();
        }

        
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Entities6())
                {
                    string username = txtUsernamePrijava.Text;
                    string lozinka = txtLozinkaPrijava.Text;

                    Korisnik korisnik = Prijava.DohvatiKorisnika(username, lozinka);



                    if (korisnik != null)
                    {
                        Sesija.PrijavljeniKorisnik = korisnik;

                    }

                    else
                    {
                        ValidacijaProfila();

                    }

                    if (Sesija.PrijavljeniKorisnik.uloga_id == 3)
                    {

                        formProfilClana formProfilClana = new formProfilClana();
                        formProfilClana.Show();
                        this.Hide();

                    }
                    else if (Sesija.PrijavljeniKorisnik.uloga_id == 2)
                    {
                        FormProfilZaposlenika formProfilZaposlenika = new FormProfilZaposlenika();
                        formProfilZaposlenika.Show();
                        this.Hide();
                    }
                    else if (Sesija.PrijavljeniKorisnik.uloga_id == 1)
                    {
                        FormaAdmin formaAdmin = new FormaAdmin();
                        formaAdmin.Show();
                        this.Hide();
                    }


                }
            }
            catch (NovaIznimka ex)
            {

                MessageBox.Show(ex.poruka);
            }

            


        }

        private void ValidacijaProfila()
        {
            if (Sesija.PrijavljeniKorisnik == null)
            {
                throw new NovaIznimka("Ne postoji taj korisnik.");
            }
        }

        private void btnPrijavaNatrag_Click(object sender, EventArgs e)
        {
            PocetnaStranica1 pocetnaStranica = new PocetnaStranica1();
            pocetnaStranica.Show();
            this.Hide();
        }

        private void FormaPrijava_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
