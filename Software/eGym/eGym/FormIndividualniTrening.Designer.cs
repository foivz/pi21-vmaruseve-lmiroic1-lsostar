
namespace eGym
{
    partial class FormIndividualniTrening
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
            this.btnRezervirajIT = new System.Windows.Forms.Button();
            this.btnNatragIT = new System.Windows.Forms.Button();
            this.dtpOdaberiDatumIndividualni = new System.Windows.Forms.DateTimePicker();
            this.cmbOdabirTrenera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvIndividualniTrening = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojmjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaVjezbeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRezervacijaInd = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualniTrening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRezervacijaInd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRezervirajIT
            // 
            this.btnRezervirajIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRezervirajIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervirajIT.ForeColor = System.Drawing.Color.White;
            this.btnRezervirajIT.Location = new System.Drawing.Point(671, 441);
            this.btnRezervirajIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezervirajIT.Name = "btnRezervirajIT";
            this.btnRezervirajIT.Size = new System.Drawing.Size(123, 50);
            this.btnRezervirajIT.TabIndex = 92;
            this.btnRezervirajIT.Text = "Rezerviraj";
            this.btnRezervirajIT.UseVisualStyleBackColor = false;
            this.btnRezervirajIT.Click += new System.EventHandler(this.btnRezervirajIT_Click);
            // 
            // btnNatragIT
            // 
            this.btnNatragIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragIT.ForeColor = System.Drawing.Color.White;
            this.btnNatragIT.Location = new System.Drawing.Point(60, 441);
            this.btnNatragIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatragIT.Name = "btnNatragIT";
            this.btnNatragIT.Size = new System.Drawing.Size(117, 50);
            this.btnNatragIT.TabIndex = 91;
            this.btnNatragIT.Text = "Natrag";
            this.btnNatragIT.UseVisualStyleBackColor = false;
            this.btnNatragIT.Click += new System.EventHandler(this.btnNatragIT_Click);
            // 
            // dtpOdaberiDatumIndividualni
            // 
            this.dtpOdaberiDatumIndividualni.Location = new System.Drawing.Point(229, 382);
            this.dtpOdaberiDatumIndividualni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpOdaberiDatumIndividualni.Name = "dtpOdaberiDatumIndividualni";
            this.dtpOdaberiDatumIndividualni.Size = new System.Drawing.Size(235, 22);
            this.dtpOdaberiDatumIndividualni.TabIndex = 90;
            this.dtpOdaberiDatumIndividualni.ValueChanged += new System.EventHandler(this.dtpOdaberiDatumIndividualni_ValueChanged);
            // 
            // cmbOdabirTrenera
            // 
            this.cmbOdabirTrenera.FormattingEnabled = true;
            this.cmbOdabirTrenera.Location = new System.Drawing.Point(229, 345);
            this.cmbOdabirTrenera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOdabirTrenera.Name = "cmbOdabirTrenera";
            this.cmbOdabirTrenera.Size = new System.Drawing.Size(235, 24);
            this.cmbOdabirTrenera.TabIndex = 89;
            this.cmbOdabirTrenera.SelectedIndexChanged += new System.EventHandler(this.cmbOdabirTrenera_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "Odaberi datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Odaberi trenera:";
            // 
            // dgvIndividualniTrening
            // 
            this.dgvIndividualniTrening.AutoGenerateColumns = false;
            this.dgvIndividualniTrening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndividualniTrening.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.odDataGridViewTextBoxColumn,
            this.doDataGridViewTextBoxColumn,
            this.brojmjestaDataGridViewTextBoxColumn,
            this.zaposlenikkorisnickoImeDataGridViewTextBoxColumn,
            this.treningidDataGridViewTextBoxColumn,
            this.vrstaVjezbeidDataGridViewTextBoxColumn});
            this.dgvIndividualniTrening.DataSource = this.bsRezervacijaInd;
            this.dgvIndividualniTrening.Location = new System.Drawing.Point(60, 140);
            this.dgvIndividualniTrening.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIndividualniTrening.Name = "dgvIndividualniTrening";
            this.dgvIndividualniTrening.RowHeadersWidth = 51;
            this.dgvIndividualniTrening.RowTemplate.Height = 24;
            this.dgvIndividualniTrening.Size = new System.Drawing.Size(733, 178);
            this.dgvIndividualniTrening.TabIndex = 86;
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
            // bsRezervacijaInd
            // 
            this.bsRezervacijaInd.DataSource = typeof(Pristup_podacima.Termin);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 85;
            this.label1.Text = "Individualni trening";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 84;
            this.label2.Text = "eGym";
            // 
            // FormIndividualniTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 538);
            this.Controls.Add(this.btnRezervirajIT);
            this.Controls.Add(this.btnNatragIT);
            this.Controls.Add(this.dtpOdaberiDatumIndividualni);
            this.Controls.Add(this.cmbOdabirTrenera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvIndividualniTrening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormIndividualniTrening";
            this.Text = "IndividualniTrening";
            this.Load += new System.EventHandler(this.FormIndividualniTrening_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormIndividualniTrening_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualniTrening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRezervacijaInd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRezervirajIT;
        private System.Windows.Forms.Button btnNatragIT;
        private System.Windows.Forms.DateTimePicker dtpOdaberiDatumIndividualni;
        private System.Windows.Forms.ComboBox cmbOdabirTrenera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvIndividualniTrening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojmjestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikkorisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treningidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaVjezbeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsRezervacijaInd;
    }
}