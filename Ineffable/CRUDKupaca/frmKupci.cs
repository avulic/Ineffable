using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDKupaca
{
    public partial class frmKupci : Form
    {
        CRUD crud = new CRUD();
        public frmKupci()
        {
            InitializeComponent();
        }

        private void frmKupci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSetKupci.korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.ineffableDataSetKupci.korisnik);
            // TODO: This line of code loads data into the 'ineffableDataSetKupci.kupac' table. You can move, or remove it, as needed.
            this.kupacTableAdapter.Fill(this.ineffableDataSetKupci.kupac);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                int kupac_id = int.Parse(dgvKupci.SelectedRows[0].Cells[5].Value.ToString());
                frmKupac kupac = new frmKupac(kupac_id);
                kupac.ShowDialog();
            }
        }

        private void btnIzbrisiKupca_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                int kupac_id = int.Parse(dgvKupci.SelectedRows[0].Cells[5].Value.ToString());
                crud.izbrisiKupca(kupac_id);
            }
        }

        private void frmKupci_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "pregled_kupaca.htm");
        }
    }
}
