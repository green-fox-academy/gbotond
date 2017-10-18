using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = { 'a', 'l', 'p', 'a', 'g', 'a' };

            string stringFromArrayLambda = String.Concat(array.Select(character => character));
            Console.WriteLine(stringFromArrayLambda);

            string stringFromArrayQuery = String.Concat(
                                          from character in array
                                          select character);
            Console.WriteLine(stringFromArrayQuery);

            Console.ReadLine();
        }
    }
}
