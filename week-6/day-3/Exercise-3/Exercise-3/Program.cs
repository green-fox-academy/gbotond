using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squareOfPositiveQuery = from num in number
                                        where num > 0
                                        select num * num;

            foreach (int num in squareOfPositiveQuery)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(System.Environment.NewLine);

            var squareOfPositiveLambda = number.Where(num => num > 0).Select(num => num * num);

            foreach (int num in squareOfPositiveLambda)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
