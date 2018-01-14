using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        List<Plant> plantList = new List<Plant>();

        public void PlantAdder(Plant plant)
        {
            plantList.Add(plant);
        }

        public void CheckGardenStatus()
        {
            foreach (Plant plant in plantList)
            {
                Console.WriteLine("The {0} {1} {2}", plant.species, plant.type, plant.PlantStatus());
            }
        }
        public void Watering(double waterPortion)
        {
            Console.WriteLine("Watering with {0}", waterPortion);
            double waterPerPlant = waterPortion / plantList.Count();
            foreach (Plant plant in plantList)
            {
                plant.currentWaterAmount += waterPerPlant * plant.waterAbsorption;
            }
        }
    }
}
