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
    public partial class FConnex : Form
    {
        public FConnex()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new Menu());
        }

        private void FConnex_Load(object sender, EventArgs e)
        {

        }

        private void BtnOkConn_Click(object sender, EventArgs e)
        {
            switch(ControlleurM1.verifierCode(txtID.Text, txtMdp.Text))
            {
                case 0:
                    MessageBox.Show("l'identifiant saisi n'est pas valide");
                    break;
                case 1:

                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();

                    break;
                case 2:
                    MessageBox.Show("votre code n'est pas bon");
                    break;

            }
        }
    }
}
