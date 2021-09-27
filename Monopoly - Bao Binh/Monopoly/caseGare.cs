using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class caseGare : casePropriete
    {
        public static List<caseGare> listeCaseGare = new List<caseGare>();
        private int loyer2Gare = 100;
        private int loyer3Gare = 150;
        private int loyer4Gare = 200;

        public caseGare(int indexGare, string nom)
            :base(indexGare,nom,200, 25)
        {
            listeCaseGare.Add(this);
        }

        public int getLoyer2Gare(){
            return this.loyer2Gare;
        }

        public int getLoyer3Gare()
        {
            return this.loyer3Gare;
        }
        public int getLoyer4Gare()
        {
            return this.loyer4Gare;
        }

        public List<caseGare> getListeCaseGare()
        {
            return listeCaseGare;
        }
    }
}
