
namespace eGym
{
    partial class FormaIzvjesce
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnNatragIzvjesce = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NaruceniSuplementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NaruceniSuplementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 44);
            this.label2.TabIndex = 85;
            this.label2.Text = "eGym";
            // 
            // btnNatragIzvjesce
            // 
            this.btnNatragIzvjesce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragIzvjesce.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragIzvjesce.ForeColor = System.Drawing.Color.White;
            this.btnNatragIzvjesce.Location = new System.Drawing.Point(46, 356);
            this.btnNatragIzvjesce.Margin = new System.Windows.Forms.Padding(2);
            this.btnNatragIzvjesce.Name = "btnNatragIzvjesce";
            this.btnNatragIzvjesce.Size = new System.Drawing.Size(88, 41);
            this.btnNatragIzvjesce.TabIndex = 92;
            this.btnNatragIzvjesce.Text = "Natrag";
            this.btnNatragIzvjesce.UseVisualStyleBackColor = false;
            this.btnNatragIzvjesce.Click += new System.EventHandler(this.btnNatragIzvjesce_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eGym.NaruceniSuplementi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(645, 246);
            this.reportViewer1.TabIndex = 95;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // NaruceniSuplementBindingSource
            // 
            this.NaruceniSuplementBindingSource.DataSource = typeof(Pristup_podacima.NaruceniSuplement);
            this.NaruceniSuplementBindingSource.CurrentChanged += new System.EventHandler(this.NaruceniSuplementBindingSource_CurrentChanged);
            // 
            // KorisnikBindingSource
            // 
            this.KorisnikBindingSource.DataSource = typeof(Pristup_podacima.Korisnik);
            // 
            // FormaIzvjesce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 454);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnNatragIzvjesce);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaIzvjesce";
            this.Text = "FormaIzvjesce";
            this.Load += new System.EventHandler(this.FormaIzvjesce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NaruceniSuplementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNatragIzvjesce;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NaruceniSuplementBindingSource;
        private System.Windows.Forms.BindingSource KorisnikBindingSource;
    }
}