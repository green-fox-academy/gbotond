using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAapp.Models
{
    public class Player
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public bool IsHealthy { get; set; } = true;
        public Weakness Weakness { get; set; }
        public Practice Practice { get; set; }

        //public Player(string name, string position, int age, double height, double weight, bool isHealthy, Weakness weakness, Practice practice)
        //{
        //    Name = name;
        //    Position = position;
        //    Age = age;
        //    Height = height;
        //    Weight = weight;
        //    IsHealthy = isHealthy;
        //    Weakness = weakness;
        //    Practice = practice;
        //}
    }
}
