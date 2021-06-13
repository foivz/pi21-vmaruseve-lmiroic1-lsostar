
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            this.btnNatragSuplement = new System.Windows.Forms.Button();
            this.btnDodajTerminE = new System.Windows.Forms.Button();
            this.bsTermin = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojmjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaVjezbeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvEvidencijaTermina.Location = new System.Drawing.Point(62, 128);
            this.dgvEvidencijaTermina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEvidencijaTermina.Name = "dgvEvidencijaTermina";
            this.dgvEvidencijaTermina.RowHeadersWidth = 51;
            this.dgvEvidencijaTermina.RowTemplate.Height = 24;
            this.dgvEvidencijaTermina.Size = new System.Drawing.Size(600, 242);
            this.dgvEvidencijaTermina.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "Evidencija termina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(55, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 44);
            this.label2.TabIndex = 79;
            this.label2.Text = "eGym";
            // 
            // btnObrisiTermin
            // 
            this.btnObrisiTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTermin.ForeColor = System.Drawing.Color.White;
            this.btnObrisiTermin.Location = new System.Drawing.Point(566, 388);
            this.btnObrisiTermin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(86, 42);
            this.btnObrisiTermin.TabIndex = 85;
            this.btnObrisiTermin.Text = "Obriši termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = false;
            this.btnObrisiTermin.Click += new System.EventHandler(this.btnObrisiTermin_Click);
            // 
            // btnNatragSuplement
            // 
            this.btnNatragSuplement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragSuplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragSuplement.ForeColor = System.Drawing.Color.White;
            this.btnNatragSuplement.Location = new System.Drawing.Point(65, 390);
            this.btnNatragSuplement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNatragSuplement.Name = "btnNatragSuplement";
            this.btnNatragSuplement.Size = new System.Drawing.Size(86, 41);
            this.btnNatragSuplement.TabIndex = 82;
            this.btnNatragSuplement.Text = "Natrag";
            this.btnNatragSuplement.UseVisualStyleBackColor = false;
            this.btnNatragSuplement.Click += new System.EventHandler(this.btnNatragSuplement_Click);
            // 
            // btnDodajTerminE
            // 
            this.btnDodajTerminE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajTerminE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTerminE.ForeColor = System.Drawing.Color.White;
            this.btnDodajTerminE.Location = new System.Drawing.Point(469, 388);
            this.btnDodajTerminE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajTerminE.Name = "btnDodajTerminE";
            this.btnDodajTerminE.Size = new System.Drawing.Size(86, 41);
            this.btnDodajTerminE.TabIndex = 83;
            this.btnDodajTerminE.Text = "Dodaj termin";
            this.btnDodajTerminE.UseVisualStyleBackColor = false;
            this.btnDodajTerminE.Click += new System.EventHandler(this.btnDodajTerminE_Click);
            // 
            // bsTermin
            // 
            this.bsTermin.DataSource = typeof(Pristup_podacima.Termin);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // odDataGridViewTextBoxColumn
            // 
            this.odDataGridViewTextBoxColumn.DataPropertyName = "od";
            this.odDataGridViewTextBoxColumn.HeaderText = "od";
            this.odDataGridViewTextBoxColumn.Name = "odDataGridViewTextBoxColumn";
            // 
            // doDataGridViewTextBoxColumn
            // 
            this.doDataGridViewTextBoxColumn.DataPropertyName = "do";
            this.doDataGridViewTextBoxColumn.HeaderText = "do";
            this.doDataGridViewTextBoxColumn.Name = "doDataGridViewTextBoxColumn";
            // 
            // brojmjestaDataGridViewTextBoxColumn
            // 
            this.brojmjestaDataGridViewTextBoxColumn.DataPropertyName = "broj_mjesta";
            this.brojmjestaDataGridViewTextBoxColumn.HeaderText = "broj_mjesta";
            this.brojmjestaDataGridViewTextBoxColumn.Name = "brojmjestaDataGridViewTextBoxColumn";
            // 
            // zaposlenikkorisnickoImeDataGridViewTextBoxColumn
            // 
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_korisnickoIme";
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.HeaderText = "zaposlenik_korisnickoIme";
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn.Name = "zaposlenikkorisnickoImeDataGridViewTextBoxColumn";
            // 
            // treningidDataGridViewTextBoxColumn
            // 
            this.treningidDataGridViewTextBoxColumn.DataPropertyName = "trening_id";
            this.treningidDataGridViewTextBoxColumn.HeaderText = "trening_id";
            this.treningidDataGridViewTextBoxColumn.Name = "treningidDataGridViewTextBoxColumn";
            // 
            // vrstaVjezbeidDataGridViewTextBoxColumn
            // 
            this.vrstaVjezbeidDataGridViewTextBoxColumn.DataPropertyName = "vrstaVjezbe_id";
            this.vrstaVjezbeidDataGridViewTextBoxColumn.HeaderText = "vrstaVjezbe_id";
            this.vrstaVjezbeidDataGridViewTextBoxColumn.Name = "vrstaVjezbeidDataGridViewTextBoxColumn";
            // 
            // FormaEvidencijaTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 479);
            this.Controls.Add(this.btnObrisiTermin);
            this.Controls.Add(this.btnNatragSuplement);
            this.Controls.Add(this.btnDodajTerminE);
            this.Controls.Add(this.dgvEvidencijaTermina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaEvidencijaTermina";
            this.Text = "Evidencija termina";
            this.Load += new System.EventHandler(this.FormaEvidencijaTermina_Load);
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
        private System.Windows.Forms.Button btnNatragSuplement;
        private System.Windows.Forms.Button btnDodajTerminE;
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