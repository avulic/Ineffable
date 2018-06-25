namespace BPModel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new BPModel.IneffableDataSet();
            this.kupacTableAdapter = new BPModel.IneffableDataSetTableAdapters.kupacTableAdapter();
            this.obavijestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrazlozenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obavijestDataGridViewTextBoxColumn,
            this.obrazlozenjeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kupacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 109);
            this.dataGridView1.TabIndex = 0;
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "kupac";
            this.kupacBindingSource.DataSource = this.ineffableDataSet;
            // 
            // ineffableDataSet
            // 
            this.ineffableDataSet.DataSetName = "IneffableDataSet";
            this.ineffableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // obavijestDataGridViewTextBoxColumn
            // 
            this.obavijestDataGridViewTextBoxColumn.DataPropertyName = "obavijest";
            this.obavijestDataGridViewTextBoxColumn.HeaderText = "Obavijest";
            this.obavijestDataGridViewTextBoxColumn.Name = "obavijestDataGridViewTextBoxColumn";
            this.obavijestDataGridViewTextBoxColumn.Width = 300;
            // 
            // obrazlozenjeDataGridViewTextBoxColumn
            // 
            this.obrazlozenjeDataGridViewTextBoxColumn.DataPropertyName = "obrazlozenje";
            this.obrazlozenjeDataGridViewTextBoxColumn.HeaderText = "Obrazloženje";
            this.obrazlozenjeDataGridViewTextBoxColumn.Name = "obrazlozenjeDataGridViewTextBoxColumn";
            this.obrazlozenjeDataGridViewTextBoxColumn.Width = 500;
            // 
            // frmObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 181);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmObavijesti";
            this.Text = "Obavijest";
            this.Load += new System.EventHandler(this.frmObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private IneffableDataSetTableAdapters.kupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn obavijestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrazlozenjeDataGridViewTextBoxColumn;
    }
}