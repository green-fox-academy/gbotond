using System;

namespace SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int remainingHours = 23 - currentHours;
            int remainingMinutes = 59 - currentMinutes;
            int remainingSeconds = 60 - currentSeconds;

            int remainingall = remainingHours * 60 * 60 + remainingMinutes * 60 + remainingSeconds;

            Console.WriteLine(remainingall);
            Console.ReadLine();

            

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables
        }
    }
}
