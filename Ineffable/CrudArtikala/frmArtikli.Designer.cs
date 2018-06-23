namespace CrudArtikala
{
    partial class frmArtikli
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableBPDataSet = new CrudArtikala.IneffableDataSet();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new CrudArtikala.IneffableDataSetTableAdapters.artiklTableAdapter();
            this.dobavljacTableAdapter = new CrudArtikala.IneffableDataSetTableAdapters.dobavljacTableAdapter();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artiklidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinanaskladistuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableBPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoGenerateColumns = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artiklidDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinanaskladistuDataGridViewTextBoxColumn,
            this.dobavljacidDataGridViewTextBoxColumn});
            this.dgvArtikli.DataSource = this.artiklBindingSource;
            this.dgvArtikli.Location = new System.Drawing.Point(12, 57);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(640, 252);
            this.dgvArtikli.TabIndex = 0;
            // 
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataMember = "dobavljac";
            this.dobavljacBindingSource.DataSource = this.ineffableBPDataSet;
            // 
            // ineffableBPDataSet
            // 
            this.ineffableBPDataSet.DataSetName = "IneffableBPDataSet";
            this.ineffableBPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "artikl";
            this.artiklBindingSource.DataSource = this.ineffableBPDataSet;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // dobavljacTableAdapter
            // 
            this.dobavljacTableAdapter.ClearBeforeFill = true;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(15, 332);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(123, 23);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj novi artikl";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataSource = typeof(CrudArtikala.artikl);
            // 
            // artiklidDataGridViewTextBoxColumn
            // 
            this.artiklidDataGridViewTextBoxColumn.DataPropertyName = "artikl_id";
            this.artiklidDataGridViewTextBoxColumn.HeaderText = "Artikl ID";
            this.artiklidDataGridViewTextBoxColumn.Name = "artiklidDataGridViewTextBoxColumn";
            this.artiklidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv artikla";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // kolicinanaskladistuDataGridViewTextBoxColumn
            // 
            this.kolicinanaskladistuDataGridViewTextBoxColumn.DataPropertyName = "kolicina_na_skladistu";
            this.kolicinanaskladistuDataGridViewTextBoxColumn.HeaderText = "Količina na skladištu";
            this.kolicinanaskladistuDataGridViewTextBoxColumn.Name = "kolicinanaskladistuDataGridViewTextBoxColumn";
            // 
            // dobavljacidDataGridViewTextBoxColumn
            // 
            this.dobavljacidDataGridViewTextBoxColumn.DataPropertyName = "dobavljac_id";
            this.dobavljacidDataGridViewTextBoxColumn.DataSource = this.dobavljacBindingSource;
            this.dobavljacidDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.dobavljacidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dobavljacidDataGridViewTextBoxColumn.HeaderText = "Dobavljač";
            this.dobavljacidDataGridViewTextBoxColumn.Name = "dobavljacidDataGridViewTextBoxColumn";
            this.dobavljacidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dobavljacidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dobavljacidDataGridViewTextBoxColumn.ValueMember = "dobavljac_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artikli na skladištu";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(515, 332);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(137, 23);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Ažuriraj odabrani artikl";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(515, 371);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(137, 23);
            this.btnIzbrisi.TabIndex = 4;
            this.btnIzbrisi.Text = "Izbriši odabrani artikl";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // frmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvArtikli);
            this.Name = "frmArtikli";
            this.Text = "frmArtikli";
            this.Load += new System.EventHandler(this.frmArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableBPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private IneffableDataSet ineffableBPDataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private IneffableDataSetTableAdapters.artiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private IneffableDataSetTableAdapters.dobavljacTableAdapter dobavljacTableAdapter;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinanaskladistuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dobavljacidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}