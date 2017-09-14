using System;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 8;

            if (c <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (c == 1)
            {
                Console.WriteLine("One");
            }
            else if (c == 2)
            {
                Console.WriteLine("Two");
            }
            else if (c > 2)
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();

        }
    }
}
