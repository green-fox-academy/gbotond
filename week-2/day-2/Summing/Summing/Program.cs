using System;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            sum();
            Console.ReadKey();
        }

        public static void sum()
        {
            int i, sum = 0;
            for (i = 0; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine("{0} ", i);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
        }


    }
}
