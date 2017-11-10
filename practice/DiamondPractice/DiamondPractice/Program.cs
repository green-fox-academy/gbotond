using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 9;
            for (int i = 1; i <= number / 2 + 1; i++)
            {
                for (int j = 0; j < number - i - 2; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = number / 2; i >= 0; i--)
            {
                for (int j = 0; j < number - i - 2; j++)
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
