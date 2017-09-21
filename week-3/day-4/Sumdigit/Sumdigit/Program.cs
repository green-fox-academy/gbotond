using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumDigitsRecursion(123, 0));
            Console.ReadLine();
        }

        public static long sumDigitsRecursion(int n, long sum)
        {
            if (n == 0)
            {
                return sum;
            }
            else
            {
                sum = sum + n % 10;
                n = n / 10;
                return sumDigitsRecursion(n, sum);
            }
        }
    }
}
