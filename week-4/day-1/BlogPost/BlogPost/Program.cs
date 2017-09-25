using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogPost1 = new BlogPost();
            blogPost1.AuthorName = "John Doe";
            blogPost1.Title = "Lorem Ipsum";
            blogPost1.Text = "Lorem ipsum dolor sit amet.";
            blogPost1.PublicationDate = "2000.05.04.";

            var blogPost2 = new BlogPost();
            blogPost2.AuthorName = "Tim Urban";
            blogPost2.Title = "Wait but why";
            blogPost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blogPost2.PublicationDate = "2010.10.10";

            var blogPost3 = new BlogPost();
            blogPost3.AuthorName = "Willian Turton";
            blogPost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogPost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            blogPost3.PublicationDate = "2017.03.28";

            Console.WriteLine(blogPost1.Title + " titled by " + blogPost1.AuthorName + " posted at " + blogPost1.PublicationDate + ":");
            Console.WriteLine(blogPost1.Text);
            Console.WriteLine(blogPost2.Title + " titled by " + blogPost2.AuthorName + " posted at " + blogPost2.PublicationDate + ":");
            Console.WriteLine(blogPost2.Text);
            Console.WriteLine(blogPost3.Title + " titled by " + blogPost3.AuthorName + " posted at " + blogPost3.PublicationDate + ":");
            Console.WriteLine(blogPost3.Text);
            Console.ReadLine();
        }
    }
}
