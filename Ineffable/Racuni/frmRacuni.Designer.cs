namespace Racuni
{
    partial class frmRacuni
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
            this.racunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new Racuni.IneffableDataSet();
            this.servisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.radninalogservisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.racunidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new Racuni.IneffableDataSetTableAdapters.racunTableAdapter();
            this.korisnikTableAdapter = new Racuni.IneffableDataSetTableAdapters.korisnikTableAdapter();
            this.radni_nalog_servisaTableAdapter = new Racuni.IneffableDataSetTableAdapters.radni_nalog_servisaTableAdapter();
            this.stavka_racunaTableAdapter = new Racuni.IneffableDataSetTableAdapters.stavka_racunaTableAdapter();
            this.artiklTableAdapter = new Racuni.IneffableDataSetTableAdapters.artiklTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.racunidDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.servisidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.racunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // racunidDataGridViewTextBoxColumn
            // 
            this.racunidDataGridViewTextBoxColumn.DataPropertyName = "racun_id";
            this.racunidDataGridViewTextBoxColumn.HeaderText = "racun_id";
            this.racunidDataGridViewTextBoxColumn.Name = "racunidDataGridViewTextBoxColumn";
            this.racunidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.DataSource = this.korisnikBindingSource;
            this.zaposlenikidDataGridViewTextBoxColumn.DisplayMember = "ime";
            this.zaposlenikidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "Ime zaposlenika";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            this.zaposlenikidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zaposlenikidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zaposlenikidDataGridViewTextBoxColumn.ValueMember = "korisnik_id";
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
            // servisidDataGridViewTextBoxColumn
            // 
            this.servisidDataGridViewTextBoxColumn.DataPropertyName = "servis_id";
            this.servisidDataGridViewTextBoxColumn.DataSource = this.radninalogservisaBindingSource;
            this.servisidDataGridViewTextBoxColumn.DisplayMember = "uredjaj";
            this.servisidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.servisidDataGridViewTextBoxColumn.HeaderText = "Naziv uređaja";
            this.servisidDataGridViewTextBoxColumn.Name = "servisidDataGridViewTextBoxColumn";
            this.servisidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.servisidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.servisidDataGridViewTextBoxColumn.ValueMember = "servis_id";
            // 
            // radninalogservisaBindingSource
            // 
            this.radninalogservisaBindingSource.DataMember = "radni_nalog_servisa";
            this.radninalogservisaBindingSource.DataSource = this.ineffableDataSet;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.ineffableDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.racunidDataGridViewTextBoxColumn1,
            this.artiklidDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stavkaracunaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1102, 200);
            this.dataGridView2.TabIndex = 1;
            // 
            // racunidDataGridViewTextBoxColumn1
            // 
            this.racunidDataGridViewTextBoxColumn1.DataPropertyName = "racun_id";
            this.racunidDataGridViewTextBoxColumn1.HeaderText = "racun_id";
            this.racunidDataGridViewTextBoxColumn1.Name = "racunidDataGridViewTextBoxColumn1";
            // 
            // artiklidDataGridViewTextBoxColumn
            // 
            this.artiklidDataGridViewTextBoxColumn.DataPropertyName = "artikl_id";
            this.artiklidDataGridViewTextBoxColumn.DataSource = this.artiklBindingSource;
            this.artiklidDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.artiklidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.artiklidDataGridViewTextBoxColumn.HeaderText = "Artikl";
            this.artiklidDataGridViewTextBoxColumn.Name = "artiklidDataGridViewTextBoxColumn";
            this.artiklidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artiklidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.artiklidDataGridViewTextBoxColumn.ValueMember = "artikl_id";
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "artikl";
            this.artiklBindingSource.DataSource = this.ineffableDataSet;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // stavkaracunaBindingSource
            // 
            this.stavkaracunaBindingSource.DataMember = "stavka_racuna";
            this.stavkaracunaBindingSource.DataSource = this.ineffableDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // radni_nalog_servisaTableAdapter
            // 
            this.radni_nalog_servisaTableAdapter.ClearBeforeFill = true;
            // 
            // stavka_racunaTableAdapter
            // 
            this.stavka_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // frmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 458);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRacuni";
            this.Text = "frmRacuni";
            this.Load += new System.EventHandler(this.frmRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private IneffableDataSetTableAdapters.racunTableAdapter racunTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private IneffableDataSetTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.BindingSource radninalogservisaBindingSource;
        private IneffableDataSetTableAdapters.radni_nalog_servisaTableAdapter radni_nalog_servisaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn servisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource stavkaracunaBindingSource;
        private IneffableDataSetTableAdapters.stavka_racunaTableAdapter stavka_racunaTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private IneffableDataSetTableAdapters.artiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn artiklidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}