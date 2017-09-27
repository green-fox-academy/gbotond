using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class Counter
    {
        public Dictionary<char, int> StrToDictCount(string example)
        {
            Dictionary<char, int> returnDict = new Dictionary<char, int>();

            if (String.IsNullOrEmpty(example))
            {
                return returnDict;
            }

            foreach (char letter in example)
            {

                if (!returnDict.ContainsKey(letter))
                {
                    returnDict.Add(letter, 1);
                }

                else
                {
                    returnDict[letter]++;
                }
            }

            return returnDict;
        }
    }
}
