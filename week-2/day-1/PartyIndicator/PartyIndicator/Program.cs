using System;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of boys: ");
            int numberOfBoys = int.Parse(Console.ReadLine());
            Console.Write("Number of girls: ");
            int numberOfGirls = int.Parse(Console.ReadLine());

            if (((numberOfBoys + numberOfGirls) > 20) && (numberOfBoys == numberOfGirls))
            {
                Console.WriteLine("The party is exellent!");
            }
            else if (((numberOfBoys + numberOfGirls) > 20) && (numberOfBoys != numberOfGirls) && (numberOfGirls != 0))
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (((numberOfBoys + numberOfGirls) <= 20) && (numberOfGirls != 0))
            {
                Console.WriteLine("Average party...");
            }
            else if (numberOfGirls == 0)
            {
                Console.WriteLine("Sausage party");
            }
            Console.ReadLine();
        }
    }
}
