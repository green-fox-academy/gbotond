using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Garage
    {
        int carAmount = 256;
        Random random = new Random();
        List<Car> carList = new List<Car>();

        public List<Car> CreateCarList()
        {
            for (int i = 0; i < carAmount; i++)
            {
                carList.Add(new Car((Car.Types)random.Next(0, 5), (Car.Colors)random.Next(0, 5)));
            }
            return carList;
        }

        public Dictionary<string, int> CountSameTypes(List<Car> cars)
        {
            return cars.GroupBy(x => x.CarType).ToDictionary(typ => typ.Key, value => value.Count());
        }

        public Dictionary<string, int> CountEachColor(List<Car> cars)
        {
            return cars.GroupBy(x => x.CarColor).ToDictionary(col => col.Key, value => value.Count());
        }

        public void Print(Dictionary<string, int> input)
        {
            foreach (var car in input)
            {
                Console.WriteLine(car);
            }
        }

        public KeyValuePair<string, int> GetMostFrequent(List<Car> cars)
        {
            var typeAndColor = cars.GroupBy(x => x.CarColor + " " + x.CarType).ToDictionary(tc => tc.Key, value => value.Count());
            var mostFrequent = typeAndColor.FirstOrDefault(x => x.Value == typeAndColor.Values.Max());

            return mostFrequent;
        }
    }
}
