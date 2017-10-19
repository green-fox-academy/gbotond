using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();
            var carList = myGarage.CreateCarList();
            myGarage.Print(myGarage.CountSameTypes(carList));
            Console.WriteLine();
            myGarage.Print(myGarage.CountEachColor(carList));
            Console.WriteLine();
            Console.WriteLine(myGarage.GetMostFrequent(carList));

            Console.ReadLine();
        }
    }
}
