
namespace eGym
{
    partial class FormaEvidencijaTermina
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
            this.dgvEvidencijaTermina = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojmjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaVjezbeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTermin = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            this.btnNatragTermin = new System.Windows.Forms.Button();
            this.btnDodajTermin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaTermina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTermin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvidencijaTermina
            // 
            this.dgvEvidencijaTermina.AutoGenerateColumns = false;
            this.dgvEvidencijaTermina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaTermina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.odDataGridViewTextBoxColumn,
            this.doDataGridViewTextBoxColumn,
            this.brojmjestaDataGridViewTextBoxColumn,
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn,
            this.treningidDataGridViewTextBoxColumn,
            this.vrstaVjezbeidDataGridViewTextBoxColumn});
            this.dgvEvidencijaTermina.DataSource = this.bsTermin;
            this.dgvEvidencijaTermina.Location = new System.Drawing.Point(83, 158);
            this.dgvEvidencijaTermina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEvidencijaTermina.Name = "dgvEvidencijaTermina";
            this.dgvEvidencijaTermina.RowHeadersWidth = 51;
            this.dgvEvidencijaTermina.RowTemplate.Height = 24;
            this.dgvEvidencijaTermina.Size = new System.Drawing.Size(800, 298);
            this.dgvEvidencijaTermina.TabIndex = 81;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // odDataGridViewTextBoxColumn
            // 
            this.odDataGridViewTextBoxColumn.DataPropertyName = "od";
            this.odDataGridViewTextBoxColumn.HeaderText = "od";
            this.odDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odDataGridViewTextBoxColumn.Name = "odDataGridViewTextBoxColumn";
            this.odDataGridViewTextBoxColumn.Width = 125;
            // 
            // doDataGridViewTextBoxColumn
            // 
            this.doDataGridViewTextBoxColumn.DataPropertyName = "do";
            this.doDataGridViewTextBoxColumn.HeaderText = "do";
            this.doDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doDataGridViewTextBoxColumn.Name = "doDataGridViewTextBoxColumn";
            this.doDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojmjestaDataGridViewTextBoxColumn
            // 
            this.brojmjestaDataGridViewTextBoxColumn.DataPropertyName = "broj_mjesta";
            this.brojmjestaDataGridViewTextBoxColumn.HeaderText = "broj_mjesta";
            this.brojmjestaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojmjestaDataGridViewTextBoxColumn.Name = "brojmjestaDataGridViewTextBoxColumn";
            this.brojmjestaDataGridViewTextBoxColumn.Width = 125;
            // 
            // zaposlenikkorisnickoImeDataGridViewTextBoxColumn
            // 
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_korisnickoIme";
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.HeaderText = "zaposlenik_korisnickoIme";
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.Name = "zaposlenikkorisnickoImeDataGridViewTextBoxColumn";
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.Width = 125;
            // 
            // treningidDataGridViewTextBoxColumn
            // 
            this.treningidDataGridViewTextBoxColumn.DataPropertyName = "trening_id";
            this.treningidDataGridViewTextBoxColumn.HeaderText = "trening_id";
            this.treningidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.treningidDataGridViewTextBoxColumn.Name = "treningidDataGridViewTextBoxColumn";
            this.treningidDataGridViewTextBoxColumn.Width = 125;
            // 
            // vrstaVjezbeidDataGridViewTextBoxColumn
            // 
            this.vrstaVjezbeidDataGridViewTextBoxColumn.DataPropertyName = "vrstaVjezbe_id";
            this.vrstaVjezbeidDataGridViewTextBoxColumn.HeaderText = "vrstaVjezbe_id";
            this.vrstaVjezbeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrstaVjezbeidDataGridViewTextBoxColumn.Name = "vrstaVjezbeidDataGridViewTextBoxColumn";
            this.vrstaVjezbeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsTermin
            // 
            this.bsTermin.DataSource = typeof(Pristup_podacima.Termin);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 80;
            this.label1.Text = "Evidencija termina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(73, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 79;
            this.label2.Text = "eGym";
            // 
            // btnObrisiTermin
            // 
            this.btnObrisiTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTermin.ForeColor = System.Drawing.Color.White;
            this.btnObrisiTermin.Location = new System.Drawing.Point(755, 478);
            this.btnObrisiTermin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(115, 52);
            this.btnObrisiTermin.TabIndex = 85;
            this.btnObrisiTermin.Text = "Obriši termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = false;
            this.btnObrisiTermin.Click += new System.EventHandler(this.btnObrisiTermin_Click);
            // 
            // btnNatragTermin
            // 
            this.btnNatragTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragTermin.ForeColor = System.Drawing.Color.White;
            this.btnNatragTermin.Location = new System.Drawing.Point(87, 480);
            this.btnNatragTermin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatragTermin.Name = "btnNatragTermin";
            this.btnNatragTermin.Size = new System.Drawing.Size(115, 50);
            this.btnNatragTermin.TabIndex = 82;
            this.btnNatragTermin.Text = "Natrag";
            this.btnNatragTermin.UseVisualStyleBackColor = false;
            this.btnNatragTermin.Click += new System.EventHandler(this.btnNatragSuplement_Click);
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTermin.ForeColor = System.Drawing.Color.White;
            this.btnDodajTermin.Location = new System.Drawing.Point(625, 478);
            this.btnDodajTermin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(115, 50);
            this.btnDodajTermin.TabIndex = 83;
            this.btnDodajTermin.Text = "Dodaj termin";
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            this.btnDodajTermin.Click += new System.EventHandler(this.btnDodajTerminE_Click);
            // 
            // FormaEvidencijaTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 590);
            this.Controls.Add(this.btnObrisiTermin);
            this.Controls.Add(this.btnNatragTermin);
            this.Controls.Add(this.btnDodajTermin);
            this.Controls.Add(this.dgvEvidencijaTermina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaEvidencijaTermina";
            this.Text = "Evidencija Termina";
            this.Load += new System.EventHandler(this.FormaEvidencijaTermina_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormaEvidencijaTermina_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaTermina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTermin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvidencijaTermina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisiTermin;
        private System.Windows.Forms.Button btnNatragTermin;
        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojmjestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikkorisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treningidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaVjezbeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsTermin;
    }
}