using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_GSB_BalemrogV2
{
    public partial class GestionVisite : Form
    {
        public GestionVisite()
        {
            InitializeComponent();
        }

        private void GestionVisite_Load(object sender, EventArgs e)
        {

        }

        private void CompteRenduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompteRendu c1 = new CompteRendu();
            c1.Show();
        }
    }
}
