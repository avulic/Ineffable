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
using QR_Kod;

namespace Komunikacija
{
    public partial class frmPregledZahjeva : Form
    {
        int idZahtjeva;
        private int kupacID;
        private string uredaj;

        public frmPregledZahjeva()
        {
            InitializeComponent();
        }

        private void frmPregledZahjeva_Load(object sender, EventArgs e)
        {
            this.kupacTableAdapter.Fill(this.ineffableDataSet2.kupac);
            this.zahtjev_za_servisTableAdapter.FillByStatus3(this.ineffableDataSet2.zahtjev_za_servis);
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (dgvZahtjevi.SelectedRows.Count > 0)
            {
                idZahtjeva = int.Parse(dgvZahtjevi.SelectedRows[0].Cells[0].Value.ToString());
                using (var db = new IneffableEntities())
                {
                    zahtjev_za_servis odabraniZahtjev = db.zahtjev_za_servis.FirstOrDefault(s => s.zahtjev_id == idZahtjeva);
                    kupacID = odabraniZahtjev.kupac_id;
                    uredaj = odabraniZahtjev.naziv_uredjaja;
                    odabraniZahtjev.obavijest = "Zahtjev za servisom uređaja " + uredaj + " prihvaćen.";
                    odabraniZahtjev.obrazlozenje = "-";
                    odabraniZahtjev.status = "odobren";
                    db.SaveChanges();
                }

                this.kupacTableAdapter.Fill(this.ineffableDataSet2.kupac);
                this.zahtjev_za_servisTableAdapter.FillByStatus3(this.ineffableDataSet2.zahtjev_za_servis);

                frmKreirajQRKod f = new frmKreirajQRKod(idZahtjeva);
                f.FormBorderStyle = FormBorderStyle.Fixed3D;
                f.ShowDialog();
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
                using (var bp = new IneffableEntities())
                {
                    zahtjev_za_servis odabraniZahtjev = bp.zahtjev_za_servis.FirstOrDefault(s => s.zahtjev_id == idZahtjeva);
                    kupacID = odabraniZahtjev.kupac_id;
                    uredaj = odabraniZahtjev.naziv_uredjaja;
                    odabraniZahtjev.obavijest = "Zahtjev za servisom uređaja " + uredaj + " nije prihvaćen.";
                    odabraniZahtjev.obrazlozenje = txtObrazlozenje.Text.ToString();
                    bp.SaveChanges();
                }
                lblPoruka.Visible = false;
                txtObrazlozenje.Visible = false;
                btnPotvrdi.Visible = false;
            }
            this.kupacTableAdapter.Fill(this.ineffableDataSet2.kupac);
            this.zahtjev_za_servisTableAdapter.FillByStatus3(this.ineffableDataSet2.zahtjev_za_servis);
        }

        private void btnOdbij_Click(object sender, EventArgs e)
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
    }
}
