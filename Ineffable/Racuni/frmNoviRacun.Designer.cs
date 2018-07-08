namespace Racuni
{
    partial class frmNoviRacun
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new Racuni.IneffableDataSet();
            this.kolicinaRacun = new System.Windows.Forms.TextBox();
            this.cijenaRacun = new System.Windows.Forms.TextBox();
            this.artiklTableAdapter = new Racuni.IneffableDataSetTableAdapters.artiklTableAdapter();
            this.gumbRacun = new System.Windows.Forms.Button();
            this.ukupnoRacun = new System.Windows.Forms.TextBox();
            this.gumbIzracunaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new Racuni.IneffableDataSetTableAdapters.korisnikTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.radninalogservisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalog_servisaTableAdapter = new Racuni.IneffableDataSetTableAdapters.radni_nalog_servisaTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.servisRacun = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ukupnoRacuna = new System.Windows.Forms.TextBox();
            this.gumbSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolicina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupno:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.artiklBindingSource;
            this.comboBox1.DisplayMember = "naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "artikl_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "artikl";
            this.artiklBindingSource.DataSource = this.ineffableDataSet;
            // 
            // ineffableDataSet
            // 
            this.ineffableDataSet.DataSetName = "IneffableDataSet";
            this.ineffableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kolicinaRacun
            // 
            this.kolicinaRacun.Location = new System.Drawing.Point(123, 137);
            this.kolicinaRacun.Name = "kolicinaRacun";
            this.kolicinaRacun.Size = new System.Drawing.Size(158, 22);
            this.kolicinaRacun.TabIndex = 5;
            // 
            // cijenaRacun
            // 
            this.cijenaRacun.Location = new System.Drawing.Point(123, 177);
            this.cijenaRacun.Name = "cijenaRacun";
            this.cijenaRacun.Size = new System.Drawing.Size(158, 22);
            this.cijenaRacun.TabIndex = 6;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // gumbRacun
            // 
            this.gumbRacun.Location = new System.Drawing.Point(18, 394);
            this.gumbRacun.Name = "gumbRacun";
            this.gumbRacun.Size = new System.Drawing.Size(97, 26);
            this.gumbRacun.TabIndex = 7;
            this.gumbRacun.Text = "Kreiraj račun";
            this.gumbRacun.UseVisualStyleBackColor = true;
            this.gumbRacun.Click += new System.EventHandler(this.gumbRacun_Click);
            // 
            // ukupnoRacun
            // 
            this.ukupnoRacun.Location = new System.Drawing.Point(123, 243);
            this.ukupnoRacun.Name = "ukupnoRacun";
            this.ukupnoRacun.Size = new System.Drawing.Size(158, 22);
            this.ukupnoRacun.TabIndex = 8;
            // 
            // gumbIzracunaj
            // 
            this.gumbIzracunaj.Location = new System.Drawing.Point(177, 394);
            this.gumbIzracunaj.Name = "gumbIzracunaj";
            this.gumbIzracunaj.Size = new System.Drawing.Size(105, 26);
            this.gumbIzracunaj.TabIndex = 9;
            this.gumbIzracunaj.Text = "Dodaj stavku";
            this.gumbIzracunaj.UseVisualStyleBackColor = true;
            this.gumbIzracunaj.Click += new System.EventHandler(this.gumbIzracunaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zaposlenik:";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DataSource = this.korisnikBindingSource;
            this.comboBox2.DisplayMember = "ime";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 304);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 24);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "korisnik_id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "korisnik";
            this.korisnikBindingSource.DataSource = this.ineffableDataSet;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Servis:";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.DataSource = this.radninalogservisaBindingSource;
            this.comboBox3.DisplayMember = "uredjaj";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(447, 26);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 24);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.ValueMember = "servis_id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // radninalogservisaBindingSource
            // 
            this.radninalogservisaBindingSource.DataMember = "radni_nalog_servisa";
            this.radninalogservisaBindingSource.DataSource = this.ineffableDataSet;
            // 
            // radni_nalog_servisaTableAdapter
            // 
            this.radni_nalog_servisaTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cijena servisa:";
            // 
            // servisRacun
            // 
            this.servisRacun.Location = new System.Drawing.Point(447, 83);
            this.servisRacun.Name = "servisRacun";
            this.servisRacun.Size = new System.Drawing.Size(159, 22);
            this.servisRacun.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "R. br. računa:";
            // 
            // ukupnoRacuna
            // 
            this.ukupnoRacuna.Location = new System.Drawing.Point(123, 23);
            this.ukupnoRacuna.Name = "ukupnoRacuna";
            this.ukupnoRacuna.Size = new System.Drawing.Size(159, 22);
            this.ukupnoRacuna.TabIndex = 17;
            // 
            // gumbSpremi
            // 
            this.gumbSpremi.Location = new System.Drawing.Point(531, 394);
            this.gumbSpremi.Name = "gumbSpremi";
            this.gumbSpremi.Size = new System.Drawing.Size(75, 26);
            this.gumbSpremi.TabIndex = 18;
            this.gumbSpremi.Text = "Spremi";
            this.gumbSpremi.UseVisualStyleBackColor = true;
            this.gumbSpremi.Click += new System.EventHandler(this.gumbSpremi_Click);
            // 
            // frmNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gumbSpremi);
            this.Controls.Add(this.ukupnoRacuna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.servisRacun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gumbIzracunaj);
            this.Controls.Add(this.ukupnoRacun);
            this.Controls.Add(this.gumbRacun);
            this.Controls.Add(this.cijenaRacun);
            this.Controls.Add(this.kolicinaRacun);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviRacun";
            this.Text = "frmNoviRacun";
            this.Load += new System.EventHandler(this.frmNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox kolicinaRacun;
        private System.Windows.Forms.TextBox cijenaRacun;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private IneffableDataSetTableAdapters.artiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.Button gumbRacun;
        private System.Windows.Forms.TextBox ukupnoRacun;
        private System.Windows.Forms.Button gumbIzracunaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private IneffableDataSetTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource radninalogservisaBindingSource;
        private IneffableDataSetTableAdapters.radni_nalog_servisaTableAdapter radni_nalog_servisaTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox servisRacun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ukupnoRacuna;
        private System.Windows.Forms.Button gumbSpremi;
    }
}