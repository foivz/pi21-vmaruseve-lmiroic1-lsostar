
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
            this.btnObrisiClana = new System.Windows.Forms.Button();
            this.btnAzurirajClana = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvEvidencijaClanova = new System.Windows.Forms.DataGridView();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEvidencijaClanova = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaClanova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvidencijaClanova)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiClana
            // 
            this.btnObrisiClana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiClana.ForeColor = System.Drawing.Color.White;
            this.btnObrisiClana.Location = new System.Drawing.Point(715, 352);
            this.btnObrisiClana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiClana.Name = "btnObrisiClana";
            this.btnObrisiClana.Size = new System.Drawing.Size(115, 52);
            this.btnObrisiClana.TabIndex = 55;
            this.btnObrisiClana.Text = "Obriši člana";
            this.btnObrisiClana.UseVisualStyleBackColor = false;
            this.btnObrisiClana.Click += new System.EventHandler(this.btnObrisiClanaE_Click);
            // 
            // btnAzurirajClana
            // 
            this.btnAzurirajClana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAzurirajClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajClana.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajClana.Location = new System.Drawing.Point(580, 354);
            this.btnAzurirajClana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzurirajClana.Name = "btnAzurirajClana";
            this.btnAzurirajClana.Size = new System.Drawing.Size(115, 50);
            this.btnAzurirajClana.TabIndex = 54;
            this.btnAzurirajClana.Text = "Ažuriraj člana";
            this.btnAzurirajClana.UseVisualStyleBackColor = false;
            this.btnAzurirajClana.Click += new System.EventHandler(this.btnAzurirajClanaE_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(45, 354);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(115, 50);
            this.btnNatrag.TabIndex = 52;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatragClanovi_Click);
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
            this.dgvEvidencijaClanova.Location = new System.Drawing.Point(45, 140);
            this.dgvEvidencijaClanova.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEvidencijaClanova.Name = "dgvEvidencijaClanova";
            this.dgvEvidencijaClanova.RowHeadersWidth = 51;
            this.dgvEvidencijaClanova.RowTemplate.Height = 24;
            this.dgvEvidencijaClanova.Size = new System.Drawing.Size(784, 186);
            this.dgvEvidencijaClanova.TabIndex = 51;
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
            // bsEvidencijaClanova
            // 
            this.bsEvidencijaClanova.DataSource = typeof(Pristup_podacima.Korisnik);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 49;
            this.label2.Text = "eGym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Evidencija članova";
            // 
            // FormaEvidencijaClanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 482);
            this.Controls.Add(this.btnObrisiClana);
            this.Controls.Add(this.btnAzurirajClana);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dgvEvidencijaClanova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaEvidencijaClanova";
            this.Text = "Evidencija Članova";
            this.Load += new System.EventHandler(this.FormaEvidencijaClanova_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormaEvidencijaClanova_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaClanova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvidencijaClanova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiClana;
        private System.Windows.Forms.Button btnAzurirajClana;
        private System.Windows.Forms.Button btnNatrag;
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