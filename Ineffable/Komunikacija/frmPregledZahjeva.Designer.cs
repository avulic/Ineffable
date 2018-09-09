namespace Komunikacija
{
    partial class frmPregledZahjeva
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.txtObrazlozenje = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.zahtjevidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpodnosenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kupacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet2 = new Komunikacija.IneffableDataSet2();
            this.prezime = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kupacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nazivuredjajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipuredjajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodjacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevzaservisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjev_za_servisTableAdapter = new Komunikacija.IneffableDataSet2TableAdapters.zahtjev_za_servisTableAdapter();
            this.kupacTableAdapter = new Komunikacija.IneffableDataSet2TableAdapters.kupacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevzaservisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahtjevi za servisom";
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Location = new System.Drawing.Point(16, 249);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(174, 23);
            this.btnPrihvati.TabIndex = 2;
            this.btnPrihvati.Text = "Prihvati odabrani zahtjev";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnOdbij
            // 
            this.btnOdbij.Location = new System.Drawing.Point(16, 278);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(174, 23);
            this.btnOdbij.TabIndex = 3;
            this.btnOdbij.Text = "Odbij odabrani zahtjev";
            this.btnOdbij.UseVisualStyleBackColor = true;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // txtObrazlozenje
            // 
            this.txtObrazlozenje.Location = new System.Drawing.Point(12, 330);
            this.txtObrazlozenje.Multiline = true;
            this.txtObrazlozenje.Name = "txtObrazlozenje";
            this.txtObrazlozenje.Size = new System.Drawing.Size(668, 74);
            this.txtObrazlozenje.TabIndex = 4;
            this.txtObrazlozenje.Visible = false;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(686, 381);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 5;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Visible = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(9, 314);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(108, 13);
            this.lblPoruka.TabIndex = 6;
            this.lblPoruka.Text = "Unesite obrazloženje:";
            this.lblPoruka.Visible = false;
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.AllowUserToAddRows = false;
            this.dgvZahtjevi.AutoGenerateColumns = false;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zahtjevidDataGridViewTextBoxColumn,
            this.datumpodnosenjaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.ime,
            this.prezime,
            this.nazivuredjajaDataGridViewTextBoxColumn,
            this.tipuredjajaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.proizvodjacDataGridViewTextBoxColumn});
            this.dgvZahtjevi.DataSource = this.zahtjevzaservisBindingSource;
            this.dgvZahtjevi.Location = new System.Drawing.Point(12, 52);
            this.dgvZahtjevi.MultiSelect = false;
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZahtjevi.Size = new System.Drawing.Size(753, 191);
            this.dgvZahtjevi.TabIndex = 7;
            // 
            // zahtjevidDataGridViewTextBoxColumn
            // 
            this.zahtjevidDataGridViewTextBoxColumn.DataPropertyName = "zahtjev_id";
            this.zahtjevidDataGridViewTextBoxColumn.HeaderText = "Zahtjev ID";
            this.zahtjevidDataGridViewTextBoxColumn.Name = "zahtjevidDataGridViewTextBoxColumn";
            this.zahtjevidDataGridViewTextBoxColumn.ReadOnly = true;
            this.zahtjevidDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumpodnosenjaDataGridViewTextBoxColumn
            // 
            this.datumpodnosenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_podnosenja";
            this.datumpodnosenjaDataGridViewTextBoxColumn.HeaderText = "Datum podnošenja";
            this.datumpodnosenjaDataGridViewTextBoxColumn.Name = "datumpodnosenjaDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // ime
            // 
            this.ime.DataPropertyName = "kupac_id";
            this.ime.DataSource = this.kupacBindingSource;
            this.ime.DisplayMember = "ime";
            this.ime.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ime.HeaderText = "Ime klijenta";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ime.ValueMember = "kupac_id";
            // 
            // kupacBindingSource
            // 
            this.kupacBindingSource.DataMember = "kupac";
            this.kupacBindingSource.DataSource = this.ineffableDataSet2;
            // 
            // ineffableDataSet2
            // 
            this.ineffableDataSet2.DataSetName = "IneffableDataSet2";
            this.ineffableDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prezime
            // 
            this.prezime.DataPropertyName = "kupac_id";
            this.prezime.DataSource = this.kupacBindingSource1;
            this.prezime.DisplayMember = "prezime";
            this.prezime.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.prezime.HeaderText = "Prezime klijenta";
            this.prezime.Name = "prezime";
            this.prezime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prezime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.prezime.ValueMember = "kupac_id";
            // 
            // kupacBindingSource1
            // 
            this.kupacBindingSource1.DataMember = "kupac";
            this.kupacBindingSource1.DataSource = this.ineffableDataSet2;
            // 
            // nazivuredjajaDataGridViewTextBoxColumn
            // 
            this.nazivuredjajaDataGridViewTextBoxColumn.DataPropertyName = "naziv_uredjaja";
            this.nazivuredjajaDataGridViewTextBoxColumn.HeaderText = "Naziv uređaja";
            this.nazivuredjajaDataGridViewTextBoxColumn.Name = "nazivuredjajaDataGridViewTextBoxColumn";
            // 
            // tipuredjajaDataGridViewTextBoxColumn
            // 
            this.tipuredjajaDataGridViewTextBoxColumn.DataPropertyName = "tip_uredjaja";
            this.tipuredjajaDataGridViewTextBoxColumn.HeaderText = "Vrsta uređaja";
            this.tipuredjajaDataGridViewTextBoxColumn.Name = "tipuredjajaDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis kvara";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // proizvodjacDataGridViewTextBoxColumn
            // 
            this.proizvodjacDataGridViewTextBoxColumn.DataPropertyName = "proizvodjac";
            this.proizvodjacDataGridViewTextBoxColumn.HeaderText = "Proizvođač";
            this.proizvodjacDataGridViewTextBoxColumn.Name = "proizvodjacDataGridViewTextBoxColumn";
            // 
            // zahtjevzaservisBindingSource
            // 
            this.zahtjevzaservisBindingSource.DataMember = "zahtjev_za_servis";
            this.zahtjevzaservisBindingSource.DataSource = this.ineffableDataSet2;
            // 
            // zahtjev_za_servisTableAdapter
            // 
            this.zahtjev_za_servisTableAdapter.ClearBeforeFill = true;
            // 
            // kupacTableAdapter
            // 
            this.kupacTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledZahjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 574);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.txtObrazlozenje);
            this.Controls.Add(this.btnOdbij);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.label1);
            this.Name = "frmPregledZahjeva";
            this.Text = "Pregled zahtjeva";
            this.Load += new System.EventHandler(this.frmPregledZahjeva_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmPregledZahjeva_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevzaservisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.TextBox txtObrazlozenje;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private IneffableDataSet2 ineffableDataSet2;
        private System.Windows.Forms.BindingSource zahtjevzaservisBindingSource;
        private IneffableDataSet2TableAdapters.zahtjev_za_servisTableAdapter zahtjev_za_servisTableAdapter;
        private System.Windows.Forms.BindingSource kupacBindingSource;
        private IneffableDataSet2TableAdapters.kupacTableAdapter kupacTableAdapter;
        private System.Windows.Forms.BindingSource kupacBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zahtjevidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpodnosenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ime;
        private System.Windows.Forms.DataGridViewComboBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivuredjajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipuredjajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodjacDataGridViewTextBoxColumn;
    }
}