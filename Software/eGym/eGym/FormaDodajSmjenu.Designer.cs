﻿
namespace eGym
{
    partial class FormaDodajSmjenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRadnoVrijeme = new System.Windows.Forms.Label();
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.btnDodajSmjenu = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.bsDodajSmjenu = new System.Windows.Forms.BindingSource(this.components);
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDodajSmjenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "eGym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj smjenu";
            // 
            // lblRadnoVrijeme
            // 
            this.lblRadnoVrijeme.AutoSize = true;
            this.lblRadnoVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnoVrijeme.Location = new System.Drawing.Point(38, 303);
            this.lblRadnoVrijeme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadnoVrijeme.Name = "lblRadnoVrijeme";
            this.lblRadnoVrijeme.Size = new System.Drawing.Size(84, 15);
            this.lblRadnoVrijeme.TabIndex = 39;
            this.lblRadnoVrijeme.Text = "Naziv smjene:";
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(130, 302);
            this.cmbNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(164, 21);
            this.cmbNaziv.TabIndex = 42;
            // 
            // btnDodajSmjenu
            // 
            this.btnDodajSmjenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajSmjenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSmjenu.ForeColor = System.Drawing.Color.White;
            this.btnDodajSmjenu.Location = new System.Drawing.Point(421, 345);
            this.btnDodajSmjenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajSmjenu.Name = "btnDodajSmjenu";
            this.btnDodajSmjenu.Size = new System.Drawing.Size(92, 41);
            this.btnDodajSmjenu.TabIndex = 49;
            this.btnDodajSmjenu.Text = "Dodaj smjenu";
            this.btnDodajSmjenu.UseVisualStyleBackColor = false;
            this.btnDodajSmjenu.Click += new System.EventHandler(this.btnDodajSmjenu_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(38, 345);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(88, 41);
            this.btnNatrag.TabIndex = 48;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.datumregistracijeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.bsDodajSmjenu;
            this.dgvZaposlenici.Location = new System.Drawing.Point(57, 130);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.Size = new System.Drawing.Size(456, 150);
            this.dgvZaposlenici.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Datum:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(399, 303);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(114, 20);
            this.dtpDatum.TabIndex = 52;
            // 
            // bsDodajSmjenu
            // 
            this.bsDodajSmjenu.DataSource = typeof(Pristup_podacima.Korisnik);
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            // 
            // datumregistracijeDataGridViewTextBoxColumn
            // 
            this.datumregistracijeDataGridViewTextBoxColumn.DataPropertyName = "datum_registracije";
            this.datumregistracijeDataGridViewTextBoxColumn.HeaderText = "datum_registracije";
            this.datumregistracijeDataGridViewTextBoxColumn.Name = "datumregistracijeDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // brojtelefonaDataGridViewTextBoxColumn
            // 
            this.brojtelefonaDataGridViewTextBoxColumn.DataPropertyName = "brojtelefona";
            this.brojtelefonaDataGridViewTextBoxColumn.HeaderText = "brojtelefona";
            this.brojtelefonaDataGridViewTextBoxColumn.Name = "brojtelefonaDataGridViewTextBoxColumn";
            // 
            // FormaDodajSmjenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 465);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.btnDodajSmjenu);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.lblRadnoVrijeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaDodajSmjenu";
            this.Text = "Dodaj smjenu";
            this.Load += new System.EventHandler(this.FormaDodajSmjenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDodajSmjenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRadnoVrijeme;
        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.Button btnDodajSmjenu;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumregistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsDodajSmjenu;
    }
}