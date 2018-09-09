namespace Komunikacija
{
    partial class frmMojiServisi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ineffableDataSet4 = new Komunikacija.IneffableDataSet4();
            this.radninalogservisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalog_servisaTableAdapter = new Komunikacija.IneffableDataSet4TableAdapters.radni_nalog_servisaTableAdapter();
            this.korisnikTableAdapter = new Komunikacija.IneffableDataSet4TableAdapters.korisnikTableAdapter();
            this.ineffableDataSet41 = new Komunikacija.IneffableDataSet4();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredjajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemekreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servisidDataGridViewTextBoxColumn,
            this.oznakaDataGridViewTextBoxColumn,
            this.uredjajDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.ime,
            this.prezime,
            this.statusDataGridViewTextBoxColumn,
            this.vrijemekreiranjaDataGridViewTextBoxColumn,
            this.osobaidDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.radninalogservisaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ineffableDataSet4
            // 
            this.ineffableDataSet4.DataSetName = "IneffableDataSet4";
            this.ineffableDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radninalogservisaBindingSource
            // 
            this.radninalogservisaBindingSource.DataMember = "radni_nalog_servisa";
            this.radninalogservisaBindingSource.DataSource = this.ineffableDataSet4;
            // 
            // radni_nalog_servisaTableAdapter
            // 
            this.radni_nalog_servisaTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // ineffableDataSet41
            // 
            this.ineffableDataSet41.DataSetName = "IneffableDataSet4";
            this.ineffableDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataMember = "korisnik";
            this.korisnikBindingSource1.DataSource = this.ineffableDataSet41;
            // 
            // servisidDataGridViewTextBoxColumn
            // 
            this.servisidDataGridViewTextBoxColumn.DataPropertyName = "servis_id";
            this.servisidDataGridViewTextBoxColumn.HeaderText = "servis_id";
            this.servisidDataGridViewTextBoxColumn.Name = "servisidDataGridViewTextBoxColumn";
            this.servisidDataGridViewTextBoxColumn.ReadOnly = true;
            this.servisidDataGridViewTextBoxColumn.Visible = false;
            // 
            // oznakaDataGridViewTextBoxColumn
            // 
            this.oznakaDataGridViewTextBoxColumn.DataPropertyName = "oznaka";
            this.oznakaDataGridViewTextBoxColumn.HeaderText = "oznaka";
            this.oznakaDataGridViewTextBoxColumn.Name = "oznakaDataGridViewTextBoxColumn";
            this.oznakaDataGridViewTextBoxColumn.Visible = false;
            // 
            // uredjajDataGridViewTextBoxColumn
            // 
            this.uredjajDataGridViewTextBoxColumn.DataPropertyName = "uredjaj";
            this.uredjajDataGridViewTextBoxColumn.HeaderText = "Naziv uređaja";
            this.uredjajDataGridViewTextBoxColumn.Name = "uredjajDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis kvara";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // ime
            // 
            this.ime.DataPropertyName = "zaposlenik_id";
            this.ime.DataSource = this.korisnikBindingSource1;
            this.ime.DisplayMember = "ime";
            this.ime.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ime.HeaderText = "Ime servisera";
            this.ime.Name = "ime";
            this.ime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ime.ValueMember = "korisnik_id";
            // 
            // prezime
            // 
            this.prezime.DataPropertyName = "zaposlenik_id";
            this.prezime.DataSource = this.korisnikBindingSource1;
            this.prezime.DisplayMember = "prezime";
            this.prezime.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.prezime.HeaderText = "Prezime servisera";
            this.prezime.Name = "prezime";
            this.prezime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prezime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.prezime.ValueMember = "korisnik_id";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status servisa";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // vrijemekreiranjaDataGridViewTextBoxColumn
            // 
            this.vrijemekreiranjaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_kreiranja";
            this.vrijemekreiranjaDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme kreiranja";
            this.vrijemekreiranjaDataGridViewTextBoxColumn.Name = "vrijemekreiranjaDataGridViewTextBoxColumn";
            // 
            // osobaidDataGridViewTextBoxColumn
            // 
            this.osobaidDataGridViewTextBoxColumn.DataPropertyName = "osoba_id";
            this.osobaidDataGridViewTextBoxColumn.HeaderText = "osoba_id";
            this.osobaidDataGridViewTextBoxColumn.Name = "osobaidDataGridViewTextBoxColumn";
            this.osobaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "Stanje servisa";
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            // 
            // frmMojiServisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 240);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMojiServisi";
            this.Text = "Moji servisi";
            this.Load += new System.EventHandler(this.frmMojiServisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IneffableDataSet4 ineffableDataSet4;
        private System.Windows.Forms.BindingSource radninalogservisaBindingSource;
        private IneffableDataSet4TableAdapters.radni_nalog_servisaTableAdapter radni_nalog_servisaTableAdapter;
        private IneffableDataSet4TableAdapters.korisnikTableAdapter korisnikTableAdapter;
        private IneffableDataSet4 ineffableDataSet41;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uredjajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ime;
        private System.Windows.Forms.DataGridViewComboBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemekreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
    }
}