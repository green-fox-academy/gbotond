using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft Delta = new Aircraft();
            F16 F16a = new F16();
            Delta.PlaneAdder(F16a);
            F35 F35a = new F35();
            Delta.PlaneAdder(F35a);

            Delta.GetAircraftStatus();
            Console.WriteLine();

            Delta.Refill(300);
            Delta.GetAircraftStatus();
            Console.WriteLine();

            Delta.Fight();
            Delta.GetAircraftStatus();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
