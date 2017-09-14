using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.
            var a = new List<string>();
            string suffix = "a";
            foreach (string animal in far)
            {
                a.Add(string.Format(animal, suffix));
                Console.WriteLine(animal);
                Console.ReadLine();
                //probald meg a stringbuildert
            }
        }
    }
}