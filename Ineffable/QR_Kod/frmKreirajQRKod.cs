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
        public frmKreirajQRKod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var kontekst = new IneffableEntities())
            {
                //DateTime TrenutnoVrijeme;
                //TrenutnoVrijeme = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                var noviRadniNalog = new radni_nalog_servisa()
                {
                    status = statusNalog.SelectedItem.ToString(),
                    vrijeme_kreiranja = DateTime.Now,
                    zaposlenik_id = int.Parse(serviseri.SelectedValue.ToString()),
                    oznaka = oznakaNalog.Text,
                    osoba_id = int.Parse(kupacNalog.SelectedValue.ToString()),
                    uredjaj = uredjajNalog.Text,
                    opis = opisNalog.Text
                };
                kontekst.radni_nalog_servisa.Add(noviRadniNalog);
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
            f.ShowDialog();
            
        }

        private void frmKreirajQRKod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSet.kupac' table. You can move, or remove it, as needed.
            this.kupacTableAdapter.Fill(this.ineffableDataSet.kupac);
            // TODO: This line of code loads data into the 'ineffableDataSet.korisnik' table. You can move, or remove it, as needed.
            //this.korisnikTableAdapter.Fill(this.ineffableDataSet.korisnik);
            this.korisnikTableAdapter.FillBy(this.ineffableDataSet.korisnik);

        }
        
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.korisnikTableAdapter.FillBy(this.ineffableDataSet.korisnik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
