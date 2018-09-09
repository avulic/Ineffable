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
    public partial class frmNoviRacun : Form
    {
        int trenutni;
        int odabrani;
        int zaposlenik;
        int servisTrenutni;
        double? ukupnoServis;
        public frmNoviRacun()
        {
            InitializeComponent();
        }

        private void frmNoviRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSet.radni_nalog_servisa' table. You can move, or remove it, as needed.
            this.radni_nalog_servisaTableAdapter.Fill(this.ineffableDataSet.radni_nalog_servisa);
            // TODO: This line of code loads data into the 'ineffableDataSet.korisnik' table. You can move, or remove it, as needed.
            //this.korisnikTableAdapter.Fill(this.ineffableDataSet.korisnik);
            // TODO: This line of code loads data into the 'ineffableDataSet.artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.ineffableDataSet.artikl);
            this.korisnikTableAdapter.FillBy(this.ineffableDataSet.korisnik);
            trenutni = int.Parse(comboBox1.SelectedValue.ToString());
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                artikl noviArtikl = kontekst.artikl.FirstOrDefault(r => r.artikl_id == trenutni);
                double cijena = double.Parse(noviArtikl.cijena.ToString());
                cijenaRacun.Text = cijena.ToString();
                
            }
            zaposlenik = int.Parse(comboBox2.SelectedValue.ToString());

            servisTrenutni = int.Parse(comboBox3.SelectedValue.ToString());
            
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                //servis_log noviServis = kontekst.servis_log.FirstOrDefault(r => r.servis_id == servisTrenutni);
                /*var result = kontekst.servis_log
                  .Select(r => new { r.cijena_promjene })
                  .ToList();*/
                //ukupnoServis = 0;
                var upit = from servis_log in kontekst.servis_log
                            where servis_log.servis_id == servisTrenutni
                            select servis_log;
                ukupnoServis = 0;
                foreach (var element in upit)
                {
                    ukupnoServis += element.cijena_promjene;
                }
                
                servisRacun.Text = ukupnoServis.ToString();
                int brojRacuna = 0;
                var upit2 = from racun in kontekst.racun
                           select racun.racun_id;
                foreach (var element2 in upit2)
                {
                    brojRacuna++;
                }
                brojRacuna++;
                ukupnoRacuna.Text = brojRacuna.ToString();

            }
        }

        private void gumbRacun_Click(object sender, EventArgs e)
        {
            using (IneffableEntities kontekst = new IneffableEntities())
            {

                DateTime datum1;
                datum1 = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                var datum = DateTime.Now;
                var vrijeme = datum.TimeOfDay;

                double ukupno;
                if (ukupnoRacun.Text == null || ukupnoRacun.Text == "")
                {
                    ukupno = 0;
                }
                else
                {
                    ukupno = double.Parse(ukupnoRacun.Text.ToString());
                }

                var noviRacun = new racun()
                {
                    datum = datum1,
                    vrijeme = vrijeme,
                    iznos = 0,
                    zaposlenik_id = zaposlenik,
                    servis_id = null

                };
                kontekst.racun.Add(noviRacun);
                kontekst.SaveChanges();
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabrani = int.Parse(comboBox1.SelectedValue.ToString());
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                artikl noviArtikl = kontekst.artikl.FirstOrDefault(r => r.artikl_id == odabrani);
                double cijena = double.Parse(noviArtikl.cijena.ToString());
                cijenaRacun.Text = cijena.ToString();
            }
        }

        private void gumbIzracunaj_Click(object sender, EventArgs e)
        {
            int kolicina;

            if (kolicinaRacun.Text == "")
            {
                kolicina = 0;
            }
            else
            {
                kolicina = int.Parse(kolicinaRacun.Text);
            }
            double cijena = double.Parse(cijenaRacun.Text.ToString());
            ukupnoRacun.Text = (kolicina * cijena).ToString();
            int racun_id = int.Parse(ukupnoRacuna.Text.ToString());
            int artikl_id = int.Parse(comboBox1.SelectedValue.ToString());
            int? kolicinaSkladiste;
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                artikl noviArtikl = kontekst.artikl.FirstOrDefault(r => r.artikl_id == trenutni);
                kolicinaSkladiste = noviArtikl.kolicina_na_skladistu;

                if (kolicina > kolicinaSkladiste)
                {
                    MessageBox.Show("Nema toliko na skladištu");
                    kolicinaRacun.Clear();
                    ukupnoRacun.Clear();
                }
                else
                {
                    if (kolicina > 0)
                    {
                        var novaStavka = new stavka_racuna()
                        {
                            racun_id = racun_id,
                            artikl_id = artikl_id,
                            kolicina = kolicina
                        };
                        kontekst.stavka_racuna.Add(novaStavka);
                        kontekst.SaveChanges();
                    }
                }
                
                int? servisId;
                if (comboBox3.SelectedValue == "" || comboBox3.SelectedValue == null)
                {
                    servisId = null;
                }
                else
                {
                    servisId = int.Parse(comboBox3.SelectedValue.ToString());
                }

                int brojRacuna = int.Parse(ukupnoRacuna.Text.ToString());
                racun noviRacun = kontekst.racun.FirstOrDefault(r => r.racun_id == brojRacuna);
                
                noviRacun.servis_id = servisId;
                kontekst.SaveChanges();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            zaposlenik = int.Parse(comboBox2.SelectedValue.ToString());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int servisTrenutni2 = int.Parse(comboBox3.SelectedValue.ToString());
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                servisTrenutni = int.Parse(comboBox3.SelectedValue.ToString());
                var upit = from servis_log in kontekst.servis_log
                           where servis_log.servis_id == servisTrenutni2
                           select servis_log;
                ukupnoServis = 0;
                foreach (var element in upit)
                {
                    ukupnoServis += element.cijena_promjene;
                }
                servisRacun.Text = ukupnoServis.ToString();
            }
            
        }

        private void gumbSpremi_Click(object sender, EventArgs e)
        {
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                int racun_id = int.Parse(ukupnoRacuna.Text.ToString());
                var upit = from artikl in kontekst.artikl
                           join stavka_racuna in kontekst.stavka_racuna on racun_id equals stavka_racuna.racun_id
                           where stavka_racuna.artikl_id == artikl.artikl_id
                           select new {ArtiklCijena = artikl.cijena, ArtiklKolicina = stavka_racuna.kolicina };
                double? ukupno = 0;
                foreach (var element in upit)
                {
                    double? privremeno = element.ArtiklKolicina * element.ArtiklCijena;
                    ukupno += privremeno;
                }
                
                
                ukupnoServis = 0;
                racun noviRacun1 = kontekst.racun.FirstOrDefault(r => r.racun_id == racun_id);
               
                if (noviRacun1.servis_id == null)
                {
                    ukupnoServis = 0;
                }
                else
                {
                    var upit3 = from servis_log in kontekst.servis_log
                                where servis_log.servis_id == noviRacun1.servis_id
                    select servis_log;
                    foreach (var element in upit3)
                    {
                        ukupnoServis += element.cijena_promjene;
                    }                    
                }

                racun noviRacun = kontekst.racun.FirstOrDefault(r => r.racun_id == racun_id);
                noviRacun.iznos = ukupno + ukupnoServis;
                kontekst.SaveChanges();
                


                int brojRacuna = 0;
                var upit2 = from racun in kontekst.racun
                            select racun.racun_id;
                foreach (var element2 in upit2)
                {
                    brojRacuna++;
                }
                brojRacuna++;
                ukupnoRacuna.Text = brojRacuna.ToString();
            }
        }
    }
}
