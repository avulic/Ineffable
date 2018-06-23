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
            this.msIzbornik.Size = new System.Drawing.Size(520, 24);
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
            this.msIzbornikArtikli.Size = new System.Drawing.Size(50, 20);
            this.msIzbornikArtikli.Text = "Artikli";
            // 
            // msIzbornikServisi
            // 
            this.msIzbornikServisi.Name = "msIzbornikServisi";
            this.msIzbornikServisi.Size = new System.Drawing.Size(52, 20);
            this.msIzbornikServisi.Text = "Servisi";
            // 
            // msIzbornikChat
            // 
            this.msIzbornikChat.Name = "msIzbornikChat";
            this.msIzbornikChat.Size = new System.Drawing.Size(44, 20);
            this.msIzbornikChat.Text = "Chat";
            // 
            // msIzbornikRezervacija
            // 
            this.msIzbornikRezervacija.Name = "msIzbornikRezervacija";
            this.msIzbornikRezervacija.Size = new System.Drawing.Size(77, 20);
            this.msIzbornikRezervacija.Text = "Rezervacije";
            // 
            // msIzbornikRacun
            // 
            this.msIzbornikRacun.Name = "msIzbornikRacun";
            this.msIzbornikRacun.Size = new System.Drawing.Size(55, 20);
            this.msIzbornikRacun.Text = "Računi";
            // 
            // msIzbornikZaposlenici
            // 
            this.msIzbornikZaposlenici.Name = "msIzbornikZaposlenici";
            this.msIzbornikZaposlenici.Size = new System.Drawing.Size(79, 20);
            this.msIzbornikZaposlenici.Text = "Zaposlenici";
            // 
            // msIzbornikOdjava
            // 
            this.msIzbornikOdjava.Name = "msIzbornikOdjava";
            this.msIzbornikOdjava.Size = new System.Drawing.Size(56, 20);
            this.msIzbornikOdjava.Text = "Odjava";
            // 
            // paExitMain
            // 
            this.paExitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paExitMain.BackColor = System.Drawing.Color.White;
            this.paExitMain.Location = new System.Drawing.Point(492, 0);
            this.paExitMain.Name = "paExitMain";
            this.paExitMain.Size = new System.Drawing.Size(28, 24);
            this.paExitMain.TabIndex = 2;
            this.paExitMain.Click += new System.EventHandler(this.paExitMain_Click);
            this.paExitMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pExit_Paint);
            // 
            // panMinMaxMain
            // 
            this.panMinMaxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panMinMaxMain.BackColor = System.Drawing.Color.White;
            this.panMinMaxMain.Location = new System.Drawing.Point(456, 0);
            this.panMinMaxMain.Name = "panMinMaxMain";
            this.panMinMaxMain.Size = new System.Drawing.Size(30, 24);
            this.panMinMaxMain.TabIndex = 3;
            this.panMinMaxMain.Click += new System.EventHandler(this.panMinMaxMain_Click);
            this.panMinMaxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panMinMaxMain_Paint);
            // 
            // panHide
            // 
            this.panHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panHide.BackColor = System.Drawing.Color.White;
            this.panHide.Location = new System.Drawing.Point(421, 0);
            this.panHide.Name = "panHide";
            this.panHide.Size = new System.Drawing.Size(29, 24);
            this.panHide.TabIndex = 4;
            this.panHide.Click += new System.EventHandler(this.panHide_Click);
            this.panHide.Paint += new System.Windows.Forms.PaintEventHandler(this.panHide_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 476);
            this.Controls.Add(this.panHide);
            this.Controls.Add(this.panMinMaxMain);
            this.Controls.Add(this.paExitMain);
            this.Controls.Add(this.msIzbornik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MainMenuStrip = this.msIzbornik;
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
    }
}

