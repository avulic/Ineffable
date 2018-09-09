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
        List<Korisnik> korisnici = new List<Korisnik>();
        List<Zaposlenik> panelZaposlenika = new List<Zaposlenik>();
        CRUD crud = new CRUD();
        Form parent;
        Zaposlenik zaposlenikSlika;

        public frmCRUDZaposlenik(Form parent, Korisnik kori)
        {
            InitializeComponent();
            this.parent = parent;
        }
        public frmCRUDZaposlenik()
        {
            InitializeComponent();
        }
        private void frmCRUDZaposlenik_Load(object sender, EventArgs e)
        {
            prikaziZaposlenike();
            posloziSadrzajPanela();
        }
        public void prikaziZaposlenike()
        {
            korisnici = crud.dohvatiZaposlenike();
            panelZaposlenika.Clear();
            if (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.Controls.Clear();
            }
            foreach (Korisnik korisnik in korisnici)
            {
                zaposlenikSlika = new Zaposlenik(korisnik);
                zaposlenikSlika.Size = new Size(140,140);
                panelZaposlenika.Add(zaposlenikSlika);
                tableLayoutPanel1.Controls.Add(zaposlenikSlika);
            }
            parent.ResizeEnd += new EventHandler(tableLayoutPanel1_Resize);
        }
        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            posloziSadrzajPanela();
        }
        public void posloziSadrzajPanela()
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
            prikaziZaposlenike();
            posloziSadrzajPanela();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
         /*   zaposlenici = crud.dohvatiZaposlenike();
            var source = new AutoCompleteStringCollection();
            foreach (var item in zaposlenici)
            {
                source.Add(item.ToString());
            }

            tbPretraga.AutoCompleteCustomSource = source;
            tbPretraga.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbPretraga.AutoCompleteSource = AutoCompleteSource.CustomSource;
            */
        }

        private void frmCRUDZaposlenik_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "pregled_zaposlenika.htm");
        }
        
    }
}
