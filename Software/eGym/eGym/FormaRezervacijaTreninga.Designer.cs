
namespace eGym
{
    partial class FormaRezervacijaTreninga
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIndividualniTrening = new System.Windows.Forms.Button();
            this.btnGrupniTrening = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "eGym";
            // 
            // btnIndividualniTrening
            // 
            this.btnIndividualniTrening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIndividualniTrening.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndividualniTrening.ForeColor = System.Drawing.Color.White;
            this.btnIndividualniTrening.Location = new System.Drawing.Point(38, 123);
            this.btnIndividualniTrening.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIndividualniTrening.Name = "btnIndividualniTrening";
            this.btnIndividualniTrening.Size = new System.Drawing.Size(224, 115);
            this.btnIndividualniTrening.TabIndex = 3;
            this.btnIndividualniTrening.Text = "Individualni trening";
            this.btnIndividualniTrening.UseVisualStyleBackColor = false;
            this.btnIndividualniTrening.Click += new System.EventHandler(this.btnIndividualniTrening_Click);
            // 
            // btnGrupniTrening
            // 
            this.btnGrupniTrening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGrupniTrening.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupniTrening.ForeColor = System.Drawing.Color.White;
            this.btnGrupniTrening.Location = new System.Drawing.Point(304, 123);
            this.btnGrupniTrening.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrupniTrening.Name = "btnGrupniTrening";
            this.btnGrupniTrening.Size = new System.Drawing.Size(224, 115);
            this.btnGrupniTrening.TabIndex = 3;
            this.btnGrupniTrening.Text = "Grupni trening";
            this.btnGrupniTrening.UseVisualStyleBackColor = false;
            this.btnGrupniTrening.Click += new System.EventHandler(this.btnGrupniTrening_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(16, 306);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(79, 38);
            this.btnNatrag.TabIndex = 20;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FormaRezervacijaTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnGrupniTrening);
            this.Controls.Add(this.btnIndividualniTrening);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaRezervacijaTreninga";
            this.Text = "FormaRezervacijaTreninga";
            this.Load += new System.EventHandler(this.FormaRezervacijaTreninga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIndividualniTrening;
        private System.Windows.Forms.Button btnGrupniTrening;
        private System.Windows.Forms.Button btnNatrag;
    }
}