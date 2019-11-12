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

            bsVisiteurs.DataSource = r.Visiteur

           

        }
    }
}
