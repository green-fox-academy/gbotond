using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfInputNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());

            double result = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4}", num1, num2, num3, num4, result);
            Console.ReadLine();
        }
    }
}
