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
    public partial class frmPrikaziLog : Form
    {
        private int servis_id;
        public frmPrikaziLog(int servisId)
        {
            InitializeComponent();
            servis_id = servisId;
        }

        private void frmPrikaziLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ineffableDataSet3.korisnik' table. You can move, or remove it, as needed.           
            // TODO: This line of code loads data into the 'ineffableDataSet3.servis_log' table. You can move, or remove it, as needed.
            this.servis_logTableAdapter.FillBy(this.ineffableDataSet3.servis_log, servis_id);

        }

        
    }
}
