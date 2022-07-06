using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpPatternBuilder
{
    public class Tour
    {
        private String alimentation = "";
        private String carteMere = "";
        private String boitier = "";
        private String disqueDur = "";
        private String memoireRAM = "";
        private String carteGraphique = "";
        private String processeur = "";
        private String carteSon = "";

        public void setAlimentation(String alimentation) { this.alimentation = alimentation; }
        public void setCarteMere(String carteMere) { this.carteMere = carteMere; }
        public void setBoitier(String boitier) { this.boitier = boitier; }
        public void setDisqueDur(String disqueDur) { this.disqueDur = disqueDur; }
        public void setMemoireRAM(String memoireRAM) { this.memoireRAM = memoireRAM; }
        public void setCarteGraphique(String carteGraphique) { this.carteGraphique = carteGraphique; }
        public void setProcesseur(String processeur) { this.processeur = processeur; }
        public void setCarteSon(String carteSon) { this.carteSon = carteSon; }

        public void Informations()
        {
            Console.WriteLine("Tour creee : " + alimentation + ", " +
                carteMere + ", " + boitier + ", " + disqueDur + ", " +
                memoireRAM + ", " + carteGraphique + ", " + processeur + ", " +
                carteSon);
        }
    }

}
