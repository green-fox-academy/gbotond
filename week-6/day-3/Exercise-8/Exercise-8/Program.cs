using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var upperCaseQuery = from s in str
                                 where Char.IsUpper(s)
                                 select s;
            foreach (var item in upperCaseQuery)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(System.Environment.NewLine);

            var upperCaseLambda = str.Where(s => Char.IsUpper(s));
            foreach (var item in upperCaseLambda)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
