using System;

namespace PalindromeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string pal = "Greenfox";
            CreatePalindrome(pal);
            Console.Write(pal);
            Console.WriteLine(CreatePalindrome(pal));
            Console.ReadLine();
        }

        public static string CreatePalindrome(string pal)
        {
            char[] chars = pal.ToCharArray();
            int j = chars.Length - 1;
            for (int i = 0; i < chars.Length / 2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                j--;
            }
            return new String(chars);
        }
    }
}
