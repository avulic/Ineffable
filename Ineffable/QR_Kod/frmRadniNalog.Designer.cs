﻿namespace QR_Kod
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis:";
            // 
            // opisNalog
            // 
            this.opisNalog.Location = new System.Drawing.Point(85, 93);
            this.opisNalog.Multiline = true;
            this.opisNalog.Name = "opisNalog";
            this.opisNalog.Size = new System.Drawing.Size(161, 125);
            this.opisNalog.TabIndex = 1;
            // 
            // statusNalog
            // 
            this.statusNalog.AutoSize = true;
            this.statusNalog.Location = new System.Drawing.Point(12, 243);
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
            this.status.Location = new System.Drawing.Point(85, 243);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(161, 24);
            this.status.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oznaka:";
            // 
            // oznakaNalog
            // 
            this.oznakaNalog.Location = new System.Drawing.Point(85, 49);
            this.oznakaNalog.Name = "oznakaNalog";
            this.oznakaNalog.Size = new System.Drawing.Size(161, 22);
            this.oznakaNalog.TabIndex = 5;
            // 
            // gumbSpremi
            // 
            this.gumbSpremi.Location = new System.Drawing.Point(171, 282);
            this.gumbSpremi.Name = "gumbSpremi";
            this.gumbSpremi.Size = new System.Drawing.Size(75, 31);
            this.gumbSpremi.TabIndex = 6;
            this.gumbSpremi.Text = "Spremi";
            this.gumbSpremi.UseVisualStyleBackColor = true;
            this.gumbSpremi.Click += new System.EventHandler(this.gumbSpremi_Click);
            // 
            // frmRadniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}