namespace QR_Kod
{
    partial class frmPrikaziLog
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
            this.servislogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet3 = new QR_Kod.IneffableDataSet3();
            this.servis_logTableAdapter = new QR_Kod.IneffableDataSet3TableAdapters.servis_logTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opispromjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenapromjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpromjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.servislogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // servislogBindingSource
            // 
            this.servislogBindingSource.DataMember = "servis_log";
            this.servislogBindingSource.DataSource = this.ineffableDataSet3;
            // 
            // ineffableDataSet3
            // 
            this.ineffableDataSet3.DataSetName = "IneffableDataSet3";
            this.ineffableDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servis_logTableAdapter
            // 
            this.servis_logTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.servisidDataGridViewTextBoxColumn,
            this.opispromjeneDataGridViewTextBoxColumn,
            this.cijenapromjeneDataGridViewTextBoxColumn,
            this.datumpromjeneDataGridViewTextBoxColumn,
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servislogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(880, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servisidDataGridViewTextBoxColumn
            // 
            this.servisidDataGridViewTextBoxColumn.DataPropertyName = "servis_id";
            this.servisidDataGridViewTextBoxColumn.HeaderText = "servis_id";
            this.servisidDataGridViewTextBoxColumn.Name = "servisidDataGridViewTextBoxColumn";
            // 
            // opispromjeneDataGridViewTextBoxColumn
            // 
            this.opispromjeneDataGridViewTextBoxColumn.DataPropertyName = "opis_promjene";
            this.opispromjeneDataGridViewTextBoxColumn.HeaderText = "opis_promjene";
            this.opispromjeneDataGridViewTextBoxColumn.Name = "opispromjeneDataGridViewTextBoxColumn";
            // 
            // cijenapromjeneDataGridViewTextBoxColumn
            // 
            this.cijenapromjeneDataGridViewTextBoxColumn.DataPropertyName = "cijena_promjene";
            this.cijenapromjeneDataGridViewTextBoxColumn.HeaderText = "cijena_promjene";
            this.cijenapromjeneDataGridViewTextBoxColumn.Name = "cijenapromjeneDataGridViewTextBoxColumn";
            // 
            // datumpromjeneDataGridViewTextBoxColumn
            // 
            this.datumpromjeneDataGridViewTextBoxColumn.DataPropertyName = "datum_promjene";
            this.datumpromjeneDataGridViewTextBoxColumn.HeaderText = "datum_promjene";
            this.datumpromjeneDataGridViewTextBoxColumn.Name = "datumpromjeneDataGridViewTextBoxColumn";
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // frmPrikaziLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPrikaziLog";
            this.Text = "frmPrikaziLog";
            this.Load += new System.EventHandler(this.frmPrikaziLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servislogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private IneffableDataSet3 ineffableDataSet3;
        private System.Windows.Forms.BindingSource servislogBindingSource;
        private IneffableDataSet3TableAdapters.servis_logTableAdapter servis_logTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opispromjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenapromjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpromjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}