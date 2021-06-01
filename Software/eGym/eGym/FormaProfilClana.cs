﻿using System;
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
            FormaPlatiClanarinu formaPlatiClanarinu = new FormaPlatiClanarinu();
            formaPlatiClanarinu.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PocetnaStranica1 pocetnaStranica = new PocetnaStranica1();
            pocetnaStranica.Show();
            this.Hide();
        }

        private void btnNaruciSuplement_Click(object sender, EventArgs e)
        {
            FormaNaruciSuplement formaNaruciSuplement = new FormaNaruciSuplement();
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

        private void formProfilClana_Load(object sender, EventArgs e)
        {
            cbClanarinaPlacenaProfilClana.Enabled = false;
            dtpVrijediDo.Enabled = false;
            dtpVrijediOd.Enabled = false;
            txtIznosNaRacunu.Enabled = false;

            cbClanarinaPlacenaProfilClana.Enabled = false;
            dtpVrijediDo.Enabled = false;
            dtpVrijediOd.Enabled = false;
            txtIznosNaRacunu.Enabled = false;

            txtImeClana.Text = Sesija.PrijavljeniKorisnik.ime;
            txtPrezimeClana.Text = Sesija.PrijavljeniKorisnik.prezime;
            txtBrojTelefonaClana.Text = Sesija.PrijavljeniKorisnik.brojtelefona;
            txtEmailClana.Text = Sesija.PrijavljeniKorisnik.email;
            


        }

        private void btnUrediProfil_Click(object sender, EventArgs e)
        {
            FormaUrediProfilClana formaUrediProfil = new FormaUrediProfilClana();
            formaUrediProfil.Show();
            this.Hide();
        }
    }
}