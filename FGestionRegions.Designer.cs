namespace PPE3_GSB_BalemrogV2
{
    partial class FGestionRegions
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
            this.cboRegions = new System.Windows.Forms.ComboBox();
            this.lblRegions = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblIdRegion = new System.Windows.Forms.Label();
            this.txtIdRegion = new System.Windows.Forms.TextBox();
            this.txtNomRegion = new System.Windows.Forms.TextBox();
            this.lblNomRegion = new System.Windows.Forms.Label();
            this.txtIdResponsable = new System.Windows.Forms.TextBox();
            this.lblIdVisiteur = new System.Windows.Forms.Label();
            this.txtNomRes = new System.Windows.Forms.TextBox();
            this.lblNomRes = new System.Windows.Forms.Label();
            this.txtPrenomRes = new System.Windows.Forms.TextBox();
            this.lblPrenomRes = new System.Windows.Forms.Label();
            this.btnModifRes = new System.Windows.Forms.Button();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bsResponsables = new System.Windows.Forms.BindingSource(this.components);
            this.lblNewRes = new System.Windows.Forms.Label();
            this.dgvNewResponsable = new System.Windows.Forms.DataGridView();
            this.btnValiderRes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRegions
            // 
            this.cboRegions.FormattingEnabled = true;
            this.cboRegions.Location = new System.Drawing.Point(50, 111);
            this.cboRegions.Name = "cboRegions";
            this.cboRegions.Size = new System.Drawing.Size(121, 21);
            this.cboRegions.TabIndex = 0;
            this.cboRegions.SelectedIndexChanged += new System.EventHandler(this.CboRegions_SelectedIndexChanged);
            // 
            // lblRegions
            // 
            this.lblRegions.AutoSize = true;
            this.lblRegions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegions.Location = new System.Drawing.Point(47, 81);
            this.lblRegions.Name = "lblRegions";
            this.lblRegions.Size = new System.Drawing.Size(85, 20);
            this.lblRegions.TabIndex = 1;
            this.lblRegions.Text = "Regions :";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(437, 81);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(156, 20);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Information region";
            // 
            // lblIdRegion
            // 
            this.lblIdRegion.AutoSize = true;
            this.lblIdRegion.Location = new System.Drawing.Point(406, 144);
            this.lblIdRegion.Name = "lblIdRegion";
            this.lblIdRegion.Size = new System.Drawing.Size(65, 13);
            this.lblIdRegion.TabIndex = 3;
            this.lblIdRegion.Text = "Indentifiant :";
            // 
            // txtIdRegion
            // 
            this.txtIdRegion.Location = new System.Drawing.Point(493, 141);
            this.txtIdRegion.Name = "txtIdRegion";
            this.txtIdRegion.Size = new System.Drawing.Size(100, 20);
            this.txtIdRegion.TabIndex = 4;
            this.txtIdRegion.TextChanged += new System.EventHandler(this.TxtIdRegion_TextChanged);
            // 
            // txtNomRegion
            // 
            this.txtNomRegion.Location = new System.Drawing.Point(493, 167);
            this.txtNomRegion.Name = "txtNomRegion";
            this.txtNomRegion.Size = new System.Drawing.Size(100, 20);
            this.txtNomRegion.TabIndex = 6;
            // 
            // lblNomRegion
            // 
            this.lblNomRegion.AutoSize = true;
            this.lblNomRegion.Location = new System.Drawing.Point(406, 170);
            this.lblNomRegion.Name = "lblNomRegion";
            this.lblNomRegion.Size = new System.Drawing.Size(35, 13);
            this.lblNomRegion.TabIndex = 5;
            this.lblNomRegion.Text = "Nom :";
            // 
            // txtIdResponsable
            // 
            this.txtIdResponsable.Enabled = false;
            this.txtIdResponsable.Location = new System.Drawing.Point(493, 193);
            this.txtIdResponsable.Name = "txtIdResponsable";
            this.txtIdResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtIdResponsable.TabIndex = 8;
            // 
            // lblIdVisiteur
            // 
            this.lblIdVisiteur.AutoSize = true;
            this.lblIdVisiteur.Location = new System.Drawing.Point(406, 196);
            this.lblIdVisiteur.Name = "lblIdVisiteur";
            this.lblIdVisiteur.Size = new System.Drawing.Size(84, 13);
            this.lblIdVisiteur.TabIndex = 7;
            this.lblIdVisiteur.Text = "ID responsable :";
            // 
            // txtNomRes
            // 
            this.txtNomRes.Enabled = false;
            this.txtNomRes.Location = new System.Drawing.Point(493, 219);
            this.txtNomRes.Name = "txtNomRes";
            this.txtNomRes.Size = new System.Drawing.Size(100, 20);
            this.txtNomRes.TabIndex = 10;
            // 
            // lblNomRes
            // 
            this.lblNomRes.AutoSize = true;
            this.lblNomRes.Location = new System.Drawing.Point(395, 222);
            this.lblNomRes.Name = "lblNomRes";
            this.lblNomRes.Size = new System.Drawing.Size(95, 13);
            this.lblNomRes.TabIndex = 9;
            this.lblNomRes.Text = "Nom responsable :";
            // 
            // txtPrenomRes
            // 
            this.txtPrenomRes.Enabled = false;
            this.txtPrenomRes.Location = new System.Drawing.Point(493, 245);
            this.txtPrenomRes.Name = "txtPrenomRes";
            this.txtPrenomRes.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomRes.TabIndex = 12;
            // 
            // lblPrenomRes
            // 
            this.lblPrenomRes.AutoSize = true;
            this.lblPrenomRes.Location = new System.Drawing.Point(381, 248);
            this.lblPrenomRes.Name = "lblPrenomRes";
            this.lblPrenomRes.Size = new System.Drawing.Size(109, 13);
            this.lblPrenomRes.TabIndex = 11;
            this.lblPrenomRes.Text = "Prenom responsable :";
            // 
            // btnModifRes
            // 
            this.btnModifRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifRes.Location = new System.Drawing.Point(30, 288);
            this.btnModifRes.Name = "btnModifRes";
            this.btnModifRes.Size = new System.Drawing.Size(131, 40);
            this.btnModifRes.TabIndex = 13;
            this.btnModifRes.Text = "Modifier le responsable";
            this.btnModifRes.UseVisualStyleBackColor = true;
            this.btnModifRes.Click += new System.EventHandler(this.BtnModifRes_Click);
            // 
            // bsRegion
            // 
            this.bsRegion.CurrentChanged += new System.EventHandler(this.BsRegion_CurrentChanged);
            // 
            // lblNewRes
            // 
            this.lblNewRes.AutoSize = true;
            this.lblNewRes.Location = new System.Drawing.Point(266, 315);
            this.lblNewRes.Name = "lblNewRes";
            this.lblNewRes.Size = new System.Drawing.Size(175, 13);
            this.lblNewRes.TabIndex = 15;
            this.lblNewRes.Text = "Nouveau responsable de la region :";
            this.lblNewRes.Visible = false;
            // 
            // dgvNewResponsable
            // 
            this.dgvNewResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewResponsable.Location = new System.Drawing.Point(269, 341);
            this.dgvNewResponsable.Name = "dgvNewResponsable";
            this.dgvNewResponsable.Size = new System.Drawing.Size(356, 150);
            this.dgvNewResponsable.TabIndex = 16;
            this.dgvNewResponsable.Visible = false;
            // 
            // btnValiderRes
            // 
            this.btnValiderRes.Location = new System.Drawing.Point(550, 513);
            this.btnValiderRes.Name = "btnValiderRes";
            this.btnValiderRes.Size = new System.Drawing.Size(75, 23);
            this.btnValiderRes.TabIndex = 17;
            this.btnValiderRes.Text = "Validez";
            this.btnValiderRes.UseVisualStyleBackColor = true;
            this.btnValiderRes.Visible = false;
            this.btnValiderRes.Click += new System.EventHandler(this.BtnValiderRes_Click);
            // 
            // FGestionRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.btnValiderRes);
            this.Controls.Add(this.dgvNewResponsable);
            this.Controls.Add(this.lblNewRes);
            this.Controls.Add(this.btnModifRes);
            this.Controls.Add(this.txtPrenomRes);
            this.Controls.Add(this.lblPrenomRes);
            this.Controls.Add(this.txtNomRes);
            this.Controls.Add(this.lblNomRes);
            this.Controls.Add(this.txtIdResponsable);
            this.Controls.Add(this.lblIdVisiteur);
            this.Controls.Add(this.txtNomRegion);
            this.Controls.Add(this.lblNomRegion);
            this.Controls.Add(this.txtIdRegion);
            this.Controls.Add(this.lblIdRegion);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblRegions);
            this.Controls.Add(this.cboRegions);
            this.Name = "FGestionRegions";
            this.Text = "FGestionRegions";
            this.Load += new System.EventHandler(this.FGestionRegions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewResponsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.ComboBox cboRegions;
        private System.Windows.Forms.Label lblRegions;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblIdRegion;
        private System.Windows.Forms.TextBox txtIdRegion;
        private System.Windows.Forms.TextBox txtNomRegion;
        private System.Windows.Forms.Label lblNomRegion;
        private System.Windows.Forms.TextBox txtIdResponsable;
        private System.Windows.Forms.Label lblIdVisiteur;
        private System.Windows.Forms.TextBox txtNomRes;
        private System.Windows.Forms.Label lblNomRes;
        private System.Windows.Forms.TextBox txtPrenomRes;
        private System.Windows.Forms.Label lblPrenomRes;
        private System.Windows.Forms.Button btnModifRes;
        private System.Windows.Forms.BindingSource bsResponsables;
        private System.Windows.Forms.Label lblNewRes;
        private System.Windows.Forms.DataGridView dgvNewResponsable;
        private System.Windows.Forms.Button btnValiderRes;
    }
}