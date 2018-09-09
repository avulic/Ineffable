namespace CRUDZaposlenik
{
    partial class frmZaposlenik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbImeZaposlenika = new System.Windows.Forms.TextBox();
            this.tbPrezimeZaposlenika = new System.Windows.Forms.TextBox();
            this.btnSpremiKor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.cbUlogaZaposlenika = new System.Windows.Forms.ComboBox();
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSetUloga = new CRUDZaposlenik.IneffableDataSetUloga();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKorIme = new System.Windows.Forms.TextBox();
            this.tbLozinkaZaposlenika = new System.Windows.Forms.TextBox();
            this.tbAdresaZaposlenika = new System.Windows.Forms.TextBox();
            this.tbTelefonZaposlenika = new System.Windows.Forms.TextBox();
            this.cbSpolZaposlenika = new System.Windows.Forms.ComboBox();
            this.ulogaTableAdapter = new CRUDZaposlenik.IneffableDataSetUlogaTableAdapters.ulogaTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSetUloga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uloga";
            // 
            // tbImeZaposlenika
            // 
            this.tbImeZaposlenika.Enabled = false;
            this.tbImeZaposlenika.Location = new System.Drawing.Point(173, 278);
            this.tbImeZaposlenika.Name = "tbImeZaposlenika";
            this.tbImeZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbImeZaposlenika.TabIndex = 3;
            // 
            // tbPrezimeZaposlenika
            // 
            this.tbPrezimeZaposlenika.Enabled = false;
            this.tbPrezimeZaposlenika.Location = new System.Drawing.Point(173, 305);
            this.tbPrezimeZaposlenika.Name = "tbPrezimeZaposlenika";
            this.tbPrezimeZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbPrezimeZaposlenika.TabIndex = 4;
            // 
            // btnSpremiKor
            // 
            this.btnSpremiKor.Enabled = false;
            this.btnSpremiKor.Location = new System.Drawing.Point(128, 507);
            this.btnSpremiKor.Name = "btnSpremiKor";
            this.btnSpremiKor.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiKor.TabIndex = 8;
            this.btnSpremiKor.Text = "Spremi";
            this.btnSpremiKor.UseVisualStyleBackColor = true;
            this.btnSpremiKor.Click += new System.EventHandler(this.spremizmjene_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUDZaposlenik.Properties.Resources.edit;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.izbmjeni_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CRUDZaposlenik.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(76, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.izbrisi_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAvatar.Location = new System.Drawing.Point(107, 124);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(144, 126);
            this.pbAvatar.TabIndex = 6;
            this.pbAvatar.TabStop = false;
            // 
            // cbUlogaZaposlenika
            // 
            this.cbUlogaZaposlenika.DataSource = this.ulogaBindingSource;
            this.cbUlogaZaposlenika.DisplayMember = "naziv";
            this.cbUlogaZaposlenika.Enabled = false;
            this.cbUlogaZaposlenika.FormattingEnabled = true;
            this.cbUlogaZaposlenika.Location = new System.Drawing.Point(173, 335);
            this.cbUlogaZaposlenika.Name = "cbUlogaZaposlenika";
            this.cbUlogaZaposlenika.Size = new System.Drawing.Size(100, 21);
            this.cbUlogaZaposlenika.TabIndex = 10;
            this.cbUlogaZaposlenika.ValueMember = "uloga_id";
            // 
            // ulogaBindingSource
            // 
            this.ulogaBindingSource.DataMember = "uloga";
            this.ulogaBindingSource.DataSource = this.ineffableDataSetUloga;
            // 
            // ineffableDataSetUloga
            // 
            this.ineffableDataSetUloga.DataSetName = "IneffableDataSetUloga";
            this.ineffableDataSetUloga.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Spol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Korisničko ime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lozinka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(57, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefon";
            // 
            // tbKorIme
            // 
            this.tbKorIme.Enabled = false;
            this.tbKorIme.Location = new System.Drawing.Point(173, 398);
            this.tbKorIme.Name = "tbKorIme";
            this.tbKorIme.Size = new System.Drawing.Size(100, 20);
            this.tbKorIme.TabIndex = 16;
            // 
            // tbLozinkaZaposlenika
            // 
            this.tbLozinkaZaposlenika.Enabled = false;
            this.tbLozinkaZaposlenika.Location = new System.Drawing.Point(173, 424);
            this.tbLozinkaZaposlenika.Name = "tbLozinkaZaposlenika";
            this.tbLozinkaZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbLozinkaZaposlenika.TabIndex = 17;
            // 
            // tbAdresaZaposlenika
            // 
            this.tbAdresaZaposlenika.Enabled = false;
            this.tbAdresaZaposlenika.Location = new System.Drawing.Point(173, 450);
            this.tbAdresaZaposlenika.Name = "tbAdresaZaposlenika";
            this.tbAdresaZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbAdresaZaposlenika.TabIndex = 18;
            // 
            // tbTelefonZaposlenika
            // 
            this.tbTelefonZaposlenika.Enabled = false;
            this.tbTelefonZaposlenika.Location = new System.Drawing.Point(173, 476);
            this.tbTelefonZaposlenika.Name = "tbTelefonZaposlenika";
            this.tbTelefonZaposlenika.Size = new System.Drawing.Size(100, 20);
            this.tbTelefonZaposlenika.TabIndex = 19;
            // 
            // cbSpolZaposlenika
            // 
            this.cbSpolZaposlenika.DisplayMember = "uloga_id";
            this.cbSpolZaposlenika.Enabled = false;
            this.cbSpolZaposlenika.FormattingEnabled = true;
            this.cbSpolZaposlenika.Location = new System.Drawing.Point(173, 363);
            this.cbSpolZaposlenika.Name = "cbSpolZaposlenika";
            this.cbSpolZaposlenika.Size = new System.Drawing.Size(100, 21);
            this.cbSpolZaposlenika.TabIndex = 20;
            this.cbSpolZaposlenika.ValueMember = "uloga_id";
            // 
            // ulogaTableAdapter
            // 
            this.ulogaTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Izmjeni";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(74, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Izbriši";
            // 
            // frmZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(343, 542);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.cbUlogaZaposlenika);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpremiKor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.tbPrezimeZaposlenika);
            this.Controls.Add(this.tbImeZaposlenika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmZaposlenik";
            this.Text = "frmZaposlenik";
            this.Load += new System.EventHandler(this.frmZaposlenik_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmZaposlenik_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSetUloga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbImeZaposlenika;
        private System.Windows.Forms.TextBox tbPrezimeZaposlenika;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSpremiKor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbUlogaZaposlenika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKorIme;
        private System.Windows.Forms.TextBox tbLozinkaZaposlenika;
        private System.Windows.Forms.TextBox tbAdresaZaposlenika;
        private System.Windows.Forms.TextBox tbTelefonZaposlenika;
        private System.Windows.Forms.ComboBox cbSpolZaposlenika;
        private IneffableDataSetUloga ineffableDataSetUloga;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
        private IneffableDataSetUlogaTableAdapters.ulogaTableAdapter ulogaTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}