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
            this.artiklidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinanaskladistuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new CrudArtikala.IneffableDataSet();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.artiklTableAdapter = new CrudArtikala.IneffableDataSetTableAdapters.artiklTableAdapter();
            this.tableAdapterManager = new CrudArtikala.IneffableDataSetTableAdapters.TableAdapterManager();
            this.dobavljacTableAdapter = new CrudArtikala.IneffableDataSetTableAdapters.dobavljacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
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
            this.dgvArtikli.Location = new System.Drawing.Point(15, 53);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(641, 252);
            this.dgvArtikli.TabIndex = 0;
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
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
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena u kunama";
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
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataMember = "dobavljac";
            this.dobavljacBindingSource.DataSource = this.ineffableDataSet;
            // 
            // ineffableDataSet
            // 
            this.ineffableDataSet.DataSetName = "IneffableDataSet";
            this.ineffableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "artikl";
            this.artiklBindingSource.DataSource = this.ineffableDataSet;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKreiraj.Location = new System.Drawing.Point(15, 328);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(123, 23);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj novi artikl";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artikli na skladištu";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(519, 325);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(137, 23);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Ažuriraj odabrani artikl";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(519, 364);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(137, 23);
            this.btnIzbrisi.TabIndex = 4;
            this.btnIzbrisi.Text = "Izbriši odabrani artikl";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = this.artiklTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dobavljacTableAdapter = null;
            this.tableAdapterManager.korisnikTableAdapter = null;
            this.tableAdapterManager.kupacTableAdapter = null;
            this.tableAdapterManager.racunTableAdapter = null;
            this.tableAdapterManager.radni_nalog_servisaTableAdapter = null;
            this.tableAdapterManager.rezervacijaTableAdapter = null;
            this.tableAdapterManager.stavka_racunaTableAdapter = null;
            this.tableAdapterManager.ulogaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrudArtikala.IneffableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zahtjev_za_servisTableAdapter = null;
            // 
            // dobavljacTableAdapter
            // 
            this.dobavljacTableAdapter.ClearBeforeFill = true;
            // 
            // frmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 415);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvArtikli);
            this.Name = "frmArtikli";
            this.Text = "Popis artikala";
            this.Load += new System.EventHandler(this.frmArtikli_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmArtikli_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnIzbrisi;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private IneffableDataSetTableAdapters.artiklTableAdapter artiklTableAdapter;
        private IneffableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private IneffableDataSetTableAdapters.dobavljacTableAdapter dobavljacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinanaskladistuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dobavljacidDataGridViewTextBoxColumn;
    }
}