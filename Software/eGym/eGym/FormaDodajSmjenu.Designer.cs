﻿
namespace eGym
{
    partial class FormaDodajSmjenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRadnoVrijeme = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblImeiPrezime = new System.Windows.Forms.Label();
            this.cmbImeIPrezime = new System.Windows.Forms.ComboBox();
            this.dtpDatumSmjena = new System.Windows.Forms.DateTimePicker();
            this.cmbRadnoVrijeme = new System.Windows.Forms.ComboBox();
            this.btnDodajSmjenu = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "eGym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj smjenu";
            // 
            // lblRadnoVrijeme
            // 
            this.lblRadnoVrijeme.AutoSize = true;
            this.lblRadnoVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnoVrijeme.Location = new System.Drawing.Point(51, 256);
            this.lblRadnoVrijeme.Name = "lblRadnoVrijeme";
            this.lblRadnoVrijeme.Size = new System.Drawing.Size(107, 18);
            this.lblRadnoVrijeme.TabIndex = 39;
            this.lblRadnoVrijeme.Text = "Radno vrijeme:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(102, 217);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(56, 18);
            this.lblDatum.TabIndex = 38;
            this.lblDatum.Text = "Datum:";
            // 
            // lblImeiPrezime
            // 
            this.lblImeiPrezime.AutoSize = true;
            this.lblImeiPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeiPrezime.Location = new System.Drawing.Point(68, 178);
            this.lblImeiPrezime.Name = "lblImeiPrezime";
            this.lblImeiPrezime.Size = new System.Drawing.Size(100, 18);
            this.lblImeiPrezime.TabIndex = 37;
            this.lblImeiPrezime.Text = "Ime i prezime:";
            // 
            // cmbImeIPrezime
            // 
            this.cmbImeIPrezime.FormattingEnabled = true;
            this.cmbImeIPrezime.Location = new System.Drawing.Point(174, 177);
            this.cmbImeIPrezime.Name = "cmbImeIPrezime";
            this.cmbImeIPrezime.Size = new System.Drawing.Size(218, 24);
            this.cmbImeIPrezime.TabIndex = 40;
            // 
            // dtpDatumSmjena
            // 
            this.dtpDatumSmjena.Location = new System.Drawing.Point(174, 217);
            this.dtpDatumSmjena.Name = "dtpDatumSmjena";
            this.dtpDatumSmjena.Size = new System.Drawing.Size(218, 22);
            this.dtpDatumSmjena.TabIndex = 41;
            // 
            // cmbRadnoVrijeme
            // 
            this.cmbRadnoVrijeme.FormattingEnabled = true;
            this.cmbRadnoVrijeme.Location = new System.Drawing.Point(174, 255);
            this.cmbRadnoVrijeme.Name = "cmbRadnoVrijeme";
            this.cmbRadnoVrijeme.Size = new System.Drawing.Size(218, 24);
            this.cmbRadnoVrijeme.TabIndex = 42;
            // 
            // btnDodajSmjenu
            // 
            this.btnDodajSmjenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajSmjenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSmjenu.ForeColor = System.Drawing.Color.White;
            this.btnDodajSmjenu.Location = new System.Drawing.Point(270, 331);
            this.btnDodajSmjenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSmjenu.Name = "btnDodajSmjenu";
            this.btnDodajSmjenu.Size = new System.Drawing.Size(122, 50);
            this.btnDodajSmjenu.TabIndex = 49;
            this.btnDodajSmjenu.Text = "Dodaj smjenu";
            this.btnDodajSmjenu.UseVisualStyleBackColor = false;
            this.btnDodajSmjenu.Click += new System.EventHandler(this.btnDodajSmjenu_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(51, 331);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(117, 50);
            this.btnNatrag.TabIndex = 48;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FormaDodajSmjenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 436);
            this.Controls.Add(this.btnDodajSmjenu);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cmbRadnoVrijeme);
            this.Controls.Add(this.dtpDatumSmjena);
            this.Controls.Add(this.cmbImeIPrezime);
            this.Controls.Add(this.lblRadnoVrijeme);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblImeiPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormaDodajSmjenu";
            this.Text = "Dodaj smjenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRadnoVrijeme;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblImeiPrezime;
        private System.Windows.Forms.ComboBox cmbImeIPrezime;
        private System.Windows.Forms.DateTimePicker dtpDatumSmjena;
        private System.Windows.Forms.ComboBox cmbRadnoVrijeme;
        private System.Windows.Forms.Button btnDodajSmjenu;
        private System.Windows.Forms.Button btnNatrag;
    }
}