using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new[] { 3, 9, 2, 8, 6, 5 };

            var numberQuery = from num in number
                              where num * num > 20
                              select num;
            foreach (int num in numberQuery)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(System.Environment.NewLine);

            var numberLambda = number.Where(num => num * num > 20);
            foreach (int num in numberLambda)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
