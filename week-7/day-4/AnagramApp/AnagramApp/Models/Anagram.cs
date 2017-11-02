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

        public bool IsAnagram()
        {
            string first = String.Concat(firstWord.OrderBy(c => c));
            string second = String.Concat(secondWord.OrderBy(c => c));

            return first == second;
        }
    }
}