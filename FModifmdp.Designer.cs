namespace PPE3_GSB_BalemrogV2
{
    partial class FModifmdp
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
            this.lblmdpActuel = new System.Windows.Forms.Label();
            this.txtAncienMdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNouveauMdp = new System.Windows.Forms.TextBox();
            this.txtConfirmeNewMdp = new System.Windows.Forms.TextBox();
            this.lblConfirmeMdp = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmdpActuel
            // 
            this.lblmdpActuel.AutoSize = true;
            this.lblmdpActuel.Location = new System.Drawing.Point(73, 75);
            this.lblmdpActuel.Name = "lblmdpActuel";
            this.lblmdpActuel.Size = new System.Drawing.Size(110, 13);
            this.lblmdpActuel.TabIndex = 0;
            this.lblmdpActuel.Text = "Mot de passe Actuel :";
            // 
            // txtAncienMdp
            // 
            this.txtAncienMdp.Location = new System.Drawing.Point(189, 75);
            this.txtAncienMdp.Name = "txtAncienMdp";
            this.txtAncienMdp.PasswordChar = '*';
            this.txtAncienMdp.Size = new System.Drawing.Size(100, 20);
            this.txtAncienMdp.TabIndex = 1;
            this.txtAncienMdp.TextChanged += new System.EventHandler(this.TxtAncienMdp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nouveau mot de passe :";
            // 
            // txtNouveauMdp
            // 
            this.txtNouveauMdp.Location = new System.Drawing.Point(189, 118);
            this.txtNouveauMdp.Name = "txtNouveauMdp";
            this.txtNouveauMdp.PasswordChar = '*';
            this.txtNouveauMdp.Size = new System.Drawing.Size(100, 20);
            this.txtNouveauMdp.TabIndex = 3;
            this.txtNouveauMdp.TextChanged += new System.EventHandler(this.TxtAncienMdp_TextChanged);
            // 
            // txtConfirmeNewMdp
            // 
            this.txtConfirmeNewMdp.Location = new System.Drawing.Point(189, 144);
            this.txtConfirmeNewMdp.Name = "txtConfirmeNewMdp";
            this.txtConfirmeNewMdp.PasswordChar = '*';
            this.txtConfirmeNewMdp.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmeNewMdp.TabIndex = 5;
            this.txtConfirmeNewMdp.TextChanged += new System.EventHandler(this.TxtAncienMdp_TextChanged);
            // 
            // lblConfirmeMdp
            // 
            this.lblConfirmeMdp.AutoSize = true;
            this.lblConfirmeMdp.Location = new System.Drawing.Point(39, 144);
            this.lblConfirmeMdp.Name = "lblConfirmeMdp";
            this.lblConfirmeMdp.Size = new System.Drawing.Size(144, 13);
            this.lblConfirmeMdp.TabIndex = 4;
            this.lblConfirmeMdp.Text = "Confirmer votre mot de passe";
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(272, 201);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FModifmdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 248);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtConfirmeNewMdp);
            this.Controls.Add(this.lblConfirmeMdp);
            this.Controls.Add(this.txtNouveauMdp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAncienMdp);
            this.Controls.Add(this.lblmdpActuel);
            this.Name = "FModifmdp";
            this.Text = "FModifmdp";
            this.Load += new System.EventHandler(this.FModifmdp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmdpActuel;
        private System.Windows.Forms.TextBox txtAncienMdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNouveauMdp;
        private System.Windows.Forms.TextBox txtConfirmeNewMdp;
        private System.Windows.Forms.Label lblConfirmeMdp;
        private System.Windows.Forms.Button btnOk;
    }
}