using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using PrijavaRegistracija;
using System.Threading;

namespace CRUDZaposlenik
{
    public partial class frmCRUDZaposlenik : Form
    {
        List<Korisnik> zaposlenici = new List<Korisnik>();
        List<PictureBox> panelZaposlenika = new List<PictureBox>();
        PictureBox zaposlenikSlika;
        CRUD crud = new CRUD();
        Form parent;
        Korisnik korisnik;

        public frmCRUDZaposlenik(Form parent, Korisnik kori)
        {
            InitializeComponent();
            this.parent = parent;
            korisnik = kori;
        }

        private void frmCRUDZaposlenik_Load(object sender, EventArgs e)
        {
            zaposlenici = crud.dohvatiZaposlenike();
            prikaziZaposlenike();
            posloziSadrzajPanela();
        }

        private void prikaziZaposlenike()
        {
            foreach (var zaposlenik in zaposlenici)
            {
                tableLayoutPanel1.Controls.Add(kreirajIkonu(zaposlenik));

                panelZaposlenika.Add(zaposlenikSlika);
            }
            parent.ResizeEnd += new EventHandler(tableLayoutPanel1_Resize);
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            posloziSadrzajPanela();
        }

        private void zaposlenikSlika_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index = panelZaposlenika.IndexOf(sender as PictureBox);
                frmZaposlenik zaposlenikPrikaz = new frmZaposlenik(zaposlenici[index]);
                zaposlenikPrikaz.ShowDialog(this);
            }
        }

        private void posloziSadrzajPanela()
        {
            bool jos = true;
            while (jos == true)
            {
             
                if (parent.ClientSize.Width > zaposlenikSlika.ClientSize.Width+128 * tableLayoutPanel1.ColumnCount)
                {
                    tableLayoutPanel1.ColumnCount += 1;
                    jos = true;
                }
                else
                {
                    tableLayoutPanel1.ColumnCount -= 1;
                    jos = false;
                }

                if (parent.ClientSize.Height > zaposlenikSlika.ClientSize.Height * tableLayoutPanel1.RowCount)
                {
                    tableLayoutPanel1.RowCount += 1;
                    jos = true;
                }
                else
                {
                    tableLayoutPanel1.RowCount -= 1;
                    jos = false;
                }
                foreach (var item in panelZaposlenika)
                {
                    tableLayoutPanel1.Controls.Add(item);
                }
            }
        }

        private PaintEventHandler dodajTekstIspdSlike() {
            return new PaintEventHandler((sender, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                int index = panelZaposlenika.IndexOf(sender as PictureBox);

                string text = zaposlenici[index].ime[0] + "." + " " + zaposlenici[index].prezime;

                SizeF textSize = e.Graphics.MeasureString(text, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (zaposlenikSlika.Width) - (textSize.Width);
                locationToDraw.Y = (zaposlenikSlika.Height) - (textSize.Height);

                e.Graphics.DrawString(text, Font, Brushes.White, locationToDraw);

            });
        }
       
        private PictureBox kreirajIkonu(Korisnik zaposlenik)
        {
            zaposlenikSlika = new PictureBox();
            zaposlenikSlika.Size = new System.Drawing.Size(128, 128);
            if (zaposlenik.spol == "m")
            {
                zaposlenikSlika.BackgroundImage = CRUDZaposlenik.Properties.Resources.if_male3_403019;
                zaposlenik.avatar = CRUDZaposlenik.Properties.Resources.if_male3_403019.GetHbitmap();
            }
            else if (zaposlenik.spol == "z")
            {
                zaposlenikSlika.BackgroundImage = CRUDZaposlenik.Properties.Resources.if_female1_403023;
                zaposlenik.avatar = CRUDZaposlenik.Properties.Resources.if_female1_403023.GetHicon();
            }
            else
            {
                zaposlenikSlika.BackgroundImage = CRUDZaposlenik.Properties.Resources.x_user;
                zaposlenik.avatar = CRUDZaposlenik.Properties.Resources.x_user.GetHbitmap();
            }
            

            zaposlenikSlika.MouseClick += zaposlenikSlika_MouseClick;
            zaposlenikSlika.Paint += dodajTekstIspdSlike();

            return zaposlenikSlika;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmRegistracija registracija = new frmRegistracija(parent);
            registracija.Text = "Novi korisnik";
            registracija.FormBorderStyle = FormBorderStyle.Fixed3D;
            registracija.Controls.Find("lbPrijava", true)[0].Visible = false;
            registracija.Controls.Find("btnReg", true)[0].Text = "Kreiraj";
            registracija.Controls.Find("lbReg", true)[0].Text = "Novi korisnik";
            registracija.Controls.Find("cbUloge", true)[0].Enabled = true;
            registracija.ShowDialog();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            zaposlenici = crud.dohvatiZaposlenike();
            var source = new AutoCompleteStringCollection();
            foreach (var item in zaposlenici)
            {
                source.Add(item.ToString());
            }

            tbPretraga.AutoCompleteCustomSource = source;
            tbPretraga.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbPretraga.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
