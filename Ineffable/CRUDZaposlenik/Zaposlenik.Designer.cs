namespace CRUDZaposlenik
{
    partial class Zaposlenik
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lbImePrezime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::CRUDZaposlenik.Properties.Resources.x_user;
            this.pbAvatar.Location = new System.Drawing.Point(3, 3);
            this.pbAvatar.MaximumSize = new System.Drawing.Size(140, 140);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(128, 128);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Zaposlenik_MouseClick);
            // 
            // lbImePrezime
            // 
            this.lbImePrezime.AutoSize = true;
            this.lbImePrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lbImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImePrezime.Location = new System.Drawing.Point(69, 115);
            this.lbImePrezime.Name = "lbImePrezime";
            this.lbImePrezime.Size = new System.Drawing.Size(41, 15);
            this.lbImePrezime.TabIndex = 1;
            this.lbImePrezime.Text = "label1";
            // 
            // Zaposlenik
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.lbImePrezime);
            this.Controls.Add(this.pbAvatar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Zaposlenik";
            this.Size = new System.Drawing.Size(133, 134);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Zaposlenik_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lbImePrezime;
    }
}
