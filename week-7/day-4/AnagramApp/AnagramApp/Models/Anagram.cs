using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagramApp.Models
{
    public class Anagram
    {
        public string firstWord { get; set; }
        public string secondWord { get; set; }

        public void AnagramChecker(string first, string second)
        {
            if (String.Concat(first.OrderBy(c => c)).Equals(String.Concat(second.OrderBy(c => c))))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}