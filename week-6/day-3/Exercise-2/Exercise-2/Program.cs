using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var oddAverageQuery = (from num in numbers
                             where num % 2 != 0
                             select num).Average();

            Console.WriteLine(oddAverageQuery);

            var oddAverageLambda = numbers.Where(num => num % 2 != 0).Average();

            Console.WriteLine(oddAverageLambda);

            Console.ReadLine();
        }
    }
}
