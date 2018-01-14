using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Tree : Plant
    {

        public Tree(string species)
        {
            waterAbsorption = 0.4;
            waterNeed = 10;
            type = "tree";
            this.species = species;
        }
    }
}