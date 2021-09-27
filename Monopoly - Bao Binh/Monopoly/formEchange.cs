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
    public partial class formEchange : Form
    {
        private int joueurEncours;
        private List<joueur> listeJoueurEchange = new List<joueur>();
        private joueur joueurChoisi;
        public int numJoueurChoisi;
        public int caseChoisi1;
        public int caseChoisi2;
        public int x=0;
        public int y=0;

        public formEchange(int joueurEncours)
        {
            InitializeComponent();

            this.joueurEncours = joueurEncours;
        }



       

        private void formEchange_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            button2.Visible = false;
            
            for( int i = 0; i < joueur.listeJoueur.Count; i++)
            {
                if(i != joueurEncours && !joueur.listeJoueur[i].isFaillite())
                {
                    listeJoueurEchange.Add(joueur.listeJoueur[i]);
                    listBox3.Items.Add(joueur.listeJoueur[i].getNom());
                }
            }
            label6.Text = joueur.listeJoueur[joueurEncours].getNom();
            foreach (int c in joueur.listeJoueur[joueurEncours].listeTousProprietes())
            {
                casePropriete cas = (casePropriete)mono.tabPlateau[c];
                listBox1.Items.Add(cas.getNom());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listBox3.SelectedIndex;
            joueurChoisi = listeJoueurEchange[a];
            numJoueurChoisi = joueurChoisi.getNumero();
            label7.Text = joueurChoisi.getNom();
            listBox4.Items.Clear();
            foreach (int c in joueurChoisi.listeTousProprietes())
            {
                casePropriete cas = (casePropriete)mono.tabPlateau[c];
                listBox4.Items.Add(cas.getNom());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItems.Count == 0 || listBox4.SelectedItems.Count == 0)
            {
                MessageBox.Show("Impossible ! Votre sélection est vide !", " Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (textBox1.Text != "" && !(int.TryParse(textBox1.Text, out x)))
            {
                MessageBox.Show("Veuillez d'entrer les bons chiffres !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
            else if (textBox3.Text != "" && !(int.TryParse(textBox3.Text, out y)))
            {
                MessageBox.Show("Veuillez d'entrer les bons chiffres !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "";
            }
            
            else
            {
                if (textBox1.Text == "")
                {
                    x = 0;
                }
                if(textBox3.Text == "")
                {
                    y = 0;
                }
                
                envoieOffre();
                int a = (int)listBox1.SelectedIndex;
                caseChoisi1 = joueur.listeJoueur[joueurEncours].listeTousProprietes()[a];
                int b = (int)listBox4.SelectedIndex;
                caseChoisi2 = joueurChoisi.listeTousProprietes()[b];
            }
        }

        public void envoieOffre()
        {
            dlgMessage dlg = new dlgMessage("Offre envoyé à " + joueurChoisi.getNom(), "A "+ joueurChoisi.getNom() +" de accepter ou réfuser l'offre !");
            dlg.ShowDialog();
            button1.Visible = false;
            button2.Visible = true;
            if (joueurChoisi.getArgent()> y){
                button3.Visible = true;
            }
        }
    }
}
