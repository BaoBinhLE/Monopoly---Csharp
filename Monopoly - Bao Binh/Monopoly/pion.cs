using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class pion
    {
        private int index;
        private int statut;

        public pion(int index)
        {
            this.index = index;
     
        }

        public int getIndex()
        {
            return index;
        }


        public int getStatut()
        {
            return statut;
        }
        
        public void setStatut(int statut)
        {
            this.statut = statut;
        }
    }

}
