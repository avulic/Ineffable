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
    public partial class frmRezervacija : Form
    {
        int korisnikId;
        int artikId;
        int kupacId;
        public frmRezervacija(int id)
        {
            InitializeComponent();
            korisnikId = id;
        }

        private void frmRezervacija_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'ineffableDataSet.dobavljac' table. You can move, or remove it, as needed.
            this.dobavljacTableAdapter.Fill(this.ineffableDataSet.dobavljac);
            // TODO: This line of code loads data into the 'ineffableDataSet.artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.ineffableDataSet.artikl);

        }

        private void gumbRezerviraj_Click(object sender, EventArgs e)
        {
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                kupac postojeciKupac = kontekst.kupac.FirstOrDefault(r => r.korisnik_id == korisnikId);
                kupacId = postojeciKupac.kupac_id;
                artikl postojeciArtikl = kontekst.artikl.FirstOrDefault(r => r.artikl_id == artikId);                
                int brojArtikala;
                bool provjera = int.TryParse(kolicina.Text, out brojArtikala);
                if (!provjera || kolicina.Text == "" || (Convert.ToInt32(kolicina.Text) <= 0))
                {
                    MessageBox.Show("Unesena je kriva vrijednost");
                }
                else
                {
                    int? dostupnoArtikala = postojeciArtikl.kolicina_na_skladistu;
                    if (brojArtikala <= dostupnoArtikala)
                    {
                        postojeciArtikl.kolicina_na_skladistu -= brojArtikala;
                        rezervacija novaRezervacija = new rezervacija
                        {
                            vrijeme_rezervacije = DateTime.Now,
                            kolicina = brojArtikala,
                            artikl_id = artikId,
                            kupac_id = kupacId
                        };
                        kontekst.rezervacija.Add(novaRezervacija);
                        kontekst.SaveChanges();
                        artiklBindingSource.DataSource = kontekst.artikl.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Nema toliko artikala na skladištu");
                    }
                }            
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            artikId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void frmRezervacija_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "rezervacije.htm");
        }
    }
}
