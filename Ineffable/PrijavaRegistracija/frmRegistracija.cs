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
    public partial class frmRegistracija : Form
    {
        Form parent;
        
        public frmRegistracija(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Size = new System.Drawing.Size(321, 639);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string ime, prezime, email, korIme, lozinka, adresa, telefon;
            ime = tbIme.Text;
            prezime = tbPrezime.Text;
            email = tbEmail.Text;
            lozinka = tbLozinka.Text;
            korIme = tbKorIme.Text;
            adresa = tbAdresa.Text;
            telefon = tbTelefon.Text;
            bool ispravno = provjeriUnos(ime, prezime, email, korIme, lozinka, adresa, telefon);
            if (ispravno)
            {
                Autentifikator autentifikator = new Autentifikator();
                ispravno = false;
                while (!ispravno)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ispravno = autentifikator.registrirajKorisnika(ime, prezime, email, korIme, lozinka, adresa, telefon);
                    if (!ispravno)
                    {
                        MessageBox.Show("Korisničko ime je zauzeto");
                    }
                }
                this.Close();  
            }
        }
        private bool provjeriUnos(string ime, string prezime, string email, string korIme, string lozinka, string adresa, string telefon)
        {
            bool ispravno = true;
            if ((ime.Length == 0) || (prezime.Length == 0) || (email.Length == 0) || (korIme.Length == 0) || (lozinka.Length == 0) || (adresa.Length == 0) || (telefon.Length == 0))
            {
                MessageBox.Show("Niste unjeli sva polaj");
                ispravno = false;
            }
            return ispravno;
        }

        private void lbPrijava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
