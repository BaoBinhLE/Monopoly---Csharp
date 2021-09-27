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
    public partial class formInfoTerrain : Form
    {
        public formInfoTerrain(string nom, int prixCarte, string couleur, int loyerN, int loyer1, int loyer2, int loyer3, int loyer4, int loyerH, int prixconstruction)
        {
            InitializeComponent();
            this.Text = nom;
            label1.Text = nom;
            label15.Text = Convert.ToString(prixCarte)+" €";
            label16.Text = Convert.ToString(prixCarte/2) + " €";
            label17.Text = Convert.ToString(loyerN) + " €";
            label18.Text = Convert.ToString(loyerN*2) + " €";
            label19.Text = Convert.ToString(loyer1) + " €";
            label20.Text = Convert.ToString(loyer2) + " €";
            label21.Text = Convert.ToString(loyer3) + " €";
            label22.Text = Convert.ToString(loyer4) + " €";
            label23.Text = Convert.ToString(loyerH) + " €";
            label24.Text = Convert.ToString(prixconstruction) + " €";
            label25.Text = Convert.ToString(prixconstruction) + " €";
            couleurCadre(couleur);
        }

     

        private void couleurCadre(string col)
        {
            if (col == "jaune")
                panel2.BackColor = Color.Yellow;
            if (col == "bleuCiel")
                panel2.BackColor = Color.SkyBlue;
            if (col == "bleuFonce")
                panel2.BackColor = Color.Blue;
            if (col == "marron")
                panel2.BackColor = Color.SaddleBrown;
            if (col == "orange")
                panel2.BackColor = Color.Orange;
            if (col == "vert")
                panel2.BackColor = Color.Green;
            if (col == "rose")
                panel2.BackColor = Color.Pink;
            if (col == "rouge")
                panel2.BackColor = Color.Red;
        }

     
    }
}
