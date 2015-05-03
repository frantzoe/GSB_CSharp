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
    public partial class GSB : Form
    {
        Produit unProduit;
        public GSB()
        {
            InitializeComponent();
        }

        private void GSB_Load(object sender, EventArgs e)
        {
            
            //Mise à jour de l'infobar
            Procedures.InfoBarMaj(lblNbVisiteur, lblNbProduits, lblConnexion);
            dtpDateEmbauche.MinDate = DateTime.Now;
            dtpDateEmbauche.CustomFormat = "yyyy";
            Passerelle.seConnecter();
            foreach (Produit unProd in Passerelle.getLesProduits())
            {
                cbxCompetences.Items.Add("ID : " + unProd.getId().ToString() + ", Libellé : " + unProd.getLibelle());
            }
            //lbxTuteurs.Items.Add(Passerelle.getVisiteur(1000).getNomVisiteur() + " " + Passerelle.getVisiteur(1000).getPrenomVisiteur());
            String lesTut = "";
            foreach (Visiteur unVis in Passerelle.getLesTuteurs(Passerelle.getProduit(1009), DateTime.Now))
            {
                lesTut = lesTut + (unVis.getNomVisiteur() + " " + unVis.getPrenomVisiteur() + Environment.NewLine);
            }
            lbxTuteurs.Items.Add(lesTut);
            MessageBox.Show(lesTut);
            Passerelle.seDeconnecter();

        }

        private void btnValiderTutorat_Click(object sender, EventArgs e)
        {
            Passerelle.seConnecter();
            //if ()
            /*tbxNomVisiteur.Enabled = false;
            tbxPrenomVisiteur.Enabled = false;
            tbxCompetenceVisiteur.Enabled = false;*/
            foreach (Produit unProd in Passerelle.getLesProduits())
            {
                cbxCompetences.Items.Add(unProd.getLibelle());
            }
            Passerelle.seDeconnecter();
        }
    }
}
