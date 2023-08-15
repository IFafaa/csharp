using Posts.Entities;
using System;

namespace Posts
{
    internal class Program {
        static void Main(string[] args) {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zealing",
                "I'm going to visit this wonderful country",
                12
            );

            p1.addComment(c1);
            p1.addComment(c2);


            Console.WriteLine(p1);
        }
    }
}