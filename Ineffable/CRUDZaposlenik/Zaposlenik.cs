using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrijavaRegistracija;
using CRUDZaposlenik;

namespace CRUDZaposlenik
{
    public partial class Zaposlenik : UserControl 
    {
        string ime;
        string prezime;
        string spol;
        Korisnik korisnik;
        public Zaposlenik(Korisnik zaposlenik)
        {
            InitializeComponent();
            this.korisnik = zaposlenik;
            this.ime = zaposlenik.ime;
            this.prezime = korisnik.prezime;
            this.spol = korisnik.spol;
            postaviImePrezime();
            postaviAvatara();
        }
        private void postaviImePrezime()
        {
            lbImePrezime.BackColor = System.Drawing.Color.Transparent;
            lbImePrezime.Text = ime[0] + "." + prezime;
        }
        private void postaviAvatara()
        {
            if (spol == "musko")
            {
                pbAvatar.BackgroundImage = null;
                pbAvatar.BackgroundImage = CRUDZaposlenik.Properties.Resources.if_male3_403019;
                korisnik.avatar = CRUDZaposlenik.Properties.Resources.if_male3_403019;
                //zaposlenik.avatar = CRUDZaposlenik.Properties.Resources.if_male3_403019.GetHbitmap();
            }
            else if (spol == "zensko")
            {
                pbAvatar.BackgroundImage = null;
                pbAvatar.BackgroundImage = CRUDZaposlenik.Properties.Resources.if_female1_403023;
                korisnik.avatar = CRUDZaposlenik.Properties.Resources.if_male3_403019;
                //zaposlenik.avatar = CRUDZaposlenik.Properties.Resources.if_female1_403023.GetHicon();
            }
        }
        private void Zaposlenik_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                frmZaposlenik zaposlenikPrikaz = new frmZaposlenik(korisnik);
                zaposlenikPrikaz.ShowDialog(this);
                if (zaposlenikPrikaz.IsDisposed == true)
                {
                    frmCRUDZaposlenik crudZaposlenika = (frmCRUDZaposlenik)Application.OpenForms["frmCRUDZaposlenik"];
                    crudZaposlenika.prikaziZaposlenike();
                }
            }
        }
    }
}
