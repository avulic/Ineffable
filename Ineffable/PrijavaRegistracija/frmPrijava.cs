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
        Korisnik kori { get; set; }
        public frmPrijava(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string korIme = tbKorIme.Text;
            string lozinka = tbLozinka.Text;

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
                Autentifikator autentifikator = new Autentifikator();
                string korisniknadjen = autentifikator.prijaviKorisnika(korIme, lozinka);
                Korisnik kori = Autentifikator.dohvatiPrijavljenogKorisnika();
                if (korisniknadjen == "")
                {
                    parent.MainMenuStrip.Visible = true;
                    
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
            frmRegistracija forma = new frmRegistracija(parent, this);
            
            forma.TopLevel = false;
            forma.Parent = parent;
            parent.Size = forma.Size;
            forma.Dock = DockStyle.Fill;
            this.Hide();
            forma.Show();
        }

        private void frmPrijava_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "prijava_registracija.htm");
        }
    }
}
