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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.btnOkConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Algerian", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConnexion.Location = new System.Drawing.Point(35, 82);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(259, 32);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Identifiez-vous";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtID.Location = new System.Drawing.Point(127, 141);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "dandre";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(127, 167);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 2;
            this.txtMdp.Text = "dandre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(71, 143);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(50, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "identifiant :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(58, 169);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(63, 15);
            this.lblMdp.TabIndex = 4;
            this.lblMdp.Text = "Code secret :";
            // 
            // btnOkConn
            // 
            this.btnOkConn.Location = new System.Drawing.Point(167, 193);
            this.btnOkConn.Name = "btnOkConn";
            this.btnOkConn.Size = new System.Drawing.Size(60, 23);
            this.btnOkConn.TabIndex = 5;
            this.btnOkConn.Text = "OK";
            this.btnOkConn.UseVisualStyleBackColor = true;
            this.btnOkConn.Click += new System.EventHandler(this.BtnOkConn_Click);
            // 
            // FConnex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 291);
            this.Controls.Add(this.btnOkConn);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblConnexion);
            this.Name = "FConnex";
            this.Text = "FConnex";
            this.Load += new System.EventHandler(this.FConnex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Button btnOkConn;
    }
}