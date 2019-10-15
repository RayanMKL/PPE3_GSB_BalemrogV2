namespace PPE3_GSB_BalemrogV2
{
    partial class Menu3
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
            this.LabMission3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListeFiche = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFiche)).BeginInit();
            this.SuspendLayout();
            // 
            // LabMission3
            // 
            this.LabMission3.AutoSize = true;
            this.LabMission3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LabMission3.Location = new System.Drawing.Point(16, 9);
            this.LabMission3.Name = "LabMission3";
            this.LabMission3.Size = new System.Drawing.Size(89, 24);
            this.LabMission3.TabIndex = 0;
            this.LabMission3.Text = "Mission 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste fiche de frais:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dgvListeFiche
            // 
            this.dgvListeFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeFiche.Location = new System.Drawing.Point(20, 85);
            this.dgvListeFiche.Name = "dgvListeFiche";
            this.dgvListeFiche.Size = new System.Drawing.Size(415, 279);
            this.dgvListeFiche.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Créer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(275, 393);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 4;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // Menu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvListeFiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabMission3);
            this.Name = "Menu3";
            this.Text = "Menu3";
            this.Load += new System.EventHandler(this.Menu3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFiche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabMission3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListeFiche;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModif;
    }
}