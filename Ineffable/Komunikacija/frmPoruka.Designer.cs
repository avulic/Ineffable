namespace Komunikacija
{
    partial class frmPoruka
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
            this.btnPosaljiPoruku = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPosaljiPoruku
            // 
            this.btnPosaljiPoruku.Location = new System.Drawing.Point(192, 263);
            this.btnPosaljiPoruku.Name = "btnPosaljiPoruku";
            this.btnPosaljiPoruku.Size = new System.Drawing.Size(64, 23);
            this.btnPosaljiPoruku.TabIndex = 13;
            this.btnPosaljiPoruku.Text = "Pošalji";
            this.btnPosaljiPoruku.UseVisualStyleBackColor = true;
            this.btnPosaljiPoruku.Click += new System.EventHandler(this.btnPosaljiPoruku_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(12, 11);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(79, 13);
            this.lblPoruka.TabIndex = 12;
            this.lblPoruka.Text = "Unesite poruku";
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(15, 30);
            this.txtPoruka.Multiline = true;
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(241, 227);
            this.txtPoruka.TabIndex = 11;
            // 
            // frmPoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 301);
            this.Controls.Add(this.btnPosaljiPoruku);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.txtPoruka);
            this.Name = "frmPoruka";
            this.Text = "Poruka";
            this.Load += new System.EventHandler(this.frmPoruka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosaljiPoruku;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.TextBox txtPoruka;
    }
}