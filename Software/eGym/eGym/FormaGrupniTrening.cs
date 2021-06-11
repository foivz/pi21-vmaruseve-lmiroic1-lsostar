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
    public partial class FormaGrupniTrening : Form
    {
        public FormaGrupniTrening()
        {
            InitializeComponent();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno rezerviran trening.");
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FormaRezervacijaTreninga formaRezervacijaTreninga = new FormaRezervacijaTreninga();
            formaRezervacijaTreninga.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbVrstaVjezbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            VrstaVjezbe vrstaVjezbe = cmbVrstaVjezbe.SelectedItem as VrstaVjezbe;
            using(var context = new Entities_())
            {
                var upit = from t in context.Termins.Include("Korisnik").Include("Trening").Include("VrstaVjezbe")
                           where t.vrstaVjezbe_id == vrstaVjezbe.ID
                           select t;
                dgvGrupniTrening.DataSource = upit.ToList();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormaGrupniTrening_Load(object sender, EventArgs e)
        {
            
            DohvatiVrsteVjezbi();
        }

    

        private void DohvatiVrsteVjezbi()
        {
            using (var context = new Entities_())
            {
                var upit = from vv in context.VrstaVjezbes.Include("Termin")
                           select vv.naziv;
                cmbVrstaVjezbe.DataSource = upit.ToList();

            }
        }
    }
}
