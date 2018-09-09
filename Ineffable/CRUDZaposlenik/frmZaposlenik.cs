using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrijavaRegistracija;
namespace CRUDZaposlenik
{
    public partial class frmZaposlenik : Form
    {
        Korisnik zaposlenik;
        CRUD crud = new CRUD();
        public frmZaposlenik(Korisnik zaposlenik)
        {
            InitializeComponent();
            this.zaposlenik = zaposlenik;
            postaviAvatar();

            popuniInformacijeOKorisniku();
            
        }
        public frmZaposlenik()
        {
            InitializeComponent();
        }

        private void postaviAvatar()
        {
            if (zaposlenik.spol == "musko")
            {
                pbAvatar.BackgroundImage = null;
                pbAvatar.BackgroundImage = CRUDZaposlenik.Properties.Resources.if_male3_403019;
            }
            else if (zaposlenik.spol == "zensko")
            {
                pbAvatar.BackgroundImage = null;
                pbAvatar.BackgroundImage = CRUDZaposlenik.Properties.Resources.if_female1_403023;
            }
            else
            {
                pbAvatar.BackgroundImage = null;
                pbAvatar.BackgroundImage = CRUDZaposlenik.Properties.Resources.x_user;
            }
        }

        private void izbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                crud.izbrisiZaposlenika(zaposlenik);
                MessageBox.Show("Zaposlenik izbrisan");
                this.Dispose();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("PAŽNJA: Zaposlenik se nalazi na aktivnom radnom listu, ne može biti izbrisan");
            }
        }

        private void izbmjeni_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Enabled = true;
                }
            }
            btnSpremiKor.Enabled = true;
        }

        private void spremizmjene_Click(object sender, EventArgs e)
        {
            zaposlenik.ime = tbImeZaposlenika.Text;
            zaposlenik.prezime = tbPrezimeZaposlenika.Text;
            zaposlenik.korisnickoIme = tbKorIme.Text;
            zaposlenik.lozinka = tbLozinkaZaposlenika.Text;
            zaposlenik.adresa = tbAdresaZaposlenika.Text;
            zaposlenik.telefon = tbTelefonZaposlenika.Text;
            zaposlenik.uloga_id = (int)cbUlogaZaposlenika.SelectedValue;
            zaposlenik.spol = cbSpolZaposlenika.SelectedValue.ToString();
            crud.spremiZaposlenika(zaposlenik);
            MessageBox.Show("Uspješno izmjenjene informacije");
        }

        private void popuniInformacijeOKorisniku()
        {
            tbImeZaposlenika.Text = zaposlenik.ime;
            tbPrezimeZaposlenika.Text = zaposlenik.prezime;
            tbKorIme.Text = zaposlenik.korisnickoIme;
            tbLozinkaZaposlenika.Text = zaposlenik.lozinka;
            tbAdresaZaposlenika.Text = zaposlenik.adresa;
            tbTelefonZaposlenika.Text = zaposlenik.telefon;
            String[] spol = { "musko", "zensko", "neodredeno"};
            cbSpolZaposlenika.DataSource = spol;
            int index = Array.IndexOf(spol, zaposlenik.spol);
            cbSpolZaposlenika.SelectedItem = index; 
            this.ulogaTableAdapter.Fill(this.ineffableDataSetUloga.uloga);
        }

        private void frmZaposlenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSetUloga.uloga' table. You can move, or remove it, as needed.
           

        }

        private void frmZaposlenik_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "odabrani_zaposlenik.htm");
        }
    }
}
