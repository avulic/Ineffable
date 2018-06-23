using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaRegistracija
{
    public partial class frmPrijava : Form
    {
        Form parent;
        public frmPrijava(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        int pomak;
        int pomakX;
        int pomakY;
        private void frmPrijava_MouseDown(object sender, MouseEventArgs e)
        {
            pomak = 1;
            pomakX = e.X;
            pomakY = e.Y;
        }

        private void frmPrijava_MouseUp(object sender, MouseEventArgs e)
        {
            pomak = 0;
        }

        private void frmPrijava_MouseMove(object sender, MouseEventArgs e)
        {
            if (pomak == 1)
            {
                this.SetDesktopLocation(MousePosition.X - pomakX, MousePosition.Y - pomakY);
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Autentifikator autentifikator = new Autentifikator();
            string korIme = tbKorIme.Text;
            string lozinka = tbLozinka.Text;
            Cursor.Current = Cursors.WaitCursor;
            if (korIme == "")
            {
                MessageBox.Show("Niste unjeli korisničko ime");
            }
            else if (lozinka == "")
            {
                MessageBox.Show("Niste unjeli lozinku");
            }
            else
            {
                string korisniknadjen = autentifikator.prijaviKorisnika(korIme, lozinka);
                if (korisniknadjen == "")
                {
                    this.Close();
                }
                else if (korisniknadjen == "lozinka")
                {
                    MessageBox.Show("Kriva lozinka");
                }
                else
                {
                    MessageBox.Show("Krivo korisničko ime");
                }
            }        
        }

        private void Registracija_Click(object sender, EventArgs e)
        {
            frmRegistracija registracija = new frmRegistracija(parent);
            registracija.MdiParent = parent;
            registracija.WindowState = FormWindowState.Maximized;
            registracija.Show();
        }

    }
}
