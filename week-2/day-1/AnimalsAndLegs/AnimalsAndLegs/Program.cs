using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            Console.WriteLine("How many chickens do you have:  "); 
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many pigs do you have:  "); 
            int y = Int32.Parse(Console.ReadLine());

            int legs = x * 2 + y * 4;
            Console.WriteLine("Your animals have: " + legs + " legs");
            Console.ReadLine();
        }
    }
}
