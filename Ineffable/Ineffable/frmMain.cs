using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ineffable
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            IsMdiContainer = true;
        }

        int pomak;
        int pomakX;
        int pomakY;
        private void msIzbornik_MouseDown(object sender, MouseEventArgs e)
        {
            pomak = 1;
            pomakX = e.X;
            pomakY = e.Y;
        }

        private void msIzbornik_MouseUp(object sender, MouseEventArgs e)
        {
            pomak = 0;
        }

        private void msIzbornik_MouseMove(object sender, MouseEventArgs e)
        {
            if (pomak == 1)
            {
                this.SetDesktopLocation(MousePosition.X - pomakX, MousePosition.Y - pomakY);
            }
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pExit_Paint(object sender, PaintEventArgs e)
        {
            Graphics exitPanel = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            exitPanel.DrawLine(pen, 7, 7, 19, 19);
            exitPanel.DrawLine(pen, 7, 19, 19, 7);
            exitPanel.DrawLine(pen, 8, 7, 20, 19);
            exitPanel.DrawLine(pen, 8, 19, 20, 7);
        }

        private void panMinMaxMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics minMaxPanel = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            SolidBrush brush = new SolidBrush(Color.FromArgb(230, 179, 70));
            minMaxPanel.DrawRectangle(pen, 7, 7, 12, 12);
            minMaxPanel.FillRectangle(brush, 7, 7, 12, 12);
            minMaxPanel.DrawRectangle(pen, 9, 7, 7, 10);
            minMaxPanel.DrawRectangle(pen, 12, 12, 10, 10);
        }

        private void panHide_Paint(object sender, PaintEventArgs e)
        {
            Graphics hidPanel = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            SolidBrush brush = new SolidBrush(Color.FromArgb(230, 179, 70));
            hidPanel.DrawRectangle(pen, 7, 16, 12, 4);
            hidPanel.FillRectangle(brush, 7, 16, 12, 4);
        }

        private void paExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mm = 0;
        private void panMinMaxMain_Click(object sender, EventArgs e)
        {
            if (mm == 0)
            {
                WindowState = FormWindowState.Maximized;
                mm = 1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                mm = 0;
            }
        }

        private void panHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
