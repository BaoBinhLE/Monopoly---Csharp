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
    public partial class Form3 : Form
    {
       
        public int indexImageChoisi = -1;
        
        public static List<PictureBox> listPictureBoxs = new List<PictureBox>();
        private int indexJoueur;
        public static List<pion> listPions = new List<pion>();
        
        public Form3(int indexJoueur)
        {
            this.indexJoueur = indexJoueur;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            listPions = getNouveauListPion();
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackgroundImage = Image.FromFile("images/button/bronzeButton.png");
           
            for (int i = 0; i < this.Controls.Count - 1; i++)
            {
                if (this.Controls[i] is PictureBox) {
                    PictureBox picturebox = (PictureBox)this.Controls[i];
                    picturebox.Image = imageList1.Images[i];
                    picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                    picturebox.MouseClick += new MouseEventHandler(pictureBox_Click);
                }               
            }           
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            indexImageChoisi = this.Controls.IndexOf(pictureBox);
            this.Controls[indexImageChoisi].BackColor = Color.Transparent;
            pictureBox.BackColor = Color.Yellow;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {       
            this.Dispose();       
        }

        public List<pion> getListPion()
        {
            List<pion> listPions = new List<pion>();

            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                pion pion = new pion(i);
                listPions.Add(pion);
            }
            return listPions;
        }

        public List<pion> getNouveauListPion()
        {
            if (listPions.Count() == 0) {
                listPions = getListPion();
            }        
            return listPions;
        }

        public ImageList getImageList()
        {
            return imageList1;
        }
    }
}
