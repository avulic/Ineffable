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

namespace Racuni
{
    public partial class frmRacuni : Form
    {
        int racunId;
        public frmRacuni()
        {
            InitializeComponent();
        }

        private void frmRacuni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSet.artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.ineffableDataSet.artikl);
            // TODO: This line of code loads data into the 'ineffableDataSet.stavka_racuna' table. You can move, or remove it, as needed.
            this.stavka_racunaTableAdapter.Fill(this.ineffableDataSet.stavka_racuna);
            // TODO: This line of code loads data into the 'ineffableDataSet.radni_nalog_servisa' table. You can move, or remove it, as needed.
            this.radni_nalog_servisaTableAdapter.Fill(this.ineffableDataSet.radni_nalog_servisa);
            // TODO: This line of code loads data into the 'ineffableDataSet.korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.ineffableDataSet.korisnik);
            // TODO: This line of code loads data into the 'ineffableDataSet.racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.ineffableDataSet.racun);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            racunId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.stavka_racunaTableAdapter.FillBy(this.ineffableDataSet.stavka_racuna, racunId);
        }
        
    }
}
