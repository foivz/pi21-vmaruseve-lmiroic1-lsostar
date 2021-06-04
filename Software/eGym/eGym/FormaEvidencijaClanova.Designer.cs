
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
            this.btnNatragEvidencijaClanova = new System.Windows.Forms.Button();
            this.dgvEvidencijaClanova = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uloga_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEvidencijaClanova = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaClanova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvidencijaClanova)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiClanaE
            // 
            this.btnObrisiClanaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiClanaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiClanaE.ForeColor = System.Drawing.Color.White;
            this.btnObrisiClanaE.Location = new System.Drawing.Point(717, 359);
            this.btnObrisiClanaE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiClanaE.Name = "btnObrisiClanaE";
            this.btnObrisiClanaE.Size = new System.Drawing.Size(115, 52);
            this.btnObrisiClanaE.TabIndex = 62;
            this.btnObrisiClanaE.Text = "Obriši člana";
            this.btnObrisiClanaE.UseVisualStyleBackColor = false;
            this.btnObrisiClanaE.Click += new System.EventHandler(this.btnObrisiClanaE_Click);
            // 
            // btnAzurirajClanaE
            // 
            this.btnAzurirajClanaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAzurirajClanaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajClanaE.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajClanaE.Location = new System.Drawing.Point(583, 361);
            this.btnAzurirajClanaE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzurirajClanaE.Name = "btnAzurirajClanaE";
            this.btnAzurirajClanaE.Size = new System.Drawing.Size(115, 50);
            this.btnAzurirajClanaE.TabIndex = 61;
            this.btnAzurirajClanaE.Text = "Ažuriraj člana";
            this.btnAzurirajClanaE.UseVisualStyleBackColor = false;
            this.btnAzurirajClanaE.Click += new System.EventHandler(this.btnAzurirajClanaE_Click);
            // 
            // btnNatragEvidencijaClanova
            // 
            this.btnNatragEvidencijaClanova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragEvidencijaClanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragEvidencijaClanova.ForeColor = System.Drawing.Color.White;
            this.btnNatragEvidencijaClanova.Location = new System.Drawing.Point(49, 361);
            this.btnNatragEvidencijaClanova.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatragEvidencijaClanova.Name = "btnNatragEvidencijaClanova";
            this.btnNatragEvidencijaClanova.Size = new System.Drawing.Size(115, 50);
            this.btnNatragEvidencijaClanova.TabIndex = 59;
            this.btnNatragEvidencijaClanova.Text = "Natrag";
            this.btnNatragEvidencijaClanova.UseVisualStyleBackColor = false;
            this.btnNatragEvidencijaClanova.Click += new System.EventHandler(this.btnNatragEvidencijaClanova_Click);
            // 
            // dgvEvidencijaClanova
            // 
            this.dgvEvidencijaClanova.AutoGenerateColumns = false;
            this.dgvEvidencijaClanova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaClanova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.uloga_id,
            this.datumregistracijeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn});
            this.dgvEvidencijaClanova.DataSource = this.bsEvidencijaClanova;
            this.dgvEvidencijaClanova.Location = new System.Drawing.Point(49, 147);
            this.dgvEvidencijaClanova.Name = "dgvEvidencijaClanova";
            this.dgvEvidencijaClanova.RowHeadersWidth = 51;
            this.dgvEvidencijaClanova.RowTemplate.Height = 24;
            this.dgvEvidencijaClanova.Size = new System.Drawing.Size(784, 186);
            this.dgvEvidencijaClanova.TabIndex = 58;
            this.dgvEvidencijaClanova.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEvidencijaClanova_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 56;
            this.label2.Text = "eGym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 57;
            this.label1.Text = "Evidencija članova";
            // 
            // uloga_id
            // 
            this.uloga_id.DataPropertyName = "uloga_id";
            this.uloga_id.HeaderText = "uloga_id";
            this.uloga_id.MinimumWidth = 6;
            this.uloga_id.Name = "uloga_id";
            this.uloga_id.Width = 125;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.Width = 125;
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
            this.bsEvidencijaClanova.DataSource = typeof(eGym.Korisnik);
            // 
            // FormaEvidencijaClanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 504);
            this.Controls.Add(this.btnObrisiClanaE);
            this.Controls.Add(this.btnAzurirajClanaE);
            this.Controls.Add(this.btnNatragEvidencijaClanova);
            this.Controls.Add(this.dgvEvidencijaClanova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaEvidencijaClanova";
            this.Text = "EvidencijaClanova";
            this.Load += new System.EventHandler(this.FormaEvidencijaClanova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaClanova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvidencijaClanova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiClanaE;
        private System.Windows.Forms.Button btnAzurirajClanaE;
        private System.Windows.Forms.Button btnNatragEvidencijaClanova;
        private System.Windows.Forms.DataGridView dgvEvidencijaClanova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsEvidencijaClanova;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uloga_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumregistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
    }
}