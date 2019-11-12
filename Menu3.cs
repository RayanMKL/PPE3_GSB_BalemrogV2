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
            bsFicheFrais.DataSource = ControlleurM3.listeFicheFraisCourant();
            dgvListeFiche.DataSource = bsFicheFrais;
            dgvListeFiche.Columns[0].Visible = false;
            dgvListeFiche.Columns[1].HeaderText = "Mois";
            dgvListeFiche.Columns[6].Visible = false;
            dgvListeFiche.Columns[7].Visible = false;
            dgvListeFiche.Columns[8].Visible = false;
            dgvListeFiche.Columns[9].Visible = false;


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

        private void BsFicheFrais_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}
