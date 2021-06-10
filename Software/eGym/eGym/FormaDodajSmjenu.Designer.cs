
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
            this.lblImeiPrezime = new System.Windows.Forms.Label();
            this.cmbPrezime = new System.Windows.Forms.ComboBox();
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.btnDodajSmjenu = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "eGym";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj smjenu";
            // 
            // lblRadnoVrijeme
            // 
            this.lblRadnoVrijeme.AutoSize = true;
            this.lblRadnoVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnoVrijeme.Location = new System.Drawing.Point(51, 225);
            this.lblRadnoVrijeme.Name = "lblRadnoVrijeme";
            this.lblRadnoVrijeme.Size = new System.Drawing.Size(101, 18);
            this.lblRadnoVrijeme.TabIndex = 39;
            this.lblRadnoVrijeme.Text = "Naziv smjene:";
            // 
            // lblImeiPrezime
            // 
            this.lblImeiPrezime.AutoSize = true;
            this.lblImeiPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeiPrezime.Location = new System.Drawing.Point(7, 177);
            this.lblImeiPrezime.Name = "lblImeiPrezime";
            this.lblImeiPrezime.Size = new System.Drawing.Size(150, 18);
            this.lblImeiPrezime.TabIndex = 37;
            this.lblImeiPrezime.Text = "Prezime zaposlenika:";
            // 
            // cmbPrezime
            // 
            this.cmbPrezime.FormattingEnabled = true;
            this.cmbPrezime.Location = new System.Drawing.Point(173, 177);
            this.cmbPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPrezime.Name = "cmbPrezime";
            this.cmbPrezime.Size = new System.Drawing.Size(217, 24);
            this.cmbPrezime.TabIndex = 40;
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(173, 224);
            this.cmbNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(217, 24);
            this.cmbNaziv.TabIndex = 42;
            // 
            // btnDodajSmjenu
            // 
            this.btnDodajSmjenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajSmjenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSmjenu.ForeColor = System.Drawing.Color.White;
            this.btnDodajSmjenu.Location = new System.Drawing.Point(269, 331);
            this.btnDodajSmjenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSmjenu.Name = "btnDodajSmjenu";
            this.btnDodajSmjenu.Size = new System.Drawing.Size(123, 50);
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
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.cmbPrezime);
            this.Controls.Add(this.lblRadnoVrijeme);
            this.Controls.Add(this.lblImeiPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaDodajSmjenu";
            this.Text = "Dodaj smjenu";
            this.Load += new System.EventHandler(this.FormaDodajSmjenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRadnoVrijeme;
        private System.Windows.Forms.Label lblImeiPrezime;
        private System.Windows.Forms.ComboBox cmbPrezime;
        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.Button btnDodajSmjenu;
        private System.Windows.Forms.Button btnNatrag;
    }
}