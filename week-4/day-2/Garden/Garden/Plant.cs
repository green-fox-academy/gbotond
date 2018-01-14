using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Plant : Garden
    {
        public double waterNeed;
        public double currentWaterAmount;
        public double waterAbsorption;
        public string type;
        public string species;

        public string PlantStatus()
        {
            if (currentWaterAmount > waterNeed)
            {
                return "doesnt need water";
            }
            return "needs water";
        }
    }
}
