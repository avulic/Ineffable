using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komunikacija
{
    public partial class frmMojiServisi : Form
    {
        private int kupacID;

        public frmMojiServisi(int kupacID)
        {
            InitializeComponent();
            this.kupacID = kupacID;
        }

        private void frmMojiServisi_Load(object sender, EventArgs e)
        {
            this.korisnikTableAdapter.Fill(this.ineffableDataSet41.korisnik);
            this.radni_nalog_servisaTableAdapter.FillByKupacID(this.ineffableDataSet4.radni_nalog_servisa, kupacID);
        }
    }
}
