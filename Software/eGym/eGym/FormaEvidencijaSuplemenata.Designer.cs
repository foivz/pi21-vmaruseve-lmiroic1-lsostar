
namespace eGym
{
    partial class FormaEvidencijaSuplemenata
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
            this.btnObrisiSuplement = new System.Windows.Forms.Button();
            this.btnAzurirajSuplement = new System.Windows.Forms.Button();
            this.btnNatragSuplement = new System.Windows.Forms.Button();
            this.btnDodajSuplement = new System.Windows.Forms.Button();
            this.dgvEvidencijaSuplemenata = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bsSuplementi = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaSuplemenata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuplementi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiSuplement
            // 
            this.btnObrisiSuplement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObrisiSuplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSuplement.ForeColor = System.Drawing.Color.White;
            this.btnObrisiSuplement.Location = new System.Drawing.Point(726, 362);
            this.btnObrisiSuplement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiSuplement.Name = "btnObrisiSuplement";
            this.btnObrisiSuplement.Size = new System.Drawing.Size(115, 52);
            this.btnObrisiSuplement.TabIndex = 55;
            this.btnObrisiSuplement.Text = "Obriši suplement";
            this.btnObrisiSuplement.UseVisualStyleBackColor = false;
            this.btnObrisiSuplement.Click += new System.EventHandler(this.btnObrisiSuplementE_Click);
            // 
            // btnAzurirajSuplement
            // 
            this.btnAzurirajSuplement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAzurirajSuplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajSuplement.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajSuplement.Location = new System.Drawing.Point(592, 364);
            this.btnAzurirajSuplement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzurirajSuplement.Name = "btnAzurirajSuplement";
            this.btnAzurirajSuplement.Size = new System.Drawing.Size(115, 50);
            this.btnAzurirajSuplement.TabIndex = 54;
            this.btnAzurirajSuplement.Text = "Ažuriraj suplement";
            this.btnAzurirajSuplement.UseVisualStyleBackColor = false;
            this.btnAzurirajSuplement.Click += new System.EventHandler(this.btnAzurirajSuplementE_Click);
            // 
            // btnNatragSuplement
            // 
            this.btnNatragSuplement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragSuplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragSuplement.ForeColor = System.Drawing.Color.White;
            this.btnNatragSuplement.Location = new System.Drawing.Point(58, 364);
            this.btnNatragSuplement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatragSuplement.Name = "btnNatragSuplement";
            this.btnNatragSuplement.Size = new System.Drawing.Size(115, 50);
            this.btnNatragSuplement.TabIndex = 52;
            this.btnNatragSuplement.Text = "Natrag";
            this.btnNatragSuplement.UseVisualStyleBackColor = false;
            this.btnNatragSuplement.Click += new System.EventHandler(this.btnNatragSuplement_Click);
            // 
            // btnDodajSuplement
            // 
            this.btnDodajSuplement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajSuplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSuplement.ForeColor = System.Drawing.Color.White;
            this.btnDodajSuplement.Location = new System.Drawing.Point(458, 364);
            this.btnDodajSuplement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSuplement.Name = "btnDodajSuplement";
            this.btnDodajSuplement.Size = new System.Drawing.Size(115, 50);
            this.btnDodajSuplement.TabIndex = 53;
            this.btnDodajSuplement.Text = "Dodaj suplement";
            this.btnDodajSuplement.UseVisualStyleBackColor = false;
            this.btnDodajSuplement.Click += new System.EventHandler(this.btnDodajSSuplementE_Click);
            // 
            // dgvEvidencijaSuplemenata
            // 
            this.dgvEvidencijaSuplemenata.AutoGenerateColumns = false;
            this.dgvEvidencijaSuplemenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencijaSuplemenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn});
            this.dgvEvidencijaSuplemenata.DataSource = this.suplementBindingSource;
            this.dgvEvidencijaSuplemenata.Location = new System.Drawing.Point(58, 150);
            this.dgvEvidencijaSuplemenata.Name = "dgvEvidencijaSuplemenata";
            this.dgvEvidencijaSuplemenata.RowHeadersWidth = 51;
            this.dgvEvidencijaSuplemenata.RowTemplate.Height = 24;
            this.dgvEvidencijaSuplemenata.Size = new System.Drawing.Size(784, 186);
            this.dgvEvidencijaSuplemenata.TabIndex = 51;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "stanje";
            this.stanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            this.stanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // suplementBindingSource
            // 
            this.suplementBindingSource.DataSource = typeof(eGym.Suplement);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 49;
            this.label2.Text = "eGym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Evidencija suplemenata";
            // 
            // FormaEvidencijaSuplemenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 547);
            this.Controls.Add(this.btnObrisiSuplement);
            this.Controls.Add(this.btnAzurirajSuplement);
            this.Controls.Add(this.btnNatragSuplement);
            this.Controls.Add(this.btnDodajSuplement);
            this.Controls.Add(this.dgvEvidencijaSuplemenata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaEvidencijaSuplemenata";
            this.Text = "Evidencija Suplemenata";
            this.Load += new System.EventHandler(this.FormaEvidencijaSuplemenata_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormaEvidencijaSuplemenata_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaSuplemenata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuplementi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiSuplement;
        private System.Windows.Forms.Button btnAzurirajSuplement;
        private System.Windows.Forms.Button btnNatragSuplement;
        private System.Windows.Forms.Button btnDodajSuplement;
        private System.Windows.Forms.DataGridView dgvEvidencijaSuplemenata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource suplementBindingSource;
        private System.Windows.Forms.BindingSource bsSuplementi;
    }
}