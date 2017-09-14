using System;

namespace Greeter_function
{
    class Program
    {
        static void Main(string[] args)
        {
            greet();
            Console.ReadLine();
        }
        private static void greet()
        {
            string al = "Greenfox";
            Console.WriteLine("Greetings, dear {0}!", al);
        }
    }
}
