using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int m = 2;

            Console.WriteLine(Ears(n, m));
            Console.ReadLine();
        }
        public static int Ears(int n , int m)
        {
            if (m == 1)
            {
                return n;
            }
            else
                return n + Ears(n, m - 1);
        }
    }
}
