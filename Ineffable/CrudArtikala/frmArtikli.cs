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
namespace CrudArtikala
{
    public partial class frmArtikli : Form
    {
        Form parent;
        public frmArtikli(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmArtikli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSet.dobavljac' table. You can move, or remove it, as needed.
            this.dobavljacTableAdapter.Fill(this.ineffableDataSet.dobavljac);
            // TODO: This line of code loads data into the 'ineffableDataSet.artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.ineffableDataSet.artikl);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            frmNoviArtikl forma = new frmNoviArtikl();
            forma.ShowDialog(this);
            this.dobavljacTableAdapter.Fill(this.ineffableDataSet.dobavljac);
            this.artiklTableAdapter.Fill(this.ineffableDataSet.artikl);
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count > 0)
            {
                int idArtikla = int.Parse(dgvArtikli.SelectedRows[0].Cells[0].Value.ToString());
                frmNoviArtikl forma = new frmNoviArtikl(idArtikla);
                forma.ShowDialog(this);
                this.dobavljacTableAdapter.Fill(this.ineffableDataSet.dobavljac);
                this.artiklTableAdapter.Fill(this.ineffableDataSet.artikl);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Jeste li sigurni da želite izbrisati ovaj artikl?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int idArtikla = int.Parse(dgvArtikli.SelectedRows[0].Cells[0].Value.ToString());
                    using (var db = new IneffableEntities())
                    {
                        artikl odabraniArtikl = db.artikl.FirstOrDefault(s => s.artikl_id == idArtikla);
                        db.artikl.Attach(odabraniArtikl);
                        db.artikl.Remove(odabraniArtikl);
                        db.SaveChanges();
                    }
                }
            }
            this.dobavljacTableAdapter.Fill(this.ineffableDataSet.dobavljac);
            this.artiklTableAdapter.Fill(this.ineffableDataSet.artikl);
        }
    }
}
