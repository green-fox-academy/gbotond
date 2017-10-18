using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                                "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var solutionWithQuery = from c in cities
                                    where c.StartsWith("A") && c.EndsWith("I")
                                    select c;
            foreach (var item in solutionWithQuery)
            {
                Console.WriteLine(item);
            }

            var solutionWithLambda = cities.Where(c => c.StartsWith("A") && c.EndsWith("I"));
            foreach (var item in solutionWithQuery)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
