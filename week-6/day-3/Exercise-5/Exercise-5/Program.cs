using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 }; 

            var frequencyWithQuery = from num in n
                                     group num by num 
                                     into x
                                     select new { Key = x.Key, Count = x.Count() };
            foreach (var item in frequencyWithQuery)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Count);
            }
            Console.WriteLine(System.Environment.NewLine);

            var frequencyWithLambda = n.GroupBy(x => x);
            foreach (var item in frequencyWithLambda)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Count());
            }

            Console.ReadLine();
        }
    }
}
