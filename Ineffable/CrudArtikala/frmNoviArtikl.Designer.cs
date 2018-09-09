namespace CrudArtikala
{
    partial class frmNoviArtikl
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
            System.Windows.Forms.Label dobavljac_idLabel;
            System.Windows.Forms.Label kolicina_na_skladistuLabel;
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label opisLabel;
            System.Windows.Forms.Label nazivLabel;
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ineffableDataSet = new CrudArtikala.IneffableDataSet();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljacTableAdapter = new CrudArtikala.IneffableDataSetTableAdapters.dobavljacTableAdapter();
            this.artiklTableAdapter = new CrudArtikala.IneffableDataSetTableAdapters.artiklTableAdapter();
            this.tableAdapterManager = new CrudArtikala.IneffableDataSetTableAdapters.TableAdapterManager();
            this.lblGreska1 = new System.Windows.Forms.Label();
            this.lblGreska2 = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.kolicina_na_skladistuTextBox = new System.Windows.Forms.TextBox();
            this.dobavljac_idComboBox = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            dobavljac_idLabel = new System.Windows.Forms.Label();
            kolicina_na_skladistuLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dobavljac_idLabel
            // 
            dobavljac_idLabel.AutoSize = true;
            dobavljac_idLabel.Location = new System.Drawing.Point(21, 266);
            dobavljac_idLabel.Name = "dobavljac_idLabel";
            dobavljac_idLabel.Size = new System.Drawing.Size(58, 13);
            dobavljac_idLabel.TabIndex = 3;
            dobavljac_idLabel.Text = "Dobavljač:";
            // 
            // kolicina_na_skladistuLabel
            // 
            kolicina_na_skladistuLabel.AutoSize = true;
            kolicina_na_skladistuLabel.Location = new System.Drawing.Point(21, 225);
            kolicina_na_skladistuLabel.Name = "kolicina_na_skladistuLabel";
            kolicina_na_skladistuLabel.Size = new System.Drawing.Size(106, 13);
            kolicina_na_skladistuLabel.TabIndex = 5;
            kolicina_na_skladistuLabel.Text = "Kolicina na skladistu:";
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(21, 192);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(89, 13);
            cijenaLabel.TabIndex = 7;
            cijenaLabel.Text = "Cijena u kunama:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Location = new System.Drawing.Point(21, 65);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(31, 13);
            opisLabel.TabIndex = 9;
            opisLabel.Text = "Opis:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(21, 37);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(68, 13);
            nazivLabel.TabIndex = 11;
            nazivLabel.Text = "Naziv artikla:";
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
            // dobavljacTableAdapter
            // 
            this.dobavljacTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = this.artiklTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dobavljacTableAdapter = this.dobavljacTableAdapter;
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
            // lblGreska1
            // 
            this.lblGreska1.AutoSize = true;
            this.lblGreska1.Location = new System.Drawing.Point(365, 191);
            this.lblGreska1.Name = "lblGreska1";
            this.lblGreska1.Size = new System.Drawing.Size(95, 13);
            this.lblGreska1.TabIndex = 14;
            this.lblGreska1.Text = "Neispravna cijena!";
            this.lblGreska1.Visible = false;
            // 
            // lblGreska2
            // 
            this.lblGreska2.AutoSize = true;
            this.lblGreska2.Location = new System.Drawing.Point(365, 225);
            this.lblGreska2.Name = "lblGreska2";
            this.lblGreska2.Size = new System.Drawing.Size(103, 13);
            this.lblGreska2.TabIndex = 15;
            this.lblGreska2.Text = "Neispravna količina!";
            this.lblGreska2.Visible = false;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(143, 34);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(216, 20);
            this.nazivTextBox.TabIndex = 17;
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "opis", true));
            this.opisTextBox.Location = new System.Drawing.Point(143, 65);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(216, 114);
            this.opisTextBox.TabIndex = 18;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(143, 189);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(216, 20);
            this.cijenaTextBox.TabIndex = 19;
            this.cijenaTextBox.TextChanged += new System.EventHandler(this.cijenaTextBox_TextChanged_1);
            // 
            // kolicina_na_skladistuTextBox
            // 
            this.kolicina_na_skladistuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "kolicina_na_skladistu", true));
            this.kolicina_na_skladistuTextBox.Location = new System.Drawing.Point(143, 222);
            this.kolicina_na_skladistuTextBox.Name = "kolicina_na_skladistuTextBox";
            this.kolicina_na_skladistuTextBox.Size = new System.Drawing.Size(216, 20);
            this.kolicina_na_skladistuTextBox.TabIndex = 20;
            this.kolicina_na_skladistuTextBox.TextChanged += new System.EventHandler(this.kolicina_na_skladistuTextBox_TextChanged_1);
            // 
            // dobavljac_idComboBox
            // 
            this.dobavljac_idComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dobavljac_idComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dobavljac_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "dobavljac_id", true));
            this.dobavljac_idComboBox.DataSource = this.dobavljacBindingSource;
            this.dobavljac_idComboBox.DisplayMember = "naziv";
            this.dobavljac_idComboBox.FormattingEnabled = true;
            this.dobavljac_idComboBox.Location = new System.Drawing.Point(143, 263);
            this.dobavljac_idComboBox.Name = "dobavljac_idComboBox";
            this.dobavljac_idComboBox.Size = new System.Drawing.Size(216, 21);
            this.dobavljac_idComboBox.TabIndex = 21;
            this.dobavljac_idComboBox.ValueMember = "dobavljac_id";
            this.dobavljac_idComboBox.MouseHover += new System.EventHandler(this.dobavljac_idComboBox_MouseHover);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(284, 308);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click_1);
            // 
            // frmNoviArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 362);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dobavljac_idComboBox);
            this.Controls.Add(this.kolicina_na_skladistuTextBox);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.lblGreska2);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(opisLabel);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(kolicina_na_skladistuLabel);
            this.Controls.Add(dobavljac_idLabel);
            this.Controls.Add(this.lblGreska1);
            this.Name = "frmNoviArtikl";
            this.Text = "Unos novog artikla";
            this.Load += new System.EventHandler(this.frmNoviArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IneffableDataSet ineffableDataSet;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private IneffableDataSetTableAdapters.dobavljacTableAdapter dobavljacTableAdapter;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private IneffableDataSetTableAdapters.artiklTableAdapter artiklTableAdapter;
        private IneffableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblGreska1;
        private System.Windows.Forms.Label lblGreska2;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox kolicina_na_skladistuTextBox;
        private System.Windows.Forms.ComboBox dobavljac_idComboBox;
        private System.Windows.Forms.Button btnSpremi;
    }
}