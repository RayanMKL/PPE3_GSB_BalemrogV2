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
            OFFRIR c = (OFFRIR)bsOffrir.Current;
            bsOffrir.DataSource = ControlleurM2.Medocs();
            dgvPracticien.DataSource = bsOffrir;
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
            cboMotif.ValueMember = "idMotif";
            cboMotif.DisplayMember = "libMotif";
            bsMotif.DataSource = ControlleurM2.listemotif();
            cboMotif.DataSource = bsMotif;
        }

        private void CboPracticien_Format(object sender, ListControlConvertEventArgs e)
        {
            string nomprenom = string.Concat(((MEDECIN)e.ListItem).nom, " ", ((MEDECIN)e.ListItem).prenom);
            e.Value = nomprenom;
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            FDetail d1 = new FDetail();
            d1.Show();
        }

        private void BsRapport_CurrentChanged(object sender, EventArgs e)
        {
            RAPPORT r = (RAPPORT)bsRapport.Current;
            txtNumRapport.Text = r.idRapport.ToString();
        }

        private void BsOffrir_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
