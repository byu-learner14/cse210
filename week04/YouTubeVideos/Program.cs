using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List to hold all videos (as required)
        List<Video> videos = new List<Video>();

        // === Video 1 ===
        Video video1 = new Video
        {
            Title = "C# Basics for Beginners",
            Author = "ProgrammingWithGrok",
            Length = 720   // 12 minutes
        };
        video1.AddComment(new Comment("Alice", "This helped me understand classes so much!"));
        video1.AddComment(new Comment("Bob", "Great explanation of abstraction."));
        video1.AddComment(new Comment("Charlie", "Thanks for the step-by-step guide!"));
        video1.AddComment(new Comment("Dana", "When will you cover inheritance?"));
        videos.Add(video1);

        // === Video 2 ===
        Video video2 = new Video
        {
            Title = "Understanding Abstraction in OOP",
            Author = "BYU CSE 210",
            Length = 450   // 7.5 minutes
        };
        video2.AddComment(new Comment("Eve", "This is exactly what I needed for my assignment."));
        video2.AddComment(new Comment("Frank", "Clear and concise!"));
        video2.AddComment(new Comment("Grace", "Love the YouTube example."));
        videos.Add(video2);

        // === Video 3 ===
        Video video3 = new Video
        {
            Title = "How to Build Classes in C#",
            Author = "TechTeacher",
            Length = 600   // 10 minutes
        };
        video3.AddComment(new Comment("Henry", "Perfect for W04 assignment."));
        video3.AddComment(new Comment("Ivy", "The comment tracking is cool."));
        video3.AddComment(new Comment("Jack", "Thanks!"));
        videos.Add(video3);

        // === Video 4 (optional — you can delete this block if needed for 3 videos only) ===
        Video video4 = new Video
        {
            Title = "YouTube Video Tracker Demo",
            Author = "xAI Dev",
            Length = 300   // 5 minutes
        };
        video4.AddComment(new Comment("Olivia", "This assignment was tricky at first."));
        video4.AddComment(new Comment("Liam", "Now I get abstraction!"));
        video4.AddComment(new Comment("Mia", "Great job on the classes."));
        videos.Add(video4);

        // Display everything (exactly as the spec requires)
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
    }
}