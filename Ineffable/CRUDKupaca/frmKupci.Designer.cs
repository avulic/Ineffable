namespace CRUDKupaca
{
    partial class frmKupci
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
            this.dgvKupci = new System.Windows.Forms.DataGridView();
            this.kupacidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSetKupci = new CRUDKupaca.IneffableDataSetKupci();
            this.telefon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupacTableAdapter = new CRUDKupaca.IneffableDataSetKupciTableAdapters.kupacTableAdapter();
            this.korisnikTableAdapter = new CRUDKupaca.IneffableDataSetKupciTableAdapters.korisnikTableAdapter();
            this.lbKupci = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnKreirajKupca = new System.Windows.Forms.Button();
            this.btnIzbrisiKupca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSetKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKupci
            // 
            this.dgvKupci.AllowUserToAddRows = false;
            this.dgvKupci.AllowUserToDeleteRows = false;
            this.dgvKupci.AutoGenerateColumns = false;
            this.dgvKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kupacidDataGridViewTextBoxColumn,
            this.adresa,
            this.telefon,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.korisnikidDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn});
            this.dgvKupci.DataSource = this.kupacBindingSource;
            this.dgvKupci.Location = new System.Drawing.Point(12, 56);
            this.dgvKupci.MultiSelect = false;
            this.dgvKupci.Name = "dgvKupci";
            this.dgvKupci.ReadOnly = true;
            this.dgvKupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKupci.Size = new System.Drawing.Size(600, 181);
            this.dgvKupci.TabIndex = 0;
            // 
            // kupacidDataGridViewTextBoxColumn
            // 
            this.kupacidDataGridViewTextBoxColumn.DataPropertyName = "kupac_id";
            this.kupacidDataGridViewTextBoxColumn.HeaderText = "kupac_id";
            this.kupacidDataGridViewTextBoxColumn.Name = "kupacidDataGridViewTextBoxColumn";
            this.kupacidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kupacidDataGridViewTextBoxColumn.Visible = false;
            // 
            // adresa
            // 
            this.adresa.DataPropertyName = "korisnik_id";
            this.adresa.DataSource = this.korisnikBindingSource;
            this.adresa.DisplayMember = "adresa";
            this.adresa.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.adresa.HeaderText = "Adresa";
            this.adresa.Name = "adresa";
            this.adresa.ReadOnly = true;
            this.adresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.adresa.ValueMember = "korisnik_id";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "korisnik";
            this.korisnikBindingSource.DataSource = this.ineffableDataSetKupci;
            // 
            // ineffableDataSetKupci
            // 
            this.ineffableDataSetKupci.DataSetName = "IneffableDataSetKupci";
            this.ineffableDataSetKupci.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "korisnik_id";
            this.telefon.DataSource = this.korisnikBindingSource;
            this.telefon.DisplayMember = "telefon";
            this.telefon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            this.telefon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.telefon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.telefon.ValueMember = "korisnik_id";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikidDataGridViewTextBoxColumn
            // 
            this.korisnikidDataGridViewTextBoxColumn.DataPropertyName = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.HeaderText = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.Name = "korisnikidDataGridViewTextBoxColumn";
            this.korisnikidDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikidDataGridViewTextBoxColumn.Visible = false;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "kupac";
            this.kupacBindingSource.DataSource = this.ineffableDataSetKupci;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // lbKupci
            // 
            this.lbKupci.AutoSize = true;
            this.lbKupci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKupci.ForeColor = System.Drawing.Color.White;
            this.lbKupci.Location = new System.Drawing.Point(12, 27);
            this.lbKupci.Name = "lbKupci";
            this.lbKupci.Size = new System.Drawing.Size(62, 25);
            this.lbKupci.TabIndex = 1;
            this.lbKupci.Text = "Kupci";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(469, 296);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(143, 23);
            this.btnAzuriraj.TabIndex = 2;
            this.btnAzuriraj.Text = "Ažuriraj odabranog kupca";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAturiraj_Click);
            // 
            // btnKreirajKupca
            // 
            this.btnKreirajKupca.Location = new System.Drawing.Point(17, 284);
            this.btnKreirajKupca.Name = "btnKreirajKupca";
            this.btnKreirajKupca.Size = new System.Drawing.Size(75, 23);
            this.btnKreirajKupca.TabIndex = 3;
            this.btnKreirajKupca.Text = "Novi kupac";
            this.btnKreirajKupca.UseVisualStyleBackColor = true;
            this.btnKreirajKupca.Click += new System.EventHandler(this.btnKreirajKupca_Click);
            // 
            // btnIzbrisiKupca
            // 
            this.btnIzbrisiKupca.Location = new System.Drawing.Point(469, 323);
            this.btnIzbrisiKupca.Name = "btnIzbrisiKupca";
            this.btnIzbrisiKupca.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisiKupca.TabIndex = 4;
            this.btnIzbrisiKupca.Text = "Izbrisi";
            this.btnIzbrisiKupca.UseVisualStyleBackColor = true;
            this.btnIzbrisiKupca.Click += new System.EventHandler(this.btnIzbrisiKupca_Click_1);
            // 
            // frmKupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(626, 349);
            this.Controls.Add(this.btnIzbrisiKupca);
            this.Controls.Add(this.btnKreirajKupca);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lbKupci);
            this.Controls.Add(this.dgvKupci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKupci";
            this.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.Text = "frmKupci";
            this.Load += new System.EventHandler(this.frmKupci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSetKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKupci;
        private IneffableDataSetKupci ineffableDataSetKupci;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private IneffableDataSetKupciTableAdapters.kupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private IneffableDataSetKupciTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupacidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn adresa;
        private System.Windows.Forms.DataGridViewComboBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbKupci;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnKreirajKupca;
        private System.Windows.Forms.Button btnIzbrisiKupca;
    }
}