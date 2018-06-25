namespace Komunikacija
{
    partial class frmKomuniciraj
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
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.btnZatraziServis = new System.Windows.Forms.Button();
            this.btnKontaktirajKorisnika = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.cbKupci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServisi = new System.Windows.Forms.DataGridView();
            this.servisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredjajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemekreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radni_nalog_servisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new Komunikacija.IneffableDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPosaljiPoruku = new System.Windows.Forms.Button();
            this.gbPitanje = new System.Windows.Forms.GroupBox();
            this.radni_nalog_servisaTableAdapter = new Komunikacija.IneffableDataSetTableAdapters.radni_nalog_servisaTableAdapter();
            this.tableAdapterManager = new Komunikacija.IneffableDataSetTableAdapters.TableAdapterManager();
            this.gbKupca = new System.Windows.Forms.GroupBox();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.ineffableDataSet1 = new CrudArtikala.IneffableDataSet();
            this.ineffableDataSet11 = new Komunikacija.IneffableDataSet1();
            this.porukeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porukeTableAdapter = new Komunikacija.IneffableDataSet1TableAdapters.porukeTableAdapter();
            this.radninalogservisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalog_servisaTableAdapter1 = new Komunikacija.IneffableDataSet1TableAdapters.radni_nalog_servisaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tekstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnPrekid = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalog_servisaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            this.gbPitanje.SuspendLayout();
            this.gbKupca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(12, 9);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(38, 13);
            this.lblKorisnik.TabIndex = 0;
            this.lblKorisnik.Text = "Kupac";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(12, 9);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(59, 13);
            this.lblZaposlenik.TabIndex = 1;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // btnZatraziServis
            // 
            this.btnZatraziServis.Location = new System.Drawing.Point(15, 34);
            this.btnZatraziServis.Name = "btnZatraziServis";
            this.btnZatraziServis.Size = new System.Drawing.Size(174, 23);
            this.btnZatraziServis.TabIndex = 2;
            this.btnZatraziServis.Text = "Zatraži servis";
            this.btnZatraziServis.UseVisualStyleBackColor = true;
            // 
            // btnKontaktirajKorisnika
            // 
            this.btnKontaktirajKorisnika.Location = new System.Drawing.Point(15, 63);
            this.btnKontaktirajKorisnika.Name = "btnKontaktirajKorisnika";
            this.btnKontaktirajKorisnika.Size = new System.Drawing.Size(174, 23);
            this.btnKontaktirajKorisnika.TabIndex = 3;
            this.btnKontaktirajKorisnika.Text = "Kontaktiranje klijenta";
            this.btnKontaktirajKorisnika.UseVisualStyleBackColor = true;
            this.btnKontaktirajKorisnika.Click += new System.EventHandler(this.btnKontaktirajKorisnika_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(705, 11);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(54, 23);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // cbKupci
            // 
            this.cbKupci.FormattingEnabled = true;
            this.cbKupci.Location = new System.Drawing.Point(19, 42);
            this.cbKupci.Name = "cbKupci";
            this.cbKupci.Size = new System.Drawing.Size(212, 21);
            this.cbKupci.TabIndex = 2;
            this.cbKupci.SelectedIndexChanged += new System.EventHandler(this.cbKupci_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberite klijenta kako bi vam se prikazali svi njegovi radni nalozi.";
            // 
            // dgvServisi
            // 
            this.dgvServisi.AllowUserToAddRows = false;
            this.dgvServisi.AutoGenerateColumns = false;
            this.dgvServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servisidDataGridViewTextBoxColumn,
            this.oznakaDataGridViewTextBoxColumn,
            this.uredjajDataGridViewTextBoxColumn,
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.vrijemekreiranjaDataGridViewTextBoxColumn,
            this.osobaidDataGridViewTextBoxColumn});
            this.dgvServisi.DataSource = this.radni_nalog_servisaBindingSource;
            this.dgvServisi.Location = new System.Drawing.Point(19, 114);
            this.dgvServisi.MultiSelect = false;
            this.dgvServisi.Name = "dgvServisi";
            this.dgvServisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServisi.Size = new System.Drawing.Size(740, 246);
            this.dgvServisi.TabIndex = 5;
            // 
            // servisidDataGridViewTextBoxColumn
            // 
            this.servisidDataGridViewTextBoxColumn.DataPropertyName = "servis_id";
            this.servisidDataGridViewTextBoxColumn.HeaderText = "Servis ID";
            this.servisidDataGridViewTextBoxColumn.Name = "servisidDataGridViewTextBoxColumn";
            this.servisidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oznakaDataGridViewTextBoxColumn
            // 
            this.oznakaDataGridViewTextBoxColumn.DataPropertyName = "oznaka";
            this.oznakaDataGridViewTextBoxColumn.HeaderText = "Oznaka";
            this.oznakaDataGridViewTextBoxColumn.Name = "oznakaDataGridViewTextBoxColumn";
            // 
            // uredjajDataGridViewTextBoxColumn
            // 
            this.uredjajDataGridViewTextBoxColumn.DataPropertyName = "uredjaj";
            this.uredjajDataGridViewTextBoxColumn.HeaderText = "Uređaj";
            this.uredjajDataGridViewTextBoxColumn.Name = "uredjajDataGridViewTextBoxColumn";
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // vrijemekreiranjaDataGridViewTextBoxColumn
            // 
            this.vrijemekreiranjaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_kreiranja";
            this.vrijemekreiranjaDataGridViewTextBoxColumn.HeaderText = "Vrijeme kreiranja";
            this.vrijemekreiranjaDataGridViewTextBoxColumn.Name = "vrijemekreiranjaDataGridViewTextBoxColumn";
            // 
            // osobaidDataGridViewTextBoxColumn
            // 
            this.osobaidDataGridViewTextBoxColumn.DataPropertyName = "osoba_id";
            this.osobaidDataGridViewTextBoxColumn.HeaderText = "osoba_id";
            this.osobaidDataGridViewTextBoxColumn.Name = "osobaidDataGridViewTextBoxColumn";
            this.osobaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // radni_nalog_servisaBindingSource
            // 
            this.radni_nalog_servisaBindingSource.DataMember = "radni_nalog_servisa";
            this.radni_nalog_servisaBindingSource.DataSource = this.ineffableDataSet;
            // 
            // ineffableDataSet
            // 
            this.ineffableDataSet.DataSetName = "IneffableDataSet";
            this.ineffableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Odaberite servis za koji postavljate pitanje.";
            // 
            // btnPosaljiPoruku
            // 
            this.btnPosaljiPoruku.Location = new System.Drawing.Point(325, 376);
            this.btnPosaljiPoruku.Name = "btnPosaljiPoruku";
            this.btnPosaljiPoruku.Size = new System.Drawing.Size(148, 23);
            this.btnPosaljiPoruku.TabIndex = 10;
            this.btnPosaljiPoruku.Text = "Kontaktiraj klijenta";
            this.btnPosaljiPoruku.UseVisualStyleBackColor = true;
            this.btnPosaljiPoruku.Click += new System.EventHandler(this.btnPosaljiPoruku_Click);
            // 
            // gbPitanje
            // 
            this.gbPitanje.Controls.Add(this.btnPosaljiPoruku);
            this.gbPitanje.Controls.Add(this.label3);
            this.gbPitanje.Controls.Add(this.label2);
            this.gbPitanje.Controls.Add(this.dgvServisi);
            this.gbPitanje.Controls.Add(this.label1);
            this.gbPitanje.Controls.Add(this.cbKupci);
            this.gbPitanje.Controls.Add(this.btnZatvori);
            this.gbPitanje.Location = new System.Drawing.Point(15, 92);
            this.gbPitanje.Name = "gbPitanje";
            this.gbPitanje.Size = new System.Drawing.Size(768, 419);
            this.gbPitanje.TabIndex = 4;
            this.gbPitanje.TabStop = false;
            this.gbPitanje.Visible = false;
            // 
            // radni_nalog_servisaTableAdapter
            // 
            this.radni_nalog_servisaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dobavljacTableAdapter = null;
            this.tableAdapterManager.korisnikTableAdapter = null;
            this.tableAdapterManager.kupacTableAdapter = null;
            this.tableAdapterManager.racunTableAdapter = null;
            this.tableAdapterManager.radni_nalog_servisaTableAdapter = this.radni_nalog_servisaTableAdapter;
            this.tableAdapterManager.rezervacijaTableAdapter = null;
            this.tableAdapterManager.stavka_racunaTableAdapter = null;
            this.tableAdapterManager.ulogaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Komunikacija.IneffableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zahtjev_za_servisTableAdapter = null;
            // 
            // gbKupca
            // 
            this.gbKupca.Controls.Add(this.label4);
            this.gbKupca.Controls.Add(this.btnPrekid);
            this.gbKupca.Controls.Add(this.btnPrihvati);
            this.gbKupca.Controls.Add(this.dgvPoruke);
            this.gbKupca.Location = new System.Drawing.Point(12, 92);
            this.gbKupca.Name = "gbKupca";
            this.gbKupca.Size = new System.Drawing.Size(789, 419);
            this.gbKupca.TabIndex = 5;
            this.gbKupca.TabStop = false;
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AutoGenerateColumns = false;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tekstDataGridViewTextBoxColumn,
            this.kupacidDataGridViewTextBoxColumn,
            this.servisidDataGridViewTextBoxColumn1});
            this.dgvPoruke.DataSource = this.porukeBindingSource;
            this.dgvPoruke.Location = new System.Drawing.Point(9, 42);
            this.dgvPoruke.MultiSelect = false;
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoruke.Size = new System.Drawing.Size(739, 175);
            this.dgvPoruke.TabIndex = 0;
            // 
            // ineffableDataSet1
            // 
            this.ineffableDataSet1.DataSetName = "IneffableDataSet";
            this.ineffableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ineffableDataSet11
            // 
            this.ineffableDataSet11.DataSetName = "IneffableDataSet1";
            this.ineffableDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porukeBindingSource
            // 
            this.porukeBindingSource.DataMember = "poruke";
            this.porukeBindingSource.DataSource = this.ineffableDataSet11;
            // 
            // porukeTableAdapter
            // 
            this.porukeTableAdapter.ClearBeforeFill = true;
            // 
            // radninalogservisaBindingSource
            // 
            this.radninalogservisaBindingSource.DataMember = "radni_nalog_servisa";
            this.radninalogservisaBindingSource.DataSource = this.ineffableDataSet11;
            // 
            // radni_nalog_servisaTableAdapter1
            // 
            this.radni_nalog_servisaTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tekstDataGridViewTextBoxColumn
            // 
            this.tekstDataGridViewTextBoxColumn.DataPropertyName = "tekst";
            this.tekstDataGridViewTextBoxColumn.HeaderText = "Tekst poruke";
            this.tekstDataGridViewTextBoxColumn.Name = "tekstDataGridViewTextBoxColumn";
            this.tekstDataGridViewTextBoxColumn.Width = 400;
            // 
            // kupacidDataGridViewTextBoxColumn
            // 
            this.kupacidDataGridViewTextBoxColumn.DataPropertyName = "kupac_id";
            this.kupacidDataGridViewTextBoxColumn.HeaderText = "kupac_id";
            this.kupacidDataGridViewTextBoxColumn.Name = "kupacidDataGridViewTextBoxColumn";
            this.kupacidDataGridViewTextBoxColumn.Visible = false;
            // 
            // servisidDataGridViewTextBoxColumn1
            // 
            this.servisidDataGridViewTextBoxColumn1.DataPropertyName = "servis_id";
            this.servisidDataGridViewTextBoxColumn1.DataSource = this.radninalogservisaBindingSource;
            this.servisidDataGridViewTextBoxColumn1.DisplayMember = "uredjaj";
            this.servisidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.servisidDataGridViewTextBoxColumn1.HeaderText = "Uređaj na servisu";
            this.servisidDataGridViewTextBoxColumn1.Name = "servisidDataGridViewTextBoxColumn1";
            this.servisidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.servisidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.servisidDataGridViewTextBoxColumn1.ValueMember = "servis_id";
            this.servisidDataGridViewTextBoxColumn1.Width = 200;
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Location = new System.Drawing.Point(140, 223);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(208, 23);
            this.btnPrihvati.TabIndex = 1;
            this.btnPrihvati.Text = "Prihvati nastavak odabranog servisa";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnPrekid
            // 
            this.btnPrekid.Location = new System.Drawing.Point(421, 223);
            this.btnPrekid.Name = "btnPrekid";
            this.btnPrekid.Size = new System.Drawing.Size(208, 23);
            this.btnPrekid.TabIndex = 2;
            this.btnPrekid.Text = "Prekini odabrani servis";
            this.btnPrekid.UseVisualStyleBackColor = true;
            this.btnPrekid.Click += new System.EventHandler(this.btnPrekid_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poruke servisera vaših uređaja:";
            // 
            // frmKomuniciraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 522);
            this.Controls.Add(this.gbKupca);
            this.Controls.Add(this.gbPitanje);
            this.Controls.Add(this.btnKontaktirajKorisnika);
            this.Controls.Add(this.btnZatraziServis);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.lblKorisnik);
            this.Name = "frmKomuniciraj";
            this.Text = "Komunikacija";
            this.Load += new System.EventHandler(this.frmKomuniciraj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalog_servisaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            this.gbPitanje.ResumeLayout(false);
            this.gbPitanje.PerformLayout();
            this.gbKupca.ResumeLayout(false);
            this.gbKupca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Button btnZatraziServis;
        private System.Windows.Forms.Button btnKontaktirajKorisnika;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ComboBox cbKupci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPosaljiPoruku;
        private System.Windows.Forms.GroupBox gbPitanje;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource radni_nalog_servisaBindingSource;
        private IneffableDataSetTableAdapters.radni_nalog_servisaTableAdapter radni_nalog_servisaTableAdapter;
        private IneffableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uredjajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemekreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbKupca;
        private CrudArtikala.IneffableDataSet ineffableDataSet1;
        private System.Windows.Forms.DataGridView dgvPoruke;
        private IneffableDataSet1 ineffableDataSet11;
        private System.Windows.Forms.BindingSource porukeBindingSource;
        private IneffableDataSet1TableAdapters.porukeTableAdapter porukeTableAdapter;
        private System.Windows.Forms.BindingSource radninalogservisaBindingSource;
        private IneffableDataSet1TableAdapters.radni_nalog_servisaTableAdapter radni_nalog_servisaTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrekid;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn servisidDataGridViewTextBoxColumn1;
    }
}