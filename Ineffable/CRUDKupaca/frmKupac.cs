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
namespace CRUDKupaca
{
    public partial class frmKupac : Form
    {
        int kupac_id;
        CRUD crud = new CRUD();
        Korisnik kupac;
        public frmKupac(int kupac_id)
        {
            InitializeComponent();
            this.kupac_id = kupac_id;
            kupac =  crud.dohvatiKupca(kupac_id);
        }
        public frmKupac()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btnSpremiKor_Click(object sender, EventArgs e)
        {
            kupac.ime = tbImeZaposlenika.Text;
            kupac.prezime = tbPrezimeZaposlenika.Text;
            kupac.korisnickoIme = tbKorIme.Text;
            kupac.lozinka = tbLozinkaZaposlenika.Text;
            kupac.adresa = tbAdresaZaposlenika.Text;
            kupac.telefon = tbTelefonZaposlenika.Text;
            kupac.spol = cbSpolZaposlenika.SelectedValue.ToString();

            crud.azurirajKupca(kupac);
            MessageBox.Show("Uspješno izmjenjene informacije");
        }

        private void frmKupac_Load(object sender, EventArgs e)
        {
            ucitajPodatkeOKupcu();
            
        }

        private void ucitajPodatkeOKupcu()
        {
            tbImeZaposlenika.Text = kupac.ime;
            tbPrezimeZaposlenika.Text = kupac.prezime;
            tbKorIme.Text = kupac.korisnickoIme;
            tbLozinkaZaposlenika.Text = kupac.lozinka;
            tbAdresaZaposlenika.Text = kupac.adresa;
            tbTelefonZaposlenika.Text = kupac.telefon;

            String[] spol = { "musko", "zensko", "neodredeno" };
            cbSpolZaposlenika.DataSource = spol;
            int index = Array.IndexOf(spol, kupac.spol);
            cbSpolZaposlenika.SelectedItem = index;
        }
    }
}
