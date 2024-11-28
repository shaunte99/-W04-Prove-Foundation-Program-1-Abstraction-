using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Learning C#", "John Doe", 600);
        Video video2 = new Video("Cooking 101", "Jane Smith", 900);
        Video video3 = new Video("Travel Vlog", "Alex Johnson", 1200);

        
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make more videos like this?"));

        
        video2.AddComment(new Comment("Diana", "I love cooking!"));
        video2.AddComment(new Comment("Eve", "Thanks for the tips!"));
        video2.AddComment(new Comment("Frank", "Simple and easy to follow."));

        
        video3.AddComment(new Comment("George", "Amazing travel spots!"));
        video3.AddComment(new Comment("Helen", "Wow, I want to visit these places."));
        video3.AddComment(new Comment("Ivy", "Thanks for sharing your journey."));

        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}

