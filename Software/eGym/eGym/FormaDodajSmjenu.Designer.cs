
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
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDodajSmjenu = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDodajSmjenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "eGym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj smjenu";
            // 
            // lblRadnoVrijeme
            // 
            this.lblRadnoVrijeme.AutoSize = true;
            this.lblRadnoVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnoVrijeme.Location = new System.Drawing.Point(51, 373);
            this.lblRadnoVrijeme.Name = "lblRadnoVrijeme";
            this.lblRadnoVrijeme.Size = new System.Drawing.Size(101, 18);
            this.lblRadnoVrijeme.TabIndex = 39;
            this.lblRadnoVrijeme.Text = "Naziv smjene:";
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(173, 372);
            this.cmbNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(217, 24);
            this.cmbNaziv.TabIndex = 42;
            // 
            // btnDodajSmjenu
            // 
            this.btnDodajSmjenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajSmjenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSmjenu.ForeColor = System.Drawing.Color.White;
            this.btnDodajSmjenu.Location = new System.Drawing.Point(561, 425);
            this.btnDodajSmjenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSmjenu.Name = "btnDodajSmjenu";
            this.btnDodajSmjenu.Size = new System.Drawing.Size(123, 50);
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
            this.btnNatrag.Location = new System.Drawing.Point(51, 425);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(117, 50);
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
            this.dgvZaposlenici.Location = new System.Drawing.Point(76, 160);
            this.dgvZaposlenici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.Size = new System.Drawing.Size(608, 185);
            this.dgvZaposlenici.TabIndex = 50;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumregistracijeDataGridViewTextBoxColumn
            // 
            this.datumregistracijeDataGridViewTextBoxColumn.DataPropertyName = "datum_registracije";
            this.datumregistracijeDataGridViewTextBoxColumn.HeaderText = "datum_registracije";
            this.datumregistracijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumregistracijeDataGridViewTextBoxColumn.Name = "datumregistracijeDataGridViewTextBoxColumn";
            this.datumregistracijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojtelefonaDataGridViewTextBoxColumn
            // 
            this.brojtelefonaDataGridViewTextBoxColumn.DataPropertyName = "brojtelefona";
            this.brojtelefonaDataGridViewTextBoxColumn.HeaderText = "brojtelefona";
            this.brojtelefonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojtelefonaDataGridViewTextBoxColumn.Name = "brojtelefonaDataGridViewTextBoxColumn";
            this.brojtelefonaDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsDodajSmjenu
            // 
            this.bsDodajSmjenu.DataSource = typeof(Pristup_podacima.Korisnik);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Datum:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(532, 373);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(151, 22);
            this.dtpDatum.TabIndex = 52;
            // 
            // FormaDodajSmjenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 572);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.btnDodajSmjenu);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.lblRadnoVrijeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaDodajSmjenu";
            this.Text = "Dodaj smjenu";
            this.Load += new System.EventHandler(this.FormaDodajSmjenu_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormaDodajSmjenu_HelpRequested);
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