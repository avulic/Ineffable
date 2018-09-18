using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servisi
{
    public partial class ProgresBar : UserControl
    {
        Servis servis;
        List<Component> slike = new List<Component>();
        public ProgresBar()
        {
            InitializeComponent();
        }
        public void PostaviStatus(Servis servis)
        {
            this.servis = servis;
            tbOpisFaze.Text = "";
            lbUkupna.Text = servis.log.ukupnaCijena.ToString();
            switch (servis.status)
            {
                case "Zaprimljeno":
                    prikazPodataka("Zaprimljeno");
                    postaviDovrseneStatuse(6);
                    progressBar.Value = (int)(progressBar.Maximum * 0);
                    break;
                case "Pregledano":
                    prikazPodataka("Pregledano");
                    postaviDovrseneStatuse(5);
                    progressBar.Value = (int)(progressBar.Maximum * 0.16);
                    break;
                case "Kvar utvrden":
                    prikazPodataka("Kvar utvrden");
                    postaviDovrseneStatuse(4);
                    progressBar.Value = (int)(progressBar.Maximum * 0.32);
                    lbKvar.Text = "Kvar utvrđen";
                    break;
                case "Kvar nije utvrden":
                    prikazPodataka("Kvar nije utvrden");
                    postaviDovrseneStatuse(4);
                    progressBar.Value = (int)(progressBar.Maximum * 0.32);
                    lbKvar.Text = "Kvar nije utvrđen";
                    break;
                case "Popravak u tijeku":
                    prikazPodataka("Popravak u tijeku");
                    postaviDovrseneStatuse(3);
                    progressBar.Value = (int)(progressBar.Maximum * 0.48);
                    break;
                case "Na cekanju":
                    prikazPodataka("Na cekanju");
                    postaviDovrseneStatuse(2);
                    progressBar.Value = (int)(progressBar.Maximum * 0.64);
                    break;
                case "Popravljeno":
                    prikazPodataka("Popravljeno");
                    postaviDovrseneStatuse(1);
                    progressBar.Value = (int)(progressBar.Maximum * 0.80);
                    break;
                case "Isporuceno":
                    prikazPodataka("Isporuceno");
                    postaviDovrseneStatuse(0);
                    progressBar.Value = (int)(progressBar.Maximum * 1);
                    break;
            }
        }
        private void postaviDovrseneStatuse(int status)
        {
            for (int i = status; i <= slike.Count-1; i++)
            {
                PictureBox slika = slike[i] as PictureBox;
                slika.Image = Servisi.Properties.Resources.check;
                slika.Enabled = true;
            }
            for (int i = status-1; i >= 0; i--)
            {
                PictureBox slika = slike[i] as PictureBox;
                slika.Image = Servisi.Properties.Resources.x;
            }
        }
        private void ProgresBar_Load(object sender, EventArgs e)
        {
            foreach (Component control in this.Controls)
            {
                if (control is PictureBox)
                {
                    slike.Add(control);
                }
            }
        }
        private void pbZaprimljeno_Click(object sender, EventArgs e)
        {
            prikazPodataka("Zaprimljeno");
        }
        private void pbPregledano_Click(object sender, EventArgs e)
        {
            prikazPodataka("Pregledano");
        }
        private void pbKvar_Click(object sender, EventArgs e)
        {
            if (servis.log.opis.ContainsKey("Kvar utvrden"))
            {
                prikazPodataka("Kvar utvrden");
            }
            else if (servis.log.opis.ContainsKey("Kvar nije utvrden"))
            {
                prikazPodataka("Kvar nije utvrden");
            }
        }
        private void pbPopravak_Click(object sender, EventArgs e)
        {
            prikazPodataka("Popravak u tijek");
        }
        private void pbCekanje_Click(object sender, EventArgs e)
        {
            prikazPodataka("Na cekanju");
        }
        private void pbPopravljeno_Click(object sender, EventArgs e)
        {
            prikazPodataka("Popravljeno");
        }
        private void pbIsporuceno_Click(object sender, EventArgs e)
        {
            prikazPodataka("Isporuceno");
        }
        private void prikazPodataka(String faza)
        {
            lbCijenaFaze.Text = servis.log.cijenaPromjene[faza].ToString();
            tbOpisFaze.Text = servis.log.opis[faza];
            lbFaza.Text = faza;
        }   
    }
}
