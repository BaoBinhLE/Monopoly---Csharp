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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("images/fond2.jpg");
            panel1.BackgroundImage = Image.FromFile("images/button/whitebutton.png");
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            button1.BackgroundImage = Image.FromFile("images/button/jouer.png");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.MouseEnter += new EventHandler(OnMouseEnterButton);

        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {         
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nbJoueurs = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            var form2 = new Form2(nbJoueurs);
            form2.Show();
            this.Dispose();
        }
    }
}
