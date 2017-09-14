using System;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            e *= 8;
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            bool smaller = f2 > f1;
            bool bigger = f1 > f2;
            Console.WriteLine(bigger);

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            g2 *= 2;
            bool bigger2 = g2 > g1;
            bool smaller2 = g2 < g1;
            Console.WriteLine(bigger2);

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            int i3 = i2 *= 3;
            int i4 = i3 * 3;

            bool hs = i1 > i3 && i1 < i4;
            bool lh = i1 < i3 && i1 > i4;
            if (true)
            {
                Console.WriteLine(hs);
            }

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            if (j % 3 == 0 || j % 5 == 0)
            {
                Console.WriteLine("True");
            }

            string k = "Apple";
            //fill the k variable with its cotnent 4 times
            

            Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}
