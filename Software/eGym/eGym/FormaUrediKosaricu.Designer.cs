
namespace eGym
{
    partial class FormaUrediKosaricu
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
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.cmbKolicina = new System.Windows.Forms.ComboBox();
            this.cmbPopisSuplemenata = new System.Windows.Forms.ComboBox();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblPopisSuplemenata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Location = new System.Drawing.Point(233, 253);
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.Size = new System.Drawing.Size(218, 22);
            this.txtUkupanIznos.TabIndex = 82;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(329, 313);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(122, 50);
            this.btnSpremi.TabIndex = 81;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(81, 313);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(117, 50);
            this.btnNatrag.TabIndex = 79;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.FormattingEnabled = true;
            this.cmbKolicina.Location = new System.Drawing.Point(233, 213);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(218, 24);
            this.cmbKolicina.TabIndex = 78;
            // 
            // cmbPopisSuplemenata
            // 
            this.cmbPopisSuplemenata.FormattingEnabled = true;
            this.cmbPopisSuplemenata.Location = new System.Drawing.Point(233, 173);
            this.cmbPopisSuplemenata.Name = "cmbPopisSuplemenata";
            this.cmbPopisSuplemenata.Size = new System.Drawing.Size(218, 24);
            this.cmbPopisSuplemenata.TabIndex = 77;
            // 
            // lblUkupanIznos
            // 
            this.lblUkupanIznos.AutoSize = true;
            this.lblUkupanIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupanIznos.Location = new System.Drawing.Point(101, 258);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(103, 18);
            this.lblUkupanIznos.TabIndex = 75;
            this.lblUkupanIznos.Text = "Ukupan iznos:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(140, 216);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(64, 18);
            this.lblKolicina.TabIndex = 76;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblPopisSuplemenata
            // 
            this.lblPopisSuplemenata.AutoSize = true;
            this.lblPopisSuplemenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisSuplemenata.Location = new System.Drawing.Point(66, 174);
            this.lblPopisSuplemenata.Name = "lblPopisSuplemenata";
            this.lblPopisSuplemenata.Size = new System.Drawing.Size(138, 18);
            this.lblPopisSuplemenata.TabIndex = 74;
            this.lblPopisSuplemenata.Text = "Popis suplemenata:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 72;
            this.label1.Text = "Uredi košaricu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 71;
            this.label2.Text = "eGym";
            // 
            // FormaUrediKosaricu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 409);
            this.Controls.Add(this.txtUkupanIznos);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.cmbPopisSuplemenata);
            this.Controls.Add(this.lblUkupanIznos);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblPopisSuplemenata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormaUrediKosaricu";
            this.Text = "Uredi košaricu";
            this.Load += new System.EventHandler(this.FormaUrediKosaricu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.ComboBox cmbKolicina;
        private System.Windows.Forms.ComboBox cmbPopisSuplemenata;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblPopisSuplemenata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}