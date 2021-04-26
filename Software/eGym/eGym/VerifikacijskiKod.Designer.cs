
namespace eGym
{
    partial class VerifikacijskiKod
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerifikacijskiKod = new System.Windows.Forms.TextBox();
            this.btnPredaj = new System.Windows.Forms.Button();
            this.btnVerifiKodNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Unesi dobiven kod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "eGym";
            // 
            // txtVerifikacijskiKod
            // 
            this.txtVerifikacijskiKod.Location = new System.Drawing.Point(217, 115);
            this.txtVerifikacijskiKod.Name = "txtVerifikacijskiKod";
            this.txtVerifikacijskiKod.Size = new System.Drawing.Size(144, 20);
            this.txtVerifikacijskiKod.TabIndex = 12;
            // 
            // btnPredaj
            // 
            this.btnPredaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPredaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredaj.ForeColor = System.Drawing.Color.White;
            this.btnPredaj.Location = new System.Drawing.Point(282, 156);
            this.btnPredaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnPredaj.Name = "btnPredaj";
            this.btnPredaj.Size = new System.Drawing.Size(79, 38);
            this.btnPredaj.TabIndex = 24;
            this.btnPredaj.Text = "Predaj";
            this.btnPredaj.UseVisualStyleBackColor = false;
            this.btnPredaj.Click += new System.EventHandler(this.btnPredaj_Click);
            // 
            // btnVerifiKodNatrag
            // 
            this.btnVerifiKodNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVerifiKodNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifiKodNatrag.ForeColor = System.Drawing.Color.White;
            this.btnVerifiKodNatrag.Location = new System.Drawing.Point(34, 197);
            this.btnVerifiKodNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerifiKodNatrag.Name = "btnVerifiKodNatrag";
            this.btnVerifiKodNatrag.Size = new System.Drawing.Size(79, 38);
            this.btnVerifiKodNatrag.TabIndex = 25;
            this.btnVerifiKodNatrag.Text = "Natrag";
            this.btnVerifiKodNatrag.UseVisualStyleBackColor = false;
            this.btnVerifiKodNatrag.Click += new System.EventHandler(this.btnVerifiKodNatrag_Click);
            // 
            // VerifikacijskiKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 246);
            this.Controls.Add(this.btnVerifiKodNatrag);
            this.Controls.Add(this.btnPredaj);
            this.Controls.Add(this.txtVerifikacijskiKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "VerifikacijskiKod";
            this.Text = "VerifikacijskiKod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerifikacijskiKod;
        private System.Windows.Forms.Button btnPredaj;
        private System.Windows.Forms.Button btnVerifiKodNatrag;
    }
}