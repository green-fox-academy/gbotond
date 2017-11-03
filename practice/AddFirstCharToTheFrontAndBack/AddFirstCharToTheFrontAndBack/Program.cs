using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFirstCharToTheFrontAndBack
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Pls enter a string");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }

            Console.ReadLine();
        }
    }
}
