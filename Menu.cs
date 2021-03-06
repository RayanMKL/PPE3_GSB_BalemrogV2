﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Mission1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mission3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu3 m3 = new Menu3();
            m3.Show();
        }

        private void ProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilVisiteur pv1 = new ProfilVisiteur();
            pv1.Show();
        }

        private void RésponsabilitéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mission2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVisite m2 = new GestionVisite();
            m2.Show();
        }

        private void ComptesrendusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompteRendu c1 = new CompteRendu();
            c1.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // if(ControlleurM1.leVisiteurCo.Laboratoire )

            //Si 
            if (!(ControlleurM1.verifResponsableSecteur()))
            {
                gestionDesRegionsToolStripMenuItem.Enabled = false;
            }
        }

        private void LesVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVisiteurs fv = new FVisiteurs();
            fv.Show();
        }

        private void GestionDesRegionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGestionRegions FgéréR = new FGestionRegions();
            FgéréR.Show();
        }

        private void LesSecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
