using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class caseTerrain : casePropriete
    {
		public static List<caseTerrain> listeCaseTerrain = new List<caseTerrain>();

        private int loyerNu;
		private int loyerAvecGroupe;
        private int loyer1Maison;
        private int loyer2Maisons;
        private int loyer3Maisons;
        private int loyer4Maisons;
        private int loyerHotel;
        private String couleur;
        private int fullColor = 0 ;  
        private int nbConstruction = 0;
		private int prixMaison;
		public caseTerrain(int index, string nom, int prix, string couleur,
			int loyerNu, int loyer1Maison, int loyer2Maisons, int loyer3Maisons, int loyer4Maisons,
			int loyerHotel)
			: base(index, nom, prix,loyerNu)
        {
            this.couleur = couleur;
            this.loyerNu = loyerNu;
            this.loyer1Maison = loyer1Maison;
            this.loyer2Maisons = loyer2Maisons;
            this.loyer3Maisons = loyer3Maisons;
            this.loyer4Maisons = loyer4Maisons;
            this.loyerHotel = loyerHotel;
			this.loyerAvecGroupe = loyerNu * 2;
			if(couleur == "marron" || couleur == "bleuCiel") {
				this.prixMaison = 50;
			}
			else if (couleur == "rose" || couleur == "orange")
            {
				this.prixMaison = 100;
            }
			else if (couleur == "rouge" || couleur == "jaune")
			{
				this.prixMaison = 150;
			}
			else if (couleur == "vert" || couleur == "bleuFonce")
			{
				this.prixMaison = 200;
			}

			listeCaseTerrain.Add(this);
		}

		public int getLoyerNu()
		{
			return loyerNu;
		}
		public void setLoyerNu(int loyerNu)
		{
			this.loyerNu = loyerNu;
		}
		public int getLoyer1Maison()
		{
			return loyer1Maison;
		}
		public void setLoyer1Maison(int loyer1Maison)
		{
			this.loyer1Maison = loyer1Maison;
		}
		public int getLoyer2Maisons()
		{
			return loyer2Maisons;
		}
		public void setLoyer2Maisons(int loyer2Maisons)
		{
			this.loyer2Maisons = loyer2Maisons;
		}
		public int getLoyer3Maisons()
		{
			return loyer3Maisons;
		}
		public void setLoyer3Maisons(int loyer3Maisons)
		{
			this.loyer3Maisons = loyer3Maisons;
		}
		public int getLoyer4Maisons()
		{
			return loyer4Maisons;
		}
		public void setLoyer4Maisons(int loyer4Maisons)
		{
			this.loyer4Maisons = loyer4Maisons;
		}
		public int getLoyerHotel()
		{
			return loyerHotel;
		}
		public void setLoyerHotel(int loyerHotel)
		{
			this.loyerHotel = loyerHotel;
		}
		public String getCouleur()
		{
			return couleur;
		}

		public int getFullColor()
		{
			return fullColor;
		}
		public void aToutLeBloc()
		{
			this.fullColor = 1;
		}

		public void perdUnBoutDeCouleur()
        {
			this.fullColor = 0;
        }
		public int getNbConstruction()
		{
			return nbConstruction;
		}
		public void setNbConstruction(int nb)
		{
			this.nbConstruction = nb;
		}

		public int getValeurMaisonHotel()
        {
			return this.nbConstruction * this.prixMaison;
        }

		public List<caseTerrain> getListeCaseTerrain()
        {
			return listeCaseTerrain;
        }

		public int getPrixMaison()
        {
			return this.prixMaison;
        }

		public void setLoyer()
        {
			int somme;
            switch (nbConstruction)
            {
				case 1:
					somme = loyer1Maison;
					break;
				case 2:
					somme = loyer2Maisons;
					break;
				case 3:
					somme = loyer3Maisons;
					break;
				case 4:
					somme = loyer4Maisons;
					break;
				case 5:
					somme = loyer4Maisons;
					break;
				default:
					somme = loyerNu;
					break;
            }
			base.setLoyer(somme);
        }
	}
}
