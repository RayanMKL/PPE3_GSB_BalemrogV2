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
    public partial class FDetail : Form
    {
        public FDetail()
        {
            InitializeComponent();
            bsPracticien.DataSource = ControlleurM2.listepracticien();
        }

        private void FDetail_Load(object sender, EventArgs e)
        {
            cboPracticien.ValueMember = "idMedecin";
            cboPracticien.DisplayMember = "nom";
            bsPracticien.DataSource = ControlleurM2.listepracticien();
            cboPracticien.DataSource = bsPracticien;
        }

        private void BsPracticien_CurrentChanged(object sender, EventArgs e)
        {
            MEDECIN m = (MEDECIN)bsPracticien.Current;
            txtNumero.Text = m.idMedecin.ToString();
            txtNom.Text = m.nom;
            txtPrenom.Text = m.prenom;
            txtAdresse.Text = m.adresse.ToString();
            txtSpecialite.Text = m.SPECIALITE.libSpecialite;
        }

        private void CboPracticien_Format(object sender, ListControlConvertEventArgs e)
        {
            string nomprenom = string.Concat(((MEDECIN)e.ListItem).nom, " ", ((MEDECIN)e.ListItem).prenom);
            e.Value = nomprenom;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
