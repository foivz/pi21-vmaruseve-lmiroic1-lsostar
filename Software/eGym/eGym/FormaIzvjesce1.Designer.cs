
namespace eGym
{
    partial class FormaIzvjesce1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsNaruceniSuplement = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.rwNaruceniSuplementi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnNatragIzvjesce = new System.Windows.Forms.Button();
            this.NaruceniSuplementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsNaruceniSuplement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaruceniSuplementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bsNaruceniSuplement
            // 
            this.bsNaruceniSuplement.DataSource = typeof(Pristup_podacima.NaruceniSuplement);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 55);
            this.label2.TabIndex = 86;
            this.label2.Text = "eGym";
            // 
            // rwNaruceniSuplementi
            // 
            reportDataSource1.Name = "DsNaruceniSuplement";
            reportDataSource1.Value = this.bsNaruceniSuplement;
            this.rwNaruceniSuplementi.LocalReport.DataSources.Add(reportDataSource1);
            this.rwNaruceniSuplementi.LocalReport.ReportEmbeddedResource = "eGym.Izvjesce.rdlc";
            this.rwNaruceniSuplementi.Location = new System.Drawing.Point(133, 135);
            this.rwNaruceniSuplementi.Margin = new System.Windows.Forms.Padding(4);
            this.rwNaruceniSuplementi.Name = "rwNaruceniSuplementi";
            this.rwNaruceniSuplementi.ServerReport.BearerToken = null;
            this.rwNaruceniSuplementi.Size = new System.Drawing.Size(859, 302);
            this.rwNaruceniSuplementi.TabIndex = 96;
            // 
            // btnNatragIzvjesce
            // 
            this.btnNatragIzvjesce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNatragIzvjesce.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatragIzvjesce.ForeColor = System.Drawing.Color.White;
            this.btnNatragIzvjesce.Location = new System.Drawing.Point(69, 496);
            this.btnNatragIzvjesce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatragIzvjesce.Name = "btnNatragIzvjesce";
            this.btnNatragIzvjesce.Size = new System.Drawing.Size(117, 50);
            this.btnNatragIzvjesce.TabIndex = 97;
            this.btnNatragIzvjesce.Text = "Natrag";
            this.btnNatragIzvjesce.UseVisualStyleBackColor = false;
            // 
            // NaruceniSuplementBindingSource
            // 
            this.NaruceniSuplementBindingSource.DataSource = typeof(Pristup_podacima.NaruceniSuplement);
            // 
            // FormaIzvjesce1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 584);
            this.Controls.Add(this.btnNatragIzvjesce);
            this.Controls.Add(this.rwNaruceniSuplementi);
            this.Controls.Add(this.label2);
            this.Name = "FormaIzvjesce1";
            this.Text = "Izvješće O Naručenim Suplementima";
            this.Load += new System.EventHandler(this.FormaIzvjesce1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsNaruceniSuplement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NaruceniSuplementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rwNaruceniSuplementi;
        private System.Windows.Forms.Button btnNatragIzvjesce;
        private System.Windows.Forms.BindingSource bsNaruceniSuplement;
        private System.Windows.Forms.BindingSource NaruceniSuplementBindingSource;
    }
}