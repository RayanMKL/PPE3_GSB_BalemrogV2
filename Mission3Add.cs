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
    public partial class Mission3Add : Form
    {
        public Mission3Add()
        {
            InitializeComponent();

            cbChoixTransport.Items.Add("essence") ;
            cbChoixTransport.Items.Add("diesel");
            cbChoixTransport.Items.Add("electrique");
            cbChoixTransport.Items.Add("hybride");
            cbChoixTransport.Items.Add("moto");
        }
    }
}