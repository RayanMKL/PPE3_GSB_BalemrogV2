namespace PPE3_GSB_BalemrogV2
{
    partial class ProfilVisiteur
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNomV = new System.Windows.Forms.Label();
            this.lblPrenomV = new System.Windows.Forms.Label();
            this.txtNomV = new System.Windows.Forms.TextBox();
            this.txtPrenomV = new System.Windows.Forms.TextBox();
            this.txtRueV = new System.Windows.Forms.TextBox();
            this.lblRueV = new System.Windows.Forms.Label();
            this.txtCpV = new System.Windows.Forms.TextBox();
            this.lblCpV = new System.Windows.Forms.Label();
            this.txtVilleV = new System.Windows.Forms.TextBox();
            this.lblVilleV = new System.Windows.Forms.Label();
            this.txtDateEmbV = new System.Windows.Forms.TextBox();
            this.lblDateEmbV = new System.Windows.Forms.Label();
            this.txtIdV = new System.Windows.Forms.TextBox();
            this.lblIdV = new System.Windows.Forms.Label();
            this.btnOKV = new System.Windows.Forms.Button();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.lbRegionV = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(630, 415);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblNomV
            // 
            this.lblNomV.AutoSize = true;
            this.lblNomV.Location = new System.Drawing.Point(100, 43);
            this.lblNomV.Name = "lblNomV";
            this.lblNomV.Size = new System.Drawing.Size(35, 13);
            this.lblNomV.TabIndex = 3;
            this.lblNomV.Text = "Nom :";
            // 
            // lblPrenomV
            // 
            this.lblPrenomV.AutoSize = true;
            this.lblPrenomV.Location = new System.Drawing.Point(100, 71);
            this.lblPrenomV.Name = "lblPrenomV";
            this.lblPrenomV.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomV.TabIndex = 4;
            this.lblPrenomV.Text = "Prenom :";
            // 
            // txtNomV
            // 
            this.txtNomV.Location = new System.Drawing.Point(170, 40);
            this.txtNomV.Name = "txtNomV";
            this.txtNomV.Size = new System.Drawing.Size(100, 20);
            this.txtNomV.TabIndex = 5;
            this.txtNomV.TextChanged += new System.EventHandler(this.TxtNomV_TextChanged);
            // 
            // txtPrenomV
            // 
            this.txtPrenomV.Location = new System.Drawing.Point(170, 68);
            this.txtPrenomV.Name = "txtPrenomV";
            this.txtPrenomV.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomV.TabIndex = 6;
            // 
            // txtRueV
            // 
            this.txtRueV.Location = new System.Drawing.Point(170, 94);
            this.txtRueV.Name = "txtRueV";
            this.txtRueV.Size = new System.Drawing.Size(100, 20);
            this.txtRueV.TabIndex = 8;
            // 
            // lblRueV
            // 
            this.lblRueV.AutoSize = true;
            this.lblRueV.Location = new System.Drawing.Point(100, 97);
            this.lblRueV.Name = "lblRueV";
            this.lblRueV.Size = new System.Drawing.Size(33, 13);
            this.lblRueV.TabIndex = 7;
            this.lblRueV.Text = "Rue :";
            // 
            // txtCpV
            // 
            this.txtCpV.Location = new System.Drawing.Point(170, 120);
            this.txtCpV.Name = "txtCpV";
            this.txtCpV.Size = new System.Drawing.Size(100, 20);
            this.txtCpV.TabIndex = 10;
            // 
            // lblCpV
            // 
            this.lblCpV.AutoSize = true;
            this.lblCpV.Location = new System.Drawing.Point(94, 123);
            this.lblCpV.Name = "lblCpV";
            this.lblCpV.Size = new System.Drawing.Size(70, 13);
            this.lblCpV.TabIndex = 9;
            this.lblCpV.Text = "Code Postal :";
            // 
            // txtVilleV
            // 
            this.txtVilleV.Location = new System.Drawing.Point(170, 146);
            this.txtVilleV.Name = "txtVilleV";
            this.txtVilleV.Size = new System.Drawing.Size(100, 20);
            this.txtVilleV.TabIndex = 12;
            // 
            // lblVilleV
            // 
            this.lblVilleV.AutoSize = true;
            this.lblVilleV.Location = new System.Drawing.Point(100, 149);
            this.lblVilleV.Name = "lblVilleV";
            this.lblVilleV.Size = new System.Drawing.Size(32, 13);
            this.lblVilleV.TabIndex = 11;
            this.lblVilleV.Text = "Ville :";
            // 
            // txtDateEmbV
            // 
            this.txtDateEmbV.Enabled = false;
            this.txtDateEmbV.Location = new System.Drawing.Point(170, 172);
            this.txtDateEmbV.Name = "txtDateEmbV";
            this.txtDateEmbV.Size = new System.Drawing.Size(100, 20);
            this.txtDateEmbV.TabIndex = 14;
            // 
            // lblDateEmbV
            // 
            this.lblDateEmbV.AutoSize = true;
            this.lblDateEmbV.Location = new System.Drawing.Point(76, 175);
            this.lblDateEmbV.Name = "lblDateEmbV";
            this.lblDateEmbV.Size = new System.Drawing.Size(88, 13);
            this.lblDateEmbV.TabIndex = 13;
            this.lblDateEmbV.Text = "Date - Ebauche :";
            // 
            // txtIdV
            // 
            this.txtIdV.Enabled = false;
            this.txtIdV.Location = new System.Drawing.Point(170, 198);
            this.txtIdV.Name = "txtIdV";
            this.txtIdV.Size = new System.Drawing.Size(100, 20);
            this.txtIdV.TabIndex = 16;
            // 
            // lblIdV
            // 
            this.lblIdV.AutoSize = true;
            this.lblIdV.Location = new System.Drawing.Point(100, 201);
            this.lblIdV.Name = "lblIdV";
            this.lblIdV.Size = new System.Drawing.Size(59, 13);
            this.lblIdV.TabIndex = 15;
            this.lblIdV.Text = "Identifiant :";
            // 
            // btnOKV
            // 
            this.btnOKV.Location = new System.Drawing.Point(401, 271);
            this.btnOKV.Name = "btnOKV";
            this.btnOKV.Size = new System.Drawing.Size(75, 23);
            this.btnOKV.TabIndex = 17;
            this.btnOKV.Text = "OK";
            this.btnOKV.UseVisualStyleBackColor = true;
            this.btnOKV.Click += new System.EventHandler(this.BtnOKV_Click);
            // 
            // lbRegionV
            // 
            this.lbRegionV.FormattingEnabled = true;
            this.lbRegionV.Location = new System.Drawing.Point(384, 67);
            this.lbRegionV.Name = "lbRegionV";
            this.lbRegionV.Size = new System.Drawing.Size(92, 95);
            this.lbRegionV.TabIndex = 18;
            this.lbRegionV.SelectedIndexChanged += new System.EventHandler(this.LbRegionV_SelectedIndexChanged);
            // 
            // ProfilVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 327);
            this.Controls.Add(this.lbRegionV);
            this.Controls.Add(this.btnOKV);
            this.Controls.Add(this.txtIdV);
            this.Controls.Add(this.lblIdV);
            this.Controls.Add(this.txtDateEmbV);
            this.Controls.Add(this.lblDateEmbV);
            this.Controls.Add(this.txtVilleV);
            this.Controls.Add(this.lblVilleV);
            this.Controls.Add(this.txtCpV);
            this.Controls.Add(this.lblCpV);
            this.Controls.Add(this.txtRueV);
            this.Controls.Add(this.lblRueV);
            this.Controls.Add(this.txtPrenomV);
            this.Controls.Add(this.txtNomV);
            this.Controls.Add(this.lblPrenomV);
            this.Controls.Add(this.lblNomV);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "ProfilVisiteur";
            this.Text = "ProfilVisiteur";
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblNomV;
        private System.Windows.Forms.Label lblPrenomV;
        private System.Windows.Forms.TextBox txtNomV;
        private System.Windows.Forms.TextBox txtPrenomV;
        private System.Windows.Forms.TextBox txtRueV;
        private System.Windows.Forms.Label lblRueV;
        private System.Windows.Forms.TextBox txtCpV;
        private System.Windows.Forms.Label lblCpV;
        private System.Windows.Forms.TextBox txtVilleV;
        private System.Windows.Forms.Label lblVilleV;
        private System.Windows.Forms.TextBox txtDateEmbV;
        private System.Windows.Forms.Label lblDateEmbV;
        private System.Windows.Forms.TextBox txtIdV;
        private System.Windows.Forms.Label lblIdV;
        private System.Windows.Forms.Button btnOKV;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.ListBox lbRegionV;
    }
}