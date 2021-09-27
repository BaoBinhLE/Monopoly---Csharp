using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Form1 : Form
    {

        private formPortefeuille portefeuille;
        private List<joueur> listeJ = joueur.listeJoueur;
        mono mono;

        public Form1()
        {
            InitializeComponent();
            mono = new mono(panel1, panelPlateau, panelButton,
            pionListImage, echange, hypotheque, acheterM, vendreM,
            finDuTour, panelDes, boxDes1, boxDes2, lancerDes,
            desListImage, panelJoueur, bgJoueurListe, listeJ, lblJoueurEncours, nbMaison, nbHotel);
            mono.EndedGame += mono_EndedGame;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            menuStrip1.Visible = true;
            this.Top = 0;
            this.Left = 10;
            this.Height = 750;
            this.Width = 1240;
            this.BackColor = Color.Beige;
            panel1.Size = new Size(725, 725);
            panel1.Top = 40;
            panel1.Left = 20;
            panelPlateau.Left = 25;
            panelPlateau.Top = 25;
            panelPlateau.Height = 665;
            panelPlateau.Width = 665;
            panelPlateau.BackgroundImage = Image.FromFile("images/plateau.jpg");

            //petits tickets pour marquer des propriétaires 
            for (int i = 0; i < 10; i++)
            {
                Panel label = new Panel();
                label.Top = 690;
                label.Left = 550 - i * 55;
                label.Size = new Size(55, 20);
                label.BackColor = Color.Transparent;
                panel1.Controls.Add(label);
            }

            for (int i = 0; i < 10; i++)
            {
                Panel label = new Panel();
                label.Top = 550 - i * 55;
                label.Left = 10;
                label.Size = new Size(20, 55);
                label.BackColor = Color.Transparent;
                panel1.Controls.Add(label);
            }

            for (int i = 0; i < 10; i++)
            {
                Panel label = new Panel();
                label.Top = 10;
                label.Left = 110 + i * 55;
                label.Size = new Size(55, 20);
                label.BackColor = Color.Transparent;
                panel1.Controls.Add(label);
            }

            for (int i = 0; i < 9; i++)
            {
                Panel label = new Panel();
                label.Top = 110 + i * 55;
                label.Left = 690;
                label.Size = new Size(20, 55);
                label.BackColor = Color.Transparent;
                panel1.Controls.Add(label);
            }
            // les panneaux de cases 
            int x = 0, y = 0;
            for (int i = 0; i < 40; i++)
            {
                Panel pane = new Panel();
                pane.BackColor = Color.Transparent;
                if (i % 10 == 0)
                {
                    pane.Size = new Size(85, 85);
                    x = 17;
                    y = 17;
                    if (i == 0 || i == 30)
                    {
                        pane.Left = (665 - 85);
                        if (i == 0)
                        {
                            pane.Top = (665 - 85);
                        }
                        else
                        {
                            pane.Top = 0;
                        }
                    }
                    else
                    {
                        pane.Left = 0;
                        if (i == 10)
                        {
                            pane.Top = (665 - 85);
                        }
                        else if (i == 20)
                        {
                            pane.Top = 0;
                        }
                    }

                }
                else if (i / 10 == 0 || i / 10 == 2)
                {
                    pane.Size = new Size(55, 85);
                    x = 2;
                    //pane.BackColor = Color.Gray;
                    if (i / 10 == 0)
                    {
                        y = 25;
                        pane.Top = 580;
                        pane.Left = (665 - 85) - i * 55;
                        if (mono.getTabPlateau()[i] is caseTerrain)
                        {
                            Label l = new Label();
                            pane.Controls.Add(l);
                            l.Top = 5;
                            l.Left = 2;
                            //l.Text = "M M M M";
                        }
                    }
                    else
                    {
                        y = 10;
                        pane.Top = 0;
                        pane.Left = 85 + (i - 21) * 55;
                        if (mono.getTabPlateau()[i] is caseTerrain)
                        {
                            Label l = new Label();
                            pane.Controls.Add(l);
                            l.Top = 70;
                            l.Left = 2;
                            //l.Text = "M M M M ";
                        }
                    }
                }
                else
                {
                    y = 2;
                    pane.Size = new Size(85, 55);
                    //pane.BackColor = Color.Gray;

                    if (i / 10 == 1)
                    {
                        x = 10;
                        pane.Left = 0;
                        pane.Top = (665 - 85) - (i - 10) * 55;
                        if (mono.getTabPlateau()[i] is caseTerrain)
                        {
                            Label l = new Label();
                            pane.Controls.Add(l);
                            l.Top = 2;
                            l.Left = 68;
                            l.Size = new Size(23, 55);
                            //l.Text = "M\nM\nM\nM";
                        }
                    }
                    else
                    {
                        x = 25;
                        pane.Left = (665 - 85);
                        pane.Top = 85 + (i - 31) * 55;
                        if (mono.getTabPlateau()[i] is caseTerrain)
                        {
                            Label l = new Label();
                            pane.Controls.Add(l);
                            l.Top = 2;
                            l.Left = 2;
                            l.Size = new Size(23, 55);
                            //l.Text = "M\nM\nM\nM";
                        }
                    }


                }
                // pictureBox pour afficher les pions

                for (int j = 0; j < mono.getListeJoueur().Count; j++)
                {
                    PictureBox posPion = new PictureBox();
                    posPion.Image = pionListImage.Images[mono.getListeJoueur()[j].getPion()];
                    posPion.SizeMode = PictureBoxSizeMode.Zoom;
                    posPion.Height = 28;
                    posPion.Width = 28;
                    posPion.Visible = false;
                    pane.Controls.Add(posPion);
                    posPion.Top = y + (j / 2) * 26;
                    posPion.Left = x + (j % 2) * 26;
                    posPion.MouseEnter += new EventHandler(testPanel);
                }
                panelPlateau.Controls.Add(pane);
                pane.MouseEnter += new EventHandler(enterPanel);
                pane.MouseLeave += new EventHandler(outPanel);
                pane.Click += new EventHandler(afficherCase);

            }

            // Panel boutton 
            panelButton.Top = 300;
            panelButton.Left = 800;
            panelButton.Size = new Size(200, 300);
            echange.BackgroundImage = Image.FromFile("images/button/echangeCarre.png");
            hypotheque.BackgroundImage = Image.FromFile("images/button/hypoCarre.png");
            acheterM.BackgroundImage = Image.FromFile("images/button/achatCarre.png");
            vendreM.BackgroundImage = Image.FromFile("images/button/venteCarre.png");
            foreach (Button c in panelButton.Controls)
            {
                c.Size = new Size(150, 60);
                c.ImageAlign = ContentAlignment.MiddleCenter;
                c.BackgroundImageLayout = ImageLayout.Zoom;
                c.BackColor = Color.Beige;
                c.Top = 70 * c.TabIndex;
                c.Left = 25;
            }

            // BUTTON FINIR LE TOUR 
            finDuTour.Top = 680;
            finDuTour.Left = 825;
            finDuTour.Size = new Size(150, 60);
            finDuTour.BackgroundImage = Image.FromFile("images/button/finCarre.png");
            finDuTour.BackgroundImageLayout = ImageLayout.Zoom;
            finDuTour.BackColor = Color.Transparent;

            //LABEL NOM JOUER
            lblJoueurEncours.Top = 80;
            lblJoueurEncours.Left = 800;
            lblJoueurEncours.Width = 200;

            // PANEL LANCER DES DES 
            panelDes.Size = new Size(200, 170);
            panelDes.BackColor = Color.Beige;
            panelDes.BorderStyle = BorderStyle.FixedSingle;
            panelDes.Top = 110;
            panelDes.Left = 800;

            //Picturebox des dés
            boxDes1.Height = 70;
            boxDes1.Width = 70;
            boxDes1.Top = 10;
            boxDes1.Left = 25;
            boxDes1.Image = (Image)desListImage.Images[0];
            boxDes1.BackColor = Color.Beige;
            boxDes1.SizeMode = PictureBoxSizeMode.StretchImage;

            boxDes2.Height = 70;
            boxDes2.Width = 70;
            boxDes2.Top = 10;
            boxDes2.Left = 105;
            boxDes2.Image = (Image)desListImage.Images[0];
            boxDes2.BackColor = Color.Beige;
            boxDes2.SizeMode = PictureBoxSizeMode.StretchImage;

            lancerDes.Size = new Size(150, 60);
            lancerDes.Top = 100;
            lancerDes.Left = 25;
            lancerDes.BackgroundImage = Image.FromFile("images/button/bronzeButton.png");
            lancerDes.BackgroundImageLayout = ImageLayout.Zoom;
            lancerDes.BackColor = Color.Beige;
            lancerDes.Text = "Lancer des dés";

            //Panel des joueurs 
            panelJoueur.BackColor = Color.Transparent;
            panelJoueur.Top = 80;
            panelJoueur.Left = 1020;
            panelJoueur.Size = new Size(210, 560);
            for (int i = 0; i < mono.getListeJoueur().Count; i++)
            {
                Panel bgJoueur = new Panel();
                bgJoueur.BackgroundImage = (Image)bgJoueurListe.Images[i];
                bgJoueur.BackgroundImageLayout = ImageLayout.Stretch;
                //bgJoueur.BackColor = Color.Beige;
                //bgJoueur.BorderStyle = BorderStyle.Fixed3D;
                panelJoueur.Controls.Add(bgJoueur);
                bgJoueur.Size = new Size(200, 130);
                bgJoueur.Top = 140 * i;
                bgJoueur.Left = 5;
                //-----panel pion------
                PictureBox pionPic = new PictureBox();

                pionPic.Image = (Image)pionListImage.Images[mono.getListeJoueur()[i].getPion()];
                bgJoueur.Controls.Add(pionPic);
                pionPic.Top = 7;
                pionPic.Left = 72;
                pionPic.Size = new Size(65, 65);
                pionPic.BackColor = Color.Transparent;
                pionPic.SizeMode = PictureBoxSizeMode.Zoom;
                pionPic.Tag = i;
                //------- label Nom --------
                Label nom = new Label();
                bgJoueur.Controls.Add(nom);
                nom.Top = 74;
                nom.Left = 50;
                nom.TextAlign = ContentAlignment.MiddleCenter;
                nom.Font = new Font("MicrosoftYaHei", 12, FontStyle.Bold);
                nom.BackColor = Color.Transparent;
                nom.ForeColor = Color.White;
                nom.Text = mono.getListeJoueur()[i].getNom();
                nom.Tag = i;
                //---------label Argent---------
                Label argent = new Label();
                bgJoueur.Controls.Add(argent);
                argent.Top = 100;
                argent.Left = 50;
                argent.TextAlign = ContentAlignment.MiddleRight;
                argent.Font = new Font("MicrosoftYaHei", 12, FontStyle.Bold);
                argent.BackColor = Color.Transparent;
                argent.Text = mono.getListeJoueur()[i].getArgent() + " €";
                argent.Tag = i;
                nom.Click += new EventHandler(clicConTrolPanel);
                argent.Click += new EventHandler(clicConTrolPanel);
                pionPic.Click += new EventHandler(clicConTrolPanel);
                nom.MouseEnter += new EventHandler(enterControlPanel);
                argent.MouseEnter += new EventHandler(enterControlPanel);
                pionPic.MouseEnter += new EventHandler(enterControlPanel);
                bgJoueur.MouseEnter += new EventHandler(enterPanel);
                bgJoueur.MouseLeave += new EventHandler(outPanel);
                bgJoueur.Click += new EventHandler(affichePortefeuille);
                //bgJoueur.Click += new EventHandler(remisePanelNormalEnCliquerUnAutreBouton);
            }

            // panel Nombre Maison Hotel 
            panelMaiTel.Top = 680;
            panelMaiTel.Left = 1050;

            mono.lierEvenement();
            mono.affichageMaisonHotel();
            initTous();
            acheterM.Click += new EventHandler(acheterMaison);
            vendreM.Click += new EventHandler(vendreMaison);
            hypotheque.Click += new EventHandler(btnHypotheque);
            //lancerDes.Click += new EventHandler(remisePanelNormalEnCliquerUnAutreBouton);
            //finDuTour.Click += new EventHandler(remisePanelNormalEnCliquerUnAutreBouton);

        }

        private void testPanel(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            this.Text = Convert.ToString(p.Parent.Controls.IndexOf(p));
        }

        private void initTous()
        {
            Panel depart = (Panel)panelPlateau.Controls[0];
            for (int p = 0; p < mono.getListeJoueur().Count; p++)
            {
                depart.Controls[p].Visible = true;
            }

        }



        private void afficherCase(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            int id = panelPlateau.Controls.IndexOf(p);
            if (id <= 39)
            {
                if (mono.getTabPlateau()[id] is caseTerrain)
                {

                    caseTerrain c = (caseTerrain)mono.getTabPlateau()[id];
                    string nom = c.getNom();
                    int prixCarte = c.getPrix();
                    string couleur = c.getCouleur();
                    int loyerN = c.getLoyerNu();
                    int loyer1 = c.getLoyer1Maison();
                    int loyer2 = c.getLoyer2Maisons();
                    int loyer3 = c.getLoyer3Maisons();
                    int loyer4 = c.getLoyer4Maisons();
                    int loyerH = c.getLoyerHotel();
                    int prixconstruction = c.getPrixMaison();
                    formInfoTerrain form = new formInfoTerrain(nom, prixCarte, couleur, loyerN, loyer1, loyer2, loyer3, loyer4, loyerH, prixconstruction);
                    form.ShowDialog();
                }
                else if (mono.getTabPlateau()[id] is caseGare)
                {
                    caseGare c = (caseGare)mono.getTabPlateau()[id];
                    string nomGare = c.getNom();
                    formInfoGare form = new formInfoGare(nomGare);
                    form.ShowDialog();
                }
                else if (mono.getTabPlateau()[id] is caseCompagnie)
                {
                    formInfoCompagnie form = new formInfoCompagnie(id);
                    form.ShowDialog();
                }
            }
        }

        // afficher le portefeuille d'un joueur
        private void affichePortefeuille(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BorderStyle = BorderStyle.None;
            int id = panelJoueur.Controls.IndexOf(p);
            string nom = mono.getListeJoueur()[id].getNom();
            int propriete = mono.getListeJoueur()[id].getTotalPropriete();
            int maisonHotel = mono.getListeJoueur()[id].getTotalValeurMaisonHotel();
            int argent = mono.getListeJoueur()[id].getArgent();
            int carteLibere = mono.getListeJoueur()[id].getnbCarteLiberer();
            portefeuille = new formPortefeuille(id, nom, propriete, maisonHotel, argent, carteLibere);
            portefeuille.ShowDialog();

        }

        // cliquer sur le bouton acheter maison pour déclencher l'événement d'achat de maison
        public void acheterMaison(object sender, EventArgs e)
        {

            List<int> casChoisi = mono.casMaisonAchetable();
            if (casChoisi.Count == 0)
            {
                dlgMessage dlg = new dlgMessage("PAS POUVOIR D'ACHAT", "Vous ne pouvez pas acheter des maison !");
                dlg.ShowDialog();
            }
            else
            {
                dlgMessage dl = new dlgMessage("ACHETER DES MAISONS", "Vous pouvez choisir un des terrains marqués !");
                dl.ShowDialog();
                foreach (int i in casChoisi)
                {
                    Panel p = (Panel)panelPlateau.Controls[i];
                    p.BorderStyle = BorderStyle.Fixed3D;
                    p.BackColor = constant.monter;
                    p.Click -= (afficherCase);
                    p.Click += (clicAchatMaison);
                }
            }

        }

        //cliquer sur 1 cas pour acheter la maison
        public void clicAchatMaison(object sender, EventArgs e)
        {
            //remisePanelNormal();
            List<int> casChoisi = mono.casMaisonAchetable();
            this.Text = "";
            foreach (int i in casChoisi)
            {
                this.Text += Convert.ToString(i);
                Panel a = (Panel)panelPlateau.Controls[i];
                a.BorderStyle = BorderStyle.None;
                a.BackColor = Color.Transparent;
                a.Click -= (clicAchatMaison);
                a.Click += (afficherCase);
            }
            Panel p = (Panel)sender;
            int index = panelPlateau.Controls.IndexOf(p);
            caseTerrain c = (caseTerrain)mono.getTabPlateau()[index];
            c.setNbConstruction(c.getNbConstruction() + 1); // ajouter la maison
            if (c.getNbConstruction() > 4)
            {
                mono.setNbHotelDispo(mono.getNbHotelDispo() - 1);
                mono.setNbMaisonDispo(mono.getNbMaisonDispo() + 4);
                nbHotel.Text = Convert.ToString(mono.getNbHotelDispo());
                nbMaison.Text = Convert.ToString(mono.getNbMaisonDispo());
            }
            else
            {
                mono.setNbMaisonDispo(mono.getNbMaisonDispo() - 1);
                nbMaison.Text = Convert.ToString(mono.getNbMaisonDispo());
            }
            c.setLoyer();                                       // recalculer le loyer
            mono.getListeJoueur()[mono.joueurEnCours].modifArgent(-c.getPrixMaison()); // enlever de l'argent
            mono.affichageMaisonHotel();                                     // maj l'affichage 
            mono.majEcran(mono.joueurEnCours);
            c.setLoyer();
            mono.avoirDetteOuFaillite(mono.getListeJoueur()[mono.joueurEnCours]);
        }

        // cliquer sur le bouton vendre maison pour déclencher l'événement de vente de maison
        public void vendreMaison(object sender, EventArgs e)
        {

            List<int> casChoisi = mono.casMaisonAVente();
            foreach (int i in casChoisi)
            {
                Panel p = (Panel)panelPlateau.Controls[i];
                p.BorderStyle = BorderStyle.Fixed3D;
                p.BackColor = constant.monter;
                p.Click -= (afficherCase);
                p.Click += new EventHandler(clicVenteMaison);
            }
        }

        //cliquer sur 1 cas pour vendre la maison
        public void clicVenteMaison(object sender, EventArgs e)
        {
            //remisePanelNormal();
            List<int> casChoisi = mono.casMaisonAVente();
            foreach (int i in casChoisi)
            {
                Panel a = (Panel)panelPlateau.Controls[i];
                a.BorderStyle = BorderStyle.None;
                a.BackColor = Color.Transparent;
                a.Click -= (clicVenteMaison);
                a.Click += new EventHandler(afficherCase);
            }
            Panel p = (Panel)sender;
            int index = panelPlateau.Controls.IndexOf(p);
            caseTerrain c = (caseTerrain)mono.getTabPlateau()[index];
            c.setNbConstruction(c.getNbConstruction() - 1); // enlever la maison
            if (c.getNbConstruction() == 4)
            {
                mono.setNbHotelDispo(mono.getNbHotelDispo() + 1);
                nbHotel.Text = Convert.ToString(mono.getNbHotelDispo());
            }
            else
            {
                mono.setNbMaisonDispo(mono.getNbMaisonDispo() + 1);
                nbMaison.Text = Convert.ToString(mono.getNbMaisonDispo());
            }
            c.setLoyer();                                       // recalculer le loyer
            mono.getListeJoueur()[mono.joueurEnCours].modifArgent(c.getPrixMaison() / 2);    // joueur reprend moitié du prix de la maison 
            mono.affichageMaisonHotel();                                     // maj l'affichage 
            mono.majEcran(mono.joueurEnCours);
            c.setLoyer();
            mono.avoirDetteOuFaillite(mono.getListeJoueur()[mono.joueurEnCours]);
        }

        // cliquer sur le bouton hypothecaire pour déclencher l'événement d'hypothecaire
        public void btnHypotheque(object sender, EventArgs e)
        {
            //remisePanelNormal();
            List<int> casChoisi = mono.getListeJoueur()[mono.getJoueurEnCours()].listeTerrainVideEtGareEtCompagnie();
            foreach (int i in casChoisi)
            {
                Panel p = (Panel)panelPlateau.Controls[i];
                p.BorderStyle = BorderStyle.Fixed3D;
                p.BackColor = constant.monter;
                p.Click -= (afficherCase);
                p.Click += new EventHandler(eventHypothecaire);
            }
            foreach (caseTerrain c in mono.getListeJoueur()[mono.getJoueurEnCours()].listeTerrainVide())
            {
                if (c.getHypotheque())
                {
                    int i = c.getIndexCase();
                    Panel p = (Panel)panelPlateau.Controls[i];
                    p.BorderStyle = BorderStyle.Fixed3D;
                    p.BackColor = constant.leverHypotheque;
                    p.Click -= (afficherCase);
                    p.Click += new EventHandler(eventLeverHypotheque);
                }
            }
            dlgMessage m = new dlgMessage("HYPOTHECAIRE", "Veuillez choisir la propriété que vous voulez poser ou lever l'hypothèque parmi des cas masqués !");
            m.ShowDialog();
        }

        //cliquer sur 1 cas pour poser l'hypothèque
        public void eventHypothecaire(object sender, EventArgs e)
        {
            List<int> casChoisi = mono.getListeJoueur()[mono.joueurEnCours].listeTerrainVideEtGareEtCompagnie();
            foreach (int i in casChoisi)
            {
                Panel a = (Panel)panelPlateau.Controls[i];
                a.BorderStyle = BorderStyle.None;
                a.BackColor = Color.Transparent;
                a.Click -= (eventHypothecaire);
                a.Click += (afficherCase);
            }
            foreach (caseTerrain cas in mono.getListeJoueur()[mono.getJoueurEnCours()].listeTerrainVide())
            {
                if (cas.getHypotheque())
                {
                    int i = cas.getIndexCase();
                    Panel l = (Panel)panelPlateau.Controls[i];
                    l.BorderStyle = BorderStyle.None;
                    l.BackColor = constant.hypotheque;
                    l.Click -= (eventLeverHypotheque);
                    l.Click += (afficherCase);
                }
            }
            Panel p = (Panel)sender;
            int index = panelPlateau.Controls.IndexOf(p);
            p.BackColor = constant.hypotheque;
            casePropriete c = (casePropriete)mono.getTabPlateau()[index];
            c.setHypotheque(true);  // set propriété est hypothèque                                      
            mono.getListeJoueur()[mono.joueurEnCours].modifArgent((int)(c.getPrix() / 2));    // joueur reprend moitié du prix
            mono.affichageMaisonHotel();                                     // maj l'affichage 
            mono.majEcran(mono.joueurEnCours);
            dlgMessage m = new dlgMessage("HYPOTHEQHE", c.getNom() + " est bien hypothéquée !\n Vous avez " + c.getPrix() / 2 + " € !");
            m.ShowDialog();
            mono.avoirDetteOuFaillite(mono.getListeJoueur()[mono.joueurEnCours]);
        }

        //cliquer sur 1 cas pour lever l'hypothèque
        public void eventLeverHypotheque(object sender, EventArgs e)
        {
            List<int> casChoisi = mono.getListeJoueur()[mono.joueurEnCours].listeTerrainVideEtGareEtCompagnie();
            foreach (int i in casChoisi)
            {
                Panel a = (Panel)panelPlateau.Controls[i];
                a.BorderStyle = BorderStyle.None;
                a.BackColor = Color.Transparent;
                a.Click -= (eventHypothecaire);
                a.Click += (afficherCase);
            }
            foreach (caseTerrain cas in mono.getListeJoueur()[mono.getJoueurEnCours()].listeTerrainVide())
            {
                if (cas.getHypotheque())
                {
                    int i = cas.getIndexCase();
                    Panel l = (Panel)panelPlateau.Controls[i];
                    l.BorderStyle = BorderStyle.None;
                    l.BackColor = constant.hypotheque;
                    l.Click -= (eventLeverHypotheque);
                    l.Click += (afficherCase);
                }
            }
            Panel p = (Panel)sender;
            int index = panelPlateau.Controls.IndexOf(p);
            p.BackColor = Color.Transparent;
            casePropriete c = (casePropriete)mono.getTabPlateau()[index];
            c.setHypotheque(false);  // lever l'hypothèque                                      
            mono.getListeJoueur()[mono.joueurEnCours].modifArgent(-(int)(c.getPrix() / 2 * 1.1));    // joueur payer le prix de l'hypothèque + 10%
            mono.majEcran(mono.joueurEnCours);
            dlgMessage m = new dlgMessage("LEVER L'HYPOTHEQHE", "Vous avez lever l'hypothèque de " + c.getNom() + "\n Vous avez payé " + (int)(c.getPrix() / 2 * 1.1) + " € !");
            if(c is caseTerrain)
            {
                caseTerrain cas = (caseTerrain)c;
                mono.siLoyerDoubleFullColor(cas);
            }
            m.ShowDialog();
            mono.avoirDetteOuFaillite(mono.getListeJoueur()[mono.joueurEnCours]);
        }

        public void remisePanelNormalEnCliquerUnAutreBouton(object sender, EventArgs e)
        {
            remisePanelNormal();
        }
        public void remisePanelNormal()
        {
            foreach (Panel p in panelPlateau.Controls)
            {
                if (panelPlateau.Controls.IndexOf(p) < 40)
                {
                    if (p.BackColor == constant.monter)
                    {
                        p.BackColor = Color.Transparent;
                    }
                    p.Click += null;
                    p.MouseEnter += (enterPanel);
                    p.MouseLeave += (outPanel);
                    p.Click += (afficherCase);
                }
            }
        }


        private void enterPanel(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BorderStyle = BorderStyle.Fixed3D;
        }

        private void enterControlPanel(object sender, EventArgs e)
        {
            Control c;
            if (sender is Label)
            {
                Label l = (Label)sender;
                c = l.Parent;
            }
            else
            {
                PictureBox l = (PictureBox)sender;
                c = l.Parent;
            }
            enterPanel(c, e);
        }
        private void clicConTrolPanel(object sender, EventArgs e)
        {
            Control c;
            if (sender is Label)
            {
                Label l = (Label)sender;
                c = l.Parent;
            }
            else
            {
                PictureBox l = (PictureBox)sender;
                c = l.Parent;
            }
            affichePortefeuille(c, e);
        }

        private void outPanel(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BorderStyle = BorderStyle.None;
        }



        public ImageList getListeBg()
        {
            return bgJoueurListe;
        }

        public ImageList getListePion()
        {
            return pionListImage;
        }

        private void quittezLaPartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Quitter", "Vous voulez quitter la partie ?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Form4 wd = new Form4();
                wd.Show();
                this.Dispose();
            }
        }

        private void règlesMonopolyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reglesMono regle = new reglesMono();
            regle.ShowDialog();
        }

        void EndGame()
        {
            DialogResult res;
            formFinirPartie fini = new formFinirPartie(mono.joueurEnCours);
            res = fini.ShowDialog();
            if (res == DialogResult.Yes)
            {
                Form4 fenetre = new Form4();
                fenetre.Show();
                this.Dispose();
            }
        }

        void mono_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }
    }
}
;