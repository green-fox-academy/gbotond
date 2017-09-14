using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            string x;
            int a;
            int b;

            Console.WriteLine("Enter two numbers seperated by space: ");

            x = Console.ReadLine();
            a = Convert.ToInt32(x.Split(' ')[0]);
            b = Convert.ToInt32(x.Split(' ')[1]);

            if (a > b)
            {
                Console.WriteLine("The bigger one is: " + a);
            }
            else
            {
                Console.WriteLine("The bigger one is: " + b);
            }

            Console.ReadLine();
        }
    }
}
