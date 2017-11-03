using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfPositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two positive or negatve integers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                Console.WriteLine("Both integers are positive");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("Both integers are negative");
            }
            else
            {
                Console.WriteLine("One is negative and one is positive");
            }
            Console.ReadLine();
        }
    }
}
