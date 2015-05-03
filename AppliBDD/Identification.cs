using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassBDD;

namespace AppliBDD
{
    public partial class Identification : Form
    {
        public Identification()
        {
            InitializeComponent();
        }

        private void Identification_Load(object sender, EventArgs e)
        {
            //Desactivation de l'onglet saisie au demarrage
            //tabControl1.TabPages.Remove(tabSaisie);
            //Selection automatique de la zone de texte
            tbxIdUtilisateur.Select();
        }

        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            bool identification = Passerelle.connexionUtilisateur(tbxIdUtilisateur.Text, tbxIdPassword.Text);
            bool connexion = Passerelle.seConnecter();
            //Verification que les cases identifiant et mot de passe ne sont pas vides
            if (tbxIdUtilisateur.Text == "" || tbxIdPassword.Text == "")
            {
                MessageBox.Show("Veuillez remplir les deux cases");
            }
            //Verification de la saisie du bon nom d'utilisateur et du bon mot de passe
            else if (identification == false)
            {
                MessageBox.Show("Veuillez saisir les bons indentifiants");
            }
            //Verification de la connexion à la base de données
            else if (connexion == true)
            {
                this.Hide();
                MessageBox.Show("Connecté");

                GSB gsb = new GSB();
                gsb.Show();
            }
            else
            {
                MessageBox.Show("Deconnecté");
            }
            Passerelle.seDeconnecter();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
