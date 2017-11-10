using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int square = 0;
            for (int i = 0; i < 10; i++)
            {
                square = i * i;
                Console.WriteLine(square);
            }
            Console.ReadLine();
        }
    }
}
