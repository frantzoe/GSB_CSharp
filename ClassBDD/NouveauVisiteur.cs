using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBDD
{
    public class NouveauVisiteur : Visiteur
    {
        private Visiteur leTuteur;
        private DateTime laDateDebut;
        
        public NouveauVisiteur(String unNomVisiteur, String unPrenomVisiteur, DateTime uneDateEmbauche, Produit uneCompetence, Visiteur unTuteur, DateTime uneDateDebut) : base (unNomVisiteur, unPrenomVisiteur, uneDateEmbauche, uneCompetence)
        {
            leTuteur = unTuteur;
            laDateDebut = uneDateDebut;
        }

        public Visiteur getLeTuteur()
        {
            return this.leTuteur;
        }

        public DateTime getLadateDebut()
        {
            return this.laDateDebut;
        }
    }
}
