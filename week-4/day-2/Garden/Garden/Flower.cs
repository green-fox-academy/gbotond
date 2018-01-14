using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Flower : Plant
    {
        public Flower(string species)
        {
            waterAbsorption = 0.75;
            waterNeed = 5;
            type = "flower";
            this.species = species;
        }
    }
}
