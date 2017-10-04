using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Student Feri = new Student();
            Feri.Introduce();
            Feri.GetGoal();

            Mentor Laci = new Mentor();

            Console.ReadKey();
        }
    }
}
