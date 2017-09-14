using System;

namespace PrintArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ..
            Printer();
            Console.ReadLine();
        }

        public static void Printer()
        {
            string[] print = new string[3];
            print[0] = "first";
            print[1] = "second";
            print[2] = "third";

            Console.WriteLine(print[2]);

        }
    }
}
