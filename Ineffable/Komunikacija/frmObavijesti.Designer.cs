namespace Komunikacija
{
    partial class frmObavijesti
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
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.zahtjevzaservisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet3 = new Komunikacija.IneffableDataSet3();
            this.zahtjev_za_servisTableAdapter = new Komunikacija.IneffableDataSet3TableAdapters.zahtjev_za_servisTableAdapter();
            this.btnUredu = new System.Windows.Forms.Button();
            this.zahtjev_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpodnosenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivuredjajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obavijestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrazlozenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevzaservisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AutoGenerateColumns = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zahtjev_id,
            this.datumpodnosenjaDataGridViewTextBoxColumn,
            this.nazivuredjajaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.obavijestDataGridViewTextBoxColumn,
            this.obrazlozenjeDataGridViewTextBoxColumn});
            this.dgvObavijesti.DataSource = this.zahtjevzaservisBindingSource;
            this.dgvObavijesti.Location = new System.Drawing.Point(12, 12);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.Size = new System.Drawing.Size(740, 150);
            this.dgvObavijesti.TabIndex = 0;
            // 
            // zahtjevzaservisBindingSource
            // 
            this.zahtjevzaservisBindingSource.DataMember = "zahtjev_za_servis";
            this.zahtjevzaservisBindingSource.DataSource = this.ineffableDataSet3;
            // 
            // ineffableDataSet3
            // 
            this.ineffableDataSet3.DataSetName = "IneffableDataSet3";
            this.ineffableDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjev_za_servisTableAdapter
            // 
            this.zahtjev_za_servisTableAdapter.ClearBeforeFill = true;
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(665, 183);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(87, 23);
            this.btnUredu.TabIndex = 1;
            this.btnUredu.Text = "U redu";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // zahtjev_id
            // 
            this.zahtjev_id.DataPropertyName = "zahtjev_id";
            this.zahtjev_id.HeaderText = "zahtjev_id";
            this.zahtjev_id.Name = "zahtjev_id";
            this.zahtjev_id.ReadOnly = true;
            this.zahtjev_id.Visible = false;
            // 
            // datumpodnosenjaDataGridViewTextBoxColumn
            // 
            this.datumpodnosenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_podnosenja";
            this.datumpodnosenjaDataGridViewTextBoxColumn.HeaderText = "Datum podnošenja zahtjeva";
            this.datumpodnosenjaDataGridViewTextBoxColumn.Name = "datumpodnosenjaDataGridViewTextBoxColumn";
            // 
            // nazivuredjajaDataGridViewTextBoxColumn
            // 
            this.nazivuredjajaDataGridViewTextBoxColumn.DataPropertyName = "naziv_uredjaja";
            this.nazivuredjajaDataGridViewTextBoxColumn.HeaderText = "Naziv uređaja";
            this.nazivuredjajaDataGridViewTextBoxColumn.Name = "nazivuredjajaDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis kvara";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // obavijestDataGridViewTextBoxColumn
            // 
            this.obavijestDataGridViewTextBoxColumn.DataPropertyName = "obavijest";
            this.obavijestDataGridViewTextBoxColumn.HeaderText = "Obavijest";
            this.obavijestDataGridViewTextBoxColumn.Name = "obavijestDataGridViewTextBoxColumn";
            this.obavijestDataGridViewTextBoxColumn.Width = 200;
            // 
            // obrazlozenjeDataGridViewTextBoxColumn
            // 
            this.obrazlozenjeDataGridViewTextBoxColumn.DataPropertyName = "obrazlozenje";
            this.obrazlozenjeDataGridViewTextBoxColumn.HeaderText = "Obrazloženje";
            this.obrazlozenjeDataGridViewTextBoxColumn.Name = "obrazlozenjeDataGridViewTextBoxColumn";
            this.obrazlozenjeDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.dgvObavijesti);
            this.Name = "frmObavijesti";
            this.Text = "Nove obavijesti";
            this.Load += new System.EventHandler(this.frmObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevzaservisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObavijesti;
        private IneffableDataSet3 ineffableDataSet3;
        private System.Windows.Forms.BindingSource zahtjevzaservisBindingSource;
        private IneffableDataSet3TableAdapters.zahtjev_za_servisTableAdapter zahtjev_za_servisTableAdapter;
        private System.Windows.Forms.Button btnUredu;
        private System.Windows.Forms.DataGridViewTextBoxColumn zahtjev_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpodnosenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivuredjajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obavijestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrazlozenjeDataGridViewTextBoxColumn;
    }
}