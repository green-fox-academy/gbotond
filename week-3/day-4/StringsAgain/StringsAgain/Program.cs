using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "yxcyxcyxcyxc";
            Console.WriteLine(CharRemove(str));
            Console.ReadLine();
        }
        public static string CharRemove(string str)
        {
            if (str.Length < 1)
            {
                return str;
            }
            else if (str[0] == 'x')
            {
                return CharRemove(str.Substring(1));
            }
            else
                return str[0] + CharRemove(str.Substring(1));
        }
    }
}
