using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Mentor : Person
    {      
        public string level;

        public new void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", name, age, gender, level);
        }

        public Mentor(string name, int age, string gender, string level)
        {           
            this.level = level;
        }

        public Mentor()
        {
            level = "intermediate";
        }
    }
}
