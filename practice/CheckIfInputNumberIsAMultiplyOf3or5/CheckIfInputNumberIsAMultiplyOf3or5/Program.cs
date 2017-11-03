using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfInputNumberIsAMultiplyOf3or5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 33;

            if (input > 0)
            {
                Console.WriteLine(input % 3 == 0 || input % 5 == 0);
            }
            Console.ReadLine();
        }
    }
}
