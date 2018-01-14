using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Botond\Desktop\wml.txt";
            string word = "greenfox";
            int number = 5;
            Writelines(path, word, number);
        }
        private static void Writelines(string path, string word, int number)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < number; i++)
                    {
                        writer.WriteLine(word);
                    }                  
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: wml.txt");
            }
        }
    }
}
