using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
	class joueur
	{
		public static List<joueur> listeJoueur = new List<joueur>();

		private int numero;
		private string nom;
		private int pion;
		private int argent = 1500;
		private int position = 0;
		private int prisonnier = -1;
		private int carteLiberer = 0;
		private List<caseTerrain> terrain = new List<caseTerrain>();
		private List<caseGare> gare = new List<caseGare>();
		private List<caseCompagnie> compagnie = new List<caseCompagnie>();
		private bool faillite = false;
		private static int num = 0;
		public joueur(string nom, int pion)
		{
			this.nom = nom;
			this.pion = pion;
			listeJoueur.Add(this);
			this.numero = num;
			num++;
		}
		public string getNom()
		{
			return nom;
		}
		public void setNom(string nom)
		{
			this.nom = nom;
		}
		public int getNumero()
		{
			return numero;
		}
		public void setNumero(int numero)
		{
			this.numero = numero;
		}
		public int getPion()
		{
			return pion;
		}
		public void setPion(int pion)
		{
			this.pion = pion;
		}
		public int getArgent()
		{
			return argent;
		}
		public void setArgent(int argent)
		{
			this.argent = argent;
		}

		public void modifArgent(int somme)
		{
			this.argent += somme;
		}
		public int getPosition()
		{
			return position;
		}
		public void setPosition(int position)
		{
			this.position = position;
		}

		public void setTourPrisonnier()
		{
			this.prisonnier += 1;
		}

		public void sortirPrison()
		{
			this.prisonnier = -1;
		}
		public List<caseTerrain> getTerrain()
		{
			return terrain;
		}
		public void setTerrain()
		{
			this.terrain.Clear();
			foreach (caseTerrain c in caseTerrain.listeCaseTerrain)
			{
				if (c.getProprietaire() == this.numero)
				{
					this.terrain.Add(c);

				}
			}
		}
		public List<caseGare> getGare()
		{
			return gare;
		}
		public void setGare()
		{
			this.gare.Clear();
			foreach (caseGare c in caseGare.listeCaseGare)
			{
				if (c.getProprietaire() == this.numero)
				{
					this.gare.Add(c);
				}
			}
		}
		public List<caseCompagnie> getCompagnie()
		{
			return compagnie;
		}
		public void setCompagnie()
		{
			this.compagnie.Clear();
			foreach (caseCompagnie c in caseCompagnie.listeCaseCompagnie)
			{
				if (c.getProprietaire() == this.numero)
				{
					this.compagnie.Add(c);
				}
			}
		}

		public bool isFaillite()
		{
			return faillite;
		}
		public void setFaillite(bool faillite)
		{
			this.faillite = faillite;
		}

		public void changeSommeArgent(int somme)
		{
			this.argent += somme;
		}

		public int estPrisonnier()
		{
			return prisonnier;
		}

		public void passerDepart()
		{
			this.argent += 200;
		}

		public int getnbCarteLiberer()
		{
			return this.carteLiberer;
		}

		public void plusMoinsCarteLibeler(int i)
		{
			this.carteLiberer += i;
		}
		public List<joueur> getListeJoueur()
		{
			return listeJoueur;
		}

		public int getTotalPropriete()
		{
			int somme = 0;
			for (int i = 0; i < this.getTerrain().Count; i++)
			{
				if (!getTerrain()[i].getHypotheque())
				{
					somme += getTerrain()[i].getPrix();
				}
			}
			for (int i = 0; i < this.getGare().Count; i++)
			{
				if (!getGare()[i].getHypotheque())
				{
					somme += getGare()[i].getPrix();
				}
			}
			for (int i = 0; i < this.getCompagnie().Count; i++)
			{
				if (!getCompagnie()[i].getHypotheque())
				{
					somme += getCompagnie()[i].getPrix();
				}
			}
			return somme;

		}

		public int getTotalValeurMaisonHotel()
		{
			int somme = 0;
			for (int i = 0; i < this.getTerrain().Count; i++)
			{
				somme += getTerrain()[i].getValeurMaisonHotel();
			}
			return somme;
		}

		public void addTerrain(caseTerrain cas)
		{
			this.terrain.Add(cas);
		}

		public void removeTerrain(caseTerrain cas)
		{
			this.terrain.Remove(cas);
		}

		public void addGare(caseGare cas)
		{
			this.gare.Add(cas);
		}

		public void removeGare(caseGare cas)
		{
			this.gare.Remove(cas);
		}

		public void addCompagnie(caseCompagnie cas)
		{
			this.compagnie.Add(cas);
		}

		public void removeCompagnie(caseCompagnie cas)
		{
			this.compagnie.Remove(cas);
		}

		public List<caseTerrain> listeTerrainVide()
		{
			List<caseTerrain> liste = new List<caseTerrain>();
			foreach (caseTerrain c in terrain)
			{
				if (c.getNbConstruction() == 0)
				{
					liste.Add(c);
				}
			}
			return liste;
		}

		// liste de propriétés peuvent être hypothèque
		public List<int> listeTerrainVideEtGareEtCompagnie()
		{
			List<int> liste = new List<int>();
			foreach (caseTerrain c in listeTerrainVide())
			{
				if (!c.getHypotheque())
                {
					if(c.getFullColor() == 0)
                    {
						liste.Add(c.getIndexCase());
					}
                    else
                    {
						string couleur = c.getCouleur();
						int compteur = 0;
						foreach (caseTerrain cas in listeTerrainVide())
						{
							if (c.getCouleur() == couleur)
							{
								compteur++;
							}
						}
						if (((couleur == "marron" || couleur == "bleuFonce") && compteur == 2) || compteur == 3)
						{
							liste.Add(c.getIndexCase());
						}
					}
				}
					
			}
			foreach (caseGare g in gare)
			{
				if (!g.getHypotheque())
					liste.Add(g.getIndexCase());
			}
			foreach (caseCompagnie g in compagnie)
			{
				if (!g.getHypotheque())
					liste.Add(g.getIndexCase());
			}
			return liste;
		}

		// liste de propriétés peuvent être échangé
		public List<int> listeTousProprietes()
		{
			List<int> liste = new List<int>();
			foreach (caseTerrain c in listeTerrainVide())
			{
				liste.Add(c.getIndexCase());
			}
			foreach (caseGare g in gare)
			{
					liste.Add(g.getIndexCase());
			}
			foreach (caseCompagnie g in compagnie)
			{
					liste.Add(g.getIndexCase());
			}
			return liste;
		}
	}
}
