using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrijavaRegistracija;
using CrudArtikala;
using QR_Kod;
using Komunikacija;
using RezervacijaArtikala;
using Racuni;
using BPModel;

namespace Ineffable
{
    public partial class frmMain : Form
    {

        int brojRedaka;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmPrijava prijavaForma = new frmPrijava(this);
            prikaziFormu(prijavaForma);

            using (IneffableEntities kontekst = new IneffableEntities())
            {
                var baza = from r in kontekst.rezervacija select r;
                brojRedaka = baza.Count();
            }
        }
        protected override void OnMdiChildActivate(EventArgs e)
        {
            Form[] mdichld = this.MdiChildren;
            base.OnMdiChildActivate(e);
            this.BeginInvoke(new Action(() => {
                if (mdichld.Length == 0)
                {
                    msIzbornik.Visible = true;
                }
                else
                {
                    foreach (Form item in mdichld)
                    {
                        if (item.Name == "frmPrijava")
                        {
                            item.Closed += delegate
                            {
                                msIzbornik.Visible = true;
                            };
                        }
                    }
                }
            }));
        }
        void prikaziFormu(Form forma)
        {
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            this.Size = forma.Size;
        }
        int pomak;
        int pomakX;
        int pomakY;
        private void msIzbornik_MouseDown(object sender, MouseEventArgs e)
        {
            pomak = 1;
            pomakX = e.X;
            pomakY = e.Y;
        }

        private void msIzbornik_MouseUp(object sender, MouseEventArgs e)
        {
            pomak = 0;
        }

        private void msIzbornik_MouseMove(object sender, MouseEventArgs e)
        {
            if (pomak == 1)
            {
                this.SetDesktopLocation(MousePosition.X - pomakX, MousePosition.Y - pomakY);
            }
        }


        private void pExit_Paint(object sender, PaintEventArgs e)
        {
            Graphics exitPanel = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            exitPanel.DrawLine(pen, 7, 7, 19, 19);
            exitPanel.DrawLine(pen, 7, 19, 19, 7);
            exitPanel.DrawLine(pen, 8, 7, 20, 19);
            exitPanel.DrawLine(pen, 8, 19, 20, 7);
        }

        private void panMinMaxMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics minMaxPanel = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            SolidBrush brush = new SolidBrush(Color.FromArgb(230, 179, 70));
            minMaxPanel.DrawRectangle(pen, 7, 7, 12, 12);
            minMaxPanel.FillRectangle(brush, 7, 7, 12, 12);
            minMaxPanel.DrawRectangle(pen, 9, 7, 7, 10);
            minMaxPanel.DrawRectangle(pen, 12, 12, 10, 10);
        }

        private void panHide_Paint(object sender, PaintEventArgs e)
        {
            Graphics hidPanel = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            SolidBrush brush = new SolidBrush(Color.FromArgb(230, 179, 70));
            hidPanel.DrawRectangle(pen, 7, 16, 12, 4);
            hidPanel.FillRectangle(brush, 7, 16, 12, 4);
        }

        private void paExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mm = 0;

       

        private void panMinMaxMain_Click(object sender, EventArgs e)
        {
            if (mm == 0)
            {
                WindowState = FormWindowState.Maximized;
                mm = 1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                mm = 0;
            }
        }

        private void panHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void msIzbornikArtikli_Click(object sender, EventArgs e)
        {
            Korisnik kori = Autentifikator.dohvatiPrijavljenogKorisnika();
            if (kori.uloga == "Zaposlenik")
            {
                frmArtikli artikli = new frmArtikli(this);
                prikaziFormu(artikli);
            }
        }

        private void msIzbornikServisi_Click(object sender, EventArgs e)
        {
            Korisnik koram = Autentifikator.dohvatiPrijavljenogKorisnika();
            if (koram.uloga == "Zaposlenik")
            {
                frmKreirajQRKod f = new frmKreirajQRKod(0);
                prikaziFormu(f);
            }
        }

        private void msIzbornikChat_Click(object sender, EventArgs e)
        {
            Korisnik kori = Autentifikator.dohvatiPrijavljenogKorisnika();
            
            frmKomuniciraj komunikacija = new frmKomuniciraj(kori.uloga, kori.id);
            prikaziFormu(komunikacija);
        }

        private void msIzbornikRezervacija_Click(object sender, EventArgs e)
        {
            Korisnik koram = Autentifikator.dohvatiPrijavljenogKorisnika();
            if (koram.uloga == "Zaposlenik")
            {
                int broj;
                using (IneffableEntities kontekst = new IneffableEntities())
                {
                    var baza = from r in kontekst.rezervacija select r;
                    broj = baza.Count();
                }
                if (broj != brojRedaka)
                {
                    MessageBox.Show("Promjena kod rezervacija");
                    brojRedaka = broj;
                }
                frmPregledRezervacija f = new frmPregledRezervacija();
                prikaziFormu(f);
            }
            else if (koram.uloga == "Kupac")
            {
                int korisnik_id = koram.id;
                frmRezervacija f = new frmRezervacija(korisnik_id);
                prikaziFormu(f);
            }
        }

        private void kreirajRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnik koram = Autentifikator.dohvatiPrijavljenogKorisnika();
            if (koram.uloga == "Zaposlenik")
            {
                frmNoviRacun f = new frmNoviRacun();
                prikaziFormu(f);
            }
        }

        private void pregledajRačuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnik koram = Autentifikator.dohvatiPrijavljenogKorisnika();
            if (koram.uloga == "Zaposlenik")
            {
                frmRacuni f = new frmRacuni();
                prikaziFormu(f);
            }
        }

    }
}
