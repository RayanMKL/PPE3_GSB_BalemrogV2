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
    public partial class ProfilVisiteur : Form
    {
        public ProfilVisiteur()
        {
            InitializeComponent();
            Visiteur leVisiteur = ControlleurM1.leVisiteurCo;

            txtNomV.Text = leVisiteur.nom.ToString();
            txtPrenomV.Text = leVisiteur.prenom.ToString();
            txtRueV.Text = leVisiteur.rue.ToString();
            txtCpV.Text = leVisiteur.cp.ToString();
            txtVilleV.Text = leVisiteur.ville.ToString();
            txtDateEmbV.Text = leVisiteur.dateEmbauche.ToString();
            txtIdV.Text = leVisiteur.identifiant.ToString();

            bsVisiteur.DataSource = leVisiteur.Region.ToList();
            dgvResponsabilité.DataSource = bsVisiteur;
            dgvResponsabilité.Columns[0].HeaderText = "id Visiteur";
            dgvResponsabilité.Columns[1].HeaderText = "Libellé Region";
            dgvResponsabilité.Columns[0].Visible = false;
            dgvResponsabilité.Columns[1].Visible = false;
            dgvResponsabilité.Columns[4].Visible = false;
            dgvResponsabilité.Columns[5].Visible = false;
            dgvResponsabilité.Columns[6].Visible = false;
           




        }

        private void TxtNomV_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOKV_Click(object sender, EventArgs e)
        {
            
            if(ControlleurM1.ModifVisteur(txtNomV.Text, txtPrenomV.Text, txtRueV.Text, txtCpV.Text, txtVilleV.Text, txtDateEmbV.Text, txtIdV.Text))
            {
                if(MessageBox.Show("Modification éffectuée")== DialogResult.OK)
                {
                    this.Close();
                }
                
            }
        }

        private void LbRegionV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
         /* 
            Visiteur leVisiteur = ControlleurM1.leVisiteurCo;
            bsVisiteur.DataSource = leVisiteur.Region.ToList();
            dgvResponsabilité.DataSource = bsVisiteur;
            dgvResponsabilité.Columns[0].HeaderText = "id Visiteur";
            dgvResponsabilité.Columns[1].HeaderText = "Libellé Region";
            cboTest.DataSource = bsVisiteur;
            
             */
        }

        private void BtnModifmdp_Click(object sender, EventArgs e)
        {
            FModifmdp fmmdp = new FModifmdp();
            fmmdp.Show();
        }
    }
}
