namespace Komunikacija
{
    partial class frmZavrseniServisi
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
            this.dgvZavrseniServisi = new System.Windows.Forms.DataGridView();
            this.servisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uredjajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemekreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet5 = new Komunikacija.IneffableDataSet5();
            this.prezime = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.radninalogservisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalog_servisaTableAdapter = new Komunikacija.IneffableDataSet5TableAdapters.radni_nalog_servisaTableAdapter();
            this.kupacTableAdapter = new Komunikacija.IneffableDataSet5TableAdapters.kupacTableAdapter();
            this.btnObavijesti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZavrseniServisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZavrseniServisi
            // 
            this.dgvZavrseniServisi.AllowUserToAddRows = false;
            this.dgvZavrseniServisi.AutoGenerateColumns = false;
            this.dgvZavrseniServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZavrseniServisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servisidDataGridViewTextBoxColumn,
            this.oznakaDataGridViewTextBoxColumn,
            this.uredjajDataGridViewTextBoxColumn,
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.vrijemekreiranjaDataGridViewTextBoxColumn,
            this.osobaidDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn,
            this.ime,
            this.prezime});
            this.dgvZavrseniServisi.DataSource = this.radninalogservisaBindingSource;
            this.dgvZavrseniServisi.Location = new System.Drawing.Point(12, 12);
            this.dgvZavrseniServisi.MultiSelect = false;
            this.dgvZavrseniServisi.Name = "dgvZavrseniServisi";
            this.dgvZavrseniServisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZavrseniServisi.Size = new System.Drawing.Size(641, 164);
            this.dgvZavrseniServisi.TabIndex = 0;
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
            this.oznakaDataGridViewTextBoxColumn.HeaderText = "Oznaka";
            this.oznakaDataGridViewTextBoxColumn.Name = "oznakaDataGridViewTextBoxColumn";
            // 
            // uredjajDataGridViewTextBoxColumn
            // 
            this.uredjajDataGridViewTextBoxColumn.DataPropertyName = "uredjaj";
            this.uredjajDataGridViewTextBoxColumn.HeaderText = "Naziv uređaja";
            this.uredjajDataGridViewTextBoxColumn.Name = "uredjajDataGridViewTextBoxColumn";
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            this.zaposlenikidDataGridViewTextBoxColumn.Visible = false;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis kvara";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
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
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "stanje";
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            this.stanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // ime
            // 
            this.ime.DataPropertyName = "osoba_id";
            this.ime.DataSource = this.kupacBindingSource;
            this.ime.DisplayMember = "ime";
            this.ime.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ime.HeaderText = "Ime klijenta";
            this.ime.Name = "ime";
            this.ime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ime.ValueMember = "kupac_id";
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "kupac";
            this.kupacBindingSource.DataSource = this.ineffableDataSet5;
            // 
            // ineffableDataSet5
            // 
            this.ineffableDataSet5.DataSetName = "IneffableDataSet5";
            this.ineffableDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prezime
            // 
            this.prezime.DataPropertyName = "osoba_id";
            this.prezime.DataSource = this.kupacBindingSource;
            this.prezime.DisplayMember = "prezime";
            this.prezime.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.prezime.HeaderText = "Prezime klijenta";
            this.prezime.Name = "prezime";
            this.prezime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prezime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.prezime.ValueMember = "kupac_id";
            // 
            // radninalogservisaBindingSource
            // 
            this.radninalogservisaBindingSource.DataMember = "radni_nalog_servisa";
            this.radninalogservisaBindingSource.DataSource = this.ineffableDataSet5;
            // 
            // radni_nalog_servisaTableAdapter
            // 
            this.radni_nalog_servisaTableAdapter.ClearBeforeFill = true;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // btnObavijesti
            // 
            this.btnObavijesti.Location = new System.Drawing.Point(458, 197);
            this.btnObavijesti.Name = "btnObavijesti";
            this.btnObavijesti.Size = new System.Drawing.Size(195, 23);
            this.btnObavijesti.TabIndex = 1;
            this.btnObavijesti.Text = "Obavijesti klijenta email porukom";
            this.btnObavijesti.UseVisualStyleBackColor = true;
            this.btnObavijesti.Click += new System.EventHandler(this.btnObavijesti_Click);
            // 
            // frmZavrseniServisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 256);
            this.Controls.Add(this.btnObavijesti);
            this.Controls.Add(this.dgvZavrseniServisi);
            this.Name = "frmZavrseniServisi";
            this.Text = "Pregled završenih servisa";
            this.Load += new System.EventHandler(this.frmZavrseniServisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZavrseniServisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZavrseniServisi;
        private IneffableDataSet5 ineffableDataSet5;
        private System.Windows.Forms.BindingSource radninalogservisaBindingSource;
        private IneffableDataSet5TableAdapters.radni_nalog_servisaTableAdapter radni_nalog_servisaTableAdapter;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private IneffableDataSet5TableAdapters.kupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uredjajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemekreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ime;
        private System.Windows.Forms.DataGridViewComboBoxColumn prezime;
        private System.Windows.Forms.Button btnObavijesti;
    }
}