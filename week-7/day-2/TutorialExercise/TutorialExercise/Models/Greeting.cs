using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialExercise.Models
{
    public class Greeting
    {
        public long Id { get; internal set; }
        public string content;

        public Greeting()
        {
            this.Id = Id++;
        }
    }
}
