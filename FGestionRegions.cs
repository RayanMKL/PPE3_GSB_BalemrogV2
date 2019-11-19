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
    public partial class FGestionRegions : Form
    {
        public FGestionRegions()
        {
            InitializeComponent();
        }



        private void FGestionRegions_Load(object sender, EventArgs e)
        {
            cboRegions.ValueMember = "idRegion";
            cboRegions.DisplayMember = "libRegion";
            bsRegion.DataSource = ControlleurM1.listeRegionCourante();
            cboRegions.DataSource = bsRegion;
        }

        private void TxtIdRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BsRegion_CurrentChanged(object sender, EventArgs e)
        {
            Region r = (Region)bsRegion.Current;
           
            txtIdRegion.Text = r.idRegion.ToString();
            txtNomRegion.Text = r.libRegion.ToString();
            txtIdResponsable.Text = r.idVisiteur.ToString();
            txtNomRes.Text = r.Visiteur.nom.ToString();
            txtPrenomRes.Text = r.Visiteur.prenom.ToString();

            bsResponsables.DataSource = r.Visiteur1.ToList();

            
            dgvNewResponsable.DataSource = bsResponsables;

        }

        private void BtnModifRes_Click(object sender, EventArgs e)
        {
            lblNewRes.Visible = true;
            dgvNewResponsable.Visible = true;
            btnValiderRes.Visible = true;
        }

        private void BtnValiderRes_Click(object sender, EventArgs e)
        {

        }
    }
}
