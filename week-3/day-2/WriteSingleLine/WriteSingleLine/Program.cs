using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Botond";
            string path = @"C:\Users\Botond\Desktop\wsl.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(name);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: wsl.txt");
            }
        }
    }
}
