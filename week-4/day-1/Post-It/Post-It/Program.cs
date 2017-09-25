using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class Program
    {              
        static void Main(string[] args)
        {
            PostIt postIt1;
            postIt1.Text = "Idea 1";
            postIt1.BackgroundColor = "orange";
            postIt1.TextColor = "blue";

            PostIt postIt2;
            postIt2.Text = "Awesome";
            postIt2.BackgroundColor = "pink";
            postIt2.TextColor = "black";

            PostIt postIt3;
            postIt3.Text = "Superb";
            postIt3.BackgroundColor = "yellow";
            postIt3.TextColor = "green";

            Console.WriteLine(postIt1.Text + ", " + postIt1.BackgroundColor + ", " + postIt1.TextColor);
            Console.WriteLine(postIt2.Text + ", " + postIt2.BackgroundColor + ", " + postIt2.TextColor);
            Console.WriteLine(postIt3.Text + ", " + postIt3.BackgroundColor + ", " + postIt3.TextColor);
            Console.ReadLine();
        }
    }
}
