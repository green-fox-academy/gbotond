using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Car 
    {
        public string CarType;
        public string CarColor;

        public Car(Types type, Colors color)
        {
            this.CarType = type.ToString();
            this.CarColor = color.ToString();
        }

        public enum Types
        {
            Honda,
            VolksWagen,
            Mazda,
            Volvo,
            Toyota
        }

        public enum Colors
        {
            Black,
            White,
            Grey,
            Metal,
            Green
        }
    }
}
