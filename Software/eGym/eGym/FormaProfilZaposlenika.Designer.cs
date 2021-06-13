
namespace eGym
{
    partial class FormProfilZaposlenika
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
            this.btnSuplementi = new System.Windows.Forms.Button();
            this.btnClanovi = new System.Windows.Forms.Button();
            this.btnIzvjesce = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDobrosao = new System.Windows.Forms.Label();
            this.lblImeIPrezimeClana = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtImeZaposlenika = new System.Windows.Forms.TextBox();
            this.txtPrezimeZaposlenika = new System.Windows.Forms.TextBox();
            this.txtEmailZaposlenika = new System.Windows.Forms.TextBox();
            this.txtBrojTelefonaZaposlenika = new System.Windows.Forms.TextBox();
            this.btnTermini = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eGymToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuplementi
            // 
            this.btnSuplementi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSuplementi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuplementi.ForeColor = System.Drawing.Color.White;
            this.btnSuplementi.Location = new System.Drawing.Point(576, 241);
            this.btnSuplementi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuplementi.Name = "btnSuplementi";
            this.btnSuplementi.Size = new System.Drawing.Size(115, 55);
            this.btnSuplementi.TabIndex = 45;
            this.btnSuplementi.Text = "Suplementi";
            this.btnSuplementi.UseVisualStyleBackColor = false;
            this.btnSuplementi.Click += new System.EventHandler(this.btnSuplementi_Click);
            // 
            // btnClanovi
            // 
            this.btnClanovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClanovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClanovi.ForeColor = System.Drawing.Color.White;
            this.btnClanovi.Location = new System.Drawing.Point(576, 166);
            this.btnClanovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClanovi.Name = "btnClanovi";
            this.btnClanovi.Size = new System.Drawing.Size(115, 50);
            this.btnClanovi.TabIndex = 43;
            this.btnClanovi.Text = "Članovi";
            this.btnClanovi.UseVisualStyleBackColor = false;
            this.btnClanovi.Click += new System.EventHandler(this.btnClanovi_Click);
            // 
            // btnIzvjesce
            // 
            this.btnIzvjesce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIzvjesce.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvjesce.ForeColor = System.Drawing.Color.White;
            this.btnIzvjesce.Location = new System.Drawing.Point(576, 393);
            this.btnIzvjesce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzvjesce.Name = "btnIzvjesce";
            this.btnIzvjesce.Size = new System.Drawing.Size(115, 55);
            this.btnIzvjesce.TabIndex = 47;
            this.btnIzvjesce.Text = "Izvješće";
            this.btnIzvjesce.UseVisualStyleBackColor = false;
            this.btnIzvjesce.Click += new System.EventHandler(this.btnIzvjesce_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Gray;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Location = new System.Drawing.Point(585, 495);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(105, 50);
            this.btnOdjava.TabIndex = 48;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "eGym";
            // 
            // lblDobrosao
            // 
            this.lblDobrosao.AutoSize = true;
            this.lblDobrosao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrosao.Location = new System.Drawing.Point(85, 117);
            this.lblDobrosao.Name = "lblDobrosao";
            this.lblDobrosao.Size = new System.Drawing.Size(124, 25);
            this.lblDobrosao.TabIndex = 24;
            this.lblDobrosao.Text = "Dobrodošao,";
            // 
            // lblImeIPrezimeClana
            // 
            this.lblImeIPrezimeClana.AutoSize = true;
            this.lblImeIPrezimeClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeIPrezimeClana.Location = new System.Drawing.Point(223, 117);
            this.lblImeIPrezimeClana.Name = "lblImeIPrezimeClana";
            this.lblImeIPrezimeClana.Size = new System.Drawing.Size(46, 25);
            this.lblImeIPrezimeClana.TabIndex = 25;
            this.lblImeIPrezimeClana.Text = "N/A";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(164, 171);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 18);
            this.lblIme.TabIndex = 26;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(135, 207);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(67, 18);
            this.lblPrezime.TabIndex = 27;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(147, 242);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 18);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojTelefona.Location = new System.Drawing.Point(107, 279);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(95, 18);
            this.lblBrojTelefona.TabIndex = 29;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // txtImeZaposlenika
            // 
            this.txtImeZaposlenika.Location = new System.Drawing.Point(228, 166);
            this.txtImeZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImeZaposlenika.Name = "txtImeZaposlenika";
            this.txtImeZaposlenika.Size = new System.Drawing.Size(183, 22);
            this.txtImeZaposlenika.TabIndex = 34;
            // 
            // txtPrezimeZaposlenika
            // 
            this.txtPrezimeZaposlenika.Location = new System.Drawing.Point(228, 203);
            this.txtPrezimeZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezimeZaposlenika.Name = "txtPrezimeZaposlenika";
            this.txtPrezimeZaposlenika.Size = new System.Drawing.Size(183, 22);
            this.txtPrezimeZaposlenika.TabIndex = 35;
            // 
            // txtEmailZaposlenika
            // 
            this.txtEmailZaposlenika.Location = new System.Drawing.Point(228, 240);
            this.txtEmailZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailZaposlenika.Name = "txtEmailZaposlenika";
            this.txtEmailZaposlenika.Size = new System.Drawing.Size(183, 22);
            this.txtEmailZaposlenika.TabIndex = 36;
            // 
            // txtBrojTelefonaZaposlenika
            // 
            this.txtBrojTelefonaZaposlenika.Location = new System.Drawing.Point(228, 276);
            this.txtBrojTelefonaZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrojTelefonaZaposlenika.Name = "txtBrojTelefonaZaposlenika";
            this.txtBrojTelefonaZaposlenika.Size = new System.Drawing.Size(183, 22);
            this.txtBrojTelefonaZaposlenika.TabIndex = 37;
            // 
            // btnTermini
            // 
            this.btnTermini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTermini.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermini.ForeColor = System.Drawing.Color.White;
            this.btnTermini.Location = new System.Drawing.Point(576, 315);
            this.btnTermini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTermini.Name = "btnTermini";
            this.btnTermini.Size = new System.Drawing.Size(115, 55);
            this.btnTermini.TabIndex = 49;
            this.btnTermini.Text = "Termini";
            this.btnTermini.UseVisualStyleBackColor = false;
            this.btnTermini.Click += new System.EventHandler(this.btnTermini_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 28);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eGymToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem1.Text = "Help";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // eGymToolStripMenuItem
            // 
            this.eGymToolStripMenuItem.Name = "eGymToolStripMenuItem";
            this.eGymToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.eGymToolStripMenuItem.Text = "Korisnički priručnik";
            this.eGymToolStripMenuItem.Click += new System.EventHandler(this.eGymToolStripMenuItem_Click);
            // 
            // FormProfilZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 612);
            this.Controls.Add(this.btnTermini);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnIzvjesce);
            this.Controls.Add(this.btnSuplementi);
            this.Controls.Add(this.btnClanovi);
            this.Controls.Add(this.txtBrojTelefonaZaposlenika);
            this.Controls.Add(this.txtEmailZaposlenika);
            this.Controls.Add(this.txtPrezimeZaposlenika);
            this.Controls.Add(this.txtImeZaposlenika);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblImeIPrezimeClana);
            this.Controls.Add(this.lblDobrosao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProfilZaposlenika";
            this.Text = "Zaposlenik";
            this.Load += new System.EventHandler(this.FormProfilZaposlenika_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormProfilZaposlenika_HelpRequested);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuplementi;
        private System.Windows.Forms.Button btnClanovi;
        private System.Windows.Forms.Button btnIzvjesce;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDobrosao;
        private System.Windows.Forms.Label lblImeIPrezimeClana;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox txtImeZaposlenika;
        private System.Windows.Forms.TextBox txtPrezimeZaposlenika;
        private System.Windows.Forms.TextBox txtEmailZaposlenika;
        private System.Windows.Forms.TextBox txtBrojTelefonaZaposlenika;
        private System.Windows.Forms.Button btnTermini;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eGymToolStripMenuItem;
    }
}

