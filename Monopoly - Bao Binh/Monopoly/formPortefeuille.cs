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
    public partial class formPortefeuille : Form
    {
        public formPortefeuille(int num, string nom, int propriete, int maisonHotel, int argent, int carteLibere )
        {
            InitializeComponent();
            this.Text = nom;
            setCouleur(num);
            label6.Text = Convert.ToString(propriete)+" €";
            label7.Text = Convert.ToString(maisonHotel) + " €";
            label8.Text = Convert.ToString(argent) + " €";
            label9.Text = Convert.ToString(propriete + maisonHotel + argent) + " €";
            label10.Text = Convert.ToString(carteLibere);
        }

        public void setCouleur(int num)
        {
            List<Color> listeColouleur = new List<Color>();
            listeColouleur.Add(Color.FromArgb(255, 208, 1, 255));
            listeColouleur.Add(Color.FromArgb(255, 123, 201,1)) ;
            listeColouleur.Add(Color.FromArgb(255,253,87,130));
            listeColouleur.Add(Color.FromArgb(255,0,255,255));
            panel1.BackColor = (Color)listeColouleur[num];
        }

      
    }
}
