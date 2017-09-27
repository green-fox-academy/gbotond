using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramClass
    {
        public static bool AnagramOrNot(string s1, string s2)
        {
            if (s1 != null && s2 != null)
            {
                char[] s1Chars = s1.ToCharArray();
                Array.Sort(s1Chars);
                char[] s2Chars = s2.ToCharArray();
                Array.Sort(s2Chars);

                bool anagram = true;

                if (s1Chars.Length != s2Chars.Length)
                {
                    anagram = false;
                }
                else
                {
                    for (int i = 0; i < s1Chars.Length; i++)
                    {
                        if (s1Chars[i] != s2Chars[i])
                        {
                            anagram = false;
                        }
                    }
                }
                return anagram;
            }
            return false;
        }
    }
}
