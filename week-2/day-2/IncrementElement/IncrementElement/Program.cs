using System;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            int[] t = { 1, 2, 3, 4, 5 };
            //- Increment the third element
            int t2 = t[2];
            int t3 = ++t2;
            //- Print the third element
            Console.WriteLine(t3);
            Console.ReadLine();
        }
    }
}
