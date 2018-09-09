using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPModel
{
    public partial class frmObavijesti : Form
    {
        private int kupacID;

        public frmObavijesti(int kupacID)
        {
            InitializeComponent();
            this.kupacID = kupacID;
        }

        private void frmObavijesti_Load(object sender, EventArgs e)
        {
            this.kupacTableAdapter.FillBy(this.ineffableDataSet.kupac, kupacID);
        }

    }
}
