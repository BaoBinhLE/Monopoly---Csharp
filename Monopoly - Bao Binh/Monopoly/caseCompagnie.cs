using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class caseCompagnie: casePropriete
    {

        public static List<caseCompagnie> listeCaseCompagnie = new List<caseCompagnie>();

        public caseCompagnie(int indexCom, string nom)
            : base(indexCom, nom,150, 75)
        {
            listeCaseCompagnie.Add(this);
        }

        public List<caseCompagnie> getListeCaseCompagnie()
        {
            return listeCaseCompagnie;
        }

        public void setLoyer(int nbCompagnie, int montantDes)
        {
            if(nbCompagnie > 0)
            {
                if (nbCompagnie == 1)
                {
                    base.setLoyer(montantDes * 4);
                }
                else if (nbCompagnie == 2)
                {
                    base.setLoyer(montantDes * 10);
                }
            }  
        }
    }
}
