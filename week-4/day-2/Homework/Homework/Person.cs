﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Person
    {
        protected string name;
        protected int age;
        protected string gender;

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm " + this.name + ", a " + this.age + "year old " + this.gender + ".");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment.");
        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
        }  
    }
}
