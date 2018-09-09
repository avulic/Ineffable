using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using BPModel;

namespace Komunikacija
{
    public partial class frmEmailPoruka : Form
    {
        private string emailPrimatelja;
        private int idServisa;

        public frmEmailPoruka(string emailPrimatelja, int idServisa)
        {
            InitializeComponent();
            this.emailPrimatelja = emailPrimatelja;
            this.idServisa = idServisa;
        }

        private void frmEmailPoruka_Load(object sender, EventArgs e)
        {
            tbPosiljatelj.Text = "ineffable5011@gmail.com";
            tbPosiljatelj.Enabled = false;
            tbPrimatelj.Text = emailPrimatelja;
            tbPrimatelj.Enabled = false;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (tbPredmet.Text == "" || tbTekst.Text == "")
            {
                MessageBox.Show("Niste ispunili sva polja.");
            }
            else
            {
                var adresaPosiljatelja = new MailAddress("ineffable5011@gmail.com", "Ineffable");
                var adresaPrimatelja = new MailAddress(emailPrimatelja, "Primatelj");
                const string lozinkaPosiljatelja = "Kjkszpj000";
                string predmet = tbPredmet.Text.ToString();
                string tekst = tbTekst.Text.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(adresaPosiljatelja.Address, lozinkaPosiljatelja)
                };

                using (var message = new MailMessage(adresaPosiljatelja, adresaPrimatelja)
                {
                    Subject = predmet,
                    Body = tekst
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("Poruka poslana.");

                using (var db = new IneffableEntities())
                {
                    radni_nalog_servisa odabraniZahtjev = db.radni_nalog_servisa.FirstOrDefault(s => s.servis_id == idServisa);
                    db.radni_nalog_servisa.Attach(odabraniZahtjev);
                    odabraniZahtjev.status = "Isporuceno";
                    odabraniZahtjev.stanje = "neaktivan";
                    db.SaveChanges();
                }
                Close();
            }
        }

        private void frmEmailPoruka_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "slanje_emaila.htm");
        }
    }
}
