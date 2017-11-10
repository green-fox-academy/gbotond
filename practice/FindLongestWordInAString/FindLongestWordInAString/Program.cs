using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLongestWordInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string practice = "GreenFoxAcademy is your one in a lifetime chance. Do not screw it!.";

            string[] words = practice.Split(' ');
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
