using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Crazy Bungee Jumping Video!!", "coolguy23", 129);
        video1.AddComment("kate777", "This was awesome to watch!");
        video1.AddComment("sweetCaroline", "I would be so scared to jump!!");
        video1.AddComment("likemike01", "Where did you go to do this?");

        Video video2 = new Video("World War II: Explained", "historynerd89", 335);
        video2.AddComment("teacherHarvey", "I showed this to my class, very helpful.");
        video2.AddComment("historynerd212", "I never knew the fact at 0:23!");
        video2.AddComment("conspiracyCarl", "WWIII is right around the corner... you watch...");
        video2.AddComment("Helpless_Student", "This helped me ace my history final! Thx!!");

        Video video3 = new Video("How to Tie a Tie", "How To!", 60);
        video3.AddComment("mommaKaren", "This video helped me learn how to tie my son's tie!");
        video3.AddComment("cats334", "I personally like the double windsor knot");
        video3.AddComment("OlliePop447", "Great video! Super helpful!");

        Video video4 = new Video("A Day in My Life: Taylor Swift", "Vogue", 436);
        video4.AddComment("tayswizzle13", "I love you Taylor!!!");
        video4.AddComment("tayl0rhat3r", "Taylor Swift is so annoying");
        video4.AddComment("eras13", "I love seeing into celebrities daily lives!!!!");

        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();
        video4.DisplayVideo();

    }
}