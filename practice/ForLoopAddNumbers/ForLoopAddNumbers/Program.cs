using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopAddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
