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
            azurirajPodatke();
        }

        private void btnAturiraj_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                int kupac_id = int.Parse(dgvKupci.SelectedRows[0].Cells[5].Value.ToString());
                frmKupac kupac = new frmKupac(kupac_id);
                kupac.ShowDialog();
                if (kupac.IsDisposed == true)
                {
                    azurirajPodatke();
                }
            }
        }
        private void btnIzbrisiKupca_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                int kupac_id = int.Parse(dgvKupci.SelectedRows[0].Cells[5].Value.ToString());
                //crud.izbrisiKupca(kupac_id);
            }
        }
        private void azurirajPodatke()
        {
            this.korisnikTableAdapter.Fill(this.ineffableDataSetKupci.korisnik);
            // TODO: This line of code loads data into the 'ineffableDataSetKupci.kupac' table. You can move, or remove it, as needed.
            this.kupacTableAdapter.Fill(this.ineffableDataSetKupci.kupac);
        }

        private void btnKreirajKupca_Click(object sender, EventArgs e)
        {
            frmRegistracija registracija = new frmRegistracija(null);
            registracija.Text = "Novi kupac";
            registracija.FormBorderStyle = FormBorderStyle.Fixed3D;
            registracija.Controls.Find("lbPrijava", true)[0].Visible = false;
            registracija.Controls.Find("btnReg", true)[0].Text = "Kreiraj";
            registracija.Controls.Find("lbReg", true)[0].Text = "Novi kupac";
            registracija.Controls.Find("cbUloge", true)[0].Enabled = false;
            registracija.ShowDialog();
            azurirajPodatke();
        }

        private void btnIzbrisiKupca_Click_1(object sender, EventArgs e)
        {
            int kupac_id = int.Parse(dgvKupci.SelectedRows[0].Cells[5].Value.ToString());
            try
            {
                crud.izbrisiKupca(kupac_id);
                MessageBox.Show("Kupac izbrisan");
                azurirajPodatke();
            }
            catch (Exception)
            {
                MessageBox.Show("PAŽNJA: Kupac se nalazi na aktivnom radnom listu, ne može biti izbrisan");
            }
        }
    }
}
