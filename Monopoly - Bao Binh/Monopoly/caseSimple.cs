using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class caseSimple : caseTableau
    {
        private static List<caseSimple> listeCaseSimple = new List<caseSimple>();
        private int plusOuMoins = 0;
        public caseSimple(int index , int plusOuMoins )
            :base(index )
        {
            this.plusOuMoins = plusOuMoins;
            listeCaseSimple.Add(this);
        }

        public caseSimple(int index)
            : base(index)
        {
        }

        public int getPlusOuMoins()
        {
            return plusOuMoins;
        }

        public void setPlusOuMoins(int somme)
        {
            this.plusOuMoins = somme;
        }

        public List<caseSimple> getListeCaseSimple()
        {
            return listeCaseSimple;
        }
    }
}
