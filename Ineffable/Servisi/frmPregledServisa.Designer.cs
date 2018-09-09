namespace Servisi
{
    partial class frmPregledServisa
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
            this.lbUredjaji = new System.Windows.Forms.ListBox();
            this.radninalogservisaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new Servisi.IneffableDataSet();
            this.radninalogservisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalog_servisaTableAdapter = new Servisi.IneffableDataSetTableAdapters.radni_nalog_servisaTableAdapter();
            this.btnPrekiniServis = new System.Windows.Forms.Button();
            this.cpBar = new Servisi.ProgresBar();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUredjaji
            // 
            this.lbUredjaji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUredjaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lbUredjaji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUredjaji.DataSource = this.radninalogservisaBindingSource;
            this.lbUredjaji.DisplayMember = "uredjaj";
            this.lbUredjaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUredjaji.ForeColor = System.Drawing.Color.White;
            this.lbUredjaji.FormattingEnabled = true;
            this.lbUredjaji.ItemHeight = 16;
            this.lbUredjaji.Location = new System.Drawing.Point(12, 102);
            this.lbUredjaji.Name = "lbUredjaji";
            this.lbUredjaji.Size = new System.Drawing.Size(120, 400);
            this.lbUredjaji.TabIndex = 0;
            this.lbUredjaji.ValueMember = "oznaka";
            this.lbUredjaji.SelectedIndexChanged += new System.EventHandler(this.lbUredjaji_SelectedIndexChanged);
            // 
            // radninalogservisaBindingSource1
            // 
            this.radninalogservisaBindingSource1.DataMember = "radni_nalog_servisa";
            this.radninalogservisaBindingSource1.DataSource = this.ineffableDataSet;
            // 
            // ineffableDataSet
            // 
            this.ineffableDataSet.DataSetName = "IneffableDataSet";
            this.ineffableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radninalogservisaBindingSource
            // 
            this.radninalogservisaBindingSource.DataMember = "radni_nalog_servisa";
            this.radninalogservisaBindingSource.DataSource = this.ineffableDataSet;
            // 
            // radni_nalog_servisaTableAdapter
            // 
            this.radni_nalog_servisaTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrekiniServis
            // 
            this.btnPrekiniServis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrekiniServis.Location = new System.Drawing.Point(817, 488);
            this.btnPrekiniServis.Name = "btnPrekiniServis";
            this.btnPrekiniServis.Size = new System.Drawing.Size(95, 21);
            this.btnPrekiniServis.TabIndex = 6;
            this.btnPrekiniServis.Text = "Prekini servis";
            this.btnPrekiniServis.UseVisualStyleBackColor = true;
            // 
            // cpBar
            // 
            this.cpBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cpBar.Location = new System.Drawing.Point(140, 37);
            this.cpBar.Name = "cpBar";
            this.cpBar.Size = new System.Drawing.Size(736, 311);
            this.cpBar.TabIndex = 7;
            // 
            // frmPregledServisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(941, 539);
            this.Controls.Add(this.cpBar);
            this.Controls.Add(this.btnPrekiniServis);
            this.Controls.Add(this.lbUredjaji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregledServisa";
            this.Text = "frmPregledServisa";
            this.Load += new System.EventHandler(this.frmPregledServisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogservisaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUredjaji;
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource radninalogservisaBindingSource;
        private IneffableDataSetTableAdapters.radni_nalog_servisaTableAdapter radni_nalog_servisaTableAdapter;
        private System.Windows.Forms.BindingSource radninalogservisaBindingSource1;
        private System.Windows.Forms.Button btnPrekiniServis;
        private ProgresBar cpBar;
    }
}