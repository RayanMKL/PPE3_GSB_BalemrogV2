namespace PPE3_GSB_BalemrogV2
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.missionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesVisiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // missionsToolStripMenuItem
            // 
            this.missionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mission1ToolStripMenuItem,
            this.mission2ToolStripMenuItem,
            this.mission3ToolStripMenuItem});
            this.missionsToolStripMenuItem.Name = "missionsToolStripMenuItem";
            this.missionsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.missionsToolStripMenuItem.Text = "Missions";
            // 
            // mission1ToolStripMenuItem
            // 
            this.mission1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.lesVisiteurToolStripMenuItem});
            this.mission1ToolStripMenuItem.Name = "mission1ToolStripMenuItem";
            this.mission1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mission1ToolStripMenuItem.Text = "Mission 1";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.ProfilToolStripMenuItem_Click);
            // 
            // lesVisiteurToolStripMenuItem
            // 
            this.lesVisiteurToolStripMenuItem.Name = "lesVisiteurToolStripMenuItem";
            this.lesVisiteurToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.lesVisiteurToolStripMenuItem.Text = "Les visiteurs";
            this.lesVisiteurToolStripMenuItem.Click += new System.EventHandler(this.LesVisiteurToolStripMenuItem_Click);
            // 
            // mission2ToolStripMenuItem
            // 
            this.mission2ToolStripMenuItem.Name = "mission2ToolStripMenuItem";
            this.mission2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mission2ToolStripMenuItem.Text = "Mission 2";
            this.mission2ToolStripMenuItem.Click += new System.EventHandler(this.Mission2ToolStripMenuItem_Click);
            // 
            // mission3ToolStripMenuItem
            // 
            this.mission3ToolStripMenuItem.Name = "mission3ToolStripMenuItem";
            this.mission3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mission3ToolStripMenuItem.Text = "Mission 3";
            this.mission3ToolStripMenuItem.Click += new System.EventHandler(this.Mission3ToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem missionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesVisiteurToolStripMenuItem;
    }
}

