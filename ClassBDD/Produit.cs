using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBDD
{
    public class Produit
    {
        private int idProduit;
        private String libelleProduit;

        //Le constructeur
        public Produit(int unId, String unLibelle)
        {
            idProduit = unId;
            libelleProduit = unLibelle;
        }

        //
        public int getId()
        {
            return this.idProduit;
        }

        //
        public String getLibelle()
        {
            return this.libelleProduit;
        }
    }
}
