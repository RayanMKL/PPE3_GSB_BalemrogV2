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
    public partial class Menu3 : Form
    {
        public Menu3()
        {
            InitializeComponent();
        }

        private void Menu3_Load(object sender, EventArgs e)
        {

        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            Mission3Modif missionM = new Mission3Modif();
            missionM.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Mission3Add missionA = new Mission3Add();
            missionA.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
