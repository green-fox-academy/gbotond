using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int expInt = 5;
            int baseInt = 3;

            Console.WriteLine(Power(baseInt, expInt));
            Console.ReadLine();
        }
        public static int Power(int baseInt, int expInt)
        {
            if (expInt == 0)
            {
                return 1;
            }
            else
                return baseInt * Power(baseInt, expInt - 1);        
        }
    }
}
