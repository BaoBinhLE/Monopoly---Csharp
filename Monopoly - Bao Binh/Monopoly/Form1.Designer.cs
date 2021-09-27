
namespace Monopoly
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plateau = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règlesMonopolyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittezLaPartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgJoueurListe = new System.Windows.Forms.ImageList(this.components);
            this.pionListImage = new System.Windows.Forms.ImageList(this.components);
            this.desListImage = new System.Windows.Forms.ImageList(this.components);
            this.panelDes = new System.Windows.Forms.Panel();
            this.lancerDes = new System.Windows.Forms.Button();
            this.boxDes2 = new System.Windows.Forms.PictureBox();
            this.boxDes1 = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.vendreM = new System.Windows.Forms.Button();
            this.acheterM = new System.Windows.Forms.Button();
            this.hypotheque = new System.Windows.Forms.Button();
            this.echange = new System.Windows.Forms.Button();
            this.finDuTour = new System.Windows.Forms.Button();
            this.panelJoueur = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPlateau = new System.Windows.Forms.Panel();
            this.timerDice = new System.Windows.Forms.Timer(this.components);
            this.panelMaiTel = new System.Windows.Forms.Panel();
            this.nbHotel = new System.Windows.Forms.Label();
            this.nbMaison = new System.Windows.Forms.Label();
            this.lblJoueurEncours = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelDes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxDes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxDes1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMaiTel.SuspendLayout();
            this.SuspendLayout();
            // 
            // plateau
            // 
            this.plateau.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("plateau.ImageStream")));
            this.plateau.TransparentColor = System.Drawing.Color.Transparent;
            this.plateau.Images.SetKeyName(0, "240568378_374539584125974_6858956203146061681_n.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1381, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.règlesMonopolyToolStripMenuItem,
            this.quittezLaPartieToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // règlesMonopolyToolStripMenuItem
            // 
            this.règlesMonopolyToolStripMenuItem.Name = "règlesMonopolyToolStripMenuItem";
            this.règlesMonopolyToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.règlesMonopolyToolStripMenuItem.Text = "Règles Monopoly";
            this.règlesMonopolyToolStripMenuItem.Click += new System.EventHandler(this.règlesMonopolyToolStripMenuItem_Click);
            // 
            // quittezLaPartieToolStripMenuItem
            // 
            this.quittezLaPartieToolStripMenuItem.Name = "quittezLaPartieToolStripMenuItem";
            this.quittezLaPartieToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.quittezLaPartieToolStripMenuItem.Text = "Quittez la partie ";
            this.quittezLaPartieToolStripMenuItem.Click += new System.EventHandler(this.quittezLaPartieToolStripMenuItem_Click);
            // 
            // bgJoueurListe
            // 
            this.bgJoueurListe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bgJoueurListe.ImageStream")));
            this.bgJoueurListe.TransparentColor = System.Drawing.Color.Transparent;
            this.bgJoueurListe.Images.SetKeyName(0, "tuym.png");
            this.bgJoueurListe.Images.SetKeyName(1, "green.png");
            this.bgJoueurListe.Images.SetKeyName(2, "pink.png");
            this.bgJoueurListe.Images.SetKeyName(3, "blue.png");
            // 
            // pionListImage
            // 
            this.pionListImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pionListImage.ImageStream")));
            this.pionListImage.TransparentColor = System.Drawing.Color.Transparent;
            this.pionListImage.Images.SetKeyName(0, "chien.png");
            this.pionListImage.Images.SetKeyName(1, "cat.png");
            this.pionListImage.Images.SetKeyName(2, "brouette.png");
            this.pionListImage.Images.SetKeyName(3, "bateau.png");
            this.pionListImage.Images.SetKeyName(4, "auto.png");
            this.pionListImage.Images.SetKeyName(5, "chapeau.png");
            this.pionListImage.Images.SetKeyName(6, "chaussure.png");
            this.pionListImage.Images.SetKeyName(7, "thimble.png");
            // 
            // desListImage
            // 
            this.desListImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("desListImage.ImageStream")));
            this.desListImage.TransparentColor = System.Drawing.Color.Transparent;
            this.desListImage.Images.SetKeyName(0, "dice 1.png");
            this.desListImage.Images.SetKeyName(1, "dice 2.png");
            this.desListImage.Images.SetKeyName(2, "dice 3.png");
            this.desListImage.Images.SetKeyName(3, "dice 4.png");
            this.desListImage.Images.SetKeyName(4, "dice 5.png");
            this.desListImage.Images.SetKeyName(5, "dice 6.png");
            // 
            // panelDes
            // 
            this.panelDes.Controls.Add(this.lancerDes);
            this.panelDes.Controls.Add(this.boxDes2);
            this.panelDes.Controls.Add(this.boxDes1);
            this.panelDes.Location = new System.Drawing.Point(803, 83);
            this.panelDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDes.Name = "panelDes";
            this.panelDes.Size = new System.Drawing.Size(200, 160);
            this.panelDes.TabIndex = 2;
            // 
            // lancerDes
            // 
            this.lancerDes.Location = new System.Drawing.Point(31, 92);
            this.lancerDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lancerDes.Name = "lancerDes";
            this.lancerDes.Size = new System.Drawing.Size(149, 60);
            this.lancerDes.TabIndex = 2;
            this.lancerDes.UseVisualStyleBackColor = true;
            // 
            // boxDes2
            // 
            this.boxDes2.Location = new System.Drawing.Point(107, 12);
            this.boxDes2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxDes2.Name = "boxDes2";
            this.boxDes2.Size = new System.Drawing.Size(69, 70);
            this.boxDes2.TabIndex = 1;
            this.boxDes2.TabStop = false;
            // 
            // boxDes1
            // 
            this.boxDes1.Location = new System.Drawing.Point(31, 12);
            this.boxDes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxDes1.Name = "boxDes1";
            this.boxDes1.Size = new System.Drawing.Size(69, 70);
            this.boxDes1.TabIndex = 0;
            this.boxDes1.TabStop = false;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.vendreM);
            this.panelButton.Controls.Add(this.acheterM);
            this.panelButton.Controls.Add(this.hypotheque);
            this.panelButton.Controls.Add(this.echange);
            this.panelButton.Location = new System.Drawing.Point(805, 249);
            this.panelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(200, 300);
            this.panelButton.TabIndex = 3;
            // 
            // vendreM
            // 
            this.vendreM.Location = new System.Drawing.Point(28, 219);
            this.vendreM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vendreM.Name = "vendreM";
            this.vendreM.Size = new System.Drawing.Size(149, 60);
            this.vendreM.TabIndex = 3;
            this.vendreM.UseVisualStyleBackColor = true;
            // 
            // acheterM
            // 
            this.acheterM.Location = new System.Drawing.Point(28, 153);
            this.acheterM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acheterM.Name = "acheterM";
            this.acheterM.Size = new System.Drawing.Size(149, 60);
            this.acheterM.TabIndex = 2;
            this.acheterM.UseVisualStyleBackColor = true;
            // 
            // hypotheque
            // 
            this.hypotheque.Location = new System.Drawing.Point(28, 87);
            this.hypotheque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hypotheque.Name = "hypotheque";
            this.hypotheque.Size = new System.Drawing.Size(149, 60);
            this.hypotheque.TabIndex = 1;
            this.hypotheque.UseVisualStyleBackColor = true;
            // 
            // echange
            // 
            this.echange.Location = new System.Drawing.Point(28, 21);
            this.echange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.echange.Name = "echange";
            this.echange.Size = new System.Drawing.Size(149, 60);
            this.echange.TabIndex = 0;
            this.echange.UseVisualStyleBackColor = true;
            // 
            // finDuTour
            // 
            this.finDuTour.Location = new System.Drawing.Point(835, 608);
            this.finDuTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finDuTour.Name = "finDuTour";
            this.finDuTour.Size = new System.Drawing.Size(149, 60);
            this.finDuTour.TabIndex = 4;
            this.finDuTour.UseVisualStyleBackColor = true;
            // 
            // panelJoueur
            // 
            this.panelJoueur.Location = new System.Drawing.Point(1029, 52);
            this.panelJoueur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelJoueur.Name = "panelJoueur";
            this.panelJoueur.Size = new System.Drawing.Size(211, 601);
            this.panelJoueur.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelPlateau);
            this.panel1.Location = new System.Drawing.Point(20, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 725);
            this.panel1.TabIndex = 6;
            // 
            // panelPlateau
            // 
            this.panelPlateau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlateau.BackgroundImage")));
            this.panelPlateau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPlateau.Location = new System.Drawing.Point(29, 30);
            this.panelPlateau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPlateau.Name = "panelPlateau";
            this.panelPlateau.Size = new System.Drawing.Size(665, 665);
            this.panelPlateau.TabIndex = 0;
            // 
            // timerDice
            // 
            this.timerDice.Interval = 10;
            // 
            // panelMaiTel
            // 
            this.panelMaiTel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMaiTel.BackgroundImage")));
            this.panelMaiTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMaiTel.Controls.Add(this.nbHotel);
            this.panelMaiTel.Controls.Add(this.nbMaison);
            this.panelMaiTel.Location = new System.Drawing.Point(1029, 658);
            this.panelMaiTel.Name = "panelMaiTel";
            this.panelMaiTel.Size = new System.Drawing.Size(211, 76);
            this.panelMaiTel.TabIndex = 7;
            // 
            // nbHotel
            // 
            this.nbHotel.AutoSize = true;
            this.nbHotel.BackColor = System.Drawing.Color.Transparent;
            this.nbHotel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbHotel.ForeColor = System.Drawing.Color.White;
            this.nbHotel.Location = new System.Drawing.Point(145, 26);
            this.nbHotel.Name = "nbHotel";
            this.nbHotel.Size = new System.Drawing.Size(44, 31);
            this.nbHotel.TabIndex = 1;
            this.nbHotel.Text = "12";
            // 
            // nbMaison
            // 
            this.nbMaison.AutoSize = true;
            this.nbMaison.BackColor = System.Drawing.Color.Transparent;
            this.nbMaison.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbMaison.ForeColor = System.Drawing.Color.White;
            this.nbMaison.Location = new System.Drawing.Point(69, 26);
            this.nbMaison.Name = "nbMaison";
            this.nbMaison.Size = new System.Drawing.Size(44, 31);
            this.nbMaison.TabIndex = 0;
            this.nbMaison.Text = "32";
            // 
            // lblJoueurEncours
            // 
            this.lblJoueurEncours.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueurEncours.Location = new System.Drawing.Point(807, 45);
            this.lblJoueurEncours.Name = "lblJoueurEncours";
            this.lblJoueurEncours.Size = new System.Drawing.Size(198, 29);
            this.lblJoueurEncours.TabIndex = 8;
            this.lblJoueurEncours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1381, 780);
            this.Controls.Add(this.lblJoueurEncours);
            this.Controls.Add(this.panelMaiTel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelJoueur);
            this.Controls.Add(this.finDuTour);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelDes);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONOPOLY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxDes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxDes1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMaiTel.ResumeLayout(false);
            this.panelMaiTel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList plateau;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem règlesMonopolyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quittezLaPartieToolStripMenuItem;
        private System.Windows.Forms.ImageList pionListImage;
        private System.Windows.Forms.ImageList desListImage;
        private System.Windows.Forms.Panel panelDes;
        private System.Windows.Forms.Button lancerDes;
        private System.Windows.Forms.PictureBox boxDes2;
        private System.Windows.Forms.PictureBox boxDes1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button echange;
        private System.Windows.Forms.Button vendreM;
        private System.Windows.Forms.Button acheterM;
        private System.Windows.Forms.Button hypotheque;
        private System.Windows.Forms.Button finDuTour;
        private System.Windows.Forms.Panel panelJoueur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPlateau;
        protected System.Windows.Forms.ImageList bgJoueurListe;
        private System.Windows.Forms.Panel panelMaiTel;
        private System.Windows.Forms.Label nbHotel;
        private System.Windows.Forms.Label nbMaison;
        private System.Windows.Forms.Timer timerDice;
        private System.Windows.Forms.Label lblJoueurEncours;
    }
}

