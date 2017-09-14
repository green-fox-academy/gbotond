using System;

namespace Exercise_03
{
    class Program
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It";
            string quote2 = "you expect, even when you take into account Hofstadter's Law.";
            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(quote + " " + "always takes longer than ").Append(quote2);
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
