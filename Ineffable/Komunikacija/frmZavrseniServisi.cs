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
    public partial class frmZavrseniServisi : Form
    {
        private int idKorisnika;

        public frmZavrseniServisi(int idKorisnika)
        {
            this.idKorisnika = idKorisnika;
            InitializeComponent();
        }

        private void frmZavrseniServisi_Load(object sender, EventArgs e)
        {
            this.kupacTableAdapter.Fill(this.ineffableDataSet5.kupac);
            this.radni_nalog_servisaTableAdapter.FillByStatus(this.ineffableDataSet5.radni_nalog_servisa);
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            if (dgvZavrseniServisi.SelectedRows.Count > 0)
            {
                int idKupca = int.Parse(dgvZavrseniServisi.SelectedRows[0].Cells[7].Value.ToString());
                int idServisa = int.Parse(dgvZavrseniServisi.SelectedRows[0].Cells[0].Value.ToString());

                using (var db = new IneffableEntities())
                {
                    kupac odabraniKlijent = db.kupac.FirstOrDefault(s => s.kupac_id == idKupca);
                    int korisnikID = (int)odabraniKlijent.korisnik_id;

                    korisnik primatelj = db.korisnik.FirstOrDefault(o => o.korisnik_id == korisnikID);
                    string emailPrimatelja = primatelj.email;

                    frmEmailPoruka forma = new frmEmailPoruka(emailPrimatelja, idServisa);
                    forma.ShowDialog(this);

                    this.kupacTableAdapter.Fill(this.ineffableDataSet5.kupac);
                    this.radni_nalog_servisaTableAdapter.FillByStatus(this.ineffableDataSet5.radni_nalog_servisa);
                }
            }
        }

        private void frmZavrseniServisi_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "zavrseni_servisi.htm");
        }
    }
}
