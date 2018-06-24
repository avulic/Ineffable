namespace QR_Kod
{
    partial class frmKreirajQRKod
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
            this.oznakaNalog = new System.Windows.Forms.TextBox();
            this.gumbKreiraj = new System.Windows.Forms.Button();
            this.qrKod = new System.Windows.Forms.PictureBox();
            this.Osoba = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uredjajNalog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opisNalog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusNalog = new System.Windows.Forms.ComboBox();
            this.skeniraj = new System.Windows.Forms.Button();
            this.serviseri = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new QR_Kod.IneffableDataSet();
            this.kupacNalog = new System.Windows.Forms.ComboBox();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupacTableAdapter = new QR_Kod.IneffableDataSetTableAdapters.kupacTableAdapter();
            this.korisnikTableAdapter = new QR_Kod.IneffableDataSetTableAdapters.korisnikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qrKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oznaka:";
            // 
            // oznakaNalog
            // 
            this.oznakaNalog.Location = new System.Drawing.Point(59, 46);
            this.oznakaNalog.Margin = new System.Windows.Forms.Padding(2);
            this.oznakaNalog.Name = "oznakaNalog";
            this.oznakaNalog.Size = new System.Drawing.Size(119, 20);
            this.oznakaNalog.TabIndex = 1;
            // 
            // gumbKreiraj
            // 
            this.gumbKreiraj.Location = new System.Drawing.Point(95, 327);
            this.gumbKreiraj.Margin = new System.Windows.Forms.Padding(2);
            this.gumbKreiraj.Name = "gumbKreiraj";
            this.gumbKreiraj.Size = new System.Drawing.Size(89, 20);
            this.gumbKreiraj.TabIndex = 2;
            this.gumbKreiraj.Text = "Kreiraj QR kod";
            this.gumbKreiraj.UseVisualStyleBackColor = true;
            this.gumbKreiraj.Click += new System.EventHandler(this.button1_Click);
            // 
            // qrKod
            // 
            this.qrKod.Location = new System.Drawing.Point(373, 106);
            this.qrKod.Margin = new System.Windows.Forms.Padding(2);
            this.qrKod.Name = "qrKod";
            this.qrKod.Size = new System.Drawing.Size(218, 240);
            this.qrKod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.qrKod.TabIndex = 3;
            this.qrKod.TabStop = false;
            // 
            // Osoba
            // 
            this.Osoba.AutoSize = true;
            this.Osoba.Location = new System.Drawing.Point(9, 76);
            this.Osoba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Osoba.Name = "Osoba";
            this.Osoba.Size = new System.Drawing.Size(41, 13);
            this.Osoba.TabIndex = 4;
            this.Osoba.Text = "Osoba:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uređaj:";
            // 
            // uredjajNalog
            // 
            this.uredjajNalog.Location = new System.Drawing.Point(59, 106);
            this.uredjajNalog.Margin = new System.Windows.Forms.Padding(2);
            this.uredjajNalog.Name = "uredjajNalog";
            this.uredjajNalog.Size = new System.Drawing.Size(119, 20);
            this.uredjajNalog.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serviser:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opis:";
            // 
            // opisNalog
            // 
            this.opisNalog.Location = new System.Drawing.Point(59, 166);
            this.opisNalog.Margin = new System.Windows.Forms.Padding(2);
            this.opisNalog.Multiline = true;
            this.opisNalog.Name = "opisNalog";
            this.opisNalog.Size = new System.Drawing.Size(119, 93);
            this.opisNalog.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status:";
            // 
            // statusNalog
            // 
            this.statusNalog.FormattingEnabled = true;
            this.statusNalog.Items.AddRange(new object[] {
            "Zaprimljeno",
            "Pregledano",
            "Kvar utvrđen",
            "Kvar nije utvrđen",
            "Popravak u tijeku",
            "Na čekanju",
            "Popravljeno",
            "Isporučeno"});
            this.statusNalog.Location = new System.Drawing.Point(241, 46);
            this.statusNalog.Margin = new System.Windows.Forms.Padding(2);
            this.statusNalog.Name = "statusNalog";
            this.statusNalog.Size = new System.Drawing.Size(128, 21);
            this.statusNalog.TabIndex = 13;
            // 
            // skeniraj
            // 
            this.skeniraj.Location = new System.Drawing.Point(241, 327);
            this.skeniraj.Margin = new System.Windows.Forms.Padding(2);
            this.skeniraj.Name = "skeniraj";
            this.skeniraj.Size = new System.Drawing.Size(89, 20);
            this.skeniraj.TabIndex = 14;
            this.skeniraj.Text = "Skeniraj QR kod";
            this.skeniraj.UseVisualStyleBackColor = true;
            this.skeniraj.Click += new System.EventHandler(this.skeniraj_Click);
            // 
            // serviseri
            // 
            this.serviseri.DataSource = this.korisnikBindingSource;
            this.serviseri.DisplayMember = "ime";
            this.serviseri.FormattingEnabled = true;
            this.serviseri.Location = new System.Drawing.Point(59, 136);
            this.serviseri.Margin = new System.Windows.Forms.Padding(2);
            this.serviseri.Name = "serviseri";
            this.serviseri.Size = new System.Drawing.Size(119, 21);
            this.serviseri.TabIndex = 15;
            this.serviseri.ValueMember = "korisnik_id";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "korisnik";
            this.korisnikBindingSource.DataSource = this.ineffableDataSet;
            // 
            // ineffableDataSet
            // 
            this.ineffableDataSet.DataSetName = "IneffableDataSet";
            this.ineffableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacNalog
            // 
            this.kupacNalog.DataSource = this.kupacBindingSource;
            this.kupacNalog.DisplayMember = "ime";
            this.kupacNalog.FormattingEnabled = true;
            this.kupacNalog.Location = new System.Drawing.Point(59, 73);
            this.kupacNalog.Margin = new System.Windows.Forms.Padding(2);
            this.kupacNalog.Name = "kupacNalog";
            this.kupacNalog.Size = new System.Drawing.Size(119, 21);
            this.kupacNalog.TabIndex = 16;
            this.kupacNalog.ValueMember = "kupac_id";
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "kupac";
            this.kupacBindingSource.DataSource = this.ineffableDataSet;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // frmKreirajQRKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 367);
            this.Controls.Add(this.kupacNalog);
            this.Controls.Add(this.serviseri);
            this.Controls.Add(this.skeniraj);
            this.Controls.Add(this.statusNalog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.opisNalog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uredjajNalog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Osoba);
            this.Controls.Add(this.qrKod);
            this.Controls.Add(this.gumbKreiraj);
            this.Controls.Add(this.oznakaNalog);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKreirajQRKod";
            this.Text = "frmKreirajQRKod";
            this.Load += new System.EventHandler(this.frmKreirajQRKod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oznakaNalog;
        private System.Windows.Forms.Button gumbKreiraj;
        private System.Windows.Forms.PictureBox qrKod;
        private System.Windows.Forms.Label Osoba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uredjajNalog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opisNalog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusNalog;
        private System.Windows.Forms.Button skeniraj;
        private System.Windows.Forms.ComboBox serviseri;
        private System.Windows.Forms.ComboBox kupacNalog;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private IneffableDataSetTableAdapters.kupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private IneffableDataSetTableAdapters.korisnikTableAdapter korisnikTableAdapter;
    }
}