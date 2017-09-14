using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            double a = 2;
            double b = 4;
            double c = 6;
            double vol = a * b * c;
            double srf = 2 * (a * b + a * c + b * c);

            Console.WriteLine("Surface Area: " + vol);
            Console.WriteLine("Volume: " + srf);

            Console.ReadLine();
        }
    }
}
