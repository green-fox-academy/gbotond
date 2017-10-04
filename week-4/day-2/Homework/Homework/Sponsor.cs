using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Sponsor : Person
    {       
        public string company;
        public int hiredStudents;

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", name, age, gender, company, hiredStudents);
        }

        public void Hire()
        {
            hiredStudents += 1;
        }

        public new void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers");
        }

        public Sponsor(string name, int age, string gender, string level, string company, int hiredStudents)
        {           
            this.company = company;
            hiredStudents = 0;
        }
        public Sponsor()
        {
            company = "Google";
        }
    }
}
