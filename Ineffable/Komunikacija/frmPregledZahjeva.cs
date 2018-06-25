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
    public partial class frmPregledZahjeva : Form
    {
        private int kupacID;
        private string uredaj;

        public frmPregledZahjeva()
        {
            InitializeComponent();
        }

        private void frmPregledZahjeva_Load(object sender, EventArgs e)
        {
            this.kupacTableAdapter.Fill(this.ineffableDataSet2.kupac);
            this.zahtjev_za_servisTableAdapter.Fill(this.ineffableDataSet2.zahtjev_za_servis);
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (dgvZahtjevi.SelectedRows.Count > 0)
            {
                int idZahtjeva = int.Parse(dgvZahtjevi.SelectedRows[0].Cells[0].Value.ToString());
                using (var db = new IneffableEntities())
                {
                    zahtjev_za_servis odabraniZahtjev = db.zahtjev_za_servis.FirstOrDefault(s => s.zahtjev_id == idZahtjeva);
                    kupacID = odabraniZahtjev.kupac_id;
                    uredaj = odabraniZahtjev.naziv_uredjaja;

                    kupac odabraniKupac = db.kupac.FirstOrDefault(s => s.kupac_id == kupacID);
                    db.kupac.Attach(odabraniKupac);
                    odabraniKupac.obavijest = "Zahtjev za servisom uređaja " + uredaj + " prihvaćen.";
                    odabraniKupac.obrazlozenje = "-";
                    db.SaveChanges();

                    db.zahtjev_za_servis.Attach(odabraniZahtjev);
                    db.zahtjev_za_servis.Remove(odabraniZahtjev);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Odaberite zahtjev.");
            }
            this.kupacTableAdapter.Fill(this.ineffableDataSet2.kupac);
            this.zahtjev_za_servisTableAdapter.Fill(this.ineffableDataSet2.zahtjev_za_servis);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvZahtjevi.SelectedRows.Count > 0)
            {
                lblPoruka.Visible = true;
                txtObrazlozenje.Visible = true;
                btnPotvrdi.Visible = true;
            }
            else
            {
                MessageBox.Show("Odaberite zahtjev.");
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            int idZahtjeva = int.Parse(dgvZahtjevi.SelectedRows[0].Cells[0].Value.ToString());
            if (txtObrazlozenje.Text == "")
            {
                MessageBox.Show("Unesite obrazloženje.");
            }
            else
            {
                using (var db2 = new IneffableEntities())
                {
                    zahtjev_za_servis odabraniZahtjev2 = db2.zahtjev_za_servis.FirstOrDefault(s => s.zahtjev_id == idZahtjeva);
                    kupacID = odabraniZahtjev2.kupac_id;
                    uredaj = odabraniZahtjev2.naziv_uredjaja;

                    kupac odabraniKupac2 = db2.kupac.FirstOrDefault(s => s.kupac_id == kupacID);
                    db2.kupac.Attach(odabraniKupac2);

                    odabraniKupac2.obavijest = "Zahtjev za servisom uređaja " + uredaj + " nije prihvaćen.";
                    odabraniKupac2.obrazlozenje = txtObrazlozenje.Text.ToString();
                    db2.SaveChanges();

                    db2.zahtjev_za_servis.Attach(odabraniZahtjev2);
                    db2.zahtjev_za_servis.Remove(odabraniZahtjev2);
                    db2.SaveChanges();
                }
            }
            this.kupacTableAdapter.Fill(this.ineffableDataSet2.kupac);
            this.zahtjev_za_servisTableAdapter.Fill(this.ineffableDataSet2.zahtjev_za_servis);
        }

        private void dgvZahtjevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
