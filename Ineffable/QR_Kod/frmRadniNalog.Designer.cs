namespace QR_Kod
{
    partial class frmRadniNalog
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
            this.label1 = new System.Windows.Forms.Label();
            this.opisNalog = new System.Windows.Forms.TextBox();
            this.statusNalog = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oznakaNalog = new System.Windows.Forms.TextBox();
            this.gumbSpremi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cijenaNalog = new System.Windows.Forms.TextBox();
            this.uredjajNalog = new System.Windows.Forms.TextBox();
            this.serviserNalog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kupacNalog = new System.Windows.Forms.TextBox();
            this.gumbLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis:";
            // 
            // opisNalog
            // 
            this.opisNalog.Location = new System.Drawing.Point(85, 57);
            this.opisNalog.Multiline = true;
            this.opisNalog.Name = "opisNalog";
            this.opisNalog.Size = new System.Drawing.Size(161, 125);
            this.opisNalog.TabIndex = 1;
            // 
            // statusNalog
            // 
            this.statusNalog.AutoSize = true;
            this.statusNalog.Location = new System.Drawing.Point(12, 192);
            this.statusNalog.Name = "statusNalog";
            this.statusNalog.Size = new System.Drawing.Size(52, 17);
            this.statusNalog.TabIndex = 2;
            this.statusNalog.Text = "Status:";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Zaprimljeno",
            "Pregledano",
            "Kvar utvrđen",
            "Kvar nije utvrđen",
            "Popravak u tijeku",
            "Na čekanju",
            "Popravljeno",
            "Isporučeno"});
            this.status.Location = new System.Drawing.Point(85, 192);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(161, 24);
            this.status.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oznaka:";
            // 
            // oznakaNalog
            // 
            this.oznakaNalog.Location = new System.Drawing.Point(85, 29);
            this.oznakaNalog.Name = "oznakaNalog";
            this.oznakaNalog.Size = new System.Drawing.Size(161, 22);
            this.oznakaNalog.TabIndex = 5;
            // 
            // gumbSpremi
            // 
            this.gumbSpremi.Location = new System.Drawing.Point(171, 396);
            this.gumbSpremi.Name = "gumbSpremi";
            this.gumbSpremi.Size = new System.Drawing.Size(75, 31);
            this.gumbSpremi.TabIndex = 6;
            this.gumbSpremi.Text = "Spremi";
            this.gumbSpremi.UseVisualStyleBackColor = true;
            this.gumbSpremi.Click += new System.EventHandler(this.gumbSpremi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cijena:";
            // 
            // cijenaNalog
            // 
            this.cijenaNalog.Location = new System.Drawing.Point(85, 343);
            this.cijenaNalog.Name = "cijenaNalog";
            this.cijenaNalog.Size = new System.Drawing.Size(161, 22);
            this.cijenaNalog.TabIndex = 8;
            // 
            // uredjajNalog
            // 
            this.uredjajNalog.Location = new System.Drawing.Point(85, 231);
            this.uredjajNalog.Name = "uredjajNalog";
            this.uredjajNalog.Size = new System.Drawing.Size(161, 22);
            this.uredjajNalog.TabIndex = 9;
            // 
            // serviserNalog
            // 
            this.serviserNalog.Location = new System.Drawing.Point(85, 271);
            this.serviserNalog.Name = "serviserNalog";
            this.serviserNalog.Size = new System.Drawing.Size(161, 22);
            this.serviserNalog.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Uređaj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Serviser:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kupac:";
            // 
            // kupacNalog
            // 
            this.kupacNalog.Location = new System.Drawing.Point(85, 307);
            this.kupacNalog.Name = "kupacNalog";
            this.kupacNalog.Size = new System.Drawing.Size(161, 22);
            this.kupacNalog.TabIndex = 14;
            // 
            // gumbLog
            // 
            this.gumbLog.Location = new System.Drawing.Point(338, 396);
            this.gumbLog.Name = "gumbLog";
            this.gumbLog.Size = new System.Drawing.Size(81, 31);
            this.gumbLog.TabIndex = 15;
            this.gumbLog.Text = "Prikaži log";
            this.gumbLog.UseVisualStyleBackColor = true;
            this.gumbLog.Click += new System.EventHandler(this.gumbLog_Click);
            // 
            // frmRadniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gumbLog);
            this.Controls.Add(this.kupacNalog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serviserNalog);
            this.Controls.Add(this.uredjajNalog);
            this.Controls.Add(this.cijenaNalog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gumbSpremi);
            this.Controls.Add(this.oznakaNalog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusNalog);
            this.Controls.Add(this.opisNalog);
            this.Controls.Add(this.label1);
            this.Name = "frmRadniNalog";
            this.Text = "frmRadniNalog";
            this.Load += new System.EventHandler(this.frmRadniNalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox opisNalog;
        private System.Windows.Forms.Label statusNalog;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oznakaNalog;
        private System.Windows.Forms.Button gumbSpremi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cijenaNalog;
        private System.Windows.Forms.TextBox uredjajNalog;
        private System.Windows.Forms.TextBox serviserNalog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kupacNalog;
        private System.Windows.Forms.Button gumbLog;
    }
}