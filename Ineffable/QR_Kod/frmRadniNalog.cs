using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Kod
{
    public partial class frmRadniNalog : Form
    {
        string oznakaNaloga;
        public frmRadniNalog(string oznaka)
        {
            InitializeComponent();
            oznakaNaloga = oznaka;
        }

        private void frmRadniNalog_Load(object sender, EventArgs e)
        {
            
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                radni_nalog_servisa noviRadniNalog = kontekst.radni_nalog_servisa.FirstOrDefault(r => r.oznaka == oznakaNaloga);
                oznakaNalog.Text = oznakaNaloga;
                opisNalog.Text = noviRadniNalog.opis;
                status.SelectedText = noviRadniNalog.status;
            }
            

        }

        private void gumbSpremi_Click(object sender, EventArgs e)
        {
            using (IneffableEntities kontekst = new IneffableEntities())
            {
                radni_nalog_servisa noviRadniNalog = kontekst.radni_nalog_servisa.FirstOrDefault(r => r.oznaka == oznakaNaloga);
                noviRadniNalog.oznaka = oznakaNaloga;
                noviRadniNalog.opis = opisNalog.Text;
                noviRadniNalog.status = status.SelectedItem.ToString();
                kontekst.SaveChanges();
            }
        }
    }
}
