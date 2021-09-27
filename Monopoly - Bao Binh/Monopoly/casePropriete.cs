using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class casePropriete : caseTableau
    {
		private static List<casePropriete> listeCasePropriete = new List<casePropriete>();

		private string nom;
        private int prix;
        private bool estAchete = false;
		private int proprietaire = -1;
		private int loyer;
		private bool hypotheque = false;


		public casePropriete(int indexPropriete, int loyer)
			:base(indexPropriete)
        {
            this.loyer = loyer;
			listeCasePropriete.Add(this);
		}

		public casePropriete(int id, string nom , int prix, int loyer)
			:base(id)
			{
			this.nom = nom;
			this.prix = prix;
			this.loyer = loyer;
        }

		public string getNom()
        {
			return this.nom;
        }

		public int getPrix()
        {
			return this.prix;
        }

		public bool isEstAchete()
		{
			return estAchete;
		}
		public void setEstAchete(bool estAchete)
		{
			this.estAchete = estAchete;
		}

		public int getProprietaire()
		{
			return proprietaire;
		}
		public void setProprietaire(int proprietaire)
		{
			this.proprietaire = proprietaire;
		}
		public int getLoyer()
		{
			return loyer;
		}
		public void setLoyer(int loyer)
		{
			this.loyer = loyer;
		}

		public void estAQuelquun(int idJouer)
        {
			this.estAchete = true;
			this.proprietaire = idJouer;
		}
		
		public List<casePropriete> getListeCaseProprietes()
        {
			return listeCasePropriete;
        }

		public bool getHypotheque()
        {
			return hypotheque;
        }

		public void setHypotheque(bool hypo)
        {
			this.hypotheque = hypo;
        }
	}
}
