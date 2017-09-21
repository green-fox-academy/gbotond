using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialRecursion(5);
            Console.ReadLine();
        }

        public static int FactorialRecursion(int n)
        {
            Console.WriteLine(n);
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialRecursion(n - 1);
            }
        }
    }
}
