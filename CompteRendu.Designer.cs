namespace PPE3_GSB_BalemrogV2
{
    partial class CompteRendu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPracticien = new System.Windows.Forms.ComboBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNumRapport = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgvPracticien = new System.Windows.Forms.DataGridView();
            this.bsPracticien = new System.Windows.Forms.BindingSource(this.components);
            this.dtpRapport = new System.Windows.Forms.DateTimePicker();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.bsOffrir = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffrir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapports de visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro rapport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Praticien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date rapport";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motif Visite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bilan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Offre d\'échantillons";
            // 
            // cboPracticien
            // 
            this.cboPracticien.FormattingEnabled = true;
            this.cboPracticien.Location = new System.Drawing.Point(138, 91);
            this.cboPracticien.Name = "cboPracticien";
            this.cboPracticien.Size = new System.Drawing.Size(121, 21);
            this.cboPracticien.TabIndex = 7;
            this.cboPracticien.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CboPracticien_Format);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(280, 89);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 8;
            this.btnDetail.Text = "Détails";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Précédent";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Suivant";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Nouveau";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(611, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Fermer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtNumRapport
            // 
            this.txtNumRapport.Location = new System.Drawing.Point(138, 57);
            this.txtNumRapport.Name = "txtNumRapport";
            this.txtNumRapport.Size = new System.Drawing.Size(100, 20);
            this.txtNumRapport.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 227);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 92);
            this.textBox4.TabIndex = 16;
            // 
            // dgvPracticien
            // 
            this.dgvPracticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticien.Location = new System.Drawing.Point(468, 169);
            this.dgvPracticien.Name = "dgvPracticien";
            this.dgvPracticien.Size = new System.Drawing.Size(240, 150);
            this.dgvPracticien.TabIndex = 17;
            // 
            // bsPracticien
            // 
            this.bsPracticien.CurrentChanged += new System.EventHandler(this.BsPracticien_CurrentChanged);
            // 
            // dtpRapport
            // 
            this.dtpRapport.Location = new System.Drawing.Point(138, 140);
            this.dtpRapport.Name = "dtpRapport";
            this.dtpRapport.Size = new System.Drawing.Size(200, 20);
            this.dtpRapport.TabIndex = 18;
            // 
            // bsRapport
            // 
            this.bsRapport.CurrentChanged += new System.EventHandler(this.BsRapport_CurrentChanged);
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(138, 186);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(121, 21);
            this.cboMotif.TabIndex = 19;
            // 
            // bsOffrir
            // 
            this.bsOffrir.CurrentChanged += new System.EventHandler(this.BsOffrir_CurrentChanged);
            // 
            // CompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMotif);
            this.Controls.Add(this.dtpRapport);
            this.Controls.Add(this.dgvPracticien);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtNumRapport);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.cboPracticien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompteRendu";
            this.Text = "CompteRendu";
            this.Load += new System.EventHandler(this.CompteRendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPracticien;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNumRapport;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgvPracticien;
        private System.Windows.Forms.BindingSource bsPracticien;
        private System.Windows.Forms.DateTimePicker dtpRapport;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.BindingSource bsOffrir;
    }
}