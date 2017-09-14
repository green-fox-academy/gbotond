using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int tempA = a;
            a = b;
            b = tempA;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadLine();
        }
    }
}
