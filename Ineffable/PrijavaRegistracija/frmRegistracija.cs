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
        Form parent, prijava;
        public frmRegistracija(Form parent, Form prijava)
        {
            InitializeComponent();
            this.parent = parent;
            this.prijava = prijava;
            this.ulogaTableAdapter.Fill(this.ineffableDataSet.uloga);
            cbUloge.SelectedIndex = 2;
           
        }
        public frmRegistracija(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
           
            this.ulogaTableAdapter.Fill(this.ineffableDataSet.uloga);
            cbUloge.SelectedIndex = 2;

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string ime, prezime, email, korIme, lozinka, adresa, telefon, spol;
            int uloga;
            ime = tbIme.Text;
            prezime = tbPrezime.Text;
            email = tbEmail.Text;
            lozinka = tbLozinka.Text;
            korIme = tbKorIme.Text;
            adresa = tbAdresa.Text;
            telefon = tbTelefon.Text;
            uloga = (int)cbUloge.SelectedValue;
            if (rbMusko.Checked == true)
            {
                spol = "musko";
            }
            else if (rbZensko.Checked == true)
            {
                spol = "zensko";
            }
            else
            {
                spol = "neodredeno";
            }
            bool ispravno = provjeraUnosa(ime, prezime, email, korIme, lozinka, adresa, telefon);
            if (ispravno)
            {
                Autentifikator autentifikator = new Autentifikator();
                ispravno = false;
                Cursor.Current = Cursors.WaitCursor;
                ispravno = autentifikator.registrirajKorisnika(ime, prezime, email, korIme, lozinka, adresa, telefon, spol, uloga);

                if (!ispravno)
                {
                    MessageBox.Show("Korisničko ime je zauzeto");
                }
                if (prijava != null)
                {
                    prijava.Show();
                }
                if (ispravno)
                {
                    MessageBox.Show("Uspjesno kreirano");
                    this.Close();
                }
                
            }
        }

        private bool provjeraUnosa(string ime, string prezime, string email, string korIme, string lozinka, string adresa, string telefon)
        {
            bool ispravno = true;
            if ((ime.Length == 0) || (prezime.Length == 0) || (email.Length == 0) || (korIme.Length == 0) || (lozinka.Length == 0) || (adresa.Length == 0) || (telefon.Length == 0))
            {
                MessageBox.Show("Niste unjeli sva polaj");
                ispravno = false;
            }
           
            return ispravno;
        }

        private void frmRegistracija_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "registracija.htm");
        }

        private void lbPrijava_Click(object sender, EventArgs e)
        {
            frmPrijava prijava = new frmPrijava(parent);
            prijava.TopLevel = false;
            prijava.Parent = parent;
            parent.Size = prijava.Size;
            prijava.Dock = DockStyle.Fill;
            prijava.Show();
            this.Close();
        }
    }
}
