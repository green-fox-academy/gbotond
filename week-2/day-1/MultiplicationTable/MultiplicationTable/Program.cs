using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter a number");
            n = Int32.Parse(Console.ReadLine());
            for (i = 1; i <= 10; ++i)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }
            Console.ReadLine();
        }
    }
}
