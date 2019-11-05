namespace PPE3_GSB_BalemrogV2
{
    partial class FVisiteurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsRegions = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVisiteurs = new System.Windows.Forms.DataGridView();
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // bsRegions
            // 
            this.bsRegions.CurrentChanged += new System.EventHandler(this.BsVisiteurs_CurrentChanged);
            // 
            // dgvVisiteurs
            // 
            this.dgvVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurs.Location = new System.Drawing.Point(347, 29);
            this.dgvVisiteurs.Name = "dgvVisiteurs";
            this.dgvVisiteurs.Size = new System.Drawing.Size(426, 244);
            this.dgvVisiteurs.TabIndex = 0;
            // 
            // cboSecteur
            // 
            this.cboSecteur.FormattingEnabled = true;
            this.cboSecteur.Location = new System.Drawing.Point(12, 72);
            this.cboSecteur.Name = "cboSecteur";
            this.cboSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboSecteur.TabIndex = 1;
            // 
            // bsSecteur
            // 
            this.bsSecteur.CurrentChanged += new System.EventHandler(this.BsSecteur_CurrentChanged);
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(12, 117);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 21);
            this.cboRegion.TabIndex = 2;
            // 
            // FVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.cboSecteur);
            this.Controls.Add(this.dgvVisiteurs);
            this.Name = "FVisiteurs";
            this.Text = "FVisiteurs";
            this.Load += new System.EventHandler(this.FVisiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsRegions;
        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.BindingSource bsVisiteurs;
    }
}