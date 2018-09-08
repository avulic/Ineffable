using BPModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Kod
{
    public partial class frmKreirajQRKod : Form
    {
        int zahtjevId;
        int kupacId;
        string aktivan = "aktivan";
        public frmKreirajQRKod(int idZahtjeva)
        {
            InitializeComponent();
            zahtjevId = idZahtjeva;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var kontekst = new IneffableEntities())
            {
                var noviRadniNalog = new radni_nalog_servisa()
                {
                    status = statusNalog.SelectedItem.ToString(),
                    vrijeme_kreiranja = DateTime.Now,
                    zaposlenik_id = int.Parse(serviseri.SelectedValue.ToString()),
                    oznaka = oznakaNalog.Text,
                    osoba_id = kupacId,
                    stanje = aktivan.ToString(),
                    uredjaj = uredjajNalog.Text,
                    opis = opisNalog.Text,
                    zahtjev_id = zahtjevId,
                };
                kontekst.radni_nalog_servisa.Add(noviRadniNalog);
                kontekst.SaveChanges();



                string oznaka2 = oznakaNalog.Text;

                radni_nalog_servisa noviRadniNalog2 = kontekst.radni_nalog_servisa.FirstOrDefault(r => r.oznaka == oznaka2);
                int servisId = noviRadniNalog2.servis_id;
                int zaposlenikId = noviRadniNalog2.zaposlenik_id;
                kontekst.SaveChanges();

                var noviLog = new servis_log()
                {
                    servis_id = servisId,
                    opis_promjene = opisNalog.Text,
                    cijena_promjene = 0,
                    zaposlenik_id = zaposlenikId,
                    status = statusNalog.SelectedItem.ToString(),
                    datum_promjene = DateTime.Now

                };
                kontekst.servis_log.Add(noviLog);
                kontekst.SaveChanges();

            }
            QRKod objekt = new QRKod();
            string oznaka = oznakaNalog.Text;
            objekt.SifrirajQRKod(oznaka, qrKod);
        }


        private void gumbSkeniraj_Click_1(object sender, EventArgs e)
        {
            
        }

        private void skeniraj_Click(object sender, EventArgs e)
        {
            
            QRKod objekt = new QRKod();
            string oznaka = objekt.DesifrirajQRKod(qrKod);
            frmRadniNalog f = new frmRadniNalog(oznaka);
            f.ShowDialog(this);
            
        }

        private void frmKreirajQRKod_Load(object sender, EventArgs e)
        {
            if (zahtjevId > 0)
            {
                using (IneffableEntities kontekst = new IneffableEntities())
                {
                    var zahtjev = kontekst.zahtjev_za_servis.FirstOrDefault(r => r.zahtjev_id == zahtjevId);
                    kupacId = zahtjev.kupac_id;
                    string nazivUredjaja = zahtjev.naziv_uredjaja;
                    uredjajNalog.Text = nazivUredjaja;
                    string opis = zahtjev.opis;
                    opisNalog.Text = opis;
                }
                this.kupacTableAdapter.FillBy(this.ineffableDataSet4.kupac, kupacId);
                this.korisnikTableAdapter.FillBy(this.ineffableDataSet.korisnik);
            }

        }
       
        private void oznakaNalog_TextChanged(object sender, EventArgs e)
        {
            using (var kontekst = new IneffableEntities())
            {
                string oznaka3 = oznakaNalog.Text;
                var oznaka = kontekst.radni_nalog_servisa.Any(r => r.oznaka == oznaka3);
                if (oznaka)
                {
                    labelaProvjera.Text = "Upisana oznaka već postoji";
                    gumbKreiraj.Enabled = false;
                }
                else
                {
                    labelaProvjera.Text = "";
                    gumbKreiraj.Enabled = true;
                }
            }
        }
    }
}
