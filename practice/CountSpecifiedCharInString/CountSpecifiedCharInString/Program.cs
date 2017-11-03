using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpecifiedCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Practice, Practice, Practice!";
            char[] chars = str.ToCharArray();
            int count = 0;
            foreach (char c in chars)
            {
                if (c == 't')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
