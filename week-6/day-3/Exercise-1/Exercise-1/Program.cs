using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> evenNumbers1 =
                from num in numbers
                where num % 2 == 0
                select num;

            foreach (int i in evenNumbers1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);

            IEnumerable<int> evenNumbers2 = numbers.Where(num => num % 2 == 0);

            foreach (int  num in evenNumbers2)
            {
                Console.Write( + num + " ");
            }

            Console.ReadLine();
        }
    }
}