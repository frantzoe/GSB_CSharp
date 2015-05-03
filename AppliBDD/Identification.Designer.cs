namespace AppliBDD
{
    partial class Identification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identification));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.gbxIndentification = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIdPassword = new System.Windows.Forms.TextBox();
            this.tbxIdUtilisateur = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxIndentification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utilisateur";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(6, 125);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(79, 24);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click_1);
            // 
            // gbxIndentification
            // 
            this.gbxIndentification.BackColor = System.Drawing.Color.White;
            this.gbxIndentification.Controls.Add(this.btnAnnuler);
            this.gbxIndentification.Controls.Add(this.label2);
            this.gbxIndentification.Controls.Add(this.label1);
            this.gbxIndentification.Controls.Add(this.btnConnexion);
            this.gbxIndentification.Controls.Add(this.tbxIdPassword);
            this.gbxIndentification.Controls.Add(this.tbxIdUtilisateur);
            this.gbxIndentification.Location = new System.Drawing.Point(121, 293);
            this.gbxIndentification.Name = "gbxIndentification";
            this.gbxIndentification.Size = new System.Drawing.Size(238, 155);
            this.gbxIndentification.TabIndex = 3;
            this.gbxIndentification.TabStop = false;
            this.gbxIndentification.Text = "Identification";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(153, 125);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(79, 24);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de Passe";
            // 
            // tbxIdPassword
            // 
            this.tbxIdPassword.Location = new System.Drawing.Point(100, 76);
            this.tbxIdPassword.Name = "tbxIdPassword";
            this.tbxIdPassword.PasswordChar = '●';
            this.tbxIdPassword.Size = new System.Drawing.Size(125, 20);
            this.tbxIdPassword.TabIndex = 1;
            // 
            // tbxIdUtilisateur
            // 
            this.tbxIdUtilisateur.Location = new System.Drawing.Point(100, 35);
            this.tbxIdUtilisateur.Name = "tbxIdUtilisateur";
            this.tbxIdUtilisateur.Size = new System.Drawing.Size(125, 20);
            this.tbxIdUtilisateur.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 215);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Identification
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(480, 474);
            this.Controls.Add(this.gbxIndentification);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Identification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identification";
            this.Load += new System.EventHandler(this.Identification_Load);
            this.gbxIndentification.ResumeLayout(false);
            this.gbxIndentification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.GroupBox gbxIndentification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIdPassword;
        private System.Windows.Forms.TextBox tbxIdUtilisateur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnnuler;
    }
}