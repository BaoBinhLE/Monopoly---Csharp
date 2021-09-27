using System;
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
    public partial class dlgEnchere : Form
    {
        
        public Form form;
        public int joueurTour ;
        private int prixInit;
        public int prix ;
        public bool vendu = false;
        private int pasPrix;
        private bool augmenter = false;
        private List<int> joueurSuivi = new List<int>();
               
        public dlgEnchere(string nom, int prixCarte, string couleur, int loyerN, int loyer1, int loyer2, int loyer3, int loyer4, int loyerH, int prixconstruction)
        {
            InitializeComponent();

            form = new formInfoTerrain(nom, prixCarte, couleur, loyerN, loyer1, loyer2, loyer3, loyer4, loyerH, prixconstruction);
            prix = prixCarte/5;
            this.pasPrix = prix;
            this.prixInit = prix;
        }

        public dlgEnchere(string nom)
        {
            InitializeComponent();

            form = new formInfoGare(nom);
            prix = 25;
            pasPrix = 25;
            this.prixInit = prix;
        }

        public dlgEnchere(int numeroCase)
        {
            InitializeComponent();

            form = new formInfoCompagnie(numeroCase);

            prix = 25;
            pasPrix = 25;
            this.prixInit = prix;
        }

        private void dlgEnchere_Load(object sender, EventArgs e)
        {
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.StartPosition = FormStartPosition.CenterParent;
            form.BringToFront();
            form.Visible = true;

            panelJoueur.BackColor = Color.Transparent;
            panelJoueur.Top = 60;
            panelJoueur.Size = new Size(210, 600);
            for (int i = 0; i < joueur.listeJoueur.Count; i++)
            {
                if (!joueur.listeJoueur[i].isFaillite())
                {
                    Panel bgJoueur = new Panel();
                    bgJoueur.BackgroundImage = (Image)bgList.Images[i];
                    bgJoueur.BackgroundImageLayout = ImageLayout.Stretch;
                    //bgJoueur.BackColor = Color.Beige;
                    //bgJoueur.BorderStyle = BorderStyle.Fixed3D;
                    panelJoueur.Controls.Add(bgJoueur);
                    bgJoueur.Size = new Size(200, 130);
                    bgJoueur.Top = 140 * i;
                    bgJoueur.Left = 5;
                    //-----panel pion------
                    PictureBox pionPic = new PictureBox();

                    pionPic.Image = (Image)pionList.Images[joueur.listeJoueur[i].getPion()];
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
                    nom.Text = joueur.listeJoueur[i].getNom();
                    nom.Tag = i;
                    //---------label Argent---------
                    Label argent = new Label();
                    bgJoueur.Controls.Add(argent);
                    argent.Top = 100;
                    argent.Left = 50;
                    argent.TextAlign = ContentAlignment.MiddleRight;
                    argent.Font = new Font("MicrosoftYaHei", 12, FontStyle.Bold);
                    argent.BackColor = Color.Transparent;
                    argent.Text = joueur.listeJoueur[i].getArgent() + " €";
                    argent.Tag = i;
                }
            }
            getListJoueurInit();
            
        }

        public void getListJoueurInit()
        {
            for(int i = 0; i<joueur.listeJoueur.Count;i++)
            {
                joueurSuivi.Add(i);
            }
            joueurEncours.Text = "Tours de " + joueur.listeJoueur[joueurTour].getNom();
            label3.Text = Convert.ToString(prix);
            joueurTour = 0;
        }

        public void retireJoueur(int id)
        {
            joueurSuivi.Remove(id);
        }

        public void setJoueurEnCours()
        {
            joueurTour ++;
            if (joueurTour >= joueur.listeJoueur.Count)
            {
                joueurTour = 0;
            }
            joueurEncours.Text = "Tours de " + joueur.listeJoueur[joueurTour].getNom();
        }


        public void setProchainTour()
        {
            if (augmenter)
            {
                label3.Text = Convert.ToString(prix + pasPrix);
            }
            else
            {
                label3.Text = Convert.ToString(prix);
            }
            
            setJoueurEnCours();
            if(!joueurSuivi.Contains(joueurTour) && joueur.listeJoueur[joueurTour].getArgent() < (prix + pasPrix)){
                setProchainTour();
            }
            else if (!joueurSuivi.Contains(joueurTour))
            {
                button2.Enabled = false;
            }
            else if (joueur.listeJoueur[joueurTour].getArgent()< (prix + pasPrix))
            {
                button1.Enabled = false;
                joueurSuivi.Remove(joueurTour);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (joueurSuivi.Count == 1)
            {
                vendu = true;
                dlgMessage dlg = new dlgMessage("Offre ", joueur.listeJoueur[joueurTour].getNom() + " a eu cette propriété !");
                dlg.ShowDialog();
                this.Hide();
            }
            else
            {
                prix += pasPrix;
                augmenter = true;
                setProchainTour();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            augmenter = false;
            int bout = joueurTour;
            retireJoueur(joueurTour);
            if (joueurSuivi.Count > 1 || (joueurSuivi.Count == 1 && prix == prixInit))
            {
                setProchainTour();
            }
            else if(joueurSuivi.Count == 1 && prix > prixInit)
            {
                joueurTour = joueurSuivi[0];
                vendu = true;
                dlgMessage dlg = new dlgMessage("Offre ", joueur.listeJoueur[joueurTour].getNom()+" a eu cette propriété !");
                dlg.ShowDialog();
                this.Hide();
            }
            else if (joueurSuivi.Count ==0 && prix == prixInit)
            {
                dlgMessage dlg = new dlgMessage("Offre abandonné", "Retentez quand vous avez de l'argent !");
                dlg.ShowDialog();
                this.Dispose();
            }
        }
    }
}
