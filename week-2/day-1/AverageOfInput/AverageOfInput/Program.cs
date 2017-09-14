using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            string x;
            int a;
            int b;
            int c;
            int d;
            int e;

            Console.WriteLine("Enter five numbers seperated by space: ");

            x = Console.ReadLine();
            a = Convert.ToInt32(x.Split(' ')[0]);
            b = Convert.ToInt32(x.Split(' ')[1]);
            c = Convert.ToInt32(x.Split(' ')[2]);
            d = Convert.ToInt32(x.Split(' ')[3]);
            e = Convert.ToInt32(x.Split(' ')[4]);

            int sum = a + b + c + d + e;
            int avg = sum / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.ReadLine();

        }
    }
}
