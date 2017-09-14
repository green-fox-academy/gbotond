using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5, };

            if (p1.Length < p2.Length)
            {
                Console.WriteLine("p2 has more elements");
            }
            else
            {
                Console.WriteLine("p1 has more elements");
            }

            Console.ReadLine();
        }
    }
}
