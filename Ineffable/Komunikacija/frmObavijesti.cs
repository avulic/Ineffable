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
    public partial class frmObavijesti : Form
    {
        private int kupacID;

        public frmObavijesti(int kupacID)
        {
            InitializeComponent();
            this.kupacID = kupacID;
        }

        private void frmObavijesti_Load(object sender, EventArgs e)
        {
            this.zahtjev_za_servisTableAdapter.FillByKupacID(this.ineffableDataSet3.zahtjev_za_servis, kupacID);

        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvObavijesti.Rows)
            {
                int idZahtjeva = int.Parse(item.Cells[0].Value.ToString());
                using (var db = new IneffableEntities())
                {
                    zahtjev_za_servis odabraniZahtjev = db.zahtjev_za_servis.FirstOrDefault(s => s.zahtjev_id == idZahtjeva);
                    db.zahtjev_za_servis.Attach(odabraniZahtjev);
                    odabraniZahtjev.procitano = "da";
                    db.SaveChanges();
                }
            }
            Close();
        }
    }
}
