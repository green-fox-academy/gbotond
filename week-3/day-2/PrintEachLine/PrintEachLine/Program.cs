using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "my-file.txt";
            try
            {
                String[] content = File.ReadAllLines(path);
                Console.WriteLine(content);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            Console.ReadLine();
        }
    }
}
