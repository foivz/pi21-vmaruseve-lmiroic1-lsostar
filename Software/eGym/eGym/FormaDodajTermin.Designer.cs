﻿
namespace eGym
{
    partial class FormaDodajTermin
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
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dtpDatumTerminaOd = new System.Windows.Forms.DateTimePicker();
            this.lblRadnoVrijeme = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojMjesta = new System.Windows.Forms.TextBox();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvVrstaVjezbe = new System.Windows.Forms.DataGridView();
            this.cbVrstaTreninga = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaVjezbe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTermin.ForeColor = System.Drawing.Color.White;
            this.btnDodajTermin.Location = new System.Drawing.Point(1117, 553);
            this.btnDodajTermin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(123, 50);
            this.btnDodajTermin.TabIndex = 59;
            this.btnDodajTermin.Text = "Dodaj termin";
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            this.btnDodajTermin.Click += new System.EventHandler(this.btnDodajTermin_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(75, 569);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(117, 50);
            this.btnNatrag.TabIndex = 58;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dtpDatumTerminaOd
            // 
            this.dtpDatumTerminaOd.Location = new System.Drawing.Point(128, 169);
            this.dtpDatumTerminaOd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumTerminaOd.Name = "dtpDatumTerminaOd";
            this.dtpDatumTerminaOd.Size = new System.Drawing.Size(217, 22);
            this.dtpDatumTerminaOd.TabIndex = 56;
            // 
            // lblRadnoVrijeme
            // 
            this.lblRadnoVrijeme.AutoSize = true;
            this.lblRadnoVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnoVrijeme.Location = new System.Drawing.Point(424, 174);
            this.lblRadnoVrijeme.Name = "lblRadnoVrijeme";
            this.lblRadnoVrijeme.Size = new System.Drawing.Size(32, 18);
            this.lblRadnoVrijeme.TabIndex = 54;
            this.lblRadnoVrijeme.Text = "Do:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(88, 174);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(32, 18);
            this.lblDatum.TabIndex = 53;
            this.lblDatum.Text = "Od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Dodaj termin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 50;
            this.label2.Text = "eGym";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(756, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Broj mjesta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(873, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Vrsta treninga:";
            // 
            // txtBrojMjesta
            // 
            this.txtBrojMjesta.Location = new System.Drawing.Point(857, 172);
            this.txtBrojMjesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrojMjesta.Name = "txtBrojMjesta";
            this.txtBrojMjesta.Size = new System.Drawing.Size(217, 22);
            this.txtBrojMjesta.TabIndex = 60;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(471, 170);
            this.dtpDatumDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(217, 22);
            this.dtpDatumDo.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Zaposlenik:";
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(90, 271);
            this.dgvZaposlenici.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.Size = new System.Drawing.Size(364, 197);
            this.dgvZaposlenici.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Vrsta vježbe:";
            // 
            // dgvVrstaVjezbe
            // 
            this.dgvVrstaVjezbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaVjezbe.Location = new System.Drawing.Point(479, 271);
            this.dgvVrstaVjezbe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVrstaVjezbe.Name = "dgvVrstaVjezbe";
            this.dgvVrstaVjezbe.RowHeadersWidth = 51;
            this.dgvVrstaVjezbe.Size = new System.Drawing.Size(364, 197);
            this.dgvVrstaVjezbe.TabIndex = 62;
            // 
            // cbVrstaTreninga
            // 
            this.cbVrstaTreninga.FormattingEnabled = true;
            this.cbVrstaTreninga.Location = new System.Drawing.Point(876, 271);
            this.cbVrstaTreninga.Name = "cbVrstaTreninga";
            this.cbVrstaTreninga.Size = new System.Drawing.Size(121, 24);
            this.cbVrstaTreninga.TabIndex = 63;
            // 
            // FormaDodajTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 650);
            this.Controls.Add(this.cbVrstaTreninga);
            this.Controls.Add(this.dgvVrstaVjezbe);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.txtBrojMjesta);
            this.Controls.Add(this.btnDodajTermin);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumTerminaOd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRadnoVrijeme);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaDodajTermin";
            this.Text = "Dodavanje Termina";
            this.Load += new System.EventHandler(this.FormaDodajTermin_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormaDodajTermin_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaVjezbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DateTimePicker dtpDatumTerminaOd;
        private System.Windows.Forms.Label lblRadnoVrijeme;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojMjesta;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvVrstaVjezbe;
        private System.Windows.Forms.ComboBox cbVrstaTreninga;
    }
}