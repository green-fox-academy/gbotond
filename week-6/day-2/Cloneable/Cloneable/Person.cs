using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOrganization
{
    public class Person
    {

        protected string name = "John Doe";
        protected int age = 30;
        protected string gender = "Male";

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person()
        {

        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, {1} year old {2}.", name, age, gender);
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
