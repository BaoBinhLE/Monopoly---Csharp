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
    public partial class reglesMono : Form
    {
        public reglesMono()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Both;
        }

        private void reglesMono_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Au début d’une partie chaque joueur choisi un pion et le banquier distribue à chaque joueur 1500 € \r\n" +
                "\r\nLes cases du plateau de jeu Monopoly :\r\n\r\n" +
                "       Il existe trois types de propriété au Monopoly : les terrains nus(terrains par groupe de couleur), les gares(au nombre de 4) et les compagnies de service public (à savoir la compagnie d’eau et d’électricité)." +
                "\r\n\r\nLorsqu’un joueur s’arrête sur une case n’appartenant à personne il peut l’acquérir en payant le prix indiqué sur la case du plateau de jeu.Le paiement se fait à la banque et le joueur reçoit en échange le titre de propriété correspondant.Si le joueur n’achète pas le terrain le banquier doit ouvrir une vente aux enchères." +
                "\r\nL’objectif au Monopoly est d’essayer d’acheter tous les terrains d’une même couleur.En effet, lorsque vous possédez tous les terrains d’un même groupe de couleur les loyers sont plus chers et vos revenus sont donc plus élevés.Quand un autre joueur arrive sur votre terrain il doit s’acquitter du loyer." +
                "Le fait de posséder tous les terrains de la même couleur vous permet de construire des maisons et des hôtels. Le but étant de toujours accroitre ses revenus." +
                "\r\n\r\nLes propriétés appartenant déjà à un autre joueur :\r\n" +
                "      Quand un joueur s’arrête sur une propriété qui appartient à quelqu’un d’autre, il doit normalement payer un loyer. Le loyer est indiqué sur le titre de propriété du terrain et est différent selon le nombre de bâtiments qu’il y a sur celui-ci (terrain nu, 2 maisons, 1 hôtel…). Si la propriété est hypothéquée vous n’avez aucun loyer à payer(titre de propriété retourné).\r\n" +
                "\r\nTerrain :\r\n" +
                "Le loyer pour un terrain nu, c’est-à-dire sans bâtiments dessus, est indiqué sur le titre de propriété.Si un joueur possède tous les terrains (non hypothéqués) d’un même groupe de couleur, les loyers sont doublés." +
                "S’il y a des maisons ou un hôtel sur le terrain, le loyer est encore plus élevé. Tous les montants des loyers sont indiqués avec précision sur les titres de propriété.\r\n" +
                "\r\nGare :\r\n" +
                "Le loyer dépend du nombre de gare que vous possédez. Le loyer est doublé à chaque gare en plus.Ainsi, il est intéressant d’en posséder le maximum. Les loyers des gares  est indiqué sur le titre de propriété.\r\n" +
                "\r\n\r\nCompagnie de Service Public(eau et électricité) :\r\n" +
                "Le montant du loyer correspond au jet de dés.Ainsi, pour connaitre le montant du loyer il faut lancer les dés et multiplier le résultat par 4. Si vous possédez les 2 compagnies il faut multiplier par 10 !\r\n\r\n" +
                "Les cartes « Caisse de communauté » et « Chance » :\r\n" +
                "Lorsque vous tombez sur une case « Chance » ou « Caisse de communauté », vous devez ensuite suivre les instructions de celle-ci.Vous pouvez recevoir de l’argent ou au contraire payer une taxe.La carte doit être remise ensuite sous le tas de carte face cachée.\r\n" +
                "Si vous piochez une carte « Vous êtes libéré de prison » vous pouvez la garder jusqu’à ce qu’elle vous serve.\r\n" +
                "Impôts et Taxes de luxe : Quand un joueur s’arrête sur une de ces cases il doit payer le montant indiqué à la banque.\r\n" +
                "\r\nAllez en prison : \r\n" +
                "Si vous vous arrêtez sur cette case vous devez aller en prison.Vous ne passez pas par la case départ et donc aucun salaire(200 €) ne vous sera versez.Si vous allez en prison votre tour est terminé et vous donnez les dés au joueur suivant.\r\n" +
                "\r\nVous êtes envoyé en prison :\r\n" +
                "   Si vous tirez une carte qui vous indique d’aller en prison.\r\n" +
                "   Si vous faites 3 doubles d’affilée aux dés.\r\n" +
                "\r\nIl existe 3 moyens pour sortir de prison :\r\n\r\n" +
                "   Payer une amende de 50 € au début du tour suivant.Cela vous permet de sortir de prison et de bouger votre pion normalement.L’amende est à réglée à la banque.\r\n" +
                "   Utiliser une carte « Vous êtes libéré de prison » si vous en possédez une. Elle ne peut être utilisée qu’une fois (une carte / une libération de prison). Il est possible d’avoir deux cartes en main.\r\n" +
                "   Vous êtes en prison pour trois tours.Vous pouvez attendre la fin des trois tours en essayant de vous libérer à chaque tour en faisant un double. Si vous faites un double vous êtes libéré de prison et pouvez repartir en relançant les dés.Si à la fin des trois tours vous n’avez pas fait de double vous devez payer une amende de 50 € à la banque avant de pouvoir repartir normalement.\r\n\r\n" +
                "Simple visite (Prison) : Lorsque vous arrivez sur la carte prison lors d’un déplacement normal ne paniquez pas. Vous ne faites que la visite.\r\n" +
                "\r\nParc gratuit : Détendez-vous . Rien ne se passez.\r\n\r\n" +
                "\r\nComment jouer au Monopoly :\r\n\r\n" +
                "Le premier joueur commence la partie. Les joueurs commencent le jeu à partir de la case départ." +
                "Le joueur avance d’autant de cases que le nombre indiqué sur les dés. La case ou vous vous arrêtez " +
                "déterminera ce que vous avez à faire . Il faut savoir que l’on peut acheter un terrain dès le premier" +
                " lancer de dés.Tous les joueurs peuvent acheter un terrain dès le premier tour.\r\n" +
                "La banque doit vous verser 200 €  à chaque fois que vous passez par la case départ(ou que vous vous" +
                " arrêtez sur celle-ci). Le fait de faire un double aux dés vous donne la possibilité de rejouer." +
                "Attention, si vous faites trois doubles d’affilée vous devez vous rendre immédiatement en prison.\r\n\r\n" +
                "Les différentes opérations du Monopoly :\r\n" +
                "\r\nVous pouvez effectuer différentes opérations même si vous êtes en prison.\r\n" +
                "\r\n1.  Percevoir un loyer : si un joueur s’arrête sur une de vos propriétés non hypothéquées, " +
                "vous pouvez lui réclamer le loyer suivant les indications du titre de propriété (voir propriété" +
                " appartenant à un autre joueur).\r\n\r\n" +
                "2.  Vente aux enchères : c’est le banquier qui a la responsabilité des ventes aux enchères." +
                "Il y a vente aux enchères :\r\n" +
                "Quand un joueur s’arrête sur une propriété qui n’appartient à personne et qu’il décide " +
                "de ne pas l’acheter.Les autres peuvent donc l’acquérir aux enchères.\r\n" +
                "Quand un joueur fait faillite et que ses titres de propriété retournent à la banque." +
                "Ces propriétés sont vendues non hypothéquées.\r\n" +
                "Tout le monde peut participer même si vous avez refusé le prix initial.\r\n" +
                "\r\n3.  Construire : pour acheter des maisons il vous faut obligatoirement posséder tous les terrains " +
                "d’un même groupe de couleur.\r\n" +
                "Le prix d’une maison est indiqué sur le titre de propriété.Il est plus ou moins élevé selon la rue " +
                "sur laquelle la maison est construite.\r\n" +
                "Vous devez construire uniformément.C’est-à-dire que vous ne pouvez pas construire de deuxième maison" +
                " sur un terrain si vous n’avez pas construit une maison sur chaque terrain d’une même couleur auparavant.\r\n" +
                "Vous pouvez construire 4 maisons au maximum par terrain.\r\n" +
                "Vous pouvez échanger 4 maisons contre un hôtel en payant le prix indiqué sur le titre de propriété." +
                " Un seul hôtel par terrain est autorisé.\r\n" +
                "Il faut savoir qu’il est impossible de construire une maison ou un hôtel si il y’a un terrain du même" +
                " groupe de couleur qui est hypothéqué.\r\n" +
                "Crise du bâtiment : s’il n’y a plus de maisons et d’hôtels à vendre vous ne pouvez plus construire." +
                " Il faut attendre que des maisons reviennent en banque.\r\n" +
                "\r\n4. Vendre un bâtiment : les bâtiments peuvent être vendus à la banque. Ils seront vendus à la moitié" +
                " de leur valeur indiqués sur le titre de propriété.\r\n" +
                "Ils doivent être vendus uniformément comme ils ont été achetés.\r\n" +
                "\r\n5. Hypothéquer une propriété : quand vous n’avez plus d’argent pour régler une dette vous êtes obligé " +
                "d’hypothéquer une de vos propriétés.Vous pouvez hypothéquer celle de votre choix.Vous devez d’abord " +
                "vendre tous les bâtiments situés dessus avant de vendre les terrains.\r\n" +
                "Pour hypothéquer vous devez retourner votre titre de propriété et percevoir le montant inscrit" +
                " au dos du titre de la part de la banque. Pour lever l’hypothèque il vous faudra payer le montant de" +
                " l’hypothèque plus 10% d’intérêts.Vous ne pouvez bien sur percevoir aucun loyer tant que votre" +
                " propriété est hypothéquée.\r\n" +
                "\r\n6. Passer des accords avec vos adversaires : Les joueurs décident entre eux des montants." +
                "On peut donc échanger une propriété contre une propriété .\r\n\r\n" +
                "Comment faire si vous avez besoin d’argent :\r\n\r\n" +
                "Si vous vous retrouvez sans argent et dans l’impossibilité de payer la banque ou un joueur " +
                "il est possible de trouver un arrangement.Vous pouvez vendre des bâtiments et/ou hypothéquer" +
                " une propriété. Si à la suite de ces différentes opérations vous devez toujours de l’argent," +
                " vous êtes déclaré en faillite et êtes donc éliminé du jeu.\r\n\r\n" +
                "Dans ce cas vous devez :\r\n" +
                "Remboursez ce que vous pouvez.\r\n" +
                "Si vous êtes mis en faillite par un autre joueur vous devez lui donner toutes vos propriétés" +
                " hypothéquées et les cartes « Vous êtes libéré de prison » que vous possédez.Ce joueur doit" +
                " immédiatement payer 10% des hypothèques puis il doit choisir de soit conserver les hypothèques " +
                "ou alors de tout régler tout de suite.\r\n" +
                "Si votre dette est envers la banque, tous vos titres de propriété sont mis aux enchères " +
                "non hypothéqués.Les cartes « Vous êtes libéré de prison » sont remises dans la pile correspondante.\r\n\r\n" +
                "\r\nComment gagner au Monopoly :\r\n\r\n" +
                "Pour gagner une partie de monopoly il faut être le dernier joueur à ne pas avoir fait faillite." +
                " Le plus gros propriétaire immobilier est souvent le gagnant.A vous d’être rusé et bien négocier !";








        }
    }
}
