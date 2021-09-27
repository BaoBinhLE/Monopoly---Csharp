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
    public partial class Form4 : Form
    {
        private List<Button> listButtons = new List<Button>();
        
        public Form4()
        {
            InitializeComponent();
            joueur.listeJoueur.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("images/fond2.jpg");

            listButtons.Add(button1);
            listButtons.Add(button2);
            listButtons.Add(button3);

            button1.BackgroundImage = Image.FromFile("images/button/jouer.png");
            button2.BackgroundImage = Image.FromFile("images/button/quitter.png");
            button3.BackgroundImage = Image.FromFile("images/button/btnRegles.png");

            foreach (Button btn in listButtons)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.MouseEnter += new EventHandler(OnMouseEnterButton);              
            }
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
           
            form5.Show();

            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reglesMono regle = new reglesMono();
            regle.ShowDialog();
        }
    }
}
