using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBDD
{
    public class Visiteur
    {
        private int idVisiteur;
        private String nomVisiteur;
        private String prenomVisiteur;
        private DateTime dateEmbauche;
        private Produit competencePrincipale;
        private List<Produit> lesCompetencesAutres=null;

        //Le constructeur
        public Visiteur(int unIdVisteur, String unNomVisiteur, String unPrenomVisisteur, DateTime uneDateEmbauche, Produit uneCompetencePrincipale)
        {
            idVisiteur = unIdVisteur;
            nomVisiteur = unNomVisiteur;
            prenomVisiteur = unPrenomVisisteur;
            dateEmbauche = uneDateEmbauche;
            competencePrincipale = uneCompetencePrincipale;
            List<Produit> lesCompetencesAutres = new List<Produit>();
        }

        public Visiteur(String unNomVisiteur, String unPrenomVisisteur, DateTime uneDateEmbauche, Produit uneCompetencePrincipale)
        {
            nomVisiteur = unNomVisiteur;
            prenomVisiteur = unPrenomVisisteur;
            dateEmbauche = uneDateEmbauche;
            competencePrincipale = uneCompetencePrincipale;
            List<Produit> lesCompetencesAutres = new List<Produit>();
        }

        //Les accesseurs
        public int getIdVisiteur()
        {
            return this.idVisiteur;
        }

        public String getNomVisiteur()
        {
            return this.nomVisiteur;
        }

        public String getPrenomVisiteur()
        {
            return this.prenomVisiteur;
        }

        public DateTime getDateEmbauche()
        {
            return this.dateEmbauche;
        }

        public Produit getCompetencePrincipale()
        {
            return this.competencePrincipale;
        }

        public List<Produit> getAutresCompetences()
        {
            List<Produit> competencesAutres = new List<Produit>();
            foreach (Produit competenceAutre in lesCompetencesAutres)
            {
                competencesAutres.Add(competenceAutre);
            }
            return competencesAutres;
        }

        public bool ancienneteUnAnPlus()
        {
            bool resultat = false;
            TimeSpan dateTS = DateTime.Now.Subtract(dateEmbauche);
            if (dateTS.Days >= 365)
            {
                resultat = true;
            }
            return resultat;
        }

        public bool ajouterCompetence(Produit uneCompetence)
        {
            bool resultat = true;
            try
            {
                lesCompetencesAutres.Add(uneCompetence);
            }
            catch
            {
                resultat = false;
            }
            return resultat;
        }
    }
}
