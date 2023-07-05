using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {        
        Video cv = new Video(); // basic object for controlling methods
        Video video1 = new Video("Choosing Bananas", "Curious George", 244);
        cv.AddVideo(video1);
        Video video2 = new Video("Skyscrapers Of New York", "King Kong", 532);
        cv.AddVideo(video2);
        Video video3 = new Video("Traveling By Vine", "George O.T. Jungle", 221);
        cv.AddVideo(video3);

        Comment comment1 = new Comment(video1._title, "Mr. Renkins", "Who knew that bananas came in so many different varieties?");
        cv.AddComment(comment1);
        Comment comment2 = new Comment(video1._title, "Charkie", "Bark bark, barkbarkbark woof woof grrrrrrr!");
        cv.AddComment(comment2);
        Comment comment3 = new Comment(video1._title, "Chef Pisghetti", "Ia donna needa no baanaanaaaas. I only wanna tha spaghetti.");
        cv.AddComment(comment3);
        Comment comment4 = new Comment(video2._title, "Anne Darrow", "I've had a few boyfriends who remind me of you, Mr. Kong.");
        cv.AddComment(comment4);
        Comment comment5 = new Comment(video2._title, "Jack Driscoll", "I love the Empire State Building.");
        cv.AddComment(comment5);
        Comment comment6 = new Comment(video2._title, "Bruce Baxter", "I hate the jungle. Tropical, concrete - don't care, I hate them all.");
        cv.AddComment(comment6);
        Comment comment7 = new Comment(video2._title, "Lumpy", "What's that smell?");
        cv.AddComment(comment7);
        Comment comment8 = new Comment(video3._title, "Ursula Stanhope", "I have a fear of flying but I'll try it if it's with you.");
        cv.AddComment(comment8);
        Comment comment9 = new Comment(video3._title, "Tookie", "Vines are for primates.");
        cv.AddComment(comment9);
        Comment comment10 = new Comment(video3._title, "Shep", "My trunk is not a vine.  Please quit trying to swing from it.");
        cv.AddComment(comment10);


        cv.ListVideos();
    }
}