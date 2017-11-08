using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestBackendApp.Models
{
    public class ArrayObject
    {
        public int[] Numbers { get; set; }
        public string Operation { get; set; }

        public int Sum(int[] numArray)
        {
            int sum = 0;

            foreach (var num in numArray)
            {
                sum += num;
            }
            return sum;
        }

        public int Multiply(int[] numArray)
        {
            int product = 1;

            foreach (var num in numArray)
            {
                product *= num;
            }
            return product;
        }

        public int[] Double(int[] numArray)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] *= 2;
            }
            return numArray;
        }
    }
}
