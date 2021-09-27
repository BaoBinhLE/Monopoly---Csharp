using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class constant
    {
        public static Color couleur1 = Color.FromArgb(255, 208, 1, 255);
        public static Color couleur2 = Color.FromArgb(255, 123, 201, 1);
        public static Color couleur3 = Color.FromArgb(255, 253, 87, 130);
        public static Color couleur4 = Color.FromArgb(255, 0, 255, 255);

        public static Color hypotheque = Color.FromArgb(50, 200, 50, 50);

        public static Color monter = Color.FromArgb(80, 50, 50, 200);

        public static Color leverHypotheque = Color.FromArgb(90, 200, 50, 50);

        public static Color elimine = Color.FromArgb(80, 200, 50, 50);

        public static List<string> blocs = new List<string> { "marron", "bleuCiel", "rose", "orange", "rouge", "jaune", "vert", "bleuFonce" };
    }
}
