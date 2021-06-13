
namespace eGym
{
    partial class FormaEvidencijaSmjena
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtgEvidencijaSmjena = new System.Windows.Forms.DataGridView();
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smjena_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSmjena = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrisiSmjenuE = new System.Windows.Forms.Button();
            this.btnDodajSmjenuE = new System.Windows.Forms.Button();
            this.btnNatragSmjena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvidencijaSmjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmjena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evidencija smjena";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(39, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "eGym";
            // 
            // dtgEvidencijaSmjena
            // 
            this.dtgEvidencijaSmjena.AutoGenerateColumns = false;
            this.dtgEvidencijaSmjena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEvidencijaSmjena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.smjena_id});
            this.dtgEvidencijaSmjena.DataSource = this.bsSmjena;
            this.dtgEvidencijaSmjena.Location = new System.Drawing.Point(49, 121);
            this.dtgEvidencijaSmjena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgEvidencijaSmjena.Name = "dtgEvidencijaSmjena";
            this.dtgEvidencijaSmjena.RowHeadersWidth = 51;
            this.dtgEvidencijaSmjena.RowTemplate.Height = 24;
            this.dtgEvidencijaSmjena.Size = new System.Drawing.Size(784, 186);
            this.dtgEvidencijaSmjena.TabIndex = 1;
            // 
            // zaposlenikkorisnickoImeDataGridViewTextBoxColumn
            // 
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_korisnickoIme";
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.HeaderText = "zaposlenik_korisnickoIme";
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.Name = "zaposlenikkorisnickoImeDataGridViewTextBoxColumn";
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 125;
            // 
            // smjena_id
            // 
            this.smjena_id.DataPropertyName = "smjena_id";
            this.smjena_id.HeaderText = "smjena_id";
            this.smjena_id.MinimumWidth = 6;
            this.smjena_id.Name = "smjena_id";
            this.smjena_id.Width = 125;
            // 
            // bsSmjena
            // 
            this.bsSmjena.DataSource = typeof(Pristup_podacima.SmjenaZaposlenika);
            // 
            // btnObrisiSmjenuE
            // 
            this.btnObrisiSmjenuE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiSmjenuE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSmjenuE.ForeColor = System.Drawing.Color.White;
            this.btnObrisiSmjenuE.Location = new System.Drawing.Point(717, 334);
            this.btnObrisiSmjenuE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiSmjenuE.Name = "btnObrisiSmjenuE";
            this.btnObrisiSmjenuE.Size = new System.Drawing.Size(115, 52);
            this.btnObrisiSmjenuE.TabIndex = 48;
            this.btnObrisiSmjenuE.Text = "Obriši smjenu";
            this.btnObrisiSmjenuE.UseVisualStyleBackColor = false;
            this.btnObrisiSmjenuE.Click += new System.EventHandler(this.btnObrisiSmjenuE_Click);
            // 
            // btnDodajSmjenuE
            // 
            this.btnDodajSmjenuE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajSmjenuE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSmjenuE.ForeColor = System.Drawing.Color.White;
            this.btnDodajSmjenuE.Location = new System.Drawing.Point(581, 334);
            this.btnDodajSmjenuE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSmjenuE.Name = "btnDodajSmjenuE";
            this.btnDodajSmjenuE.Size = new System.Drawing.Size(117, 50);
            this.btnDodajSmjenuE.TabIndex = 46;
            this.btnDodajSmjenuE.Text = "Dodaj smjenu";
            this.btnDodajSmjenuE.UseVisualStyleBackColor = false;
            this.btnDodajSmjenuE.Click += new System.EventHandler(this.btnDodajSmjenuE_Click);
            // 
            // btnNatragSmjena
            // 
            this.btnNatragSmjena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragSmjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragSmjena.ForeColor = System.Drawing.Color.White;
            this.btnNatragSmjena.Location = new System.Drawing.Point(49, 335);
            this.btnNatragSmjena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatragSmjena.Name = "btnNatragSmjena";
            this.btnNatragSmjena.Size = new System.Drawing.Size(115, 50);
            this.btnNatragSmjena.TabIndex = 46;
            this.btnNatragSmjena.Text = "Natrag";
            this.btnNatragSmjena.UseVisualStyleBackColor = false;
            this.btnNatragSmjena.Click += new System.EventHandler(this.btnNatragSmjena_Click);
            // 
            // FormaEvidencijaSmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 416);
            this.Controls.Add(this.btnObrisiSmjenuE);
            this.Controls.Add(this.btnNatragSmjena);
            this.Controls.Add(this.btnDodajSmjenuE);
            this.Controls.Add(this.dtgEvidencijaSmjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaEvidencijaSmjena";
            this.Text = "Smjene";
            this.Load += new System.EventHandler(this.FormaEvidencijaSmjena_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormaEvidencijaSmjena_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvidencijaSmjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmjena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgEvidencijaSmjena;
        private System.Windows.Forms.Button btnObrisiSmjenuE;
        private System.Windows.Forms.Button btnDodajSmjenuE;
        private System.Windows.Forms.Button btnNatragSmjena;
        private System.Windows.Forms.BindingSource bsSmjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikkorisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smjena_id;
    }
}