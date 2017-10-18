using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var lettersAndCountsLambda = str.GroupBy(x => x);

            foreach (var item in lettersAndCountsLambda)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Count());
            }

            Console.WriteLine(System.Environment.NewLine);

            var lettersAndCounsQuery = from s in str
                                       group s by s
                                       into x
                                       select new { Letter = x.Key, Count = x.Count() };

            foreach (var item in lettersAndCounsQuery)
            {
                Console.WriteLine("{0} : {1}", item.Letter, item.Count);
            }
            Console.ReadLine();
        }
    }
}
