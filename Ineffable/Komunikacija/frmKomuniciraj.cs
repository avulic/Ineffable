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
using System.Threading;

namespace Komunikacija
{
    public partial class frmKomuniciraj : Form
    {
        private kupac odabranaOsoba;
        private string uloga;
        private int idKorisnika;
        private int kupacID;

        public frmKomuniciraj(string uloga, int idKorisnika)
        {
            InitializeComponent();
            this.uloga = uloga;
            this.idKorisnika = idKorisnika;
        }

        private void frmKomuniciraj_Load(object sender, EventArgs e)
        {
            this.radni_nalog_servisaTableAdapter2.Fill(this.ineffableDataSet5.radni_nalog_servisa);
            this.radni_nalog_servisaTableAdapter1.Fill(this.ineffableDataSet11.radni_nalog_servisa);

            if (uloga == "Zaposlenik")
                {
                    lblZaposlenik.Visible = true;
                    lblKorisnik.Visible = false;
                    btnKontaktirajKorisnika.Visible = true;
                    btnZatraziServis.Visible = false;
                    gbKupca.Visible = false;
                    btnPregledajZahtjeve.Visible = true;
                    btnMojiServisi.Visible = false;
                    btnZavrseniServisi.Visible = true;
            }
            if (uloga == "Kupac")
            {
                    lblZaposlenik.Visible = false;
                    lblKorisnik.Visible = true;
                    btnKontaktirajKorisnika.Visible = false;
                    btnZatraziServis.Visible = true;
                    gbKupca.Visible = true;
                    btnPregledajZahtjeve.Visible = false;
                    btnMojiServisi.Visible = true;
                    btnZavrseniServisi.Visible = false;

                    using (var db = new IneffableEntities())
                    {
                        kupac odabraniKupac = db.kupac.FirstOrDefault(s => s.korisnik_id == idKorisnika);
                        kupacID = odabraniKupac.kupac_id;

                        var count1 = db.poruke.Where(s => s.kupac_id == kupacID).Count();
                        if (count1 > 0)
                        {
                            dgvPoruke.Visible = true;
                            this.porukeTableAdapter1.FillByKupacID(this.ineffableDataSet5.poruke, kupacID);
                        }
                        else
                        {
                            dgvPoruke.Visible = false;
                            lblPorukeServisera.Text = "Nema novih poruka servisera.";
                            btnPrihvati.Visible = false;
                            btnPrekid.Visible = false;
                        }

                        var count = db.zahtjev_za_servis.Where(o => o.procitano == null && o.kupac_id == kupacID).Count();
                        if (count > 0)
                        {
                            if (MessageBox.Show("Imate nove obavijesti o zahtjevima za servis. Želite li ih pogledati?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                frmObavijesti formaObavijesti = new frmObavijesti(kupacID);
                                formaObavijesti.ShowDialog(this);
                            }
                        }
                    }
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
            if (dgvServisi.SelectedRows.Count > 0)
            {
                odabranaOsoba = (kupac)cbKupci.SelectedItem;
                int osobaID = odabranaOsoba.kupac_id;
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
            this.porukeTableAdapter1.FillByKupacID(this.ineffableDataSet5.poruke, kupacID);
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
            this.porukeTableAdapter1.FillByKupacID(this.ineffableDataSet5.poruke, kupacID);
        }

        private void btnZatraziServis_Click(object sender, EventArgs e)
        {
            frmNoviZahtjev forma = new frmNoviZahtjev(kupacID);
            forma.ShowDialog(this);
        }

        private void btnPregledajZahtjeve_Click(object sender, EventArgs e)
        {
            using (var db = new IneffableEntities())
            {
                var count = db.zahtjev_za_servis.Where(o => o.procitano == null && o.status == "blokiran").Count();
                if (count > 0)
                {
                    frmPregledZahjeva forma = new frmPregledZahjeva();
                    forma.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Nema novih zahtjeva za servisom.");
                }
            }
        }

        private void btnMojiServisi_Click(object sender, EventArgs e)
        {
            using (var db = new IneffableEntities())
            {
                kupac odabraniKupac = db.kupac.FirstOrDefault(s => s.korisnik_id == idKorisnika);
                kupacID = odabraniKupac.kupac_id;
                var count = db.radni_nalog_servisa.Where(o => o.osoba_id == kupacID).Count();
                if (count > 0)
                {
                    frmMojiServisi forma = new frmMojiServisi(kupacID);
                    forma.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Nemate niti jedan uređaj na servisu.");
                }
            }
        }

        private void btnZavrseniServisi_Click(object sender, EventArgs e)
        {
            frmZavrseniServisi forma = new frmZavrseniServisi(idKorisnika);
            forma.ShowDialog(this);
        }
    }
}
