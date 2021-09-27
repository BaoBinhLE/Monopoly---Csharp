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
    public partial class Form2 : Form
    {
        
        private int nbJoueurs;
        private List<joueur> listJoueurs = new List<joueur>();
        public List<Panel> listPanels = new List<Panel>();
        public List<PictureBox> listPictureBoxs = new List<PictureBox>();
        private List<int> PionChoisi = new List<int>();
        public List<Button> listButtons = new List<Button>();
        public List<String> listNomsJoueurs = new List<String>();

        public Form2(int nbJoueurs)           
        {
            this.nbJoueurs = nbJoueurs;
    
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("images/fond4.png");
            listPanels.Clear();
            listPanels.Add(panel1);
            listPanels.Add(panel2);
            listPanels.Add(panel3);
            listPanels.Add(panel4);

            for(int i = 0; i < nbJoueurs; i++)
            {
                listPanels[i].BackgroundImage = Image.FromFile("images/button/tag.png");
                listPanels[i].Visible = true;              
            }

            listPictureBoxs.Add(pictureBox1);
            listPictureBoxs.Add(pictureBox2);
            listPictureBoxs.Add(pictureBox3);
            listPictureBoxs.Add(pictureBox4);

            foreach(PictureBox pictureBox in listPictureBoxs)
            {
                pictureBox.Image = imageList1.Images[listPictureBoxs.IndexOf(pictureBox)];
                pictureBox.Tag = listPictureBoxs.IndexOf(pictureBox);
            }
                 
            listButtons.Add(button1);
            listButtons.Add(button2);
            listButtons.Add(button3);
            listButtons.Add(button4);
         
            foreach (Button btn in listButtons)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImage = Image.FromFile("images/button/circlepen.png");
                btn.Click += new EventHandler(btn_Click);
                btn.MouseEnter += new EventHandler(OnMouseEnterButton);

            }



            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.BackgroundImage = Image.FromFile("images/button/jouer.png");
            button5.MouseEnter += new EventHandler(OnMouseEnterButton);

            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.BackgroundImage = Image.FromFile("images/button/arrow.png");
            button6.MouseEnter += new EventHandler(OnMouseEnterButton);


        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = listButtons.IndexOf(btn);
            DialogResult res;
            Form3 form3 = new Form3(index);
            res = form3.ShowDialog();
            if(res == DialogResult.OK)
            {
                listPictureBoxs[index].Image = imageList1.Images[form3.indexImageChoisi];
                listPictureBoxs[index].Tag = form3.indexImageChoisi;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getNouveauListeNom();
            getNouveauListeJoueurPions();
            if (!tousNomRemplis())
                {
                    MessageBox.Show("Veuillez renseigner tous les noms des joueurs!");
                }
                else if (testDoublonNom()) {
                    MessageBox.Show("Les noms des joueurs doivent être différents!");
                }
                else if (testDoublonPion())
                {
                    MessageBox.Show("Les pions des joueurs doivent être différents!");
                }
                else
                {
                    creerJoueur();
                    /*mono.initJeu(listJoueurs);*/
                    Form form1 = new Form1();
                    form1.Show();
                    this.Visible = false;
                }
                
            }

        private Boolean testDoublonNom()
        {
          
            Boolean doublon = false;
            for (int i = 0; i <= nbJoueurs - 2; i++)
            {
                for (int j = i+1; j <= nbJoueurs - 1; j++)
                {                   
                    if (listNomsJoueurs[i].Equals(listNomsJoueurs[j]))
                    {                       
                        doublon = true;                                              
                    }                   
                }              
            }
            return doublon;
        }

        private Boolean testDoublonPion()
        {
           
            Boolean doublon = false;
            for (int i = 0; i <= nbJoueurs - 2; i++)
            {
                for (int j = i+1; j <= nbJoueurs - 1; j++)
                {                             
                    if (listPictureBoxs[i].Image == (listPictureBoxs[j].Image))
                    {
                        doublon = true;      
                    }                    
                }
            }
            return doublon;
        }

        private Boolean tousNomRemplis()
        {
            Boolean filled = true;
            for (int i = 0; i <= nbJoueurs -1; i++)
            {
                if (listNomsJoueurs[i].Length == 0)
                {
                    filled = false;
                }
            }
            return filled;
        }

       
        private void creerJoueur()
        {   
            for (int i = 0; i < nbJoueurs; i++)
            {
                joueur joueur = new joueur(listNomsJoueurs[i], PionChoisi[i]);
                listJoueurs.Add(joueur);
            }
        }

        private void getNouveauListeNom()
        {
            listNomsJoueurs.Clear();
            listNomsJoueurs.Add(textBox1.Text);
            listNomsJoueurs.Add(textBox2.Text);
            listNomsJoueurs.Add(textBox3.Text);
            listNomsJoueurs.Add(textBox4.Text);
        }

        private void getNouveauListeJoueurPions()
        {
            PionChoisi.Clear();
            for(int i = 0; i< listPictureBoxs.Count; i++)
            {
                PionChoisi.Add(Convert.ToInt32(listPictureBoxs[i].Tag));
            }
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.Show();
            this.Dispose();
            
        }
    }
}
