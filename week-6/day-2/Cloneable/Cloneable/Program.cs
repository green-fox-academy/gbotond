using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John Doe", 20, "male", "BME");
            john.Introduce();
            Student johnTheClone = (Student)john.Clone();
            johnTheClone.Introduce();
            Console.ReadLine();
        }
    }
}
