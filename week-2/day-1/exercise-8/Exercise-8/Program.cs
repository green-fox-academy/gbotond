using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 4, b = 6;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("After Swapping");
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
