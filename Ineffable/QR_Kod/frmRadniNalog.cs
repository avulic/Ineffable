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
namespace QR_Kod
{
    public partial class frmRadniNalog : Form
    {
        int servisId;
        string oznakaNaloga;
        public frmRadniNalog(string oznaka)
        {
            InitializeComponent();
            oznakaNaloga = oznaka;
        }

        private void frmRadniNalog_Load(object sender, EventArgs e)
        {
            
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                
                radni_nalog_servisa noviRadniNalog = kontekst.radni_nalog_servisa.FirstOrDefault(r => r.oznaka == oznakaNaloga);
                string stanje = noviRadniNalog.stanje;
                if (stanje == "neaktivan")
                {
                    oznakaNalog.Enabled = false;
                    opisNalog.Enabled = false;
                    status.Enabled = false;
                    uredjajNalog.Enabled = false;
                    serviserNalog.Enabled = false;
                    kupacNalog.Enabled = false;
                    cijenaNalog.Enabled = false;
                    gumbSpremi.Enabled = false;
                    gumbLog.Enabled = false;
                }
                else
                {
                    oznakaNalog.Text = oznakaNaloga;
                    opisNalog.Text = noviRadniNalog.opis;
                    status.SelectedText = noviRadniNalog.status;
                    uredjajNalog.Text = noviRadniNalog.uredjaj;

                    servisId = noviRadniNalog.servis_id;

                    int zaposlenik = noviRadniNalog.zaposlenik_id;
                    int osoba = noviRadniNalog.osoba_id;
                    kupac noviKupac = kontekst.kupac.FirstOrDefault(r => r.kupac_id == osoba);
                    kupacNalog.Text = noviKupac.ime;
                    korisnik noviKorisnik = kontekst.korisnik.FirstOrDefault(r => r.korisnik_id == zaposlenik);
                    serviserNalog.Text = noviKorisnik.ime;
                }
            }
            
        }

        private void gumbSpremi_Click(object sender, EventArgs e)
        {
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                radni_nalog_servisa noviRadniNalog = kontekst.radni_nalog_servisa.FirstOrDefault(r => r.oznaka == oznakaNaloga);
                noviRadniNalog.oznaka = oznakaNaloga;
                noviRadniNalog.opis = opisNalog.Text;
                noviRadniNalog.status = status.SelectedItem.ToString();
                int zaposlenik = noviRadniNalog.zaposlenik_id;

                double cijena;
                if (cijenaNalog.Text == null || cijenaNalog.Text == "")
                {
                    cijena = 0;
                }
                else
                {
                    cijena = double.Parse(cijenaNalog.Text.ToString());
                }

                var noviLog = new servis_log()
                {
                    servis_id = servisId,
                    opis_promjene = opisNalog.Text,
                    cijena_promjene = cijena,
                    status = status.SelectedItem.ToString(),
                    datum_promjene = DateTime.Now,
                    zaposlenik_id = zaposlenik

                };
                kontekst.servis_log.Add(noviLog);
                kontekst.SaveChanges();               
            }
        }

        private void gumbLog_Click(object sender, EventArgs e)
        {
            frmPrikaziLog f = new frmPrikaziLog(servisId);
            f.ShowDialog(this);
        }
    }
}
