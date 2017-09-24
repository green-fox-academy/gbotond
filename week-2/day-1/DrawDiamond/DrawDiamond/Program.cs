using System;

namespace DrawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            int d = 7;
            for (int i = 1; i <= d/2 + 1; i++)
            {
                for (int j = 0; j < d - i - 2; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = d/2; i >= 0; i--)
            {
                for (int j = 0; j < d - i - 2; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                }               
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
