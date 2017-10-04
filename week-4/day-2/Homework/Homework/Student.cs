using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Student : Person
    {       
        public string previousOrganization;
        public int skippedDays;

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public void SkipDays(int numberofDays)
        {
            skippedDays += numberofDays;
        }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            skippedDays = 0;
            this.previousOrganization = previousOrganization;
        }

        public Student()
        {
            skippedDays = 0;
            previousOrganization = "The school of life";
        }
    }
}
