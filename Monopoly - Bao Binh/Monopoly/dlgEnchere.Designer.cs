
namespace Monopoly
{
    partial class dlgEnchere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgEnchere));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelJoueur = new System.Windows.Forms.Panel();
            this.bgList = new System.Windows.Forms.ImageList(this.components);
            this.pionList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joueurEncours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(69, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 571);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENCHERE";
            // 
            // panelJoueur
            // 
            this.panelJoueur.Location = new System.Drawing.Point(896, 80);
            this.panelJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.panelJoueur.Name = "panelJoueur";
            this.panelJoueur.Size = new System.Drawing.Size(260, 576);
            this.panelJoueur.TabIndex = 2;
            // 
            // bgList
            // 
            this.bgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bgList.ImageStream")));
            this.bgList.TransparentColor = System.Drawing.Color.Transparent;
            this.bgList.Images.SetKeyName(0, "tuym.png");
            this.bgList.Images.SetKeyName(1, "green.png");
            this.bgList.Images.SetKeyName(2, "pink.png");
            this.bgList.Images.SetKeyName(3, "blue.png");
            // 
            // pionList
            // 
            this.pionList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pionList.ImageStream")));
            this.pionList.TransparentColor = System.Drawing.Color.Transparent;
            this.pionList.Images.SetKeyName(0, "chien.png");
            this.pionList.Images.SetKeyName(1, "cat.png");
            this.pionList.Images.SetKeyName(2, "brouette.png");
            this.pionList.Images.SetKeyName(3, "bateau.png");
            this.pionList.Images.SetKeyName(4, "auto.png");
            this.pionList.Images.SetKeyName(5, "chapeau.png");
            this.pionList.Images.SetKeyName(6, "chaussure.png");
            this.pionList.Images.SetKeyName(7, "thimble.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(585, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "BID";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(585, 543);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "SE RETIRER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joueurEncours
            // 
            this.joueurEncours.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueurEncours.Location = new System.Drawing.Point(590, 309);
            this.joueurEncours.Name = "joueurEncours";
            this.joueurEncours.Size = new System.Drawing.Size(264, 64);
            this.joueurEncours.TabIndex = 7;
            this.joueurEncours.Text = "label3";
            this.joueurEncours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(590, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 100);
            this.label2.TabIndex = 8;
            this.label2.Text = "Qui me donne ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(680, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 52);
            this.label3.TabIndex = 9;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = "€   ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dlgEnchere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 772);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.joueurEncours);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelJoueur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dlgEnchere";
            this.Text = "Enchère";
            this.Load += new System.EventHandler(this.dlgEnchere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelJoueur;
        private System.Windows.Forms.ImageList bgList;
        private System.Windows.Forms.ImageList pionList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joueurEncours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}