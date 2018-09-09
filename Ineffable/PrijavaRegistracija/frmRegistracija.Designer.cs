namespace PrijavaRegistracija
{
    partial class frmRegistracija
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
            this.lbReg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrijava = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKorIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.rbNeodredjeno = new System.Windows.Forms.RadioButton();
            this.rbMusko = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUloga = new System.Windows.Forms.Label();
            this.cbUloge = new System.Windows.Forms.ComboBox();
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new PrijavaRegistracija.IneffableDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.ulogaTableAdapter = new PrijavaRegistracija.IneffableDataSetTableAdapters.ulogaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReg
            // 
            this.lbReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbReg.AutoSize = true;
            this.lbReg.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReg.ForeColor = System.Drawing.Color.White;
            this.lbReg.Location = new System.Drawing.Point(142, 9);
            this.lbReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReg.Name = "lbReg";
            this.lbReg.Size = new System.Drawing.Size(129, 25);
            this.lbReg.TabIndex = 14;
            this.lbReg.Text = "Registracija";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.MaximumSize = new System.Drawing.Size(133, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 2);
            this.label5.TabIndex = 17;
            // 
            // btnReg
            // 
            this.btnReg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReg.Location = new System.Drawing.Point(147, 721);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(100, 28);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "Registracija";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbPrezime
            // 
            this.tbPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrezime.ForeColor = System.Drawing.Color.White;
            this.tbPrezime.Location = new System.Drawing.Point(29, 118);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(133, 15);
            this.tbPrezime.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime";
            // 
            // lbPrijava
            // 
            this.lbPrijava.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPrijava.AutoSize = true;
            this.lbPrijava.ForeColor = System.Drawing.Color.White;
            this.lbPrijava.Location = new System.Drawing.Point(164, 753);
            this.lbPrijava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrijava.Name = "lbPrijava";
            this.lbPrijava.Size = new System.Drawing.Size(63, 16);
            this.lbPrijava.TabIndex = 15;
            this.lbPrijava.Text = "Prijavi se";
            this.lbPrijava.Click += new System.EventHandler(this.lbPrijava_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.MaximumSize = new System.Drawing.Size(133, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 2);
            this.label6.TabIndex = 20;
            // 
            // tbKorIme
            // 
            this.tbKorIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbKorIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKorIme.ForeColor = System.Drawing.Color.White;
            this.tbKorIme.Location = new System.Drawing.Point(29, 183);
            this.tbKorIme.Margin = new System.Windows.Forms.Padding(4);
            this.tbKorIme.Name = "tbKorIme";
            this.tbKorIme.Size = new System.Drawing.Size(133, 15);
            this.tbKorIme.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Korisnicko ime";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.MaximumSize = new System.Drawing.Size(133, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 2);
            this.label8.TabIndex = 23;
            // 
            // tbLozinka
            // 
            this.tbLozinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLozinka.ForeColor = System.Drawing.Color.White;
            this.tbLozinka.Location = new System.Drawing.Point(29, 247);
            this.tbLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(133, 15);
            this.tbLozinka.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Lozinka";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 326);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.MaximumSize = new System.Drawing.Size(133, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 2);
            this.label10.TabIndex = 26;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(29, 313);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(133, 15);
            this.tbEmail.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(29, 396);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.MaximumSize = new System.Drawing.Size(133, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 2);
            this.label12.TabIndex = 29;
            // 
            // tbAdresa
            // 
            this.tbAdresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdresa.ForeColor = System.Drawing.Color.White;
            this.tbAdresa.Location = new System.Drawing.Point(29, 383);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(133, 15);
            this.tbAdresa.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 349);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Adresa";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(29, 464);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.MaximumSize = new System.Drawing.Size(133, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 2);
            this.label14.TabIndex = 32;
            // 
            // tbTelefon
            // 
            this.tbTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelefon.ForeColor = System.Drawing.Color.White;
            this.tbTelefon.Location = new System.Drawing.Point(29, 450);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(133, 15);
            this.tbTelefon.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(9, 415);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Telefon";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(12, 482);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 18);
            this.label17.TabIndex = 33;
            this.label17.Text = "Spol";
            // 
            // tbIme
            // 
            this.tbIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIme.ForeColor = System.Drawing.Color.White;
            this.tbIme.Location = new System.Drawing.Point(29, 50);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(133, 15);
            this.tbIme.TabIndex = 12;
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.ForeColor = System.Drawing.Color.White;
            this.rbZensko.Location = new System.Drawing.Point(29, 551);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(71, 20);
            this.rbZensko.TabIndex = 36;
            this.rbZensko.Text = "Žensko";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbNeodredjeno
            // 
            this.rbNeodredjeno.AutoSize = true;
            this.rbNeodredjeno.ForeColor = System.Drawing.Color.White;
            this.rbNeodredjeno.Location = new System.Drawing.Point(29, 579);
            this.rbNeodredjeno.Name = "rbNeodredjeno";
            this.rbNeodredjeno.Size = new System.Drawing.Size(103, 20);
            this.rbNeodredjeno.TabIndex = 37;
            this.rbNeodredjeno.Text = "Neodređeno";
            this.rbNeodredjeno.UseVisualStyleBackColor = true;
            // 
            // rbMusko
            // 
            this.rbMusko.AutoSize = true;
            this.rbMusko.Checked = true;
            this.rbMusko.ForeColor = System.Drawing.Color.White;
            this.rbMusko.Location = new System.Drawing.Point(29, 521);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(66, 20);
            this.rbMusko.TabIndex = 38;
            this.rbMusko.TabStop = true;
            this.rbMusko.Text = "Muško";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lbUloga);
            this.groupBox1.Controls.Add(this.cbUloge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbZensko);
            this.groupBox1.Controls.Add(this.rbMusko);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.rbNeodredjeno);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTelefon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbPrezime);
            this.groupBox1.Controls.Add(this.tbAdresa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbKorIme);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbLozinka);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(101, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 660);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // lbUloga
            // 
            this.lbUloga.AutoSize = true;
            this.lbUloga.ForeColor = System.Drawing.Color.White;
            this.lbUloga.Location = new System.Drawing.Point(15, 606);
            this.lbUloga.Name = "lbUloga";
            this.lbUloga.Size = new System.Drawing.Size(45, 16);
            this.lbUloga.TabIndex = 42;
            this.lbUloga.Text = "Uloga";
            // 
            // cbUloge
            // 
            this.cbUloge.DataSource = this.ulogaBindingSource;
            this.cbUloge.DisplayMember = "naziv";
            this.cbUloge.Enabled = false;
            this.cbUloge.FormattingEnabled = true;
            this.cbUloge.Location = new System.Drawing.Point(29, 625);
            this.cbUloge.Name = "cbUloge";
            this.cbUloge.Size = new System.Drawing.Size(121, 24);
            this.cbUloge.TabIndex = 41;
            this.cbUloge.ValueMember = "uloga_id";
            // 
            // ulogaBindingSource
            // 
            this.ulogaBindingSource.DataMember = "uloga";
            this.ulogaBindingSource.DataSource = this.ineffableDataSet;
            // 
            // ineffableDataSet
            // 
            this.ineffableDataSet.DataSetName = "IneffableDataSet";
            this.ineffableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(133, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 2);
            this.label3.TabIndex = 40;
            // 
            // ulogaTableAdapter
            // 
            this.ulogaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(390, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbReg);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lbPrijava);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(390, 726);
            this.Name = "frmRegistracija";
            this.Text = "Registracija";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmRegistracija_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrijava;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKorIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.RadioButton rbZensko;
        private System.Windows.Forms.RadioButton rbNeodredjeno;
        private System.Windows.Forms.RadioButton rbMusko;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUloga;
        private System.Windows.Forms.ComboBox cbUloge;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
        private IneffableDataSetTableAdapters.ulogaTableAdapter ulogaTableAdapter;
    }
}