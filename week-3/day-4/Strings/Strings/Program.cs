using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "xyxyxyxy";
            Console.WriteLine(CharChange(str));
            Console.ReadLine();
        }
        public static string CharChange(string str)
        {
            if (str.Length < 1)
            {
                return str;
            }
            else if (str[0] == 'x')
            {
                return 'y' + CharChange(str.Substring(1));
            }
            else
                return str[0] + CharChange(str.Substring(1));
        }
    }
}
