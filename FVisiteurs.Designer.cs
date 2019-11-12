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
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblResSecteur = new System.Windows.Forms.Label();
            this.lblResRegion = new System.Windows.Forms.Label();
            this.txtNomResS = new System.Windows.Forms.TextBox();
            this.NomResS = new System.Windows.Forms.Label();
            this.lblPrenomResS = new System.Windows.Forms.Label();
            this.txtPrenomResS = new System.Windows.Forms.TextBox();
            this.lblIdResS = new System.Windows.Forms.Label();
            this.txtIdResS = new System.Windows.Forms.TextBox();
            this.lblIdResR = new System.Windows.Forms.Label();
            this.txtIdResR = new System.Windows.Forms.TextBox();
            this.lblPrenomResR = new System.Windows.Forms.Label();
            this.txtPrenomResR = new System.Windows.Forms.TextBox();
            this.lblNomResR = new System.Windows.Forms.Label();
            this.txtNomResR = new System.Windows.Forms.TextBox();
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
            this.cboSecteur.Location = new System.Drawing.Point(103, 52);
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
            this.cboRegion.Location = new System.Drawing.Point(103, 87);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 21);
            this.cboRegion.TabIndex = 2;
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecteur.Location = new System.Drawing.Point(12, 51);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(85, 18);
            this.lblSecteur.TabIndex = 3;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(12, 87);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(80, 18);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Regions :";
            // 
            // lblResSecteur
            // 
            this.lblResSecteur.AutoSize = true;
            this.lblResSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResSecteur.Location = new System.Drawing.Point(12, 145);
            this.lblResSecteur.Name = "lblResSecteur";
            this.lblResSecteur.Size = new System.Drawing.Size(152, 13);
            this.lblResSecteur.TabIndex = 5;
            this.lblResSecteur.Text = "Responsable de secteur :";
            // 
            // lblResRegion
            // 
            this.lblResRegion.AutoSize = true;
            this.lblResRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResRegion.Location = new System.Drawing.Point(12, 273);
            this.lblResRegion.Name = "lblResRegion";
            this.lblResRegion.Size = new System.Drawing.Size(145, 13);
            this.lblResRegion.TabIndex = 6;
            this.lblResRegion.Text = "Responsable de region :";
            // 
            // txtNomResS
            // 
            this.txtNomResS.Enabled = false;
            this.txtNomResS.Location = new System.Drawing.Point(124, 179);
            this.txtNomResS.Name = "txtNomResS";
            this.txtNomResS.Size = new System.Drawing.Size(100, 20);
            this.txtNomResS.TabIndex = 7;
            // 
            // NomResS
            // 
            this.NomResS.AutoSize = true;
            this.NomResS.Location = new System.Drawing.Point(32, 186);
            this.NomResS.Name = "NomResS";
            this.NomResS.Size = new System.Drawing.Size(35, 13);
            this.NomResS.TabIndex = 8;
            this.NomResS.Text = "Nom :";
            // 
            // lblPrenomResS
            // 
            this.lblPrenomResS.AutoSize = true;
            this.lblPrenomResS.Location = new System.Drawing.Point(32, 212);
            this.lblPrenomResS.Name = "lblPrenomResS";
            this.lblPrenomResS.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomResS.TabIndex = 10;
            this.lblPrenomResS.Text = "Prenom :";
            // 
            // txtPrenomResS
            // 
            this.txtPrenomResS.Enabled = false;
            this.txtPrenomResS.Location = new System.Drawing.Point(124, 205);
            this.txtPrenomResS.Name = "txtPrenomResS";
            this.txtPrenomResS.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomResS.TabIndex = 9;
            // 
            // lblIdResS
            // 
            this.lblIdResS.AutoSize = true;
            this.lblIdResS.Location = new System.Drawing.Point(32, 238);
            this.lblIdResS.Name = "lblIdResS";
            this.lblIdResS.Size = new System.Drawing.Size(59, 13);
            this.lblIdResS.TabIndex = 12;
            this.lblIdResS.Text = "Identifiant :";
            // 
            // txtIdResS
            // 
            this.txtIdResS.Enabled = false;
            this.txtIdResS.Location = new System.Drawing.Point(124, 231);
            this.txtIdResS.Name = "txtIdResS";
            this.txtIdResS.Size = new System.Drawing.Size(100, 20);
            this.txtIdResS.TabIndex = 11;
            // 
            // lblIdResR
            // 
            this.lblIdResR.AutoSize = true;
            this.lblIdResR.Location = new System.Drawing.Point(32, 361);
            this.lblIdResR.Name = "lblIdResR";
            this.lblIdResR.Size = new System.Drawing.Size(59, 13);
            this.lblIdResR.TabIndex = 18;
            this.lblIdResR.Text = "Identifiant :";
            // 
            // txtIdResR
            // 
            this.txtIdResR.Enabled = false;
            this.txtIdResR.Location = new System.Drawing.Point(124, 354);
            this.txtIdResR.Name = "txtIdResR";
            this.txtIdResR.Size = new System.Drawing.Size(100, 20);
            this.txtIdResR.TabIndex = 17;
            // 
            // lblPrenomResR
            // 
            this.lblPrenomResR.AutoSize = true;
            this.lblPrenomResR.Location = new System.Drawing.Point(32, 335);
            this.lblPrenomResR.Name = "lblPrenomResR";
            this.lblPrenomResR.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomResR.TabIndex = 16;
            this.lblPrenomResR.Text = "Prenom :";
            // 
            // txtPrenomResR
            // 
            this.txtPrenomResR.Enabled = false;
            this.txtPrenomResR.Location = new System.Drawing.Point(124, 328);
            this.txtPrenomResR.Name = "txtPrenomResR";
            this.txtPrenomResR.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomResR.TabIndex = 15;
            // 
            // lblNomResR
            // 
            this.lblNomResR.AutoSize = true;
            this.lblNomResR.Location = new System.Drawing.Point(32, 309);
            this.lblNomResR.Name = "lblNomResR";
            this.lblNomResR.Size = new System.Drawing.Size(35, 13);
            this.lblNomResR.TabIndex = 14;
            this.lblNomResR.Text = "Nom :";
            // 
            // txtNomResR
            // 
            this.txtNomResR.Enabled = false;
            this.txtNomResR.Location = new System.Drawing.Point(124, 302);
            this.txtNomResR.Name = "txtNomResR";
            this.txtNomResR.Size = new System.Drawing.Size(100, 20);
            this.txtNomResR.TabIndex = 13;
            // 
            // FVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdResR);
            this.Controls.Add(this.txtIdResR);
            this.Controls.Add(this.lblPrenomResR);
            this.Controls.Add(this.txtPrenomResR);
            this.Controls.Add(this.lblNomResR);
            this.Controls.Add(this.txtNomResR);
            this.Controls.Add(this.lblIdResS);
            this.Controls.Add(this.txtIdResS);
            this.Controls.Add(this.lblPrenomResS);
            this.Controls.Add(this.txtPrenomResS);
            this.Controls.Add(this.NomResS);
            this.Controls.Add(this.txtNomResS);
            this.Controls.Add(this.lblResRegion);
            this.Controls.Add(this.lblResSecteur);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblSecteur);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsRegions;
        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblResSecteur;
        private System.Windows.Forms.Label lblResRegion;
        private System.Windows.Forms.TextBox txtNomResS;
        private System.Windows.Forms.Label NomResS;
        private System.Windows.Forms.Label lblPrenomResS;
        private System.Windows.Forms.TextBox txtPrenomResS;
        private System.Windows.Forms.Label lblIdResS;
        private System.Windows.Forms.TextBox txtIdResS;
        private System.Windows.Forms.Label lblIdResR;
        private System.Windows.Forms.TextBox txtIdResR;
        private System.Windows.Forms.Label lblPrenomResR;
        private System.Windows.Forms.TextBox txtPrenomResR;
        private System.Windows.Forms.Label lblNomResR;
        private System.Windows.Forms.TextBox txtNomResR;
    }
}