using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAgainAndAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "greenfox";
            Console.WriteLine(CharAdd(str));
            Console.ReadLine();
        }
        public static string CharAdd(string str)
        {
            if (str.Length < 1)
            {
                return str;
            }
            return str[0] + "*" + CharAdd(str.Substring(1));
        }
    }
}
