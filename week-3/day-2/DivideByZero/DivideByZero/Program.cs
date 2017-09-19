using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide();
            Console.ReadLine();
        }
        private static void Divide()
        {
            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Can't divide by zero!");
            }
            catch (Exception error)
            {
                Console.WriteLine("Damn! Something wrong happened!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
