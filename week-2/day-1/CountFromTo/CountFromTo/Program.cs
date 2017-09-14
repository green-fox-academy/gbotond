using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int a;
            int b;

            Console.WriteLine("Enter two numbers seperated by space: ");

            x = Console.ReadLine();
            a = Convert.ToInt32(x.Split(' ')[0]);
            b = Convert.ToInt32(x.Split(' ')[1]);

            if (b <= a)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
