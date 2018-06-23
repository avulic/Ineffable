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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoviArtikl));
            this.ineffableBPDataSet = new CrudArtikala.IneffableDataSet();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new CrudArtikala.IneffableDataSetTableAdapters.artiklTableAdapter();
            this.tableAdapterManager = new CrudArtikala.IneffableDataSetTableAdapters.TableAdapterManager();
            this.dobavljacTableAdapter = new CrudArtikala.IneffableDataSetTableAdapters.dobavljacTableAdapter();
            this.artiklBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.artiklBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dobavljac_idComboBox = new System.Windows.Forms.ComboBox();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicina_na_skladistuTextBox = new System.Windows.Forms.TextBox();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            dobavljac_idLabel = new System.Windows.Forms.Label();
            kolicina_na_skladistuLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ineffableBPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingNavigator)).BeginInit();
            this.artiklBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
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
            cijenaLabel.Location = new System.Drawing.Point(21, 188);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 7;
            cijenaLabel.Text = "Cijena:";
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
            // ineffableBPDataSet
            // 
            this.ineffableBPDataSet.DataSetName = "IneffableBPDataSet";
            this.ineffableBPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "artikl";
            this.artiklBindingSource.DataSource = this.ineffableBPDataSet;
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
            // dobavljacTableAdapter
            // 
            this.dobavljacTableAdapter.ClearBeforeFill = true;
            // 
            // artiklBindingNavigator
            // 
            this.artiklBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.artiklBindingNavigator.BindingSource = this.artiklBindingSource;
            this.artiklBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.artiklBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.artiklBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.artiklBindingNavigatorSaveItem});
            this.artiklBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.artiklBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.artiklBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.artiklBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.artiklBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.artiklBindingNavigator.Name = "artiklBindingNavigator";
            this.artiklBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.artiklBindingNavigator.Size = new System.Drawing.Size(419, 25);
            this.artiklBindingNavigator.TabIndex = 0;
            this.artiklBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // artiklBindingNavigatorSaveItem
            // 
            this.artiklBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.artiklBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("artiklBindingNavigatorSaveItem.Image")));
            this.artiklBindingNavigatorSaveItem.Name = "artiklBindingNavigatorSaveItem";
            this.artiklBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.artiklBindingNavigatorSaveItem.Text = "Save Data";
            this.artiklBindingNavigatorSaveItem.Click += new System.EventHandler(this.artiklBindingNavigatorSaveItem_Click);
            // 
            // dobavljac_idComboBox
            // 
            this.dobavljac_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "dobavljac_id", true));
            this.dobavljac_idComboBox.DataSource = this.dobavljacBindingSource;
            this.dobavljac_idComboBox.DisplayMember = "naziv";
            this.dobavljac_idComboBox.FormattingEnabled = true;
            this.dobavljac_idComboBox.Location = new System.Drawing.Point(135, 258);
            this.dobavljac_idComboBox.Name = "dobavljac_idComboBox";
            this.dobavljac_idComboBox.Size = new System.Drawing.Size(224, 21);
            this.dobavljac_idComboBox.TabIndex = 4;
            this.dobavljac_idComboBox.ValueMember = "dobavljac_id";
            // 
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataMember = "dobavljac";
            this.dobavljacBindingSource.DataSource = this.ineffableBPDataSet;
            // 
            // kolicina_na_skladistuTextBox
            // 
            this.kolicina_na_skladistuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "kolicina_na_skladistu", true));
            this.kolicina_na_skladistuTextBox.Location = new System.Drawing.Point(135, 222);
            this.kolicina_na_skladistuTextBox.Name = "kolicina_na_skladistuTextBox";
            this.kolicina_na_skladistuTextBox.Size = new System.Drawing.Size(224, 20);
            this.kolicina_na_skladistuTextBox.TabIndex = 6;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(135, 188);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(224, 20);
            this.cijenaTextBox.TabIndex = 8;
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "opis", true));
            this.opisTextBox.Location = new System.Drawing.Point(135, 65);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(224, 114);
            this.opisTextBox.TabIndex = 10;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklBindingSource, "naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(135, 34);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(224, 20);
            this.nazivTextBox.TabIndex = 12;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(284, 306);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 13;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmNoviArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 354);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(kolicina_na_skladistuLabel);
            this.Controls.Add(this.kolicina_na_skladistuTextBox);
            this.Controls.Add(dobavljac_idLabel);
            this.Controls.Add(this.dobavljac_idComboBox);
            this.Controls.Add(this.artiklBindingNavigator);
            this.Name = "frmNoviArtikl";
            this.Text = "frmNoviArtikl";
            this.Load += new System.EventHandler(this.frmNoviArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ineffableBPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingNavigator)).EndInit();
            this.artiklBindingNavigator.ResumeLayout(false);
            this.artiklBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IneffableDataSet ineffableBPDataSet;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private IneffableDataSetTableAdapters.artiklTableAdapter artiklTableAdapter;
        private IneffableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator artiklBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton artiklBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox dobavljac_idComboBox;
        private System.Windows.Forms.TextBox kolicina_na_skladistuTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private IneffableDataSetTableAdapters.dobavljacTableAdapter dobavljacTableAdapter;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private System.Windows.Forms.Button btnSpremi;
    }
}