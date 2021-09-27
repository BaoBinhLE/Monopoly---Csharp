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
    public partial class dlgLeverHypotheque : Form
    {
        public Form form;
        private int player;
        public dlgLeverHypotheque(string nom, int prixCarte, string couleur, int loyerN, int loyer1, int loyer2, int loyer3, int loyer4, int loyerH, int prixconstruction,int player)
        {
            InitializeComponent();
            this.player = player;
            form = new formInfoTerrain(nom, prixCarte, couleur, loyerN, loyer1, loyer2, loyer3, loyer4, loyerH, prixconstruction);
            if (joueur.listeJoueur[player].getArgent() < prixCarte / 2 * 1.1)
            {
                button1.Enabled = false;
            }
        }

        public dlgLeverHypotheque(string nom, int player)
        {
            InitializeComponent();
            this.player = player;
            form = new formInfoGare(nom);
            if (joueur.listeJoueur[player].getArgent() < 110)
            {
                button1.Enabled = false;
            }
        }

        public dlgLeverHypotheque(int numeroCase, int player)
        {
            InitializeComponent();
            this.player = player;
            form = new formInfoCompagnie(numeroCase);
            if (joueur.listeJoueur[player].getArgent() < 83)
            {
                button1.Enabled = false;
            }
        }

        private void dlgLeverHypotheque_Load(object sender, EventArgs e)
        {
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.StartPosition = FormStartPosition.CenterParent;
            form.BringToFront();
            form.Visible = true;

            
        }
    }
}
