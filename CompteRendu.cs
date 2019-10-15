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
    public partial class CompteRendu : Form
    {
        public CompteRendu()
        {
            InitializeComponent();
            bsPracticien.DataSource = ControlleurM2.listepracticien();
            dgvPracticien.DataSource = bsPracticien;
        }

        private void BsPracticien_CurrentChanged(object sender, EventArgs e)
        {
            MEDECIN m = (MEDECIN)bsPracticien.Current;
        }

        private void CompteRendu_Load(object sender, EventArgs e)
        {
            cboPracticien.ValueMember = "idMedecin";
            cboPracticien.DisplayMember = "nom";
            bsPracticien.DataSource = ControlleurM2.listepracticien();
            cboPracticien.DataSource = bsPracticien;

            //dtpRapport.Value = (RAPPORT).;
        }

        private void CboPracticien_Format(object sender, ListControlConvertEventArgs e)
        {
            string nomprenom = string.Concat(((MEDECIN)e.ListItem).nom, " ", ((MEDECIN)e.ListItem).prenom);
            e.Value = nomprenom;
        }
    }
}
