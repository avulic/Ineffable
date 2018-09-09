namespace CRUDKupaca
{
    partial class frmKupac
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
            this.cbSpolZaposlenika = new System.Windows.Forms.ComboBox();
            this.tbTelefonZaposlenika = new System.Windows.Forms.TextBox();
            this.tbAdresaZaposlenika = new System.Windows.Forms.TextBox();
            this.tbLozinkaZaposlenika = new System.Windows.Forms.TextBox();
            this.tbKorIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbIzmjeni = new System.Windows.Forms.PictureBox();
            this.btnSpremiKor = new System.Windows.Forms.Button();
            this.tbPrezimeZaposlenika = new System.Windows.Forms.TextBox();
            this.tbImeZaposlenika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzmjeni)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSpolZaposlenika
            // 
            this.cbSpolZaposlenika.DisplayMember = "uloga_id";
            this.cbSpolZaposlenika.Enabled = false;
            this.cbSpolZaposlenika.FormattingEnabled = true;
            this.cbSpolZaposlenika.Location = new System.Drawing.Point(150, 181);
            this.cbSpolZaposlenika.Name = "cbSpolZaposlenika";
            this.cbSpolZaposlenika.Size = new System.Drawing.Size(100, 21);
            this.cbSpolZaposlenika.TabIndex = 40;
            this.cbSpolZaposlenika.ValueMember = "uloga_id";
            // 
            // tbTelefonZaposlenika
            // 
            this.tbTelefonZaposlenika.Enabled = false;
            this.tbTelefonZaposlenika.Location = new System.Drawing.Point(150, 294);
            this.tbTelefonZaposlenika.Name = "tbTelefonZaposlenika";
            this.tbTelefonZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbTelefonZaposlenika.TabIndex = 39;
            // 
            // tbAdresaZaposlenika
            // 
            this.tbAdresaZaposlenika.Enabled = false;
            this.tbAdresaZaposlenika.Location = new System.Drawing.Point(150, 268);
            this.tbAdresaZaposlenika.Name = "tbAdresaZaposlenika";
            this.tbAdresaZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbAdresaZaposlenika.TabIndex = 38;
            // 
            // tbLozinkaZaposlenika
            // 
            this.tbLozinkaZaposlenika.Enabled = false;
            this.tbLozinkaZaposlenika.Location = new System.Drawing.Point(150, 242);
            this.tbLozinkaZaposlenika.Name = "tbLozinkaZaposlenika";
            this.tbLozinkaZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbLozinkaZaposlenika.TabIndex = 37;
            // 
            // tbKorIme
            // 
            this.tbKorIme.Enabled = false;
            this.tbKorIme.Location = new System.Drawing.Point(150, 216);
            this.tbKorIme.Name = "tbKorIme";
            this.tbKorIme.Size = new System.Drawing.Size(100, 20);
            this.tbKorIme.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Lozinka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Korisničko ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Spol";
            // 
            // pbIzmjeni
            // 
            this.pbIzmjeni.Image = global::CRUDKupaca.Properties.Resources.edit_kupac;
            this.pbIzmjeni.Location = new System.Drawing.Point(7, 17);
            this.pbIzmjeni.Name = "pbIzmjeni";
            this.pbIzmjeni.Size = new System.Drawing.Size(51, 49);
            this.pbIzmjeni.TabIndex = 29;
            this.pbIzmjeni.TabStop = false;
            this.pbIzmjeni.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSpremiKor
            // 
            this.btnSpremiKor.Enabled = false;
            this.btnSpremiKor.ForeColor = System.Drawing.Color.Black;
            this.btnSpremiKor.Location = new System.Drawing.Point(105, 325);
            this.btnSpremiKor.Name = "btnSpremiKor";
            this.btnSpremiKor.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiKor.TabIndex = 28;
            this.btnSpremiKor.Text = "Spremi";
            this.btnSpremiKor.UseVisualStyleBackColor = true;
            this.btnSpremiKor.Click += new System.EventHandler(this.btnSpremiKor_Click);
            // 
            // tbPrezimeZaposlenika
            // 
            this.tbPrezimeZaposlenika.Enabled = false;
            this.tbPrezimeZaposlenika.Location = new System.Drawing.Point(150, 150);
            this.tbPrezimeZaposlenika.Name = "tbPrezimeZaposlenika";
            this.tbPrezimeZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbPrezimeZaposlenika.TabIndex = 25;
            // 
            // tbImeZaposlenika
            // 
            this.tbImeZaposlenika.Enabled = false;
            this.tbImeZaposlenika.Location = new System.Drawing.Point(150, 123);
            this.tbImeZaposlenika.Name = "tbImeZaposlenika";
            this.tbImeZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbImeZaposlenika.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Izmjeni";
            // 
            // frmKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(284, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSpolZaposlenika);
            this.Controls.Add(this.tbTelefonZaposlenika);
            this.Controls.Add(this.tbAdresaZaposlenika);
            this.Controls.Add(this.tbLozinkaZaposlenika);
            this.Controls.Add(this.tbKorIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbIzmjeni);
            this.Controls.Add(this.btnSpremiKor);
            this.Controls.Add(this.tbPrezimeZaposlenika);
            this.Controls.Add(this.tbImeZaposlenika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmKupac";
            this.Text = "frmKupac";
            this.Load += new System.EventHandler(this.frmKupac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIzmjeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSpolZaposlenika;
        private System.Windows.Forms.TextBox tbTelefonZaposlenika;
        private System.Windows.Forms.TextBox tbAdresaZaposlenika;
        private System.Windows.Forms.TextBox tbLozinkaZaposlenika;
        private System.Windows.Forms.TextBox tbKorIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpremiKor;
        private System.Windows.Forms.TextBox tbPrezimeZaposlenika;
        private System.Windows.Forms.TextBox tbImeZaposlenika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pbIzmjeni;
    }
}