using System;

namespace Exercise_24
{
    class Program
    {
        static void Main(string[] args)
        {
            { }
                int i;
                for (i = 1; i < 500; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadLine();
            }
    }
}
