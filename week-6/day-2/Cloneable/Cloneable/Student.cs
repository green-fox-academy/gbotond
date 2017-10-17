using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOrganization
{
    public class Student : Person, ICloneable
    {
        private string previousOrganization = "The School of Life";
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            base.name = name;
            base.age = age;
            base.gender = gender;
            this.previousOrganization = previousOrganization;
        }

        public Student()
        {

        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior developer.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, {1} age old {2} from {3} who skipped {4} day(s) from the course already.", name, age, gender, previousOrganization, skippedDays);
        }

        public void SkipDays(int value)
        {
            skippedDays += value;
        }

        public object Clone()
        {
            return new Student(name, age, gender, previousOrganization);
        }
    }
}
