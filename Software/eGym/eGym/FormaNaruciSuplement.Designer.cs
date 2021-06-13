
namespace eGym
{
    partial class FormaNaruciSuplement
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
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblPopisSuplemenata = new System.Windows.Forms.Label();
            this.lblIznosNaRacunu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.txtIznosNaRacunu = new System.Windows.Forms.TextBox();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.bsKosarica = new System.Windows.Forms.BindingSource(this.components);
            this.dgvNazivSuplementa = new System.Windows.Forms.DataGridView();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSuplementi = new System.Windows.Forms.BindingSource(this.components);
            this.btnOdaberi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsKosarica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNazivSuplementa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuplementi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNaruci
            // 
            this.btnNaruci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNaruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaruci.ForeColor = System.Drawing.Color.White;
            this.btnNaruci.Location = new System.Drawing.Point(434, 514);
            this.btnNaruci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(123, 50);
            this.btnNaruci.TabIndex = 69;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = false;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(216, 514);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(117, 50);
            this.btnNatrag.TabIndex = 68;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(113, 334);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(64, 18);
            this.lblKolicina.TabIndex = 64;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblPopisSuplemenata
            // 
            this.lblPopisSuplemenata.AutoSize = true;
            this.lblPopisSuplemenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisSuplemenata.Location = new System.Drawing.Point(39, 215);
            this.lblPopisSuplemenata.Name = "lblPopisSuplemenata";
            this.lblPopisSuplemenata.Size = new System.Drawing.Size(138, 18);
            this.lblPopisSuplemenata.TabIndex = 63;
            this.lblPopisSuplemenata.Text = "Popis suplemenata:";
            // 
            // lblIznosNaRacunu
            // 
            this.lblIznosNaRacunu.AutoSize = true;
            this.lblIznosNaRacunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIznosNaRacunu.Location = new System.Drawing.Point(60, 164);
            this.lblIznosNaRacunu.Name = "lblIznosNaRacunu";
            this.lblIznosNaRacunu.Size = new System.Drawing.Size(117, 18);
            this.lblIznosNaRacunu.TabIndex = 62;
            this.lblIznosNaRacunu.Text = "Iznos na računu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Naruči suplement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 60;
            this.label2.Text = "eGym";
            // 
            // lblUkupanIznos
            // 
            this.lblUkupanIznos.AutoSize = true;
            this.lblUkupanIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupanIznos.Location = new System.Drawing.Point(75, 440);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(103, 18);
            this.lblUkupanIznos.TabIndex = 64;
            this.lblUkupanIznos.Text = "Ukupan iznos:";
            // 
            // txtIznosNaRacunu
            // 
            this.txtIznosNaRacunu.Location = new System.Drawing.Point(205, 164);
            this.txtIznosNaRacunu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIznosNaRacunu.Name = "txtIznosNaRacunu";
            this.txtIznosNaRacunu.Size = new System.Drawing.Size(217, 22);
            this.txtIznosNaRacunu.TabIndex = 70;
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Location = new System.Drawing.Point(205, 436);
            this.txtUkupanIznos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.Size = new System.Drawing.Size(217, 22);
            this.txtUkupanIznos.TabIndex = 70;
            // 
            // bsKosarica
            // 
            this.bsKosarica.DataSource = typeof(Pristup_podacima.NaruceniSuplement);
            // 
            // dgvNazivSuplementa
            // 
            this.dgvNazivSuplementa.AutoGenerateColumns = false;
            this.dgvNazivSuplementa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNazivSuplementa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn});
            this.dgvNazivSuplementa.DataSource = this.bsSuplementi;
            this.dgvNazivSuplementa.Location = new System.Drawing.Point(205, 206);
            this.dgvNazivSuplementa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNazivSuplementa.Name = "dgvNazivSuplementa";
            this.dgvNazivSuplementa.RowHeadersWidth = 51;
            this.dgvNazivSuplementa.RowTemplate.Height = 24;
            this.dgvNazivSuplementa.Size = new System.Drawing.Size(549, 105);
            this.dgvNazivSuplementa.TabIndex = 0;
            this.dgvNazivSuplementa.SelectionChanged += new System.EventHandler(this.dgvNazivSuplementa_SelectionChanged);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(207, 334);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(217, 22);
            this.txtKolicina.TabIndex = 70;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "stanje";
            this.stanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            this.stanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsSuplementi
            // 
            this.bsSuplementi.DataSource = typeof(eGym.Suplement);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOdaberi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberi.ForeColor = System.Drawing.Color.White;
            this.btnOdaberi.Location = new System.Drawing.Point(210, 369);
            this.btnOdaberi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOdaberi.Size = new System.Drawing.Size(123, 50);
            this.btnOdaberi.TabIndex = 71;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // FormaNaruciSuplement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 612);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dgvNazivSuplementa);
            this.Controls.Add(this.txtUkupanIznos);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtIznosNaRacunu);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblUkupanIznos);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblPopisSuplemenata);
            this.Controls.Add(this.lblIznosNaRacunu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaNaruciSuplement";
            this.Text = "Naruči suplement";
            this.Load += new System.EventHandler(this.FormaNaruciSuplement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsKosarica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNazivSuplementa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuplementi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblPopisSuplemenata;
        private System.Windows.Forms.Label lblIznosNaRacunu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.TextBox txtIznosNaRacunu;
        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.DataGridView dgvNazivSuplementa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsSuplementi;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.BindingSource bsKosarica;
        private System.Windows.Forms.Button btnOdaberi;
    }
}