
namespace eGym
{
    partial class FormaPrijava
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtLozinkaPrijava = new System.Windows.Forms.TextBox();
            this.txtUsernamePrijava = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnPrijavaNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(499, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "PRIJAVA";
            // 
            // txtLozinkaPrijava
            // 
            this.txtLozinkaPrijava.Location = new System.Drawing.Point(440, 302);
            this.txtLozinkaPrijava.Margin = new System.Windows.Forms.Padding(4);
            this.txtLozinkaPrijava.Name = "txtLozinkaPrijava";
            this.txtLozinkaPrijava.PasswordChar = '*';
            this.txtLozinkaPrijava.Size = new System.Drawing.Size(271, 22);
            this.txtLozinkaPrijava.TabIndex = 14;
            // 
            // txtUsernamePrijava
            // 
            this.txtUsernamePrijava.Location = new System.Drawing.Point(440, 230);
            this.txtUsernamePrijava.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsernamePrijava.Name = "txtUsernamePrijava";
            this.txtUsernamePrijava.Size = new System.Drawing.Size(271, 22);
            this.txtUsernamePrijava.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(252, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lozinka:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(252, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Korisničko ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 69);
            this.label1.TabIndex = 10;
            this.label1.Text = "eGym";
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.Location = new System.Drawing.Point(607, 352);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(105, 47);
            this.btnPrijava.TabIndex = 24;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnPrijavaNatrag
            // 
            this.btnPrijavaNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPrijavaNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijavaNatrag.ForeColor = System.Drawing.Color.White;
            this.btnPrijavaNatrag.Location = new System.Drawing.Point(44, 476);
            this.btnPrijavaNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrijavaNatrag.Name = "btnPrijavaNatrag";
            this.btnPrijavaNatrag.Size = new System.Drawing.Size(105, 47);
            this.btnPrijavaNatrag.TabIndex = 25;
            this.btnPrijavaNatrag.Text = "Natrag";
            this.btnPrijavaNatrag.UseVisualStyleBackColor = false;
            this.btnPrijavaNatrag.Click += new System.EventHandler(this.btnPrijavaNatrag_Click);
            // 
            // FormaPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPrijavaNatrag);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLozinkaPrijava);
            this.Controls.Add(this.txtUsernamePrijava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaPrijava";
            this.Text = "FormaPrijava";
            this.Load += new System.EventHandler(this.FormaPrijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLozinkaPrijava;
        private System.Windows.Forms.TextBox txtUsernamePrijava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnPrijavaNatrag;
    }
}