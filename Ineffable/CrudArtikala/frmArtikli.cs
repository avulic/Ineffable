﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudArtikala
{
    public partial class frmArtikli : Form
    {
        public frmArtikli()
        {
            InitializeComponent();
        }

        private void frmArtikli_Load(object sender, EventArgs e)
        {
            this.dobavljacTableAdapter.Fill(this.ineffableBPDataSet.dobavljac);
            this.artiklTableAdapter.Fill(this.ineffableBPDataSet.artikl);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            frmNoviArtikl forma = new frmNoviArtikl();
            forma.ShowDialog();
            this.dobavljacTableAdapter.Fill(this.ineffableBPDataSet.dobavljac);
            this.artiklTableAdapter.Fill(this.ineffableBPDataSet.artikl);
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedRows.Count > 0)
            {
                int idArtikla = int.Parse(dgvArtikli.SelectedRows[0].Cells[0].Value.ToString());
                frmNoviArtikl forma = new frmNoviArtikl(idArtikla);
                forma.ShowDialog();
                this.dobavljacTableAdapter.Fill(this.ineffableBPDataSet.dobavljac);
                this.artiklTableAdapter.Fill(this.ineffableBPDataSet.artikl);
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
            this.dobavljacTableAdapter.Fill(this.ineffableBPDataSet.dobavljac);
            this.artiklTableAdapter.Fill(this.ineffableBPDataSet.artikl);
        }
    }
}