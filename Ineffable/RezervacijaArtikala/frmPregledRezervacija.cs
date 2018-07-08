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

namespace RezervacijaArtikala
{
    public partial class frmPregledRezervacija : Form
    {
        int brojRedaka;
        public frmPregledRezervacija()
        {
            InitializeComponent();
        }

        private void frmPregledRezervacija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSet2.kupac' table. You can move, or remove it, as needed.
            //this.kupacTableAdapter1.Fill(this.ineffableDataSet2.kupac);
            // TODO: This line of code loads data into the 'ineffableDataSet2.kupac' table. You can move, or remove it, as needed.
            this.kupacTableAdapter1.Fill(this.ineffableDataSet2.kupac);
            // TODO: This line of code loads data into the 'ineffableDataSet1.kupac' table. You can move, or remove it, as needed.
            //this.kupacTableAdapter.Fill(this.ineffableDataSet1.kupac);
            // TODO: This line of code loads data into the 'ineffableDataSet1.artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.ineffableDataSet1.artikl);
            // TODO: This line of code loads data into the 'ineffableDataSet1.rezervacija' table. You can move, or remove it, as needed.
            this.rezervacijaTableAdapter.Fill(this.ineffableDataSet1.rezervacija);
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                var baza = from r in kontekst.rezervacija select r;
                brojRedaka = baza.Count();
            }

        }

        private void gumbOsvjezi_Click(object sender, EventArgs e)
        {
            this.kupacTableAdapter1.Fill(this.ineffableDataSet2.kupac);
            this.artiklTableAdapter.Fill(this.ineffableDataSet1.artikl);
            this.rezervacijaTableAdapter.Fill(this.ineffableDataSet1.rezervacija);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int broj;
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                var baza = from r in kontekst.rezervacija select r;
                broj = baza.Count();           
            }
            if (broj != brojRedaka)
            {
                MessageBox.Show("Promjena kod rezervacija");
                brojRedaka = broj;
            }
            
        }
    }
}
