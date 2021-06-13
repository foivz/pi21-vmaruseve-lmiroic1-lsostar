﻿using System;
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
    public partial class FormaRezervacijaTreninga : Form
    {
        public FormaRezervacijaTreninga()
        {
            InitializeComponent();
        }

        private void btnGrupniTrening_Click(object sender, EventArgs e)
        {
            FormaGrupniTrening formaGrupniTrening = new FormaGrupniTrening();
            formaGrupniTrening.Show();
            this.Hide();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            formProfilClana formProfilClana = new formProfilClana();
            formProfilClana.Show();
            this.Hide();
        }

        private void btnIndividualniTrening_Click(object sender, EventArgs e)
        {
            FormIndividualniTrening formIndividualniTrening = new FormIndividualniTrening();
            formIndividualniTrening.Show();
            this.Hide();
        }

        private void FormaRezervacijaTreninga_Load(object sender, EventArgs e)
        {

        }

        private void FormaRezervacijaTreninga_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "eGym_Help.chm", HelpNavigator.Topic, "O aplikaciji.html");
        }
    }
}
