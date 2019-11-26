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
    public partial class FVisiteurs : Form
    {
        public FVisiteurs()
        {
            InitializeComponent();
        }

        private void FVisiteurs_Load(object sender, EventArgs e)
        {
            cboSecteur.ValueMember = "idSecteur";
            cboSecteur.DisplayMember = "libSecteur";
            bsSecteur.DataSource = ControlleurM1.listeSecteur();
            cboSecteur.DataSource = bsSecteur;
        }

        private void BsSecteur_CurrentChanged(object sender, EventArgs e)
        {
            Secteur s = (Secteur)bsSecteur.Current;

            bsRegions.DataSource = s.Region.ToList();
            cboRegion.ValueMember = "idRegion";
            cboRegion.DisplayMember = "libRegion";
            cboRegion.DataSource = bsRegions;

            txtNomResS.Text = s.Visiteur.nom;
            txtPrenomResS.Text = s.Visiteur.prenom;
            txtIdResS.Text = s.Visiteur.identifiant;
        }

        private void BsVisiteurs_CurrentChanged(object sender, EventArgs e)
        {
            Region r = (Region)bsRegions.Current;

            bsVisiteurs.DataSource = r.Visiteur1.ToList();
            dgvVisiteurs.DataSource = bsVisiteurs;

            txtNomResR.Text = r.Visiteur.nom;
            txtPrenomResR.Text = r.Visiteur.prenom;
            txtIdResR.Text = r.Visiteur.identifiant;

            dgvVisiteurs.Columns[4].Visible = false;
            dgvVisiteurs.Columns[5].Visible = false;
            dgvVisiteurs.Columns[6].Visible = false;
            dgvVisiteurs.Columns[7].Visible = false;
            dgvVisiteurs.Columns[8].Visible = false;
            dgvVisiteurs.Columns[9].Visible = false;
            dgvVisiteurs.Columns[10].Visible = false;
            dgvVisiteurs.Columns[11].Visible = false;
            dgvVisiteurs.Columns[12].Visible = false;
            dgvVisiteurs.Columns[13].Visible = false;
            dgvVisiteurs.Columns[14].Visible = false;
            dgvVisiteurs.Columns[15].Visible = false;



        }
    }
}
