namespace PPE3_GSB_BalemrogV2
{
    partial class FConnex
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
            this.lblConnexion = new System.Windows.Forms.Label();
            this.txtNomConn = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.btnOkConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Algerian", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConnexion.Location = new System.Drawing.Point(253, 97);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(259, 32);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Identifiez-vous";
            // 
            // txtNomConn
            // 
            this.txtNomConn.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomConn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNomConn.Location = new System.Drawing.Point(345, 155);
            this.txtNomConn.Name = "txtNomConn";
            this.txtNomConn.Size = new System.Drawing.Size(100, 20);
            this.txtNomConn.TabIndex = 1;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(345, 181);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(306, 159);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 15);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(276, 183);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(63, 15);
            this.lblMdp.TabIndex = 4;
            this.lblMdp.Text = "Code secret :";
            // 
            // btnOkConn
            // 
            this.btnOkConn.Location = new System.Drawing.Point(408, 207);
            this.btnOkConn.Name = "btnOkConn";
            this.btnOkConn.Size = new System.Drawing.Size(37, 23);
            this.btnOkConn.TabIndex = 5;
            this.btnOkConn.Text = "OK";
            this.btnOkConn.UseVisualStyleBackColor = true;
            // 
            // FConnex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 314);
            this.Controls.Add(this.btnOkConn);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtNomConn);
            this.Controls.Add(this.lblConnexion);
            this.Name = "FConnex";
            this.Text = "FConnex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.TextBox txtNomConn;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Button btnOkConn;
    }
}