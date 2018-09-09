namespace Komunikacija
{
    partial class frmNoviZahtjev
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
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProizvodjac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(12, 202);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(350, 152);
            this.txtOpis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite detaljan opis kvara vašeg uređaja:";
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(240, 372);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(122, 23);
            this.btnPosalji.TabIndex = 2;
            this.btnPosalji.Text = "Pošalji zahtjev";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 26);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(350, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv uređaja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrsta uređaja:";
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(12, 83);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(350, 20);
            this.txtVrsta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proizvođač:";
            // 
            // cbProizvodjac
            // 
            this.cbProizvodjac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProizvodjac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProizvodjac.FormattingEnabled = true;
            this.cbProizvodjac.Items.AddRange(new object[] {
            "Acer",
            "Asus",
            "Dell",
            "HP",
            "Lenovo",
            "Apple",
            "Instar",
            "GIGABYTE",
            "INTEL",
            "MSGW",
            "Fujitsu",
            "Feniks",
            "HPInc Computing",
            "HTC",
            "Huawei",
            "LG",
            "NOA",
            "Nokia",
            "Samsung",
            "Xiaomi",
            "ZTE",
            "Vivax",
            "Sony Mobile"});
            this.cbProizvodjac.Location = new System.Drawing.Point(12, 144);
            this.cbProizvodjac.Name = "cbProizvodjac";
            this.cbProizvodjac.Size = new System.Drawing.Size(350, 21);
            this.cbProizvodjac.TabIndex = 9;
            // 
            // frmNoviZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 405);
            this.Controls.Add(this.cbProizvodjac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpis);
            this.Name = "frmNoviZahtjev";
            this.Text = "Novi zahtjev za servisom";
            this.Load += new System.EventHandler(this.frmNoviZahtjev_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmNoviZahtjev_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProizvodjac;
    }
}