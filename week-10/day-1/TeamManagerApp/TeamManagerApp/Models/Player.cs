using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagerApp.Models
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
    }
}
