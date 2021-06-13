
namespace eGym
{
    partial class FormaGrupniTrening
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
            this.dgvGrupniTrening = new System.Windows.Forms.DataGridView();
            this.bsTermin = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVrstaVjezbe = new System.Windows.Forms.ComboBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dtpOdaberiDatumGrupni = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broj_mjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaVjezbe_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupniTrening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTermin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 74;
            this.label1.Text = "Grupni trening";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 73;
            this.label2.Text = "eGym";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvGrupniTrening
            // 
            this.dgvGrupniTrening.AutoGenerateColumns = false;
            this.dgvGrupniTrening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupniTrening.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.broj_mjesta,
            this.vrstaVjezbe_id});
            this.dgvGrupniTrening.DataSource = this.bsTermin;
            this.dgvGrupniTrening.Location = new System.Drawing.Point(39, 144);
            this.dgvGrupniTrening.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGrupniTrening.Name = "dgvGrupniTrening";
            this.dgvGrupniTrening.RowHeadersWidth = 51;
            this.dgvGrupniTrening.RowTemplate.Height = 24;
            this.dgvGrupniTrening.Size = new System.Drawing.Size(733, 178);
            this.dgvGrupniTrening.TabIndex = 75;
            this.dgvGrupniTrening.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bsTermin
            // 
            this.bsTermin.DataSource = typeof(Pristup_podacima.Termin);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "Odaberi vrstu vježbe:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbVrstaVjezbe
            // 
            this.cmbVrstaVjezbe.FormattingEnabled = true;
            this.cmbVrstaVjezbe.Location = new System.Drawing.Point(208, 348);
            this.cmbVrstaVjezbe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVrstaVjezbe.Name = "cmbVrstaVjezbe";
            this.cmbVrstaVjezbe.Size = new System.Drawing.Size(235, 24);
            this.cmbVrstaVjezbe.TabIndex = 77;
            this.cmbVrstaVjezbe.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaVjezbe_SelectedIndexChanged);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezerviraj.ForeColor = System.Drawing.Color.White;
            this.btnRezerviraj.Location = new System.Drawing.Point(651, 444);
            this.btnRezerviraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(123, 50);
            this.btnRezerviraj.TabIndex = 83;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = false;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(39, 444);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(117, 50);
            this.btnNatrag.TabIndex = 82;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dtpOdaberiDatumGrupni
            // 
            this.dtpOdaberiDatumGrupni.Location = new System.Drawing.Point(208, 382);
            this.dtpOdaberiDatumGrupni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpOdaberiDatumGrupni.Name = "dtpOdaberiDatumGrupni";
            this.dtpOdaberiDatumGrupni.Size = new System.Drawing.Size(235, 22);
            this.dtpOdaberiDatumGrupni.TabIndex = 92;
            this.dtpOdaberiDatumGrupni.ValueChanged += new System.EventHandler(this.dtpOdaberiDatumGrupni_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "Odaberi datum:";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "od";
            this.dataGridViewTextBoxColumn1.HeaderText = "od";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "do";
            this.dataGridViewTextBoxColumn2.HeaderText = "do";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // broj_mjesta
            // 
            this.broj_mjesta.DataPropertyName = "broj_mjesta";
            this.broj_mjesta.HeaderText = "broj_mjesta";
            this.broj_mjesta.MinimumWidth = 6;
            this.broj_mjesta.Name = "broj_mjesta";
            this.broj_mjesta.Width = 125;
            // 
            // vrstaVjezbe_id
            // 
            this.vrstaVjezbe_id.DataPropertyName = "vrstaVjezbe_id";
            this.vrstaVjezbe_id.HeaderText = "vrstaVjezbe_id";
            this.vrstaVjezbe_id.MinimumWidth = 6;
            this.vrstaVjezbe_id.Name = "vrstaVjezbe_id";
            this.vrstaVjezbe_id.Width = 125;
            // 
            // FormaGrupniTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 522);
            this.Controls.Add(this.dtpOdaberiDatumGrupni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cmbVrstaVjezbe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGrupniTrening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaGrupniTrening";
            this.Text = "Grupni trening";
            this.Load += new System.EventHandler(this.FormaGrupniTrening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupniTrening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTermin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGrupniTrening;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVrstaVjezbe;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.BindingSource bsTermin;
        private System.Windows.Forms.DateTimePicker dtpOdaberiDatumGrupni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_mjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaVjezbe_id;
    }
}