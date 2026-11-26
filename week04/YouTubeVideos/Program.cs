using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // First video
            Video video1 = new Video(
                "How to Learn Programming",
                "Code Academy",
                600);

            video1.AddComment(new Comment("John", "This video was very helpful."));
            video1.AddComment(new Comment("Mary", "I learned something new today."));
            video1.AddComment(new Comment("David", "Please make more videos like this."));
            video1.AddComment(new Comment("Sarah", "The explanation was easy to follow."));

            videos.Add(video1);


            // Second video
            Video video2 = new Video(
                "Understanding Environmental Pollution",
                "Green World",
                850);

            video2.AddComment(new Comment("Peter", "This is an important topic."));
            video2.AddComment(new Comment("Grace", "I enjoyed watching this."));
            video2.AddComment(new Comment("Daniel", "Very informative video."));
            video2.AddComment(new Comment("Jane", "I hope you make a part two."));

            videos.Add(video2);


            // Third video
            Video video3 = new Video(
                "Introduction to Python Programming",
                "Tech Learning",
                720);

            video3.AddComment(new Comment("Michael", "Python looks interesting."));
            video3.AddComment(new Comment("Blessing", "This helped me understand variables."));
            video3.AddComment(new Comment("Samuel", "Great tutorial."));
            video3.AddComment(new Comment("Esther", "I will practise what I learned."));

            videos.Add(video3);


            // Fourth video
            Video video4 = new Video(
                "The Importance of Wildlife Conservation",
                "Nature Watch",
                950);

            video4.AddComment(new Comment("Alex", "We need to protect wildlife."));
            video4.AddComment(new Comment("Faith", "I learned a lot from this video."));
            video4.AddComment(new Comment("Chris", "Very interesting presentation."));

            videos.Add(video4);


            // Display all videos and their comments
            foreach (Video video in videos)
            {
                Console.WriteLine("==============================");
                video.DisplayVideoInfo();
                Console.WriteLine("==============================");
                Console.WriteLine();
            }
        }
    }
}