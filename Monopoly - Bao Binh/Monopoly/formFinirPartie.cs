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
    public partial class formFinirPartie : Form
    {
        
        public formFinirPartie(int gagnant)
        {
            InitializeComponent();
            label1.Text = joueur.listeJoueur[gagnant].getNom().ToUpper()+ " A GAGNE !  VOUS VOULEZ RECOMMENCER UNE AUTRE PARTIE ?";
        }
    }
}
