
namespace eGym
{
    partial class FormaEvidencijaClanova
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
            this.btnObrisiClanaE = new System.Windows.Forms.Button();
            this.btnAzurirajClanaE = new System.Windows.Forms.Button();
            this.btnNatragClanovi = new System.Windows.Forms.Button();
            this.dgvEvidencijaClanova = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bsEvidencijaClanova = new System.Windows.Forms.BindingSource(this.components);
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaClanova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvidencijaClanova)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiClanaE
            // 
            this.btnObrisiClanaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiClanaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiClanaE.ForeColor = System.Drawing.Color.White;
            this.btnObrisiClanaE.Location = new System.Drawing.Point(536, 286);
            this.btnObrisiClanaE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisiClanaE.Name = "btnObrisiClanaE";
            this.btnObrisiClanaE.Size = new System.Drawing.Size(86, 42);
            this.btnObrisiClanaE.TabIndex = 55;
            this.btnObrisiClanaE.Text = "Obriši člana";
            this.btnObrisiClanaE.UseVisualStyleBackColor = false;
            this.btnObrisiClanaE.Click += new System.EventHandler(this.btnObrisiClanaE_Click);
            // 
            // btnAzurirajClanaE
            // 
            this.btnAzurirajClanaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAzurirajClanaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajClanaE.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajClanaE.Location = new System.Drawing.Point(435, 288);
            this.btnAzurirajClanaE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAzurirajClanaE.Name = "btnAzurirajClanaE";
            this.btnAzurirajClanaE.Size = new System.Drawing.Size(86, 41);
            this.btnAzurirajClanaE.TabIndex = 54;
            this.btnAzurirajClanaE.Text = "Ažuriraj člana";
            this.btnAzurirajClanaE.UseVisualStyleBackColor = false;
            this.btnAzurirajClanaE.Click += new System.EventHandler(this.btnAzurirajClanaE_Click);
            // 
            // btnNatragClanovi
            // 
            this.btnNatragClanovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragClanovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragClanovi.ForeColor = System.Drawing.Color.White;
            this.btnNatragClanovi.Location = new System.Drawing.Point(34, 288);
            this.btnNatragClanovi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNatragClanovi.Name = "btnNatragClanovi";
            this.btnNatragClanovi.Size = new System.Drawing.Size(86, 41);
            this.btnNatragClanovi.TabIndex = 52;
            this.btnNatragClanovi.Text = "Natrag";
            this.btnNatragClanovi.UseVisualStyleBackColor = false;
            this.btnNatragClanovi.Click += new System.EventHandler(this.btnNatragClanovi_Click);
            // 
            // dgvEvidencijaClanova
            // 
            this.dgvEvidencijaClanova.AutoGenerateColumns = false;
            this.dgvEvidencijaClanova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaClanova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.datumregistracijeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn});
            this.dgvEvidencijaClanova.DataSource = this.bsEvidencijaClanova;
            this.dgvEvidencijaClanova.Location = new System.Drawing.Point(34, 114);
            this.dgvEvidencijaClanova.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEvidencijaClanova.Name = "dgvEvidencijaClanova";
            this.dgvEvidencijaClanova.RowHeadersWidth = 51;
            this.dgvEvidencijaClanova.RowTemplate.Height = 24;
            this.dgvEvidencijaClanova.Size = new System.Drawing.Size(588, 151);
            this.dgvEvidencijaClanova.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 44);
            this.label2.TabIndex = 49;
            this.label2.Text = "eGym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Evidencija članova";
            // 
            // bsEvidencijaClanova
            // 
            this.bsEvidencijaClanova.DataSource = typeof(eGym.Korisnik);
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
            // FormaEvidencijaClanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 392);
            this.Controls.Add(this.btnObrisiClanaE);
            this.Controls.Add(this.btnAzurirajClanaE);
            this.Controls.Add(this.btnNatragClanovi);
            this.Controls.Add(this.dgvEvidencijaClanova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaEvidencijaClanova";
            this.Text = "FormaEvidencijaClanova";
            this.Load += new System.EventHandler(this.FormaEvidencijaClanova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaClanova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvidencijaClanova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiClanaE;
        private System.Windows.Forms.Button btnAzurirajClanaE;
        private System.Windows.Forms.Button btnNatragClanovi;
        private System.Windows.Forms.DataGridView dgvEvidencijaClanova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumregistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsEvidencijaClanova;
    }
}