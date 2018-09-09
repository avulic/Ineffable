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

namespace Komunikacija
{
    public partial class frmPoruka : Form
    {
        private kupac odabranaOsoba;
        private int idServisa;

        public frmPoruka()
        {
            InitializeComponent();
        }

        public frmPoruka(kupac odabranaOsoba, int idServisa)
        {
            InitializeComponent();
            this.odabranaOsoba = odabranaOsoba;
            this.idServisa = idServisa;
        }

        private void frmPoruka_Load(object sender, EventArgs e)
        {

        }

        private void btnPosaljiPoruku_Click(object sender, EventArgs e)
        {
            string message = txtPoruka.Text.ToString();
            int kupacID = odabranaOsoba.kupac_id;
            int servisID = idServisa;

            if (message == "")
            {
                MessageBox.Show("Niste unijeli poruku!");
            }
            else
            {
                using (var db = new IneffableEntities())
                {
                    poruke novaPoruka = new poruke
                    {
                        tekst = message,
                        kupac_id = kupacID,
                        servis_id = servisID
                    };
                    db.poruke.Add(novaPoruka);

                    radni_nalog_servisa odabraniNalog = db.radni_nalog_servisa.FirstOrDefault(r => r.servis_id == servisID);
                    odabraniNalog.stanje = "neaktivan";
                    db.SaveChanges();
                    MessageBox.Show("Poruka uspješno poslana!");
                }
                Close();
            }
        }

        private void frmPoruka_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "slanje_obavijesti.htm");
        }
    }
}
