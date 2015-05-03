using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassBDD
{
    public static class Passerelle
    {
        private static SqlConnection laConnexion;
        public static bool seConnecter()
        {
            bool ouvert = false;
            laConnexion = new SqlConnection();
            laConnexion.ConnectionString = "Data Source=Inspiron;Initial Catalog=BDDGSB;Integrated Security=True;MultipleActiveResultSets=True";
            laConnexion.Open();
            if (laConnexion.State == System.Data.ConnectionState.Open)
            {
                ouvert = true;
            }
            return ouvert;
        }

        public static bool seDeconnecter()
        {
            bool fermer = false;
            laConnexion.Close();
            if (laConnexion.State == System.Data.ConnectionState.Closed)
            {
                fermer = true;
            }
            return fermer;
        }

        public static bool connexionUtilisateur(String tbx1, String tbx2)
        {
            bool resultat = false;
            if (tbx1 == "admin" && tbx2 == "password")
            {
                resultat = true;
            }
            return resultat;
        }

        public static int getNombreVisisiteurs()
        {
            SqlCommand laCommande = new SqlCommand("PROC_NOMBREVISITEURS", laConnexion);
            laCommande.CommandType = CommandType.StoredProcedure;
            int nombre = (int)laCommande.ExecuteScalar();
            return nombre;
        }

        public static int getNombreProduits()
        {
            SqlCommand laCommande = new SqlCommand("PROC_NOMBREPRODUITS", laConnexion);
            laCommande.CommandType = CommandType.StoredProcedure;
            int nombre = (int)laCommande.ExecuteScalar();
            return nombre;
        }

        public static Produit getProduit(int unIdProduit)
        {
            Produit leProduit;
            SqlCommand laCommande = new SqlCommand("PROC_UNPRODUIT", laConnexion);
            laCommande.CommandType = CommandType.StoredProcedure;
            SqlParameter paramID = new SqlParameter("@unCode", SqlDbType.Int);
            paramID.Value = unIdProduit;
            laCommande.Parameters.Add(paramID);
            SqlParameter paramLibelle = new SqlParameter("@leLibel", SqlDbType.NVarChar, 50);
            paramLibelle.Direction = ParameterDirection.Output;
            laCommande.Parameters.Add(paramLibelle);
            laCommande.ExecuteNonQuery();
            if (paramLibelle.Value != DBNull.Value)
            {
                leProduit = new Produit(unIdProduit, (String)paramLibelle.Value);
            }
            else
            {
                leProduit = null;
            }
            return leProduit;
        }

        public static List<Produit> getLesProduits()
        {
            List<Produit> lesProduits = new List<Produit>();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = CommandType.Text;
            laCommande.CommandText = "SELECT * FROM T_PRODUITLABO";
            SqlDataReader leLecteur = laCommande.ExecuteReader();
            while (leLecteur.Read())
            {
                Produit unProduit = new Produit((int)leLecteur.GetValue(0), (String)leLecteur.GetValue(1));
                lesProduits.Add(unProduit);
            }
            leLecteur.Close();
            return lesProduits;
        }

        public static Visiteur getVisiteur(int unIDVisiteur)
        {
            Visiteur leVisiteur;
            SqlCommand laCommande = new SqlCommand("PROC_UNVISITEUR", laConnexion);
            laCommande.CommandType = CommandType.StoredProcedure;
            SqlParameter paramID = new SqlParameter("@unID", SqlDbType.Int);
            paramID.Value = unIDVisiteur;
            laCommande.Parameters.Add(paramID);
            SqlParameter paramNom = new SqlParameter("@unNom", SqlDbType.NVarChar, 50);
            paramNom.Direction = ParameterDirection.Output;
            laCommande.Parameters.Add(paramNom);
            SqlParameter paramPrenom = new SqlParameter("@unPrenom", SqlDbType.NVarChar, 75);
            paramPrenom.Direction = ParameterDirection.Output;
            laCommande.Parameters.Add(paramPrenom);
            SqlParameter paramDateEmbauche = new SqlParameter("@uneDate", SqlDbType.Date);
            paramDateEmbauche.Direction = ParameterDirection.Output;
            laCommande.Parameters.Add(paramDateEmbauche);
            SqlParameter paramCompetencePrincipale = new SqlParameter("@uneCompetence", SqlDbType.Int);
            paramCompetencePrincipale.Direction = ParameterDirection.Output;
            laCommande.Parameters.Add(paramCompetencePrincipale);
            laCommande.ExecuteNonQuery();
            Produit laCompetencePricipale = Passerelle.getProduit((int)paramCompetencePrincipale.Value);
            if (paramNom.Value != DBNull.Value)
            {
                leVisiteur = new Visiteur(unIDVisiteur, (String)paramNom.Value, (String)paramPrenom.Value, (DateTime)paramDateEmbauche.Value, laCompetencePricipale);
            }
            else
            {
                leVisiteur = null;
            }
            return leVisiteur;
        }

        

        public static bool estDisponible(Visiteur unVisiteur, DateTime uneDate)
        {
            bool resultat = true;
            List<Visiteur> unTuteuDisponible = new List<Visiteur>();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = CommandType.Text;
            laCommande.CommandText = "SELECT * FROM T_TUTORAT";
            SqlDataReader leLecteur = laCommande.ExecuteReader();
            while (leLecteur.Read() == true)
            {
                if((int)leLecteur.GetValue(1) == unVisiteur.getIdVisiteur())
                {

                }
            }
            return resultat;
        }

        public static List<Visiteur> getLesTuteurs(Produit unProduit, DateTime uneDateTut)
        {
            //List<Visiteur> lesVisiteurs = new List<Visiteur>();
            List<Visiteur> lesTuteurs = new List<Visiteur>();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = CommandType.Text;
            laCommande.CommandText = "SELECT * FROM T_VISITEUR WHERE VIS_COMPETENCEPRINCIPALE = " + unProduit.getId();
            SqlDataReader leLecteur = laCommande.ExecuteReader();
            while (leLecteur.Read() == true)
            {
                Visiteur leVisiteur = new Visiteur((int)leLecteur.GetValue(0), (String)leLecteur.GetValue(1), (String)leLecteur.GetValue(2), (DateTime)leLecteur.GetValue(3), unProduit);
                DateTime laDateEmbauche = (DateTime)leLecteur.GetValue(3);
                DateTime laDateEmbauchePlus1an = laDateEmbauche.AddYears(1);
                if (laDateEmbauchePlus1an < DateTime.Now && Passerelle.estDisponible(leVisiteur, uneDateTut) == true)
                {
                    lesTuteurs.Add(leVisiteur);
                }
            }
            leLecteur.Close();
            return lesTuteurs;
        }

        /*public static Visiteur getUnTuteur(Produit unProduit, DateTime uneDate)
        {
            Visiteur leVisiteur = null;
            Random visiteurAleatoir = new Random();
            int numIdAleatoire = visiteurAleatoir.Next(1, Passerelle.getNombreVisisiteurs());

            return leVisiteur;
        }

        public static bool ajouter(NouveauVisiteur unNouveauVisiteur)
        {
            bool resultat = true;

            try
            {
                
            }
            catch
            {

            }
            return resultat;
        }*/
        
    }
}
