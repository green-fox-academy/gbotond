using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            int triangle = int.Parse(Console.ReadLine());
            for (int i = 0; i < triangle; i++)
            {
                for (int j = 0; j < triangle; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadLine();
        }
    }
}
