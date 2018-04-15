namespace BaseWindow
{
    partial class Form1
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
            this.prijava = new System.Windows.Forms.Button();
            this.registracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prijava
            // 
            this.prijava.Location = new System.Drawing.Point(90, 60);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(75, 23);
            this.prijava.TabIndex = 0;
            this.prijava.Text = "Prijava";
            this.prijava.UseVisualStyleBackColor = true;
            // 
            // registracija
            // 
            this.registracija.Location = new System.Drawing.Point(90, 126);
            this.registracija.Name = "registracija";
            this.registracija.Size = new System.Drawing.Size(75, 23);
            this.registracija.TabIndex = 1;
            this.registracija.Text = "Registracija";
            this.registracija.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.registracija);
            this.Controls.Add(this.prijava);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.Button registracija;
    }
}