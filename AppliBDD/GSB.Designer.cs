namespace AppliBDD
{
    partial class GSB
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
            this.lblNbProduits = new System.Windows.Forms.Label();
            this.lblNbVisiteur = new System.Windows.Forms.Label();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.tabSaisieTutorat = new System.Windows.Forms.TabPage();
            this.gbxTuteur = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxTuteurs = new System.Windows.Forms.ListBox();
            this.btnAnnulerTutorat = new System.Windows.Forms.Button();
            this.gbxVisiteur = new System.Windows.Forms.GroupBox();
            this.cbxCompetences = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValiderTutorat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.tbxNomVisiteur = new System.Windows.Forms.TextBox();
            this.tbxPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSaisieTutorat.SuspendLayout();
            this.gbxTuteur.SuspendLayout();
            this.gbxVisiteur.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNbProduits
            // 
            this.lblNbProduits.AutoSize = true;
            this.lblNbProduits.Location = new System.Drawing.Point(261, 600);
            this.lblNbProduits.Name = "lblNbProduits";
            this.lblNbProduits.Size = new System.Drawing.Size(35, 13);
            this.lblNbProduits.TabIndex = 6;
            this.lblNbProduits.Text = "label3";
            // 
            // lblNbVisiteur
            // 
            this.lblNbVisiteur.AutoSize = true;
            this.lblNbVisiteur.Location = new System.Drawing.Point(13, 600);
            this.lblNbVisiteur.Name = "lblNbVisiteur";
            this.lblNbVisiteur.Size = new System.Drawing.Size(35, 13);
            this.lblNbVisiteur.TabIndex = 5;
            this.lblNbVisiteur.Text = "label3";
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Location = new System.Drawing.Point(518, 600);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(35, 13);
            this.lblConnexion.TabIndex = 7;
            this.lblConnexion.Text = "label3";
            // 
            // tabSaisieTutorat
            // 
            this.tabSaisieTutorat.Controls.Add(this.gbxTuteur);
            this.tabSaisieTutorat.Controls.Add(this.btnAnnulerTutorat);
            this.tabSaisieTutorat.Controls.Add(this.gbxVisiteur);
            this.tabSaisieTutorat.Location = new System.Drawing.Point(4, 22);
            this.tabSaisieTutorat.Name = "tabSaisieTutorat";
            this.tabSaisieTutorat.Padding = new System.Windows.Forms.Padding(3);
            this.tabSaisieTutorat.Size = new System.Drawing.Size(760, 554);
            this.tabSaisieTutorat.TabIndex = 0;
            this.tabSaisieTutorat.Text = "Saisie Tutorat";
            this.tabSaisieTutorat.UseVisualStyleBackColor = true;
            // 
            // gbxTuteur
            // 
            this.gbxTuteur.Controls.Add(this.label6);
            this.gbxTuteur.Controls.Add(this.dateTimePicker2);
            this.gbxTuteur.Controls.Add(this.label5);
            this.gbxTuteur.Controls.Add(this.lbxTuteurs);
            this.gbxTuteur.Location = new System.Drawing.Point(385, 146);
            this.gbxTuteur.Name = "gbxTuteur";
            this.gbxTuteur.Size = new System.Drawing.Size(369, 349);
            this.gbxTuteur.TabIndex = 7;
            this.gbxTuteur.TabStop = false;
            this.gbxTuteur.Text = "Le Tuteur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date du tutorat";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(149, 134);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Les Tuteurs";
            // 
            // lbxTuteurs
            // 
            this.lbxTuteurs.FormattingEnabled = true;
            this.lbxTuteurs.Location = new System.Drawing.Point(149, 19);
            this.lbxTuteurs.Name = "lbxTuteurs";
            this.lbxTuteurs.Size = new System.Drawing.Size(200, 95);
            this.lbxTuteurs.TabIndex = 4;
            // 
            // btnAnnulerTutorat
            // 
            this.btnAnnulerTutorat.Location = new System.Drawing.Point(679, 524);
            this.btnAnnulerTutorat.Name = "btnAnnulerTutorat";
            this.btnAnnulerTutorat.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerTutorat.TabIndex = 6;
            this.btnAnnulerTutorat.Text = "Annuler";
            this.btnAnnulerTutorat.UseVisualStyleBackColor = true;
            // 
            // gbxVisiteur
            // 
            this.gbxVisiteur.Controls.Add(this.cbxCompetences);
            this.gbxVisiteur.Controls.Add(this.label4);
            this.gbxVisiteur.Controls.Add(this.btnValiderTutorat);
            this.gbxVisiteur.Controls.Add(this.label3);
            this.gbxVisiteur.Controls.Add(this.label2);
            this.gbxVisiteur.Controls.Add(this.label1);
            this.gbxVisiteur.Controls.Add(this.dtpDateEmbauche);
            this.gbxVisiteur.Controls.Add(this.tbxNomVisiteur);
            this.gbxVisiteur.Controls.Add(this.tbxPrenomVisiteur);
            this.gbxVisiteur.Location = new System.Drawing.Point(7, 146);
            this.gbxVisiteur.Name = "gbxVisiteur";
            this.gbxVisiteur.Size = new System.Drawing.Size(372, 349);
            this.gbxVisiteur.TabIndex = 3;
            this.gbxVisiteur.TabStop = false;
            this.gbxVisiteur.Text = "Le Visiteur";
            // 
            // cbxCompetences
            // 
            this.cbxCompetences.FormattingEnabled = true;
            this.cbxCompetences.Location = new System.Drawing.Point(150, 72);
            this.cbxCompetences.Name = "cbxCompetences";
            this.cbxCompetences.Size = new System.Drawing.Size(200, 21);
            this.cbxCompetences.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date d\'embauche";
            // 
            // btnValiderTutorat
            // 
            this.btnValiderTutorat.Location = new System.Drawing.Point(6, 320);
            this.btnValiderTutorat.Name = "btnValiderTutorat";
            this.btnValiderTutorat.Size = new System.Drawing.Size(75, 23);
            this.btnValiderTutorat.TabIndex = 5;
            this.btnValiderTutorat.Text = "Valider";
            this.btnValiderTutorat.UseVisualStyleBackColor = true;
            this.btnValiderTutorat.Click += new System.EventHandler(this.btnValiderTutorat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Compétence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // dtpDateEmbauche
            // 
            this.dtpDateEmbauche.Location = new System.Drawing.Point(150, 133);
            this.dtpDateEmbauche.Name = "dtpDateEmbauche";
            this.dtpDateEmbauche.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEmbauche.TabIndex = 0;
            // 
            // tbxNomVisiteur
            // 
            this.tbxNomVisiteur.Location = new System.Drawing.Point(150, 19);
            this.tbxNomVisiteur.Name = "tbxNomVisiteur";
            this.tbxNomVisiteur.Size = new System.Drawing.Size(200, 20);
            this.tbxNomVisiteur.TabIndex = 1;
            // 
            // tbxPrenomVisiteur
            // 
            this.tbxPrenomVisiteur.Location = new System.Drawing.Point(150, 45);
            this.tbxPrenomVisiteur.Name = "tbxPrenomVisiteur";
            this.tbxPrenomVisiteur.Size = new System.Drawing.Size(200, 20);
            this.tbxPrenomVisiteur.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSaisieTutorat);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 580);
            this.tabControl1.TabIndex = 4;
            // 
            // GSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 624);
            this.Controls.Add(this.lblConnexion);
            this.Controls.Add(this.lblNbProduits);
            this.Controls.Add(this.lblNbVisiteur);
            this.Controls.Add(this.tabControl1);
            this.Name = "GSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB";
            this.Load += new System.EventHandler(this.GSB_Load);
            this.tabSaisieTutorat.ResumeLayout(false);
            this.gbxTuteur.ResumeLayout(false);
            this.gbxTuteur.PerformLayout();
            this.gbxVisiteur.ResumeLayout(false);
            this.gbxVisiteur.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNbProduits;
        private System.Windows.Forms.Label lblNbVisiteur;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.TabPage tabSaisieTutorat;
        private System.Windows.Forms.GroupBox gbxTuteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxTuteurs;
        private System.Windows.Forms.Button btnAnnulerTutorat;
        private System.Windows.Forms.Button btnValiderTutorat;
        private System.Windows.Forms.GroupBox gbxVisiteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateEmbauche;
        private System.Windows.Forms.TextBox tbxNomVisiteur;
        private System.Windows.Forms.TextBox tbxPrenomVisiteur;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cbxCompetences;

    }
}