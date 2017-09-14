using System;

namespace Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            string correcturl = url.Replace("bots", "odds");

            Console.WriteLine(correcturl);

            string correcturl2 = correcturl.Insert(5, ":");

            Console.WriteLine(correcturl2);

            Console.ReadLine();




        }
    }
}
