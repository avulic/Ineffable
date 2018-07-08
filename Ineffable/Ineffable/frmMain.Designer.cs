namespace Ineffable
{
    partial class frmMain
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
            this.msIzbornik = new System.Windows.Forms.MenuStrip();
            this.msIzbornikArtikli = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzbornikServisi = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzbornikChat = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzbornikRezervacija = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzbornikRacun = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajRačuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzbornikZaposlenici = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzbornikOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.paExitMain = new System.Windows.Forms.Panel();
            this.panMinMaxMain = new System.Windows.Forms.Panel();
            this.panHide = new System.Windows.Forms.Panel();
            this.msIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIzbornik
            // 
            this.msIzbornik.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msIzbornikArtikli,
            this.msIzbornikServisi,
            this.msIzbornikChat,
            this.msIzbornikRezervacija,
            this.msIzbornikRacun,
            this.msIzbornikZaposlenici,
            this.msIzbornikOdjava});
            this.msIzbornik.Location = new System.Drawing.Point(0, 0);
            this.msIzbornik.Name = "msIzbornik";
            this.msIzbornik.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msIzbornik.Size = new System.Drawing.Size(693, 28);
            this.msIzbornik.TabIndex = 0;
            this.msIzbornik.Text = "menuStrip1";
            this.msIzbornik.Visible = false;
            this.msIzbornik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.msIzbornik_MouseDown);
            this.msIzbornik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.msIzbornik_MouseMove);
            this.msIzbornik.MouseUp += new System.Windows.Forms.MouseEventHandler(this.msIzbornik_MouseUp);
            // 
            // msIzbornikArtikli
            // 
            this.msIzbornikArtikli.Name = "msIzbornikArtikli";
            this.msIzbornikArtikli.Size = new System.Drawing.Size(60, 24);
            this.msIzbornikArtikli.Text = "Artikli";
            this.msIzbornikArtikli.Click += new System.EventHandler(this.msIzbornikArtikli_Click);
            // 
            // msIzbornikServisi
            // 
            this.msIzbornikServisi.Name = "msIzbornikServisi";
            this.msIzbornikServisi.Size = new System.Drawing.Size(63, 24);
            this.msIzbornikServisi.Text = "Servisi";
            this.msIzbornikServisi.Click += new System.EventHandler(this.msIzbornikServisi_Click);
            // 
            // msIzbornikChat
            // 
            this.msIzbornikChat.Name = "msIzbornikChat";
            this.msIzbornikChat.Size = new System.Drawing.Size(51, 24);
            this.msIzbornikChat.Text = "Chat";
            this.msIzbornikChat.Click += new System.EventHandler(this.msIzbornikChat_Click);
            // 
            // msIzbornikRezervacija
            // 
            this.msIzbornikRezervacija.Name = "msIzbornikRezervacija";
            this.msIzbornikRezervacija.Size = new System.Drawing.Size(96, 24);
            this.msIzbornikRezervacija.Text = "Rezervacije";
            this.msIzbornikRezervacija.Click += new System.EventHandler(this.msIzbornikRezervacija_Click);
            // 
            // msIzbornikRacun
            // 
            this.msIzbornikRacun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajRačunToolStripMenuItem,
            this.pregledajRačuneToolStripMenuItem});
            this.msIzbornikRacun.Name = "msIzbornikRacun";
            this.msIzbornikRacun.Size = new System.Drawing.Size(65, 24);
            this.msIzbornikRacun.Text = "Računi";
            // 
            // kreirajRačunToolStripMenuItem
            // 
            this.kreirajRačunToolStripMenuItem.Name = "kreirajRačunToolStripMenuItem";
            this.kreirajRačunToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.kreirajRačunToolStripMenuItem.Text = "Kreiraj račun";
            this.kreirajRačunToolStripMenuItem.Click += new System.EventHandler(this.kreirajRačunToolStripMenuItem_Click);
            // 
            // pregledajRačuneToolStripMenuItem
            // 
            this.pregledajRačuneToolStripMenuItem.Name = "pregledajRačuneToolStripMenuItem";
            this.pregledajRačuneToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.pregledajRačuneToolStripMenuItem.Text = "Pregledaj račune";
            this.pregledajRačuneToolStripMenuItem.Click += new System.EventHandler(this.pregledajRačuneToolStripMenuItem_Click);
            // 
            // msIzbornikZaposlenici
            // 
            this.msIzbornikZaposlenici.Name = "msIzbornikZaposlenici";
            this.msIzbornikZaposlenici.Size = new System.Drawing.Size(97, 24);
            this.msIzbornikZaposlenici.Text = "Zaposlenici";
            // 
            // msIzbornikOdjava
            // 
            this.msIzbornikOdjava.Name = "msIzbornikOdjava";
            this.msIzbornikOdjava.Size = new System.Drawing.Size(68, 24);
            this.msIzbornikOdjava.Text = "Odjava";
            // 
            // paExitMain
            // 
            this.paExitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paExitMain.BackColor = System.Drawing.Color.White;
            this.paExitMain.Location = new System.Drawing.Point(656, 0);
            this.paExitMain.Margin = new System.Windows.Forms.Padding(4);
            this.paExitMain.Name = "paExitMain";
            this.paExitMain.Size = new System.Drawing.Size(37, 30);
            this.paExitMain.TabIndex = 2;
            this.paExitMain.Click += new System.EventHandler(this.paExitMain_Click);
            this.paExitMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pExit_Paint);
            // 
            // panMinMaxMain
            // 
            this.panMinMaxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panMinMaxMain.BackColor = System.Drawing.Color.White;
            this.panMinMaxMain.Location = new System.Drawing.Point(608, 0);
            this.panMinMaxMain.Margin = new System.Windows.Forms.Padding(4);
            this.panMinMaxMain.Name = "panMinMaxMain";
            this.panMinMaxMain.Size = new System.Drawing.Size(40, 30);
            this.panMinMaxMain.TabIndex = 3;
            this.panMinMaxMain.Click += new System.EventHandler(this.panMinMaxMain_Click);
            this.panMinMaxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panMinMaxMain_Paint);
            // 
            // panHide
            // 
            this.panHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panHide.BackColor = System.Drawing.Color.White;
            this.panHide.Location = new System.Drawing.Point(561, 0);
            this.panHide.Margin = new System.Windows.Forms.Padding(4);
            this.panHide.Name = "panHide";
            this.panHide.Size = new System.Drawing.Size(39, 30);
            this.panHide.TabIndex = 4;
            this.panHide.Click += new System.EventHandler(this.panHide_Click);
            this.panHide.Paint += new System.Windows.Forms.PaintEventHandler(this.panHide_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 586);
            this.Controls.Add(this.panHide);
            this.Controls.Add(this.panMinMaxMain);
            this.Controls.Add(this.paExitMain);
            this.Controls.Add(this.msIzbornik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msIzbornik;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msIzbornik.ResumeLayout(false);
            this.msIzbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIzbornik;
        private System.Windows.Forms.ToolStripMenuItem msIzbornikArtikli;
        private System.Windows.Forms.ToolStripMenuItem msIzbornikOdjava;
        private System.Windows.Forms.ToolStripMenuItem msIzbornikServisi;
        private System.Windows.Forms.ToolStripMenuItem msIzbornikChat;
        private System.Windows.Forms.ToolStripMenuItem msIzbornikRezervacija;
        private System.Windows.Forms.ToolStripMenuItem msIzbornikRacun;
        private System.Windows.Forms.Panel paExitMain;
        private System.Windows.Forms.Panel panMinMaxMain;
        private System.Windows.Forms.Panel panHide;
        private System.Windows.Forms.ToolStripMenuItem msIzbornikZaposlenici;
        private System.Windows.Forms.ToolStripMenuItem kreirajRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajRačuneToolStripMenuItem;
    }
}

