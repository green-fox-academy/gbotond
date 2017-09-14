using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            Console.WriteLine(example);

            example = example.Replace("dishwasher", "galaxy");

            Console.WriteLine(example);
            Console.ReadLine();
        }
    }
}
