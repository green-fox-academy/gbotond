using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] vowels = new char[6];    //Declare an array of 6 characters.
            //vowels[0] = 'a';
            //vowels[1] = 'r';
            //vowels[2] = 'r';
            //vowels[3] = 'a';
            //vowels[4] = 'y';
            //vowels[5] = 's';

            //char[] vowels = new char[] {'a','r','r','a','y','s'};    //Declare the same array in a single step.

            char[] vowels = {'a','r','r','a','y','s'};  //More simple.

            Console.WriteLine(vowels[4]);

            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i]);
            }
            
            Console.ReadLine();
        }
    }
}
