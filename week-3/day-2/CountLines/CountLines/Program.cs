using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            CountLines();
            Console.ReadLine();
        }
        private static void CountLines()
        {
            try
            {
                string name = @"C:\Users\Botond\Desktop\cls.txt";
                int lines = File.ReadAllLines(name).Length;
                Console.WriteLine(lines);
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }                       
        }
    }
}
