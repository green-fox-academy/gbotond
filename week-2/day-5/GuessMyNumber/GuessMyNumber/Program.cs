using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();

            int val = n.Next(1, 100);
            int guess = 0;
            bool correct = false;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (!correct)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }
                if (guess < val)
                {
                    Console.WriteLine("No, the number I'm thinking is higher than that number.");
                }
                else if (guess > val)
                {
                    Console.WriteLine("No, the number I'm thinking is lower than that number.");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You guessed right!");
                    Console.ReadLine();
                }
            }
        }
    }
}
