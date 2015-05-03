using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassBDD;

namespace AppliBDD
{
    class Procedures
    {
        public static void InfoBarMaj(Control lbl1, Control lbl2, Control lbl3)
        {
            lbl1.Text = "Nombre de Visiteurs : " + Passerelle.getNombreVisisiteurs();
            lbl2.Text = "Nombre de Produits : " + Passerelle.getNombreProduits();
            lbl3.Text = "Statut de Connexion : " + Procedures.statutConnexion();
        }

        public static String statutConnexion()
        {
            String resultat = "Connecté";
            if (Passerelle.seDeconnecter() == false)
            {
                resultat = "Deconnecté";
            }
            return resultat;
        }
    }
}
