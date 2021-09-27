using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    class mono
    {
        public int joueurEnCours;
        private int nbMaisonDispo = 32;
        private int nbHotelDispo = 12;
        private int nbDesDouble = 0;
        private int lancePourCalculerLeLoyerDuService = 0;
        private bool idem = false;
        private List<joueur> listeJoueur = new List<joueur>();
        private List<caseTableau> listeCaseTableau;
        private Random rnd = new Random();
        private Button finDuTour;
        private Button lancerDes;
        private PictureBox boxDes1;
        private PictureBox boxDes2;
        private ImageList desListImage;
        private Panel panel1;
        private Panel panelJoueur;
        private Panel panelPlateau;
        private Label lblJoueurEncours;
        private Button echange;
        private Button hypotheque;
        private Button acheterM;
        private Button vendreM;
        private Label nbMaison;
        private Label nbHotel;

        //Création des cases terrain + un tableau pour chaque couleur pour utilisation dans des procedures

        //Marron
        private static caseTerrain blvDeBelleville;
        private static caseTerrain rueLecourbe;
        //Terrains de couleur marron dans un tableau
        private caseTerrain[] terrainMarron = new caseTerrain[2] { blvDeBelleville, rueLecourbe };

        //Bleu ciel
        private static caseTerrain rueDeVaugirard;
        private static caseTerrain rueDeCourcelles;
        private static caseTerrain avenueDeLaRepublique;
        //Terrains de couleur bleu ciel dans un tableau
        private caseTerrain[] terrainBleuCiel = new caseTerrain[3] { rueDeVaugirard, rueDeCourcelles, avenueDeLaRepublique };

        //Rose
        private static caseTerrain blvDeLaVilette;
        private static caseTerrain avenueDeNeuilly;
        private static caseTerrain rueDeParadis;
        //Terrains de couleur rose dans un tableau
        private caseTerrain[] terrainRose = new caseTerrain[3] { blvDeLaVilette, avenueDeNeuilly, rueDeParadis };

        //Orange
        private static caseTerrain avenueMozart;
        private static caseTerrain blvSaintMichel;
        private static caseTerrain placePigalle;
        //Terrains de couleur orange dans un tableau
        private caseTerrain[] terrainOrange = new caseTerrain[3] { avenueMozart, blvSaintMichel, placePigalle };

        //Rouge
        private static caseTerrain avenueMatignon;
        private static caseTerrain blvMalesherbes;
        private static caseTerrain avenueHenriMartin;
        //Terrains de couleur rouge dans un tableau
        private caseTerrain[] terrainRouge = new caseTerrain[3] { avenueMatignon, blvMalesherbes, avenueHenriMartin };

        //Jaune 
        private static caseTerrain faubourgSaintHonore;
        private static caseTerrain placeDeLaBourse;
        private static caseTerrain rueLafayette;
        //Terrains de couleur jaune dans un tableau
        private caseTerrain[] terrainJaune = new caseTerrain[3] { faubourgSaintHonore, placeDeLaBourse, rueLafayette };

        //Vert
        private static caseTerrain avenueDeBreteuil;
        private static caseTerrain avenueFoch;
        private static caseTerrain boulevardDesCapicines;
        //Terrains de couleur vert dans un tableau
        private caseTerrain[] TerrainVert = new caseTerrain[3] { avenueDeBreteuil, avenueFoch, boulevardDesCapicines };

        //bleuFonce
        private static caseTerrain avenueChampsElysees;
        private static caseTerrain rueDeLaPaix;
        //Terrains de couleur bleuFonce dans un tableau
        private caseTerrain[] TerrainBleuFonce = new caseTerrain[2] { avenueChampsElysees, rueDeLaPaix };

        //Les gares
        private static caseGare gareMontparnasse;
        private static caseGare gareDeLyon;
        private static caseGare gareDuNord;
        private static caseGare gareSaintLazare;
        //rangées dans un meme tableau pour utilisation dans des procédures
        private caseGare[] tabGare = new caseGare[4] { gareMontparnasse, gareDeLyon, gareDuNord, gareSaintLazare };

        //Les compagnies services public
        private static caseCompagnie serviceElectricite;
        private static caseCompagnie serviceDesEaux;
        private caseCompagnie[] compagnieService = new caseCompagnie[2] { serviceElectricite, serviceDesEaux };

        //Les cases simples 
        private static caseSimple depart = new caseSimple(0, 200);
        private static caseSimple prison = new caseSimple(10);
        private static caseSimple parc = new caseSimple(20);
        private static caseSimple allerEnPrison = new caseSimple(30);
        private static caseSimple impotsRevenu = new caseSimple(4, -200);
        private static caseSimple taxDeLuxe = new caseSimple(38, -100);
        private static caseSimple chance1 = new caseSimple(7);
        private static caseSimple chance2 = new caseSimple(22);
        private static caseSimple chance3 = new caseSimple(36);
        private static caseSimple communaute1 = new caseSimple(2);
        private static caseSimple communaute2 = new caseSimple(17);
        private static caseSimple communaute3 = new caseSimple(33);

        private caseSimple[] tabSimple = new caseSimple[12] { depart,prison, parc, allerEnPrison,
        impotsRevenu, taxDeLuxe , chance1,chance2, chance3, communaute1, communaute2,communaute3};

        //Toutes les cases terrain dans le meme tableau
        private caseTerrain[] tabTerrain = new caseTerrain[] { blvDeBelleville, rueLecourbe, rueDeVaugirard,
            rueDeCourcelles, avenueDeLaRepublique, blvDeLaVilette, avenueDeNeuilly, rueDeParadis,
            avenueMozart, blvSaintMichel, placePigalle, avenueMatignon, blvMalesherbes,
            avenueHenriMartin, faubourgSaintHonore, placeDeLaBourse, rueLafayette, avenueDeBreteuil,
            avenueFoch, boulevardDesCapicines, avenueChampsElysees, rueDeLaPaix };


        //Toutes les cases cartes dans le meme tableau 
        public static caseTableau[] tabPlateau = new caseTableau[] { depart, blvDeBelleville, communaute1,
            rueLecourbe, impotsRevenu, gareMontparnasse, rueDeVaugirard, chance1, rueDeCourcelles,
            avenueDeLaRepublique, prison, blvDeLaVilette, serviceElectricite, avenueDeNeuilly,
            rueDeParadis, gareDeLyon, avenueMozart, communaute3, blvSaintMichel, placePigalle,
            parc, avenueMatignon, chance2, blvMalesherbes, avenueHenriMartin, gareDuNord,
            faubourgSaintHonore, placeDeLaBourse, serviceDesEaux, rueLafayette, allerEnPrison,
            avenueDeBreteuil, avenueFoch, communaute3, boulevardDesCapicines, gareSaintLazare,
            chance3, avenueChampsElysees, taxDeLuxe, rueDeLaPaix };

        //=========Carte chance==============
        //Type Identifications :
        //'P' = Payer 
        //'C' = Crédit de la banque
        //'D' = Avancer au départ
        //'J' = Aller en prison
        //'L' = Libérer de prison
        //'G' = Déplacer

        //Carte chance payer
        private static carteChance payerAmendeVitesseChance = new carteChance("P", 15, "Amende pour excès de vitesse (en vélo) : 15 euros");
        private static carteChance payerFraisChance = new carteChance("P", 150, "Payez les frais de scolarité de votre enfant pour l'inscription à l'école : 150 euros");
        private static carteChance payerAmendeIvresseChance = new carteChance("P", 20, "Amende pour ivresse un vendredi de fin d'année: 20 euros");

        //Carte chance crédit
        private static carteChance recevoirDividendeChance = new carteChance("C", 50, "La banque vous verse un dividende de 50 euros");
        private static carteChance recevoirImmeubleChance = new carteChance("C", 150, "Le binaire est constitué de 10 chiffre, vous avez comprit\n Vous recevez 150 euros");
        private static carteChance recevoirPrixChance = new carteChance("C", 100, "Gagnez un prix de 100 euros");

        //Carte de déplacement
        private static carteChance goToLyonChance = new carteChance("G", 15, "Téléportation à la gare de Lyon, si vous passez par la case Départ alors vous recevez 200 euros");
        private static carteChance goToViletteChance = new carteChance("G", 11, "Téléportation au Boulevard de la Vilette, si vous passez par la case Départ alors vous recevez 200 euros");

        //Carte aller prison
        private static carteChance allerPrisonChance = new carteChance("J", 10, "Téléportation en prison");
        //Carte aller départ
        private static carteChance allerDepartChance = new carteChance("D", 0, "Téléportation sur la case Départ, 200 euros dans votre poche");
        //Carte liberation
        private static carteChance liberationChance = new carteChance("L", 0, "Acquisition d'un bon de sortie de prison");

        private carteChance[] tabCarteChance = new carteChance[] { payerAmendeVitesseChance, payerFraisChance,
            payerAmendeIvresseChance, recevoirDividendeChance, recevoirImmeubleChance, recevoirPrixChance,
            goToLyonChance, goToViletteChance, allerPrisonChance, allerDepartChance, liberationChance };

        //==============Carte de communauté===================
        //Type Identifications :
        //'P' = Payer 
        //'C' = Crédit de la banque
        //'D' = Avancer au départ
        //'J' = Aller en prison
        //'L' = Libérer de prison
        //'G' = Déplacer

        //Carte communaute Debit 
        private static carteCommunaute payerPise = new carteCommunaute("P", 50, "Payer le frais de l'insription scolaire : 50 euros");
        private static carteCommunaute payerAssurance = new carteCommunaute("P", 50, "Payer l'assurance obligatoire : 50 euros");
        private static carteCommunaute payerHopital = new carteCommunaute("P", 100, "Payer un passage à l'hopital Diderot : 100 euros");

        //Carte de credit
        private static carteCommunaute recevoirDeLaBanque = new carteCommunaute("C", 200, "Erreure de la banque en votre faveur, vous recevez 200 euros");
        private static carteCommunaute recevoirStock = new carteCommunaute("C", 50, "La vente de votre stock vous rapporte 50 euros");
        private static carteCommunaute recevoirRevenu = new carteCommunaute("C", 100, "Recevez votre revenu annuel de 100 euros");
        private static carteCommunaute recevoirPrixBeaute = new carteCommunaute("C", 10, "Vous avez gagné le deuxième Prix de Beauté, recevez 10 euros");
        private static carteCommunaute recevoirAnniversaire = new carteCommunaute("C", 10, "C'est votre anniversaire : vous recevez 10 euros");

        //Carte aller en prison
        private static carteCommunaute allerPrisonCommunaute = new carteCommunaute("J", 0, "Téléportation en prison");

        //Carte aller depart
        private static carteCommunaute allerDepartCommunaute = new carteCommunaute("D", 0, "Téléportation sur la case Départ, 200 euros dans votre poche");

        //Carte sortir de prison
        private static carteCommunaute bonDeSortieCommunaute = new carteCommunaute("L", 0, "Acquisition d'un bon de sortie de prison");

        //Tableau des cartes communauté
        private carteCommunaute[] tabCarteCommunaute = new carteCommunaute[] { payerPise, payerAssurance, payerHopital, recevoirDeLaBanque, recevoirStock, recevoirRevenu, recevoirPrixBeaute, recevoirAnniversaire, allerPrisonCommunaute, allerDepartCommunaute, bonDeSortieCommunaute };


        internal List<caseTableau> ListeCaseTableau { get => listeCaseTableau; set => listeCaseTableau = value; }

        #region Initialize
        /// <summary>
        /// contructeur
        /// </summary>
        public mono(Panel panel1, Panel panelPlateau, Panel panelButton,
            ImageList pionListImage, Button echange, Button hypotheque, Button acheterM, Button vendreM,
            Button finDuTour, Panel panelDes, PictureBox boxDes1, PictureBox boxDes2, Button lancerDes,
            ImageList desListImage, Panel panelJoueur, ImageList bgJoueurListe, List<joueur> listeJoueurs,
            Label lblJoueurEncours, Label nbMaison, Label nbHotel)
        {
            this.panel1 = panel1;
            this.panelJoueur = panelJoueur;
            this.panelPlateau = panelPlateau;
            this.finDuTour = finDuTour;
            this.lancerDes = lancerDes;
            this.boxDes1 = boxDes1;
            this.boxDes2 = boxDes2;
            this.desListImage = desListImage;
            this.listeJoueur = listeJoueurs;
            this.joueurEnCours = 0;
            this.lblJoueurEncours = lblJoueurEncours;
            this.echange = echange;
            this.hypotheque = hypotheque;
            this.acheterM = acheterM;
            this.vendreM = vendreM;
            this.nbMaison = nbMaison;
            this.nbHotel = nbHotel;

            initPlateau();
            changeJoueur();
        }

        //Affiche maison ou hotel si construction en fin de tour au dessus de la case correspondante
        public void affichageMaisonHotel()
        {
            foreach (caseTerrain c in tabTerrain)
            {
                Label l = (Label)panelPlateau.Controls[c.getIndexCase()].Controls[0];
                //Affichage ligne
                if (c.getIndexCase() > 0 && c.getIndexCase() < 10 || c.getIndexCase() > 20 && c.getIndexCase() < 30)
                {
                    if (c.getNbConstruction() == 5)
                        l.Text = "H";
                    else if (c.getNbConstruction() == 4)
                        l.Text = "M M M M";
                    else if (c.getNbConstruction() == 3)
                        l.Text = "M M M";
                    else if (c.getNbConstruction() == 2)
                        l.Text = "M M";
                    else if (c.getNbConstruction() == 1)
                        l.Text = "M";
                    else if (c.getNbConstruction() == 0)
                        l.Text = "";
                }
                //Affichage colonne
                else
                {
                    if (c.getNbConstruction() == 5)
                        l.Text = "H";
                    else if (c.getNbConstruction() == 4)
                        l.Text = "M\nM\nM\nM";
                    else if (c.getNbConstruction() == 3)
                        l.Text = "M\nM\nM";
                    else if (c.getNbConstruction() == 2)
                        l.Text = "M\nM";
                    else if (c.getNbConstruction() == 1)
                        l.Text = "M";
                    else if (c.getNbConstruction() == 0)
                        l.Text = "";
                }
            }

        }

        // lier les événements 
        public void lierEvenement()
        {
            this.finDuTour.Click += new EventHandler(btnFinTourClic);
            this.lancerDes.Click += new EventHandler(lancerDes_Click);
            this.echange.Click += new EventHandler(clicBtnEchange);
        }

        /// cliquer sur le bouton FIN DU TOUR pour finir le tour 
        private void btnFinTourClic(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            setJoueurEnCours(); // joueur prochain
            if (joueurRestant() > 1)
            {
                //s'il est en prison
                if (listeJoueur[joueurEnCours].estPrisonnier() >= 0)
                {
                    listeJoueur[joueurEnCours].setTourPrisonnier(); // augmenter 1
                    if (listeJoueur[joueurEnCours].estPrisonnier() > 3) // 3 tours: obliger de payer 50€ 
                    {
                        dlgMessage dlg = new dlgMessage("PAYER 50€ POUR SORTIR DE PRISON", "Vous devrez payer cette fois pour sortir de prison !");
                        dlg.ShowDialog();
                        payerSortirPrison();
                    }
                    else  // choisir la facon pr sortir de prison
                    {
                        bool carteGratuit = false;
                        bool assezArgent = false;
                        if (listeJoueur[joueurEnCours].getnbCarteLiberer() > 0)
                        {
                            carteGratuit = true;
                        }
                        if (listeJoueur[joueurEnCours].getArgent() > 50)
                        {
                            assezArgent = true;
                        }
                        DialogResult result;
                        dlgPrison dlg = new dlgPrison(carteGratuit, assezArgent);  // form 3 choix
                        result = dlg.ShowDialog();
                        if (result == DialogResult.Yes) // rouler double des
                        {
                            lancerDes.Enabled = true;
                            boxDes1.Image = desListImage.Images[0];
                            boxDes2.Image = desListImage.Images[0];
                        }
                        else if (result == DialogResult.No)  // choisir payer 50 pr sortir de la prison
                        {
                            payerSortirPrison();
                        }
                        else                                    // utiliser la carte libérer de prison
                        {
                            listeJoueur[joueurEnCours].sortirPrison();
                            listeJoueur[joueurEnCours].plusMoinsCarteLibeler(-1);
                            changeJoueur();
                        }
                    }
                }
                else
                {
                    changeJoueur();
                }

                btn.Enabled = false;
                nbDesDouble = 0;
            }
            else
            {
                EndGame();
            }
        }

        public void isEndGame()
        {
            DialogResult res;
            formFinirPartie fini = new formFinirPartie(joueurEnCours);
            res = fini.ShowDialog();
            if (res == DialogResult.Yes)
            {
                Form1 unPartie = new Form1();
                unPartie.Show();
            }
            else
            {
                Form4 entre = new Form4();
                entre.Show();
            }
        }
        public int joueurRestant()
        {
            int nbRestant = 0;
            foreach (joueur j in listeJoueur)
            {
                if (!j.isFaillite())
                {
                    nbRestant += 1;
                }
            }
            return nbRestant;
        }
        public void payerSortirPrison()
        {
            listeJoueur[joueurEnCours].sortirPrison();
            listeJoueur[joueurEnCours].modifArgent(-50);
            changeJoueur();
        }

        //Lancement d'un tour dés
        private void lancerDes_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // lancer des des 1 seule fois
            lancerDes.Enabled = false;

            finDuTour.Enabled = true;
            //random le résultat des dés 
            int resultat = tirageDes();
            if (listeJoueur[joueurEnCours].estPrisonnier() >= 0)  // en prison et tenter double des 
            {
                if (nbDesDouble == 0)
                {
                    dlgMessage dlg = new dlgMessage("Pas de chance", "Vous restez en prison !");
                    dlg.ShowDialog();
                }
                else
                {
                    nbDesDouble = 0;
                    dlgMessage d = new dlgMessage("Yeahhh", "Vous est sorti de la prison !");
                    d.ShowDialog();
                    lancerDes.Enabled = true;
                    finDuTour.Enabled = false;
                    listeJoueur[joueurEnCours].sortirPrison();
                }
            }
            // si le joueur n'est pas en prison et le nombre de des doubles < 3, jouer standard
            else if (nbDesDouble < 3)
            {
                loadPion(listeJoueur[joueurEnCours].getPosition(), resultat);
                int pos = listeJoueur[joueurEnCours].getPosition();

                entrerDansUnCas(pos);
            }
            else if (nbDesDouble == 3)   // 3 fois double dés ,aller en prison
            {
                deplacementRapide(listeJoueur[getJoueurEnCours()].getPosition(), 10);
                nbDesDouble = 0;
            }



        }


        // lancer les dés et afficher le résultat
        public int tirageDes()
        {
            idem = false;
            int lanceeUn = rnd.Next(1, 7);
            int lanceeDeux = rnd.Next(1, 7);
            //int lanceeUn = 4;
            //int lanceeDeux = 4;

            //Affichage des images des dés dans les picturebox
            boxDes1.Image = desListImage.Images[lanceeUn - 1];
            boxDes2.Image = desListImage.Images[lanceeDeux - 1];

            int resultat = lanceeUn + lanceeDeux;

            //Au cas ou le joueur arrive sur une case de service public
            lancePourCalculerLeLoyerDuService = resultat;

            Convert.ToString(resultat);
            dlgMessage dlg = new dlgMessage("LANCER DES", "Vous avez fait " + resultat);
            dlg.ShowDialog();

            idem = lanceeUn == lanceeDeux;
            if (idem)
            {
                nbDesDouble++;
                if (nbDesDouble < 3)
                {
                    if (listeJoueur[joueurEnCours].estPrisonnier() != -1)
                    {
                        finDuTour.Enabled = false;
                        lancerDes.Enabled = true;
                    }
                    else
                    {
                        dlgMessage info = new dlgMessage("Doubles dés", "Vous avez encore un tour !");
                        info.ShowDialog();
                        finDuTour.Enabled = false;
                        lancerDes.Enabled = true;
                    }
                }
                else if (nbDesDouble == 3)
                {
                    dlgMessage prison = new dlgMessage("TROIS FOIS DOUBLE", "Ops !!! \n Vous allez en prison !");
                    prison.ShowDialog();
                    listeJoueur[joueurEnCours].setTourPrisonnier();
                }
            }
            return resultat;
        }

        //Afficher la position de pion
        public void loadPion(int posAncien, int pas)
        {
            int posNouvelle = (posAncien + pas) % 39;
            Panel a = (Panel)panelPlateau.Controls[posAncien];
            int ecart = a.Controls.Count - listeJoueur.Count;
            a.Controls[joueurEnCours + ecart].Visible = false;
            Panel n = (Panel)panelPlateau.Controls[posNouvelle];
            ecart = n.Controls.Count - listeJoueur.Count;
            n.Controls[joueurEnCours + ecart].Visible = true;
            listeJoueur[joueurEnCours].setPosition(posNouvelle);
            passerDepart(posAncien, (posAncien + pas) % 39);
        }

        //Téléportation : mise à jour la position et le pion
        public void deplacementRapide(int posAncien, int cible)
        {
            Panel a = (Panel)panelPlateau.Controls[posAncien];
            int ecart = a.Controls.Count - listeJoueur.Count;
            a.Controls[getJoueurEnCours() + ecart].Visible = false;
            Panel n = (Panel)panelPlateau.Controls[cible];
            ecart = n.Controls.Count - listeJoueur.Count;
            n.Controls[getJoueurEnCours() + ecart].Visible = true;
            listeJoueur[getJoueurEnCours()].setPosition(cible);
            passerDepart(posAncien, cible);
        }

        // recevoir 200€ quand on passe le cas départ , sauf aller en prison
        public void passerDepart(int posAncien, int cible)
        {
            if (posAncien > cible)
            {
                if (cible != 10)
                {
                    dlgMessage m = new dlgMessage("SALAIRE", "Vous recevez 200 €");
                    m.ShowDialog();
                    listeJoueur[joueurEnCours].modifArgent(+200);
                }
            }
        }


        private bool isEndGame(Button btn)
        {
            return false;
        }

        /// Changer le joueur:mise à jour l'écran
        public void changeJoueur()
        {
            lancerDes.Enabled = true;
            nbDesDouble = 0;
            boxDes1.Image = desListImage.Images[0];
            boxDes2.Image = desListImage.Images[0];
            lblJoueurEncours.Text = "A " + listeJoueur[joueurEnCours].getNom().ToUpper() + " DE JOUER";
            echange.Visible = pouvoirEchange(listeJoueur[joueurEnCours]);
            hypotheque.Visible = pouvoirHypotheque(listeJoueur[joueurEnCours]);
            acheterM.Visible = pouvoirAchatM(listeJoueur[joueurEnCours]);
            vendreM.Visible = pouvoirVenteM(listeJoueur[joueurEnCours]);
        }
        #endregion


        //capable échanger des propriétés
        public bool pouvoirEchange(joueur j)
        {
            bool echange = false;
            if (j.listeTerrainVideEtGareEtCompagnie().Count > 0)
            {
                echange = true;
            }
            return echange;
        }

        //capable hypothèque des propriétés
        public bool pouvoirHypotheque(joueur j)
        {
            bool hypo = false;
            if (j.listeTerrainVide().Count > 0 || j.getGare().Count > 0 || j.getCompagnie().Count > 0)
            {
                hypo = true;
            }
            return hypo;
        }

        // liste des terrains vide d'un joueur
        /*
        public List<caseTerrain> listeTerrainVide(joueur j){
            List<caseTerrain> liste = new List<caseTerrain>();
            foreach(caseTerrain c in j.getTerrain()){
                if(c.getNbConstruction()=0){
                    liste.Add(c)
                }
            }
            return liste;
        }*/

        // liste des terrains ou on peut encore contruire des maison
        public List<caseTerrain> listeTerrainContruit(joueur j)
        {
            List<caseTerrain> liste = new List<caseTerrain>();
            foreach (caseTerrain c in j.getTerrain())
            {
                if (c.getNbConstruction() < 5 && c.getFullColor() == 1)
                {
                    liste.Add(c);
                }
            }
            return liste;
        }

        //capable acheter des maisons
        public bool pouvoirAchatM(joueur j)
        {
            bool achat = false;
            if (listeTerrainContruit(j).Count > 0)
            {
                achat = true;
            }
            return achat;
        }
        // capable de vendre des maisons
        public bool pouvoirVenteM(joueur j)
        {
            bool vente = false;
            if (j.getTotalValeurMaisonHotel() > 0)
            {
                vente = true;
            }
            return vente;
        }

        // globalement quand un joueur tombe dans un cas : soit un cas propriété soit un cas simple
        public void entrerDansUnCas(int position)
        {
            if (tabPlateau[position] is casePropriete)
            {
                entrerCasePropriete(position);
                avoirDetteOuFaillite(listeJoueur[joueurEnCours]);
                majEcran(joueurEnCours);
            }
            else if (tabPlateau[position] is caseSimple)
            {
                entrerCaseSimple(position);
                avoirDetteOuFaillite(listeJoueur[joueurEnCours]);
                majEcran(joueurEnCours);
            }
        }

        // événement quand on clique sur le boutton échange
        public void clicBtnEchange(object sender, EventArgs e)
        {
            DialogResult res;
            formEchange echange = new formEchange(joueurEnCours);
            res = echange.ShowDialog();
            if (res == DialogResult.Yes)
            {
                casePropriete c1 = (casePropriete)tabPlateau[echange.caseChoisi1];
                casePropriete c2 = (casePropriete)tabPlateau[echange.caseChoisi2];
                c1.setProprietaire(echange.numJoueurChoisi);
                c2.setProprietaire(joueurEnCours);
                listeJoueur[joueurEnCours].modifArgent(echange.y - echange.x);
                listeJoueur[echange.numJoueurChoisi].modifArgent(echange.x - echange.y);
                if (c1.getHypotheque())
                {
                    dlgMessage hypo = new dlgMessage("PROPRIETE HYPOTHEQUE", "A " + listeJoueur[echange.numJoueurChoisi].getNom()+ "!\n Vous avez obtenu une propriété hypothéquée, vous devez choisir entre lever l'hypothèque maintenant ou payer 10% et garder l'hypothèque !" );
                    hypo.ShowDialog();
                    leverOuGaderHypotheque(c1, echange.numJoueurChoisi);
                }
                if (c1 is caseTerrain)
                {
                    caseTerrain cas1 = (caseTerrain)c1;
                    listeJoueur[joueurEnCours].setTerrain();
                    listeJoueur[echange.numJoueurChoisi].setTerrain();
                    siLoyerDoubleFullColor(cas1);
                }
                else if (c1 is caseGare)
                {
                    caseGare cas1 = (caseGare)c1;
                    listeJoueur[joueurEnCours].setGare();
                    listeJoueur[echange.numJoueurChoisi].setGare();
                }
                else if (c1 is caseCompagnie)
                {
                    caseCompagnie cas1 = (caseCompagnie)c1;
                    listeJoueur[joueurEnCours].setCompagnie();
                    listeJoueur[echange.numJoueurChoisi].setCompagnie();
                }
                if (c2.getHypotheque())
                {
                    dlgMessage hypo2 = new dlgMessage("PROPRIETE HYPOTHEQUE", "A " + listeJoueur[echange.numJoueurChoisi].getNom() + "!\n Vous avez obtenu une propriété hypothéquée, vous devez choisir entre lever l'hypothèque maintenant ou payer 10% et garder l'hypothèque !");
                    hypo2.ShowDialog();
                    leverOuGaderHypotheque(c1, joueurEnCours);
                }
                if (c2 is caseTerrain)
                {
                    caseTerrain cas2 = (caseTerrain)c2;
                    listeJoueur[joueurEnCours].setTerrain();
                    listeJoueur[echange.numJoueurChoisi].setTerrain();
                    siLoyerDoubleFullColor(cas2);
                }
                else if (c2 is caseGare)
                {
                    caseGare cas2 = (caseGare)c2;
                    listeJoueur[joueurEnCours].setGare();
                    listeJoueur[echange.numJoueurChoisi].setGare();
                }
                else if (c2 is caseCompagnie)
                {
                    caseCompagnie cas2 = (caseCompagnie)c2;
                    listeJoueur[joueurEnCours].setCompagnie();
                    listeJoueur[echange.numJoueurChoisi].setCompagnie();
                }

                majEcran(joueurEnCours);
                majEcran(echange.numJoueurChoisi);
                setLabelleCouleur(c1, echange.numJoueurChoisi);
                setLabelleCouleur(c2, joueurEnCours);
            }
        }

        //caseSimple
        public void entrerCaseSimple(int idCase)
        {
            if (idCase == 4 || idCase == 38)
            {
                caseSimple c = (caseSimple)tabPlateau[idCase];
                listeJoueur[joueurEnCours].modifArgent(c.getPlusOuMoins());
                dlgMessage m = new dlgMessage("PAIEMENT DU", "Vous devrez payer " + c.getPlusOuMoins() * (-1) + " € !");
                m.ShowDialog();
                majEcran(joueurEnCours);
            }
            else if (idCase == 30)
            {
                dlgMessage prison = new dlgMessage("ALLER EN PRISON", "Ops !!! \n Vous allez en prison !");
                prison.ShowDialog();
                listeJoueur[joueurEnCours].setTourPrisonnier();
                deplacementRapide(listeJoueur[getJoueurEnCours()].getPosition(), 10);
                nbDesDouble = 0;
            }
            else if (idCase == 7 || idCase == 22 || idCase == 36)
            {
                scenarioChance();
            }
            else if (idCase == 2 || idCase == 17 || idCase == 33)
            {
                scenarioCommunaute();
            }
        }

        private void scenarioChance()
        {
            carteChance maCarteChance;
            Random r = new Random();
            int indexCarteChance = r.Next(0, 11);
            maCarteChance = carteChance.listeCarteChance[indexCarteChance];
            int valeur;
            int nouveauPos;
            dlgMessage m = new dlgMessage("CHANCE", maCarteChance.getText());
            m.ShowDialog();
            //TIRER UNE CARTE TYPE PAYER
            if (maCarteChance.getType().Equals("P"))
            {
                valeur = 0 - maCarteChance.getValue();
                listeJoueur[joueurEnCours].modifArgent(valeur);

            }
            //TIRER UNE CARTE TYPE CREDIT
            else if (maCarteChance.getType().Equals("C"))
            {
                valeur = maCarteChance.getValue();
                listeJoueur[joueurEnCours].modifArgent(valeur);
            }
            // TIRER UNE CARTE TYPE DEPLACER
            else if (maCarteChance.getType().Equals("G"))
            {
                nouveauPos = maCarteChance.getValue();
                deplacementRapide(listeJoueur[joueurEnCours].getPosition(), nouveauPos);
                entrerDansUnCas(nouveauPos);
            }

            // TIRER LA CARTE ALLER EN PRISON
            else if (maCarteChance.getType().Equals("J"))
            {
                dlgMessage prison = new dlgMessage("Téléportation en prison", "Ops !!! \n Vous allez en prison !");
                prison.ShowDialog();
                listeJoueur[joueurEnCours].setTourPrisonnier();
                deplacementRapide(listeJoueur[getJoueurEnCours()].getPosition(), 10);
                nbDesDouble = 0;
            }

            //TIRER UNE CARTE RETOURNER A LA CASE DE DEPART
            else if (maCarteChance.getType().Equals("D"))
            {
                deplacementRapide(listeJoueur[getJoueurEnCours()].getPosition(), 0);

            }
            //TIRER UNE CARTE LIBERER
            else if (maCarteChance.getType().Equals("L"))
            {
                listeJoueur[joueurEnCours].plusMoinsCarteLibeler(1);
            }
        }

        private void scenarioCommunaute()
        {
            carteCommunaute maCarte;
            Random r = new Random();
            int indexCarte = r.Next(0, 11);
            maCarte = carteCommunaute.listeCarteCummunaute[indexCarte];
            int valeur;
            int nouveauPos;
            dlgMessage m = new dlgMessage("COMMUNAUTE", maCarte.getText());
            m.ShowDialog();
            //TIRER UNE CARTE TYPE PAYER
            if (maCarte.getType().Equals("P"))
            {
                valeur = 0 - maCarte.getValue();
                listeJoueur[joueurEnCours].modifArgent(valeur);
            }
            //TIRER UNE CARTE TYPE CREDIT
            else if (maCarte.getType().Equals("C"))
            {
                valeur = maCarte.getValue();
                listeJoueur[joueurEnCours].modifArgent(valeur);
            }
            // TIRER UNE CARTE TYPE DEPLACER
            else if (maCarte.getType().Equals("G"))
            {
                nouveauPos = maCarte.getValue();
                deplacementRapide(listeJoueur[joueurEnCours].getPosition(), nouveauPos);
                entrerDansUnCas(nouveauPos);
            }

            // TIRER LA CARTE ALLER EN PRISON
            else if (maCarte.getType().Equals("J"))
            {
                dlgMessage prison = new dlgMessage("Téléportation en prison", "Ops !!! \n Vous allez en prison !");
                prison.ShowDialog();
                listeJoueur[joueurEnCours].setTourPrisonnier();
                deplacementRapide(listeJoueur[getJoueurEnCours()].getPosition(), 10);
                nbDesDouble = 0;
            }

            //TIRER UNE CARTE RETOURNER A LA CASE DE DEPART
            else if (maCarte.getType().Equals("D"))
            {
                deplacementRapide(listeJoueur[getJoueurEnCours()].getPosition(), 0);

            }
            //TIRER UNE CARTE LIBERER
            else if (maCarte.getType().Equals("L"))
            {
                listeJoueur[joueurEnCours].plusMoinsCarteLibeler(1);
            }
        }

        // cas propriété 
        public void entrerCasePropriete(int idCase)
        {
            casePropriete cas = (casePropriete)tabPlateau[idCase];
            if (cas.getProprietaire() == -1)
            {
                acheteOuEnchere(cas);
            }
            else
            {
                if (joueurEnCours != cas.getProprietaire() && !cas.getHypotheque())
                {
                    payerLoyer(cas);
                }
            }
        }

        // un joueur tombe sur un cas propriété qui n'a pas encore de propriétaire
        // il doit choisir acheter ou enchère 
        public void acheteOuEnchere(casePropriete cas)
        {
            int prix = cas.getPrix();
            // si le joueur n'a pas assez d'argent , il doit choisir enchère
            bool pouvoirAchat = listeJoueur[getJoueurEnCours()].getArgent() >= prix;
            DialogResult result;
            dlgAcheteEnchere dlg;
            if (cas is caseCompagnie)
            {
                dlg = new dlgAcheteEnchere(cas.getIndexCase(), pouvoirAchat);
                result = dlg.ShowDialog();
            }
            else if (cas is caseGare)
            {
                dlg = new dlgAcheteEnchere(cas.getNom(), pouvoirAchat);
                result = dlg.ShowDialog();
            }
            else
            {
                caseTerrain c = (caseTerrain)cas;
                dlg = new dlgAcheteEnchere(c.getNom(), c.getPrix(), c.getCouleur(), c.getLoyerNu(), c.getLoyer1Maison(), c.getLoyer2Maisons(), c.getLoyer3Maisons(), c.getLoyer4Maisons(), c.getLoyerHotel(), c.getPrixMaison(), pouvoirAchat);
                result = dlg.ShowDialog();
            }
            // DialogResult.OK = ACHETER
            if (result == DialogResult.OK)
            {
                dlg.Dispose();
                dlgMessage mess = new dlgMessage("ACHAT", "Vous avez acheté ce propriété !");
                mess.ShowDialog();
                achat(cas, joueurEnCours, prix);
            }
            else  // ENCHERE
            {
                dlg.Dispose();
                enchere(cas);
            }

        }

        // enchère un propriété 
        public void enchere(casePropriete cas)
        {
            dlgEnchere enchere;
            if (cas is caseGare)
            {
                enchere = new dlgEnchere(cas.getNom());
            }
            else if (cas is caseCompagnie)
            {
                enchere = new dlgEnchere(cas.getIndexCase());
            }
            else
            {
                caseTerrain c = (caseTerrain)cas;
                enchere = new dlgEnchere(c.getNom(), c.getPrix(), c.getCouleur(), c.getLoyer(), c.getLoyer1Maison(), c.getLoyer2Maisons(), c.getLoyer3Maisons(), c.getLoyer4Maisons(), c.getLoyerHotel(), c.getPrixMaison());
            }
            enchere.ShowDialog();
            bool res = enchere.vendu;
            // s'il une personne l'achète
            if (res)
            {
                achat(cas, enchere.joueurTour, enchere.prix);
            }
        }

        public void setLabelleCouleur(caseTableau cas, int joueur)
        {
            if (cas.getIndexCase() != 0)
            {

                switch (joueur)
                {
                    case 0:
                        panel1.Controls[cas.getIndexCase()].BackColor = constant.couleur1;
                        break;
                    case 1:
                        panel1.Controls[cas.getIndexCase()].BackColor = constant.couleur2;
                        break;
                    case 2:
                        panel1.Controls[cas.getIndexCase()].BackColor = constant.couleur3;
                        break;
                    case 3:
                        panel1.Controls[cas.getIndexCase()].BackColor = constant.couleur4;
                        break;
                    default:
                        panel1.Controls[cas.getIndexCase()].BackColor = Color.Transparent;
                        break;
                }

            }
        }
        // si le joueur achète un propriété
        public void achat(casePropriete cas, int joueur, int prix)
        {
            listeJoueur[joueur].modifArgent(-prix);
            // masquer le couleur sur tableau
            if (cas.getIndexCase() != 0)
            {
                setLabelleCouleur(cas, joueur);
            }
            // ajouter le propriétaire à la case
            cas.setProprietaire(joueur);
            // ajouter la propriété dans la portefeuille de joueur
            if (cas is caseCompagnie)
            {
                caseCompagnie c = (caseCompagnie)cas;
                listeJoueur[joueur].setCompagnie();
            }
            else if (cas is caseTerrain)
            {
                caseTerrain c = (caseTerrain)cas;
                listeJoueur[joueur].setTerrain();
                siLoyerDoubleFullColor(c);
            }
            else
            {
                caseGare c = (caseGare)cas;
                listeJoueur[joueur].setGare();
            }
            // maj le texte de somme de l'argent
            majEcran(joueur);

        }

        // si le joueur a un bloc de ce terrain , le loyer est doublé et il peut acheter des maison
        public void siLoyerDoubleFullColor(caseTerrain c)
        {

            bool fullColor = verifierFullColor(c);
            if (fullColor)
            {
                changePrixMasse(true, c);
                if (!acheterM.Visible)
                {
                    acheterM.Visible = true;
                }
                dlgMessage dlg = new dlgMessage("DOUBLE LOYER", " Yeah " + listeJoueur[c.getProprietaire()].getNom() + " a tout un bloc de " + c.getCouleur() + " !\n Le loyer est doublé et vous pouvez acheter des maisons maintenant !");
                dlg.ShowDialog();
            }
        }

        public void majEcran(int joueur)
        {
            if (!listeJoueur[joueur].isFaillite())
            {
                if (panelJoueur.Controls[joueur].Controls[2] is Label)
                {
                    Label montant = (Label)panelJoueur.Controls[joueur].Controls[2];
                    montant.Text = Convert.ToString(listeJoueur[joueur].getArgent());
                }
            }
            echange.Visible = pouvoirEchange(listeJoueur[joueurEnCours]);
            hypotheque.Visible = pouvoirHypotheque(listeJoueur[joueurEnCours]);
            acheterM.Visible = pouvoirAchatM(listeJoueur[joueurEnCours]);
            vendreM.Visible = pouvoirVenteM(listeJoueur[joueurEnCours]);
        }

        // changer le prix de tous les propriete de même couleur ( x2 quand le joueur a tout le bloc de couleur et diviser par 2 quand il vente ou perd un cas
        public void changePrixMasse(bool augmente, caseTerrain cas)
        {
            string couleur = cas.getCouleur();
            foreach (caseTerrain c in tabTerrain)
            {
                if (c.getCouleur().Contains(couleur))
                {
                    if (augmente)
                    {
                        c.setLoyer(c.getLoyerNu() * 2);
                        c.aToutLeBloc();
                    }
                    else
                    {
                        c.setLoyer(c.getLoyerNu());
                        c.perdUnBoutDeCouleur();
                    }
                }
            }
        }

        // quand le joueur vient d'acheter 1 terrain
        // Vérifier si l'acheteur a tous des propriétés de même couleur 
        public bool verifierFullColor(caseTerrain cas)
        {
            bool fullColor = false;
            string couleur = cas.getCouleur();
            int compteur = 0;
            foreach (caseTerrain c in listeJoueur[joueurEnCours].getTerrain())
            {
                if (c.getCouleur() == couleur && !c.getHypotheque())
                {
                    compteur++;
                }
            }
            if (((couleur == "marron" || couleur == "bleuFonce") && compteur == 2) || compteur == 3)
            {
                fullColor = true;
                cas.aToutLeBloc();
            }
            return fullColor;
        }

        // vérifier si un joueur a au moins 1 bloc de terrain
        // si oui il peut acheter des maison
        public bool siUnJoueurAUnBloc(joueur j)
        {
            bool aUnBloc = false;
            int i = 0;
            while (!aUnBloc && i < j.getTerrain().Count)
            {
                if (j.getTerrain()[i].getFullColor() == 1)
                {
                    aUnBloc = true;
                }
                i++;
            }
            return aUnBloc;
        }

        /* public void acheterMaison()
        {

            List<int> casChoisi = casMaisonAchetable();
            foreach(int i in casChoisi)
            {
                Panel p = (Panel)panelPlateau.Controls[i];
                p.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        public void clicAchatMaison(object sender, EventArgs e )
        {
            List<int> casChoisi = casMaisonAchetable();
            foreach (int i in casChoisi)
            {
                Panel a = (Panel)panelPlateau.Controls[i];
                a.BorderStyle = BorderStyle.None;
            }
            Panel p = (Panel)sender;
            int index = panelPlateau.Controls.IndexOf(p);
            caseTerrain c = (caseTerrain)tabPlateau[index];
            c.setNbConstruction(c.getNbConstruction() + 1); // ajouter la maison
            c.setLoyer();                                       // recalculer le loyer
            listeJoueur[joueurEnCours].modifArgent(-c.getPrixMaison()); // enlever de l'argent
            affichageMaisonHotel();                                     // maj l'affichage 
            majEcran(joueurEnCours);

        }*/

        // liste des cas d'un joueur ou il peut choisir acheter 1 maison 
        // il faut acheter un par un pour tous les terrains d'un même couleur 
        // le joueur doit avoir assez d'argent pour acheter la maison
        // la maison doit être disponible 
        public List<int> casMaisonAchetable()
        {
            List<int> casChoisi = new List<int>();
            foreach (caseTerrain c in listeJoueur[joueurEnCours].getTerrain())
            {
                if (c.getFullColor() == 1 && c.getNbConstruction() < 5 && listeJoueur[joueurEnCours].getArgent() >= c.getPrixMaison())
                {
                    string couleur = c.getCouleur();
                    caseTerrain[] tab;
                    switch (couleur)
                    {
                        case "marron":
                            tab = terrainMarron;
                            break;
                        case "bleuCiel":
                            tab = terrainBleuCiel;
                            break;
                        case "rose":
                            tab = terrainRose;
                            break;
                        case "orange":
                            tab = terrainOrange;
                            break;
                        case "rouge":
                            tab = terrainRouge;
                            break;
                        case "jaune":
                            tab = terrainJaune;
                            break;
                        case "vert":
                            tab = TerrainVert;
                            break;
                        default:
                            tab = TerrainBleuFonce;
                            break;
                    }

                    int nbMin = 4;
                    foreach (caseTerrain cas in tab)
                    {
                        if (cas.getNbConstruction() < nbMin)
                        {
                            nbMin = cas.getNbConstruction();
                        }
                    }
                    if ((nbMin == 4 && nbHotelDispo > 0) || (nbMin < 4 && nbMaisonDispo > 0))   // s'il y a encore des maison et des hotel disponibles
                    {
                        if (c.getNbConstruction() == nbMin && c.getPrixMaison() < listeJoueur[joueurEnCours].getArgent())
                        {
                            casChoisi.Add(c.getIndexCase());
                        }
                    }
                }
            }
            return casChoisi;
        }

        public List<int> casMaisonAVente()
        {
            List<int> casChoisi = new List<int>();
            foreach (caseTerrain c in listeJoueur[joueurEnCours].getTerrain())
            {
                if (c.getNbConstruction() > 0)
                {
                    string couleur = c.getCouleur();
                    caseTerrain[] tab;
                    switch (couleur)
                    {
                        case "marron":
                            tab = terrainMarron;
                            break;
                        case "bleuCiel":
                            tab = terrainBleuCiel;
                            break;
                        case "rose":
                            tab = terrainRose;
                            break;
                        case "orange":
                            tab = terrainOrange;
                            break;
                        case "rouge":
                            tab = terrainRouge;
                            break;
                        case "jaune":
                            tab = terrainJaune;
                            break;
                        case "vert":
                            tab = TerrainVert;
                            break;
                        default:
                            tab = TerrainBleuFonce;
                            break;
                    }

                    int nbMax = 1;
                    foreach (caseTerrain cas in tab)
                    {
                        if (cas.getNbConstruction() > nbMax)
                        {
                            nbMax = cas.getNbConstruction();
                        }
                    }

                    if (c.getNbConstruction() == nbMax)
                    {
                        casChoisi.Add(c.getIndexCase());
                    }

                }
            }
            return casChoisi;
        }
        public void payerLoyer(casePropriete cas)
        {
            int somme;
            if (cas is caseCompagnie)
            {
                int propCase = cas.getProprietaire();
                int nbCompagniePossede = listeJoueur[propCase].getCompagnie().Count;
                switch (nbCompagniePossede)
                {
                    case 1:
                        somme = lancePourCalculerLeLoyerDuService * 4;
                        break;
                    case 2:
                        somme = lancePourCalculerLeLoyerDuService * 10;
                        break;
                    default:
                        somme = 0;
                        break;
                }
            }
            else if (cas is caseGare)
            {
                int propCase = cas.getProprietaire();
                int nbGarePossede = listeJoueur[propCase].getGare().Count;
                caseGare c = (caseGare)cas;
                switch (nbGarePossede)
                {
                    case 1:
                        somme = c.getLoyer();
                        break;
                    case 2:
                        somme = c.getLoyer2Gare();
                        break;
                    case 3:
                        somme = c.getLoyer3Gare();
                        break;
                    case 4:
                        somme = c.getLoyer4Gare();
                        break;
                    default:
                        somme = 0;
                        break;
                }
            }
            else
            {
                somme = cas.getLoyer();
            }
            listeJoueur[getJoueurEnCours()].modifArgent(-somme);
            listeJoueur[cas.getProprietaire()].modifArgent(somme);
            dlgMessage dlg = new dlgMessage("MONTANT DU", "Vous devez payer " + somme + " à " + listeJoueur[cas.getProprietaire()].getNom() + " !");
            dlg.ShowDialog();
            majEcran(joueurEnCours);
            majEcran(cas.getProprietaire());
        }

        public void avoirDetteOuFaillite(joueur j)
        {
            if (j.getArgent() < 0)
            {
                finDuTour.Enabled = false;
                if ((j.getTotalPropriete() + j.getTotalValeurMaisonHotel()) / 2 + j.getArgent() > 0)
                {
                    dlgMessage dlg = new dlgMessage("PAS ASSEZ D'ARGENT", "Vous devrez vendre des maisons ou hypothéquer des propriérés !");
                    dlg.ShowDialog();
                }
                else
                {

                    dlgMessage dlg = new dlgMessage("FAILLITE", "Vous ne pouvez plus payer votre dette, vous êtes éliminé !\n Vos bâtiments seront tous vendus et vos propritétés seron toutes hypothéquées !");
                    dlg.ShowDialog();
                    j.setFaillite(true);
                    if (joueurRestant() > 1)
                    {
                        lancerDes.Enabled = false;
                        finDuTour.Enabled = true;
                        panelJoueur.Controls[j.getNumero()].BackColor = Color.Red;
                        if (panelJoueur.Controls[j.getNumero()].Controls[2] is Label)
                        {
                            Label montant = (Label)panelJoueur.Controls[j.getNumero()].Controls[2];
                            montant.Text = "X";
                        }
                        viderMaisonFaillite(j);
                        if (tabPlateau[j.getPosition()] is casePropriete)
                        {
                            casePropriete c = (casePropriete)tabPlateau[j.getPosition()];
                            dlgMessage dl = new dlgMessage("DETTE ", "L'argent et les propriétés de " + j.getNom() + " seront transférés au " + listeJoueur[c.getProprietaire()].getNom());
                            dl.ShowDialog();
                            dlgMessage passe = new dlgMessage("Passer à " + listeJoueur[c.getProprietaire()].getNom(), listeJoueur[c.getProprietaire()].getNom() + ", à vous de choisir de lever ou garder les hypothèques ! ");
                            passe.ShowDialog();
                            changerProprietaireFaillite(j, c.getProprietaire());
                        }
                        else
                        {
                            dlgMessage d = new dlgMessage("DETTE DUE A LA BANQUE", "L'hypothèque sur les propriétés de " + j.getNom() + " sera levée\n chaque propritété sera vendue au enchère !"); ;
                            d.ShowDialog();
                            enchereProprieteJoueurFaillite(j);
                        }
                        Panel a = (Panel)panelPlateau.Controls[j.getPosition()];
                        int ecart = a.Controls.Count - listeJoueur.Count;
                        a.Controls[j.getNumero() + ecart].Visible = false;
                        dlgMessage fin = new dlgMessage("FIN DU TOUR", "Cliquez sur le bouton FIN DU TOUR pour passer .");
                        fin.ShowDialog();
                    }
                    else
                    {
                        EndGame();
                    }
                }
            }
            else
            {
                finDuTour.Enabled = true;
            }
        }

        //reprendre des maisons d'un joueur éliminé
        public void viderMaisonFaillite(joueur j)
        {

            foreach (caseTerrain c in j.getTerrain())
            {
                if (c.getNbConstruction() > 0)
                {
                    if (c.getNbConstruction() == 5)
                    {
                        nbHotelDispo += 1;
                    }
                    else
                    {
                        nbMaisonDispo += c.getNbConstruction();
                    }
                    c.setNbConstruction(0);
                    c.setLoyer();  // recalculer le loyer
                }
            }
            nbHotel.Text = Convert.ToString(nbHotelDispo);
            nbMaison.Text = Convert.ToString(nbMaisonDispo);
            affichageMaisonHotel();                        // maj l'affichage 
        }

        // enchère des propriété du joueur éliminé
        public void enchereProprieteJoueurFaillite(joueur j)
        {
            foreach (int i in j.listeTousProprietes())
            {
                if (tabPlateau[i] is casePropriete)
                {
                    setLabelleCouleur(tabPlateau[i], -1);
                    casePropriete c = (casePropriete)tabPlateau[i];
                    c.setProprietaire(-1);
                    enchere(c);
                }
            }
            j.setTerrain();
            j.setCompagnie();
            j.setGare();
        }

        // un joueur obtient des propriétés de celui qu'il a éliminé 
        public void changerProprietaireFaillite(joueur ancienProp, int nouveauProprietaire)
        {
            foreach (int i in ancienProp.listeTousProprietes())
            {
                if (tabPlateau[i] is casePropriete)
                {
                    setLabelleCouleur(tabPlateau[i], nouveauProprietaire);
                    casePropriete c = (casePropriete)tabPlateau[i];
                    c.setProprietaire(nouveauProprietaire);
                    leverOuGaderHypotheque(c, nouveauProprietaire);
                }
            }
            ancienProp.setTerrain();
            ancienProp.setCompagnie();
            ancienProp.setGare();
            listeJoueur[nouveauProprietaire].setCompagnie();
            listeJoueur[nouveauProprietaire].setGare();
            listeJoueur[nouveauProprietaire].setTerrain();
        }

        public void leverOuGaderHypotheque(casePropriete cas, int player)
        {
            dlgLeverHypotheque hypotheque;
            DialogResult res;
            if (cas is caseGare)
            {
                hypotheque = new dlgLeverHypotheque(cas.getNom(), player);
            }
            else if (cas is caseCompagnie)
            {
                hypotheque = new dlgLeverHypotheque(cas.getIndexCase(), player);
            }
            else
            {
                caseTerrain c = (caseTerrain)cas;
                hypotheque = new dlgLeverHypotheque(c.getNom(), c.getPrix(), c.getCouleur(), c.getLoyer(), c.getLoyer1Maison(), c.getLoyer2Maisons(), c.getLoyer3Maisons(), c.getLoyer4Maisons(), c.getLoyerHotel(), c.getPrixMaison(), player);
            }
            res = hypotheque.ShowDialog();
            if (res == DialogResult.Yes)
            {
                cas.setHypotheque(false);
                listeJoueur[player].modifArgent(-(int)(cas.getPrix() / 2 * 1.1));
                panelPlateau.Controls[cas.getIndexCase()].BackColor = Color.Transparent;
                majEcran(player);
            }
            else
            {
                listeJoueur[player].modifArgent(-(int)(cas.getPrix() / 2 * 0.1));
                majEcran(player);
            }
        }
        public void initPlateau()
        {
            //Marron
            blvDeBelleville = new caseTerrain(1, "Boulevard de Belleville", 60, "marron", 2, 10, 30, 90, 160, 250);
            rueLecourbe = new caseTerrain(3, "Rue Lecourbe", 60, "marron", 4, 20, 60, 180, 320, 450);
            //Terrains de couleur marron dans un tableau
            terrainMarron = new caseTerrain[2] { blvDeBelleville, rueLecourbe };

            //Bleu ciel
            rueDeVaugirard = new caseTerrain(6, "Rue de Vaugirard", 100, "bleuCiel", 6, 30, 90, 270, 400, 550);
            rueDeCourcelles = new caseTerrain(8, "Rue de Courcelles", 100, "bleuCiel", 6, 30, 90, 270, 400, 550);
            avenueDeLaRepublique = new caseTerrain(9, "Avenue de la République", 120, "bleuCiel", 8, 40, 100, 300, 450, 600);
            //Terrains de couleur bleu ciel dans un tableau
            terrainBleuCiel = new caseTerrain[3] { rueDeVaugirard, rueDeCourcelles, avenueDeLaRepublique };

            //Rose
            blvDeLaVilette = new caseTerrain(11, "Boulevard de la Vielette", 140, "rose", 10, 50, 150, 450, 625, 750);
            avenueDeNeuilly = new caseTerrain(13, "Avenue de Neuilly", 140, "rose", 10, 50, 150, 450, 625, 750);
            rueDeParadis = new caseTerrain(14, "Rue de Paradis", 160, "rose", 12, 60, 180, 500, 700, 900);
            //Terrains de couleur rose dans un tableau
            terrainRose = new caseTerrain[3] { blvDeLaVilette, avenueDeNeuilly, rueDeParadis };

            //Orange
            avenueMozart = new caseTerrain(16, "Avenue Mozart", 180, "orange", 14, 70, 200, 550, 760, 950);
            blvSaintMichel = new caseTerrain(18, "Boulevard Saint-Michel", 180, "orange", 14, 70, 200, 550, 760, 950);
            placePigalle = new caseTerrain(19, "Place Pigalle", 200, "orange", 16, 80, 220, 600, 800, 1000);
            //Terrains de couleur orange dans un tableau
            terrainOrange = new caseTerrain[3] { avenueMozart, blvSaintMichel, placePigalle };

            //Rouge
            avenueMatignon = new caseTerrain(21, "Avenue Matignon", 220, "rouge", 18, 90, 250, 700, 875, 1050);
            blvMalesherbes = new caseTerrain(23, "Boulevard Malesherbes", 220, "rouge", 18, 90, 250, 700, 875, 1050);
            avenueHenriMartin = new caseTerrain(24, "Avenue Henri-Martin", 240, "rouge", 20, 100, 300, 750, 925, 1100);
            //Terrains de couleur rouge dans un tableau
            terrainRouge = new caseTerrain[3] { avenueMatignon, blvMalesherbes, avenueHenriMartin };

            //Jaune 
            faubourgSaintHonore = new caseTerrain(26, "Faubourg Saint-Honore", 260, "jaune", 22, 110, 330, 800, 975, 1150);
            placeDeLaBourse = new caseTerrain(27, "Place de la Bourse", 260, "jaune", 22, 110, 330, 800, 975, 1150);
            rueLafayette = new caseTerrain(29, "Rue Lafayette", 280, "jaune", 24, 120, 360, 850, 1025, 1200);
            //Terrains de couleur jaune dans un tableau
            terrainJaune = new caseTerrain[3] { faubourgSaintHonore, placeDeLaBourse, rueLafayette };

            //Vert
            avenueDeBreteuil = new caseTerrain(31, "Avenue de Breteuil", 300, "vert", 26, 130, 390, 900, 1100, 1275);
            avenueFoch = new caseTerrain(32, "Avenue Foch", 300, "vert", 26, 130, 390, 900, 1100, 1275);
            boulevardDesCapicines = new caseTerrain(34, "Boulevard des Capucines", 320, "vert", 28, 150, 450, 1000, 1200, 1400);
            //Terrains de couleur vert dans un tableau
            TerrainVert = new caseTerrain[3] { avenueDeBreteuil, avenueFoch, boulevardDesCapicines };

            //bleuFonce
            avenueChampsElysees = new caseTerrain(37, "Avenue des Champs Elysées", 350, "bleuFonce", 35, 175, 500, 1100, 1300, 1500);
            rueDeLaPaix = new caseTerrain(39, "Rue de la Paix", 400, "bleuFonce", 50, 200, 600, 1400, 1700, 2000);
            //Terrains de couleur bleuFonce dans un tableau
            TerrainBleuFonce = new caseTerrain[2] { avenueChampsElysees, rueDeLaPaix };

            //Les gares
            gareMontparnasse = new caseGare(5, "Gare Montparnasse");
            gareDeLyon = new caseGare(15, "Gare de Lyon");
            gareDuNord = new caseGare(25, "Gare du Nord");
            gareSaintLazare = new caseGare(35, "Gare Saint-Lazare");
            //rangées dans un meme tableau pour utilisation dans des procédures
            tabGare = new caseGare[4] { gareMontparnasse, gareDeLyon, gareDuNord, gareSaintLazare };

            //Les compagnies services public
            serviceElectricite = new caseCompagnie(12, "Compagnie de distribution d'électricité");
            serviceDesEaux = new caseCompagnie(28, "Compagnie de distribution des eaux");
            compagnieService = new caseCompagnie[2] { serviceElectricite, serviceDesEaux };

            tabTerrain = new caseTerrain[] { blvDeBelleville, rueLecourbe, rueDeVaugirard,
            rueDeCourcelles, avenueDeLaRepublique, blvDeLaVilette, avenueDeNeuilly, rueDeParadis,
            avenueMozart, blvSaintMichel, placePigalle, avenueMatignon, blvMalesherbes,
            avenueHenriMartin, faubourgSaintHonore, placeDeLaBourse, rueLafayette, avenueDeBreteuil,
            avenueFoch, boulevardDesCapicines, avenueChampsElysees, rueDeLaPaix };


            //Toutes les cases cartes dans le meme tableau 
            tabPlateau = new caseTableau[] { depart, blvDeBelleville, communaute1,
            rueLecourbe, impotsRevenu, gareMontparnasse, rueDeVaugirard, chance1, rueDeCourcelles,
            avenueDeLaRepublique, prison, blvDeLaVilette, serviceElectricite, avenueDeNeuilly,
            rueDeParadis, gareDeLyon, avenueMozart, communaute3, blvSaintMichel, placePigalle,
            parc, avenueMatignon, chance2, blvMalesherbes, avenueHenriMartin, gareDuNord,
            faubourgSaintHonore, placeDeLaBourse, serviceDesEaux, rueLafayette, allerEnPrison,
            avenueDeBreteuil, avenueFoch, communaute3, boulevardDesCapicines, gareSaintLazare,
            chance3, avenueChampsElysees, taxDeLuxe, rueDeLaPaix };
        }

        public caseTableau[] getTabPlateau()
        {
            return tabPlateau;
        }

        public caseTableau[] getTabTerrain()
        {
            return tabTerrain;
        }

        public List<joueur> getListeJoueur()
        {
            return listeJoueur;
        }

        public void setJoueurEnCours()
        {
            joueurEnCours++;
            if (joueurEnCours >= listeJoueur.Count)
            {
                joueurEnCours = 0;
            }
            if (listeJoueur[joueurEnCours].isFaillite())
            {
                setJoueurEnCours();
            }
        }


        public int getJoueurEnCours()
        {
            return joueurEnCours;
        }
        public void setListeJoueur(List<joueur> list)
        {
            this.listeJoueur = list;

        }

        public int getNbMaisonDispo()
        {
            return nbMaisonDispo;
        }

        public void setNbMaisonDispo(int i)
        {
            this.nbMaisonDispo = i;
        }

        public int getNbHotelDispo()
        {
            return nbHotelDispo;
        }

        public void setNbHotelDispo(int i)
        {
            this.nbHotelDispo = i;
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        public void EndGame()
        {
            if (endedGame != null)
            {
                endedGame(this, new EventArgs());
            }
        }
    }
}
