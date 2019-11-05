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
    public partial class FModifmdp : Form
    {
        public FModifmdp()
        {
            InitializeComponent();
        }

        private void FModifmdp_Load(object sender, EventArgs e)
        {

        }

        private void TxtAncienMdp_TextChanged(object sender, EventArgs e)
        {
            

            if(this.txtAncienMdp.Text.Length > 0 && this.txtNouveauMdp.Text.Length > 0 && this.txtConfirmeNewMdp.Text.Length > 0)
            {
                this.btnOk.Enabled = true;
                
            }
            else
            {
                this.btnOk.Enabled = false;
            }
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.txtNouveauMdp.Text == this.txtConfirmeNewMdp.Text && ControlleurM1.verifierCode(ControlleurM1.leVisiteurCo.identifiant, this.txtAncienMdp.Text) == 1)
            {

                if (ControlleurM1.modifierMDP(this.txtNouveauMdp.Text))
                {
                   if( MessageBox.Show("mot de passe modifié") == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
                else
                {
                    if(MessageBox.Show("Erreur") == DialogResult.OK)
                    {
                        this.Close();
                    }
                }


            }
            else
            {
                MessageBox.Show("pas bon");
            }
        }
    }
}
