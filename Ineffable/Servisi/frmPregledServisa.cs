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

namespace Servisi
{
    public partial class frmPregledServisa : Form
    {
        Form parent;
        Korisnik korisnik;
        Servis servis = null;
        List<Servis> servisi = new List<Servis>();
        public frmPregledServisa(Form parent, Korisnik korisnik)
        {
            this.parent = parent;
            this.korisnik = korisnik;
            InitializeComponent();
        }

        private void frmPregledServisa_Load(object sender, EventArgs e)
        {
            Servisi.IneffableDataSet.radni_nalog_servisaDataTable data = ineffableDataSet.radni_nalog_servisa;
            this.radni_nalog_servisaTableAdapter.FillByOsobaID(data, korisnik.kupac_id);
            foreach (var item in data)
            {
                servis = new Servis(korisnik, item.uredjaj);
                servisi.Add(servis);
            }
        }

        private void lbUredjaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUredjaji.SelectedIndex != -1)
            {
                cpBar.PostaviStatus(servisi[lbUredjaji.SelectedIndex]);
            }
        }

        private void frmPregledServisa_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "uredjaji_na_servisu.htm");
        }
    }
}
