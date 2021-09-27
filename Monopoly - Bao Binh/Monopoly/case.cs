using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class caseTableau
    {
        public static List<caseTableau> listeCaseTableau = new List<caseTableau>();

        private int indexCase;

        public caseTableau(int index)
        {
            this.indexCase = index;
            listeCaseTableau.Add(this);
        }

        public void setIndexCase(int indexCase)
        {
            this.indexCase = indexCase;
        }

        public int getIndexCase()
        {
            return this.indexCase;
        }

        public List<caseTableau> getListeCaseTableau()
        {
            return listeCaseTableau;
        }

    }
}
