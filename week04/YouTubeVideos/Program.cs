using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("C# Abstraction Explained", "TechWithTim", 300);
        v1.AddComment(new Comment("Alice", "Very clear explanation."));
        v1.AddComment(new Comment("Bob", "I finally understand classes!"));
        v1.AddComment(new Comment("Charlie", "Can you show inheritance next?"));
        videos.Add(v1);

        Video v2 = new Video("How to Train Your Horse", "GiddyUp Travels", 1200);
        v2.AddComment(new Comment("RancherDan", "Great tips for the arena."));
        v2.AddComment(new Comment("HorseGirl99", "My horse loved the exercise."));
        v2.AddComment(new Comment("EquinePro", "Professional advice, thank you."));
        videos.Add(v2);

        Video v3 = new Video("Top 5 Travel Destinations", "WorldExplorer", 600);
        v3.AddComment(new Comment("Traveler1", "Adding these to my bucket list."));
        v3.AddComment(new Comment("HikerBen", "Number 2 is breathtaking."));
        v3.AddComment(new Comment("VloggerJess", "Great cinematography here."));
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.Length} seconds");
            Console.WriteLine($"Count: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"- {c.Name}: {c.Text}");
            }
            Console.WriteLine();
        }
    }
}