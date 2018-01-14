using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myGarden = new Garden();
            Flower flower1 = new Flower("Tulip");
            myGarden.PlantAdder(flower1);
            Flower flower2 = new Flower("Lily");
            myGarden.PlantAdder(flower2);
            Tree tree1 = new Tree("Oak");
            myGarden.PlantAdder(tree1);
            Tree tree2 = new Tree("Mapple");
            myGarden.PlantAdder(tree2);

            myGarden.CheckGardenStatus();
            Console.WriteLine();

            myGarden.Watering(40);
            myGarden.CheckGardenStatus();
            Console.WriteLine();

            myGarden.Watering(70);
            myGarden.CheckGardenStatus();
            Console.WriteLine();

            Console.ReadLine();
        }       
    }
}
