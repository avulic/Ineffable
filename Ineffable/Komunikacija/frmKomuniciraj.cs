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
    public partial class frmKomuniciraj : Form
    {
        private kupac odabranaOsoba;

        public frmKomuniciraj()
        {
            InitializeComponent();
        }

        private void frmKomuniciraj_Load(object sender, EventArgs e)
        {
            this.radni_nalog_servisaTableAdapter1.Fill(this.ineffableDataSet11.radni_nalog_servisa);
            this.porukeTableAdapter.Fill(this.ineffableDataSet11.poruke);
            int ulogaKorisnika = 3;
            int kupacID = 1;

                if (ulogaKorisnika == 2)
                {
                    lblZaposlenik.Visible = true;
                    lblKorisnik.Visible = false;
                    btnKontaktirajKorisnika.Visible = true;
                    btnZatraziServis.Visible = false;
                }
                if (ulogaKorisnika == 3)
                {
                    lblZaposlenik.Visible = false;
                    lblKorisnik.Visible = true;
                    btnKontaktirajKorisnika.Visible = false;
                    btnZatraziServis.Visible = true;
                    gbKupca.Visible = true;
            }
        }

        private void btnKontaktirajKorisnika_Click(object sender, EventArgs e)
        {
            gbPitanje.Visible = true;
            DohvatiKupce();
        }

        private void DohvatiKupce()
        {
            BindingList<kupac> listaKupaca = null;
            using (var db = new IneffableEntities())
            {
                listaKupaca = new BindingList<kupac>(db.kupac.ToList());
            }

            foreach (kupac kupac in listaKupaca)
            {
                cbKupci.Items.Add(kupac);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            gbPitanje.Visible = false;
        }

        private void cbKupci_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabranaOsoba = (kupac)cbKupci.SelectedItem;
            int osobaID = odabranaOsoba.kupac_id;
            this.radni_nalog_servisaTableAdapter.FillByIDOsobe(this.ineffableDataSet.radni_nalog_servisa, osobaID);
        }

        private void btnPosaljiPoruku_Click(object sender, EventArgs e)
        {
            odabranaOsoba = (kupac)cbKupci.SelectedItem;
            int osobaID = odabranaOsoba.kupac_id;
            if (dgvServisi.SelectedRows.Count > 0)
            {
                int idServisa = int.Parse(dgvServisi.SelectedRows[0].Cells[0].Value.ToString());
                if (idServisa > 0)
                {
                    frmPoruka forma = new frmPoruka(odabranaOsoba, idServisa);
                    forma.ShowDialog(this);
                    this.radni_nalog_servisaTableAdapter.FillByIDOsobe(this.ineffableDataSet.radni_nalog_servisa, osobaID);
                }
            }
            else
            {
                MessageBox.Show("Odaberite servis");
            }
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (dgvPoruke.SelectedRows.Count > 0)
            {
                int idPoruke = int.Parse(dgvPoruke.SelectedRows[0].Cells[0].Value.ToString());
                int idServisa = int.Parse(dgvPoruke.SelectedRows[0].Cells[3].Value.ToString());
                using (var db = new IneffableEntities())
                {
                    poruke odabranaPoruka = db.poruke.FirstOrDefault(s => s.id == idPoruke);
                    db.poruke.Attach(odabranaPoruka);
                    db.poruke.Remove(odabranaPoruka);
                    db.SaveChanges();

                    radni_nalog_servisa odabraniNalog = db.radni_nalog_servisa.FirstOrDefault(r => r.servis_id == idServisa);
                    odabraniNalog.stanje = "aktivan";
                    db.SaveChanges();
                }
            }
            this.radni_nalog_servisaTableAdapter1.Fill(this.ineffableDataSet11.radni_nalog_servisa);
            this.porukeTableAdapter.Fill(this.ineffableDataSet11.poruke);
        }

        private void btnPrekid_Click(object sender, EventArgs e)
        {
            if (dgvPoruke.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Jeste li sigurni da želite prekinuti servis ovog uređaja?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idPoruke = int.Parse(dgvPoruke.SelectedRows[0].Cells[0].Value.ToString());
                    using (var db = new IneffableEntities())
                    {
                        poruke odabranaPoruka = db.poruke.FirstOrDefault(s => s.id == idPoruke);
                        db.poruke.Attach(odabranaPoruka);
                        db.poruke.Remove(odabranaPoruka);
                        db.SaveChanges();
                    }
                }
            }
            this.radni_nalog_servisaTableAdapter1.Fill(this.ineffableDataSet11.radni_nalog_servisa);
            this.porukeTableAdapter.Fill(this.ineffableDataSet11.poruke);
        }
    }
}
