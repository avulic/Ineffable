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
using System.Threading;

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
                    dobavljac_idComboBox.SelectedValue = artikl.dobavljac_id;
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

        private void cijenaTextBox_TextChanged_1(object sender, EventArgs e)
        {
            float n;
            var isFloat = float.TryParse(cijenaTextBox.Text, out n);
            if (isFloat)
            {
                cijenaTextBox.ForeColor = Color.Green;
                lblGreska1.Visible = false;
                btnSpremi.Enabled = true;
            }
            else
            {
                cijenaTextBox.ForeColor = Color.Red;
                lblGreska1.Visible = true;
                btnSpremi.Enabled = false;
            }
        }

        private void kolicina_na_skladistuTextBox_TextChanged_1(object sender, EventArgs e)
        {
            int n;
            var isNumber = int.TryParse(kolicina_na_skladistuTextBox.Text, out n);
            if (isNumber)
            {
                kolicina_na_skladistuTextBox.ForeColor = Color.Green;
                lblGreska2.Visible = false;
                btnSpremi.Enabled = true;
            }
            else
            {
                kolicina_na_skladistuTextBox.ForeColor = Color.Red;
                lblGreska2.Visible = true;
                btnSpremi.Enabled = false;
            }
        }

        private void btnSpremi_Click_1(object sender, EventArgs e)
        {
            if (nazivTextBox.Text == "" || opisTextBox.Text == "" || cijenaTextBox.Text == "" || kolicina_na_skladistuTextBox.Text == "" || dobavljac_idComboBox.Text == "")
            {
                MessageBox.Show("Niste ispunili sva polja!");
            }
            else
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
                        MessageBox.Show("Artikl uspješno kreiran!");
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
                        MessageBox.Show("Artikl uspješno ažuriran!");
                    }
                }
                Close();
            }
        }

        private void dobavljac_idComboBox_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void frmNoviArtikl_Load(object sender, EventArgs e)
        {
            this.dobavljacTableAdapter.Fill(this.ineffableDataSet.dobavljac);
        }

        private void frmNoviArtikl_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (kolicina_na_skladistuTextBox.Text == "")
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "kreiranje_artikla.htm");
            }
            else
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "azuriranje_artikla.htm");
            }
        }
    }
}
