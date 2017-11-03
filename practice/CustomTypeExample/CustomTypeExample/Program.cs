using System;

namespace CustomTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(milesToFeetConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));

            Console.ReadLine();
        }
    }
}
