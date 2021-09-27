using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class carteChance : carte
    {
        //Type Identifications :
        //'P' = Payer 
        //'C' = Collecter de l'argent de la banque
        //'D' = Avancer au départ
        //'J' = Aller en prison
        //'L' = Libérer de prison
        //'G' = Déplacer

        public static List<carteChance> listeCarteChance = new List<carteChance>();
        public carteChance(string type, int valeur, string text)
            :base(type, valeur,text)
        {
            listeCarteChance.Add(this);
        }

        public List<carteChance> getListeCarteChance()
        {
            return listeCarteChance;
        }

        public string toString()
        {
            return "CHANCE\n\n" + base.getText();
        }
    }
}
