using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPyramidPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j <= number - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
