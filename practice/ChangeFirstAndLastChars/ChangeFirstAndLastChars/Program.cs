using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeFirstAndLastChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstLast("practice"));

            Console.ReadLine();
        }

        public static string FirstLast(string original)
        {  
            int len = original.Length;
            return original[len - 1] + original.Substring(1, len - 2) + original[0];
        }
    }
}
