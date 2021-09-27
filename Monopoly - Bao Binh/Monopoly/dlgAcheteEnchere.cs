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
    public partial class dlgAcheteEnchere : Form
    {
        public Form form;
        public bool acheter = true;
        bool pouvoirAchat;
        public dlgAcheteEnchere(string nom, int prixCarte, string couleur, int loyerN, int loyer1, int loyer2, int loyer3, int loyer4, int loyerH, int prixconstruction, bool pouvoirAchat)
        {
            InitializeComponent();

            form = new formInfoTerrain(nom, prixCarte, couleur, loyerN, loyer1, loyer2, loyer3, loyer4, loyerH, prixconstruction);
            this.pouvoirAchat = pouvoirAchat;
        }

        public dlgAcheteEnchere(string nom,bool pouvoirAchat)
        {
            InitializeComponent();

            form = new formInfoGare(nom);
            this.pouvoirAchat = pouvoirAchat;
        }

        public dlgAcheteEnchere(int numeroCase, bool pouvoirAchat)
        {
            InitializeComponent();

            form = new formInfoCompagnie(numeroCase);
            this.pouvoirAchat = pouvoirAchat;
        }

        private void dlgAcheteEnchere_Load(object sender, EventArgs e)
        {
            this.button1.Focus();
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Visible = true;
            button1.Enabled = pouvoirAchat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acheter = true;
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acheter = false;
        }
    }
}
