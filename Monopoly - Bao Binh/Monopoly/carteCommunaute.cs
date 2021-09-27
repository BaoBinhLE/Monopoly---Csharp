using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class carteCommunaute : carte
    {
        //Type Identifications :
        //'P' = Payer 
        //'C' = Collecter de l'argent de la banque
        //'D' = Avancer au départ
        //'J' = Aller en prison
        //'L' = Libérer de prison
        //'G' = Déplacer

        public static List<carteCommunaute> listeCarteCummunaute = new List<carteCommunaute>();

        public carteCommunaute(string type, int valeur, string text)
           : base(type, valeur, text)
        {
            listeCarteCummunaute.Add(this);
        }

        public List<carteCommunaute> getListeCarteCommunaute()
        {
            return listeCarteCummunaute;
        }
        public string toString()
        {
            return "CAISSE DE COMMUNAUTE \n\n" + base.getText();
        }
    }
}
