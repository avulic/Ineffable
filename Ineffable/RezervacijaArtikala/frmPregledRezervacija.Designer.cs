namespace RezervacijaArtikala
{
    partial class frmPregledRezervacija
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
            this.rezervacijaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemerezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet1 = new RezervacijaArtikala.IneffableDataSet1();
            this.kupacidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kupacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet2 = new RezervacijaArtikala.IneffableDataSet2();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaTableAdapter = new RezervacijaArtikala.IneffableDataSet1TableAdapters.rezervacijaTableAdapter();
            this.artiklTableAdapter = new RezervacijaArtikala.IneffableDataSet1TableAdapters.artiklTableAdapter();
            this.kupacTableAdapter = new RezervacijaArtikala.IneffableDataSet1TableAdapters.kupacTableAdapter();
            this.gumbOsvjezi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kupacTableAdapter1 = new RezervacijaArtikala.IneffableDataSet2TableAdapters.kupacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervacijaidDataGridViewTextBoxColumn,
            this.vrijemerezervacijeDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.artiklidDataGridViewTextBoxColumn,
            this.kupacidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervacijaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // rezervacijaidDataGridViewTextBoxColumn
            // 
            this.rezervacijaidDataGridViewTextBoxColumn.DataPropertyName = "rezervacija_id";
            this.rezervacijaidDataGridViewTextBoxColumn.HeaderText = "rezervacija_id";
            this.rezervacijaidDataGridViewTextBoxColumn.Name = "rezervacijaidDataGridViewTextBoxColumn";
            this.rezervacijaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemerezervacijeDataGridViewTextBoxColumn
            // 
            this.vrijemerezervacijeDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_rezervacije";
            this.vrijemerezervacijeDataGridViewTextBoxColumn.HeaderText = "vrijeme_rezervacije";
            this.vrijemerezervacijeDataGridViewTextBoxColumn.Name = "vrijemerezervacijeDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
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
            this.artiklBindingSource.DataSource = this.ineffableDataSet1;
            // 
            // ineffableDataSet1
            // 
            this.ineffableDataSet1.DataSetName = "IneffableDataSet1";
            this.ineffableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacidDataGridViewTextBoxColumn
            // 
            this.kupacidDataGridViewTextBoxColumn.DataPropertyName = "kupac_id";
            this.kupacidDataGridViewTextBoxColumn.DataSource = this.kupacBindingSource1;
            this.kupacidDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.kupacidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.kupacidDataGridViewTextBoxColumn.HeaderText = "Kupac";
            this.kupacidDataGridViewTextBoxColumn.Name = "kupacidDataGridViewTextBoxColumn";
            this.kupacidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kupacidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kupacidDataGridViewTextBoxColumn.ValueMember = "kupac_id";
            // 
            // kupacBindingSource1
            // 
            this.kupacBindingSource1.DataMember = "kupac";
            this.kupacBindingSource1.DataSource = this.ineffableDataSet2;
            // 
            // ineffableDataSet2
            // 
            this.ineffableDataSet2.DataSetName = "IneffableDataSet2";
            this.ineffableDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "rezervacija";
            this.rezervacijaBindingSource.DataSource = this.ineffableDataSet1;
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "kupac";
            this.kupacBindingSource.DataSource = this.ineffableDataSet1;
            // 
            // rezervacijaTableAdapter
            // 
            this.rezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // gumbOsvjezi
            // 
            this.gumbOsvjezi.Location = new System.Drawing.Point(12, 267);
            this.gumbOsvjezi.Name = "gumbOsvjezi";
            this.gumbOsvjezi.Size = new System.Drawing.Size(75, 30);
            this.gumbOsvjezi.TabIndex = 1;
            this.gumbOsvjezi.Text = "Osvježi";
            this.gumbOsvjezi.UseVisualStyleBackColor = true;
            this.gumbOsvjezi.Click += new System.EventHandler(this.gumbOsvjezi_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kupacTableAdapter1
            // 
            this.kupacTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gumbOsvjezi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPregledRezervacija";
            this.Text = "frmPregledRezervacija";
            this.Load += new System.EventHandler(this.frmPregledRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IneffableDataSet1 ineffableDataSet1;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private IneffableDataSet1TableAdapters.rezervacijaTableAdapter rezervacijaTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private IneffableDataSet1TableAdapters.artiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private IneffableDataSet1TableAdapters.kupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.Button gumbOsvjezi;
        private System.Windows.Forms.Timer timer1;
        private IneffableDataSet2 ineffableDataSet2;
        private System.Windows.Forms.BindingSource kupacBindingSource1;
        private IneffableDataSet2TableAdapters.kupacTableAdapter kupacTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemerezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artiklidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kupacidDataGridViewTextBoxColumn;
    }
}