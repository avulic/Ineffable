using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPModel;

namespace Komunikacija
{
    public partial class frmNoviZahtjev : Form
    {
        private int kupacID;

        public frmNoviZahtjev(int kupacID)
        {
            InitializeComponent();
            this.kupacID = kupacID;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            string vrsta = txtVrsta.Text;
            string proizvodjac = txtProizvodac.Text;
            string opis = txtOpis.Text;

            if (naziv == "" || vrsta == "" || proizvodjac == "" || opis == "")
            {
                MessageBox.Show("Niste popunili sva polja.");
            }
            else
            {
                using (var db = new IneffableEntities())
                {
                    zahtjev_za_servis noviZahtjev = new zahtjev_za_servis
                    {
                        opis = opis,
                        naziv_uredjaja = naziv,
                        proizvodjac = proizvodjac,
                        tip_uredjaja = vrsta,
                        kupac_id = kupacID,
                        status = "blokiran",
                        datum_podnosenja = DateTime.Now
                    };
                    db.zahtjev_za_servis.Add(noviZahtjev);
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void frmNoviZahtjev_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNaziv;
        }
    }
}
