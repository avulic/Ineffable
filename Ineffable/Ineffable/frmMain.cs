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
using CRUDZaposlenik;
using Komunikacija;
using CRUDKupaca;
using BPModel;
using Racuni;
using RezervacijaArtikala;
using Servisi;

namespace Ineffable
{
    public partial class frmMain : Form
    {

        Korisnik kori;
        public frmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmPrijava prijavaForma = new frmPrijava(this);
            prijavaForma.FormClosed += new FormClosedEventHandler(provjeraDopustenjaKorisnika);
            prikaziFormu(prijavaForma);
            
        }

        void prikaziFormu(Form forma)
        {
            FormCollection forme = Application.OpenForms;
            for (int i = 1; i < forme.Count; i++)
            {
                if (!(forme[i].Name == "frmMain"))
                {
                    forme[i].Close();
                }
            }
            forma.TopLevel = false;
            forma.Parent = this;
            this.Size = new Size(700, 800);
            
            forma.Dock = DockStyle.Fill;
            forma.StartPosition = FormStartPosition.CenterScreen;
            forma.Show();
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

        private bool mouseDown;
        private Point lastLocation;

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void msIzbornikArtikli_Click(object sender, EventArgs e)
        {
            frmArtikli artikli = new frmArtikli(this);
            prikaziFormu(artikli);
        }

        private void msIzbornikServisi_Click(object sender, EventArgs e)
        {
            frmKreirajQRKod kod = new frmKreirajQRKod(0);
            prikaziFormu(kod);
        }

        private void msIzbornikZaposlenici_Click(object sender, EventArgs e)
        {
            frmCRUDZaposlenik zaposlenici = new frmCRUDZaposlenik(this, kori);
            prikaziFormu(zaposlenici);
        }

        private void msIzbornikChat_Click(object sender, EventArgs e)
        {
            frmKomuniciraj komunikacija = new frmKomuniciraj(kori.ulogaNaziv, kori.id);
            prikaziFormu(komunikacija);
        }

        private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKupci kupci = new frmKupci();
            prikaziFormu(kupci);
        }

        private void provjeraDopustenjaKorisnika(object sender, FormClosedEventArgs e)
        {
            kori = Autentifikator.dohvatiPrijavljenogKorisnika();
            if (kori.ulogaNaziv == "Kupac")
            {
                msIzbornikArtikli.Visible = false;
                msIzbornikServisi.Visible = false;
                msIzbornikRacun.Visible = false;
                msIzbornikZaposlenici.Visible = false;
                msIzbornikKupci.Visible = false;
            }
            else
            {
                msIzbornikUredjaji.Visible = false;
            }
        }
    
        private void kreirajRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoviRacun f = new frmNoviRacun();
            prikaziFormu(f);
        }
        
        private void pregledajRačuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRacuni f = new frmRacuni();
            prikaziFormu(f);
        }
        int brojRedaka;
        private void msIzbornikRezervacija_Click(object sender, EventArgs e)
        {
           
            if (kori.ulogaNaziv == "Zaposlenik" || kori.ulogaNaziv == "Gazda")
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
            else if (kori.ulogaNaziv == "Kupac")
            {
                int korisnik_id = kori.id;
                frmRezervacija f = new frmRezervacija(korisnik_id);
                prikaziFormu(f);
            }
        }

        private void msIzbornikUredjaji_Click(object sender, EventArgs e)
        {
            frmPregledServisa servisi = new frmPregledServisa(this, kori);
            prikaziFormu(servisi);
        }
    }
}
