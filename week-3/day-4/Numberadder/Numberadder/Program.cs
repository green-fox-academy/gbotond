using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Recursion(27, n);
            Console.ReadLine();
        }
        public static int Recursion(int input, int n)
        {
            Console.WriteLine(n);
            if (n == input)
            {
                return 1;
            }
            else
            {
                return Recursion(input, n + 1);
            }
        }
    }
}
