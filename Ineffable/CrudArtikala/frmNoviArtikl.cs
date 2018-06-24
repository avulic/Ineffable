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
    public partial class frmNoviArtikl : Form
    {
        private int odabraniArtikl;

        public frmNoviArtikl()
        {
            InitializeComponent();
        }

        public frmNoviArtikl(int idArtikla)
        {
            InitializeComponent();
            odabraniArtikl = idArtikla;
            IspuniPolja();
        }

        private void IspuniPolja()
        {
            if (odabraniArtikl != null) {
                using (var db = new IneffableEntities())
                {
                    artikl artikl = db.artikl.FirstOrDefault(s => s.artikl_id == odabraniArtikl);

                    nazivTextBox.Text = artikl.naziv.ToString();
                    opisTextBox.Text = artikl.opis;
                    cijenaTextBox.Text = artikl.cijena.ToString();
                    kolicina_na_skladistuTextBox.Text = artikl.kolicina_na_skladistu.ToString();
                    dobavljac_idComboBox.Text = artikl.dobavljac.naziv;
                }
            }

        }

        private void artiklBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artiklBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ineffableDataSet);
        }

        private void frmNoviArtikl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSet.dobavljac' table. You can move, or remove it, as needed.
            this.dobavljacTableAdapter.Fill(this.ineffableDataSet.dobavljac);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new IneffableEntities())
            {
                artikl postojeciArtikl = db.artikl.FirstOrDefault(s => s.artikl_id == odabraniArtikl);
                if (postojeciArtikl == null)
                {
                    artikl noviArtikl = new artikl
                    {
                        naziv = nazivTextBox.Text,
                        opis = opisTextBox.Text,
                        cijena = float.Parse(cijenaTextBox.Text),
                        kolicina_na_skladistu = int.Parse(kolicina_na_skladistuTextBox.Text),
                        dobavljac_id = (int)dobavljac_idComboBox.SelectedValue
                    };
                    db.artikl.Add(noviArtikl);
                    db.SaveChanges();
                }
                else
                {
                    db.artikl.Attach(postojeciArtikl);
                    postojeciArtikl.naziv = nazivTextBox.Text;
                    postojeciArtikl.opis = opisTextBox.Text;
                    postojeciArtikl.cijena = float.Parse(cijenaTextBox.Text);
                    postojeciArtikl.kolicina_na_skladistu = int.Parse(kolicina_na_skladistuTextBox.Text);
                    postojeciArtikl.dobavljac_id = (int)dobavljac_idComboBox.SelectedValue;
                    db.SaveChanges();
                }
            }
           Close();
        }
    }
}
