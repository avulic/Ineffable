namespace RezervacijaArtikala
{
    partial class frmRezervacija
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
            this.artiklidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinanaskladistuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new RezervacijaArtikala.IneffableDataSet();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gumbRezerviraj = new System.Windows.Forms.Button();
            this.artiklTableAdapter = new RezervacijaArtikala.IneffableDataSetTableAdapters.artiklTableAdapter();
            this.dobavljacTableAdapter = new RezervacijaArtikala.IneffableDataSetTableAdapters.dobavljacTableAdapter();
            this.kolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artiklidDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinanaskladistuDataGridViewTextBoxColumn,
            this.dobavljacidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artiklBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // artiklidDataGridViewTextBoxColumn
            // 
            this.artiklidDataGridViewTextBoxColumn.DataPropertyName = "artikl_id";
            this.artiklidDataGridViewTextBoxColumn.HeaderText = "artikl_id";
            this.artiklidDataGridViewTextBoxColumn.Name = "artiklidDataGridViewTextBoxColumn";
            this.artiklidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // kolicinanaskladistuDataGridViewTextBoxColumn
            // 
            this.kolicinanaskladistuDataGridViewTextBoxColumn.DataPropertyName = "kolicina_na_skladistu";
            this.kolicinanaskladistuDataGridViewTextBoxColumn.HeaderText = "kolicina_na_skladistu";
            this.kolicinanaskladistuDataGridViewTextBoxColumn.Name = "kolicinanaskladistuDataGridViewTextBoxColumn";
            // 
            // dobavljacidDataGridViewTextBoxColumn
            // 
            this.dobavljacidDataGridViewTextBoxColumn.DataPropertyName = "dobavljac_id";
            this.dobavljacidDataGridViewTextBoxColumn.DataSource = this.dobavljacBindingSource;
            this.dobavljacidDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.dobavljacidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dobavljacidDataGridViewTextBoxColumn.HeaderText = "Dobavljac";
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
            // gumbRezerviraj
            // 
            this.gumbRezerviraj.Location = new System.Drawing.Point(526, 219);
            this.gumbRezerviraj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gumbRezerviraj.Name = "gumbRezerviraj";
            this.gumbRezerviraj.Size = new System.Drawing.Size(61, 25);
            this.gumbRezerviraj.TabIndex = 1;
            this.gumbRezerviraj.Text = "Rezerviraj";
            this.gumbRezerviraj.UseVisualStyleBackColor = true;
            this.gumbRezerviraj.Click += new System.EventHandler(this.gumbRezerviraj_Click);
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // dobavljacTableAdapter
            // 
            this.dobavljacTableAdapter.ClearBeforeFill = true;
            // 
            // kolicina
            // 
            this.kolicina.Location = new System.Drawing.Point(641, 10);
            this.kolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kolicina.Name = "kolicina";
            this.kolicina.Size = new System.Drawing.Size(76, 20);
            this.kolicina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Količina:";
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kolicina);
            this.Controls.Add(this.gumbRezerviraj);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRezervacija";
            this.Text = "frmRezervacija";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmRezervacija_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gumbRezerviraj;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private IneffableDataSetTableAdapters.artiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private IneffableDataSetTableAdapters.dobavljacTableAdapter dobavljacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinanaskladistuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dobavljacidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox kolicina;
        private System.Windows.Forms.Label label1;
    }
}