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
                    lbCijenaFaze.Text = servis.log.cijenaPromjene["Zaprimljeno"].ToString();
                    lbFaza.Text = "Zaprimljeno";
                    postaviDovrseneStatuse(6);
                    progressBar.Value = (int)(progressBar.Maximum * 0);
                    break;
                case "Pregledano":
                    lbCijenaFaze.Text = servis.log.cijenaPromjene["Pregledano"].ToString();
                    lbFaza.Text = "Pregledano";
                    postaviDovrseneStatuse(5);
                    progressBar.Value = (int)(progressBar.Maximum * 0.16);
                    break;
                case "Kvar utvrden":
                    lbCijenaFaze.Text = servis.log.cijenaPromjene["Kvar utvrden"].ToString();
                    lbFaza.Text = "Kvar utvrdjen";
                    postaviDovrseneStatuse(4);
                    progressBar.Value = (int)(progressBar.Maximum * 0.32);
                    lbKvar.Text = "Kvar utvrđen";
                    break;
                case "Kvar nije utvrden":
                    lbCijenaFaze.Text = servis.log.cijenaPromjene["Kvar nije utvrden"].ToString();
                    lbFaza.Text = "Kvar nije utvrđen";
                    postaviDovrseneStatuse(4);
                    progressBar.Value = (int)(progressBar.Maximum * 0.32);
                    lbKvar.Text = "Kvar nije utvrđen";
                    break;
                case "Popravak u tijeku":
                    lbCijenaFaze.Text = servis.log.cijenaPromjene["Popravak u tijeku"].ToString();
                    lbFaza.Text = "Popravak u tijeku";
                    postaviDovrseneStatuse(3);
                    progressBar.Value = (int)(progressBar.Maximum * 0.48);
                    break;
                case "Na cekanju":
                    lbCijenaFaze.Text = servis.log.cijenaPromjene["Na cekanju"].ToString();
                    lbFaza.Text = "Na cekanju";
                    postaviDovrseneStatuse(2);
                    progressBar.Value = (int)(progressBar.Maximum * 0.64);
                    break;
                case "Popravljeno":
                    lbCijenaFaze.Text = servis.log.cijenaPromjene["Popravljeno"].ToString();
                    lbFaza.Text = "Popravljeno";
                    postaviDovrseneStatuse(1);
                    progressBar.Value = (int)(progressBar.Maximum * 0.80);
                    break;
                case "Isporuceno":
                    lbCijenaFaze.Text = servis.log.cijenaPromjene["Isporuceno"].ToString();
                    lbFaza.Text = "Isporuceno";
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
            lbCijenaFaze.Text = servis.log.cijenaPromjene["Zaprimljeno"].ToString();
            tbOpisFaze.Text = servis.log.opis["Zaprimljeno"];
            lbFaza.Text = "Zaprimljeno";
        }

        private void pbPregledano_Click(object sender, EventArgs e)
        {
            lbCijenaFaze.Text = servis.log.cijenaPromjene["Pregledano"].ToString();
            tbOpisFaze.Text = servis.log.opis["Pregledano"];
            lbFaza.Text = "Pregledano";
        }

        private void pbKvar_Click(object sender, EventArgs e)
        {
            if (servis.log.opis.ContainsKey("Kvar utvrden"))
            {
                lbCijenaFaze.Text = servis.log.cijenaPromjene["Kvar utvrden"].ToString();
                tbOpisFaze.Text = servis.log.opis["Kvar utvrden"];
                lbFaza.Text = "Kvar utvrden";
            }
            else if (servis.log.opis.ContainsKey("Kvar nije utvrden"))
            {
                lbCijenaFaze.Text = servis.log.cijenaPromjene["Kvar nije utvrden"].ToString();
                tbOpisFaze.Text = servis.log.opis["Kvar nije utvrden"];
                lbFaza.Text = "Kvar nije utvrden";
            }
        }

        private void pbPopravak_Click(object sender, EventArgs e)
        {
            lbCijenaFaze.Text = servis.log.cijenaPromjene["Popravak u tijeku"].ToString();
            tbOpisFaze.Text = servis.log.opis["Popravak u tijeku"];
            lbFaza.Text = "Popravak u tijeku";

        }

        private void pbCekanje_Click(object sender, EventArgs e)
        {
            lbCijenaFaze.Text = servis.log.cijenaPromjene["Na cekanju"].ToString();
            tbOpisFaze.Text = servis.log.opis["Na cekanju"];
            lbFaza.Text = "Na cekanju";

        }

        private void pbPopravljeno_Click(object sender, EventArgs e)
        {
            lbCijenaFaze.Text = servis.log.cijenaPromjene["Popravljeno"].ToString();
            tbOpisFaze.Text = servis.log.opis["Popravljeno"];
            lbFaza.Text = "Popravljeno";

        }

        private void pbIsporuceno_Click(object sender, EventArgs e)
        {
            lbCijenaFaze.Text = servis.log.cijenaPromjene["Isporuceno"].ToString();
            tbOpisFaze.Text = servis.log.opis["Isporuceno"];
            lbFaza.Text = "Isporuceno";

        }
    }
}
