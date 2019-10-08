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
    }
}
