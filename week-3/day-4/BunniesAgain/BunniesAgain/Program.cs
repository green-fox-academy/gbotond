using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EarCounter(8));
            Console.ReadLine();
        } 
        public static int EarCounter(int n)
        {
            if ((n == 0))
            {
                return 0;
            } 
            else if (n % 2 == 0)
            {
                return 3 + EarCounter(n - 1);
            }
            else
            {
                return 2 + EarCounter(n - 1);
            }
        }
    }
}
