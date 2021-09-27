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
    public partial class formInfoCompagnie : Form
    {
        public formInfoCompagnie(int numeroCase)
        {
            InitializeComponent();
            affichage(numeroCase);

        }

        private void affichage(int numero)
        {
            if (numero == 12)
            {
                panel2.BackgroundImage = Image.FromFile("images/compagnie_electricite.png");
                label1.Text = "Compagnie d'électricité";
               
            }
            else if (numero == 28)
            {
                panel2.BackgroundImage = Image.FromFile("images/compagnie_eaux.png");
                label1.Text = "Compagnie des eaux";
            }
            this.Text = label1.Text;
        }

       
    }
}
