
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
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.cmbKolicina = new System.Windows.Forms.ComboBox();
            this.cmbPopisSuplemenata = new System.Windows.Forms.ComboBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblPopisSuplemenata = new System.Windows.Forms.Label();
            this.lblIznosNaRacunu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.txtIznosNaRacunu = new System.Windows.Forms.TextBox();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.btnDodajSuplement = new System.Windows.Forms.Button();
            this.grbKosarica = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrediKosaricu = new System.Windows.Forms.Button();
            this.btnObrisiKosaricu = new System.Windows.Forms.Button();
            this.grbKosarica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNaruci
            // 
            this.btnNaruci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNaruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaruci.ForeColor = System.Drawing.Color.White;
            this.btnNaruci.Location = new System.Drawing.Point(302, 448);
            this.btnNaruci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(122, 50);
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
            this.btnNatrag.Location = new System.Drawing.Point(83, 448);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(117, 50);
            this.btnNatrag.TabIndex = 68;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.FormattingEnabled = true;
            this.cmbKolicina.Location = new System.Drawing.Point(206, 240);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(218, 24);
            this.cmbKolicina.TabIndex = 67;
            // 
            // cmbPopisSuplemenata
            // 
            this.cmbPopisSuplemenata.FormattingEnabled = true;
            this.cmbPopisSuplemenata.Location = new System.Drawing.Point(206, 201);
            this.cmbPopisSuplemenata.Name = "cmbPopisSuplemenata";
            this.cmbPopisSuplemenata.Size = new System.Drawing.Size(218, 24);
            this.cmbPopisSuplemenata.TabIndex = 65;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(113, 240);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(64, 18);
            this.lblKolicina.TabIndex = 64;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblPopisSuplemenata
            // 
            this.lblPopisSuplemenata.AutoSize = true;
            this.lblPopisSuplemenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisSuplemenata.Location = new System.Drawing.Point(39, 202);
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
            this.lblUkupanIznos.Location = new System.Drawing.Point(74, 346);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(103, 18);
            this.lblUkupanIznos.TabIndex = 64;
            this.lblUkupanIznos.Text = "Ukupan iznos:";
            // 
            // txtIznosNaRacunu
            // 
            this.txtIznosNaRacunu.Location = new System.Drawing.Point(206, 164);
            this.txtIznosNaRacunu.Name = "txtIznosNaRacunu";
            this.txtIznosNaRacunu.Size = new System.Drawing.Size(218, 22);
            this.txtIznosNaRacunu.TabIndex = 70;
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Location = new System.Drawing.Point(206, 342);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.Size = new System.Drawing.Size(218, 22);
            this.txtUkupanIznos.TabIndex = 70;
            // 
            // btnDodajSuplement
            // 
            this.btnDodajSuplement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajSuplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSuplement.ForeColor = System.Drawing.Color.White;
            this.btnDodajSuplement.Location = new System.Drawing.Point(206, 280);
            this.btnDodajSuplement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSuplement.Name = "btnDodajSuplement";
            this.btnDodajSuplement.Size = new System.Drawing.Size(218, 42);
            this.btnDodajSuplement.TabIndex = 69;
            this.btnDodajSuplement.Text = "Dodaj";
            this.btnDodajSuplement.UseVisualStyleBackColor = false;
            // 
            // grbKosarica
            // 
            this.grbKosarica.Controls.Add(this.dataGridView1);
            this.grbKosarica.Controls.Add(this.btnUrediKosaricu);
            this.grbKosarica.Controls.Add(this.btnObrisiKosaricu);
            this.grbKosarica.ForeColor = System.Drawing.Color.Black;
            this.grbKosarica.Location = new System.Drawing.Point(514, 116);
            this.grbKosarica.Name = "grbKosarica";
            this.grbKosarica.Size = new System.Drawing.Size(530, 282);
            this.grbKosarica.TabIndex = 71;
            this.grbKosarica.TabStop = false;
            this.grbKosarica.Text = "Košarica";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(491, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUrediKosaricu
            // 
            this.btnUrediKosaricu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUrediKosaricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediKosaricu.ForeColor = System.Drawing.Color.White;
            this.btnUrediKosaricu.Location = new System.Drawing.Point(52, 215);
            this.btnUrediKosaricu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrediKosaricu.Name = "btnUrediKosaricu";
            this.btnUrediKosaricu.Size = new System.Drawing.Size(122, 50);
            this.btnUrediKosaricu.TabIndex = 69;
            this.btnUrediKosaricu.Text = "Uredi";
            this.btnUrediKosaricu.UseVisualStyleBackColor = false;
            this.btnUrediKosaricu.Click += new System.EventHandler(this.btnUrediKosaricu_Click);
            // 
            // btnObrisiKosaricu
            // 
            this.btnObrisiKosaricu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiKosaricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKosaricu.ForeColor = System.Drawing.Color.White;
            this.btnObrisiKosaricu.Location = new System.Drawing.Point(350, 215);
            this.btnObrisiKosaricu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiKosaricu.Name = "btnObrisiKosaricu";
            this.btnObrisiKosaricu.Size = new System.Drawing.Size(122, 50);
            this.btnObrisiKosaricu.TabIndex = 69;
            this.btnObrisiKosaricu.Text = "Obriši";
            this.btnObrisiKosaricu.UseVisualStyleBackColor = false;
            this.btnObrisiKosaricu.Click += new System.EventHandler(this.btnObrisiKosaricu_Click);
            // 
            // FormaNaruciSuplement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 536);
            this.Controls.Add(this.grbKosarica);
            this.Controls.Add(this.txtUkupanIznos);
            this.Controls.Add(this.txtIznosNaRacunu);
            this.Controls.Add(this.btnDodajSuplement);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.cmbPopisSuplemenata);
            this.Controls.Add(this.lblUkupanIznos);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblPopisSuplemenata);
            this.Controls.Add(this.lblIznosNaRacunu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormaNaruciSuplement";
            this.Text = "Naruči suplement";
            this.grbKosarica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.ComboBox cmbKolicina;
        private System.Windows.Forms.ComboBox cmbPopisSuplemenata;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblPopisSuplemenata;
        private System.Windows.Forms.Label lblIznosNaRacunu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.TextBox txtIznosNaRacunu;
        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.Button btnDodajSuplement;
        private System.Windows.Forms.GroupBox grbKosarica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrediKosaricu;
        private System.Windows.Forms.Button btnObrisiKosaricu;
    }
}