
namespace eGym
{
    partial class FormaEvidencijaZaposlenika
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEvidencijaZaposlenika = new System.Windows.Forms.DataGridView();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEvidencijaZaposlenika = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnAzurirajZaposlenika = new System.Windows.Forms.Button();
            this.btnObrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnEvidencijaZaposlenikaNatrag = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvidencijaZaposlenika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(349, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Evidencija zaposlenika";
            // 
            // dgvEvidencijaZaposlenika
            // 
            this.dgvEvidencijaZaposlenika.AutoGenerateColumns = false;
            this.dgvEvidencijaZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaZaposlenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.datumregistracijeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn});
            this.dgvEvidencijaZaposlenika.DataSource = this.bsEvidencijaZaposlenika;
            this.dgvEvidencijaZaposlenika.Location = new System.Drawing.Point(16, 142);
            this.dgvEvidencijaZaposlenika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEvidencijaZaposlenika.Name = "dgvEvidencijaZaposlenika";
            this.dgvEvidencijaZaposlenika.RowHeadersWidth = 51;
            this.dgvEvidencijaZaposlenika.Size = new System.Drawing.Size(1035, 289);
            this.dgvEvidencijaZaposlenika.TabIndex = 5;
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
            // bsEvidencijaZaposlenika
            // 
            this.bsEvidencijaZaposlenika.DataSource = typeof(Pristup_podacima.Korisnik);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 55);
            this.label2.TabIndex = 24;
            this.label2.Text = "eGym";
            // 
            // btnAzurirajZaposlenika
            // 
            this.btnAzurirajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAzurirajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajZaposlenika.Location = new System.Drawing.Point(804, 448);
            this.btnAzurirajZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzurirajZaposlenika.Name = "btnAzurirajZaposlenika";
            this.btnAzurirajZaposlenika.Size = new System.Drawing.Size(105, 47);
            this.btnAzurirajZaposlenika.TabIndex = 25;
            this.btnAzurirajZaposlenika.Text = "Ažuriraj";
            this.btnAzurirajZaposlenika.UseVisualStyleBackColor = false;
            this.btnAzurirajZaposlenika.Click += new System.EventHandler(this.btnAzurirajZaposlenika_Click);
            // 
            // btnObrisiZaposlenika
            // 
            this.btnObrisiZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnObrisiZaposlenika.Location = new System.Drawing.Point(945, 448);
            this.btnObrisiZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiZaposlenika.Name = "btnObrisiZaposlenika";
            this.btnObrisiZaposlenika.Size = new System.Drawing.Size(105, 47);
            this.btnObrisiZaposlenika.TabIndex = 26;
            this.btnObrisiZaposlenika.Text = "Obriši";
            this.btnObrisiZaposlenika.UseVisualStyleBackColor = false;
            this.btnObrisiZaposlenika.Click += new System.EventHandler(this.btnObrisiZaposlenika_Click);
            // 
            // btnEvidencijaZaposlenikaNatrag
            // 
            this.btnEvidencijaZaposlenikaNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEvidencijaZaposlenikaNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvidencijaZaposlenikaNatrag.ForeColor = System.Drawing.Color.White;
            this.btnEvidencijaZaposlenikaNatrag.Location = new System.Drawing.Point(16, 448);
            this.btnEvidencijaZaposlenikaNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvidencijaZaposlenikaNatrag.Name = "btnEvidencijaZaposlenikaNatrag";
            this.btnEvidencijaZaposlenikaNatrag.Size = new System.Drawing.Size(105, 47);
            this.btnEvidencijaZaposlenikaNatrag.TabIndex = 27;
            this.btnEvidencijaZaposlenikaNatrag.Text = "Natrag";
            this.btnEvidencijaZaposlenikaNatrag.UseVisualStyleBackColor = false;
            this.btnEvidencijaZaposlenikaNatrag.Click += new System.EventHandler(this.btnEvidencijaZaposlenikaNatrag_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(664, 448);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 47);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormaEvidencijaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnEvidencijaZaposlenikaNatrag);
            this.Controls.Add(this.btnObrisiZaposlenika);
            this.Controls.Add(this.btnAzurirajZaposlenika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEvidencijaZaposlenika);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormaEvidencijaZaposlenika";
            this.Text = "FormaEvidencijaZaposlenika";
            this.Load += new System.EventHandler(this.FormaEvidencijaZaposlenika_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormaEvidencijaZaposlenika_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvidencijaZaposlenika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEvidencijaZaposlenika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAzurirajZaposlenika;
        private System.Windows.Forms.Button btnObrisiZaposlenika;
        private System.Windows.Forms.Button btnEvidencijaZaposlenikaNatrag;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumregistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsEvidencijaZaposlenika;
    }
}