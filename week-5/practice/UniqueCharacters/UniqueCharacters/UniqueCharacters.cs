using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacters
{
    public class UniqueCharacters
    {
        public static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            string input = Console.ReadLine();
            foreach (var chars in GetUniqueCharacters(input))
            {
                Console.Write("\"{0}\", ", chars);
            }
            Console.ReadLine();
        }

        public static List<char> GetUniqueCharacters(string input)
        {
            input = input.ToLower();
            char[] CharArray = input.ToCharArray();
            var UniqChars = new List<char>();
            for (int i = 0; i < CharArray.Length; i++)
            {
                if (!UniqChars.Contains(CharArray[i]))
                {
                    UniqChars.Add(CharArray[i]);
                }
            }
            return UniqChars;
        }
    }
}
