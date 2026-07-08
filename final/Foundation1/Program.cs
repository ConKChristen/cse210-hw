using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("How to Cook Pasta", "Tony the Chef", 500);
        Video v2 = new Video("My life on the road", "Vaction Gary", 1000);
        Video v3 = new Video("How to understand C Sharp", "Goodness Godderidge", 300);

        v1.AddComment(new Comment("Daniel","Wow I didn't know pasta could be that easy!"));
        v1.AddComment(new Comment("Haylee", "I love pasta and this is great for making my own!"));
        v1.AddComment(new Comment("Brody", "Unsure about step 2 does anyone else know an alternative?"));

        v2.AddComment(new Comment("Bryce", "I wish I could visit California during this time of year"));
        v2.AddComment(new Comment("Kayla", "Vacation Gary YOU ARE THE BEST!!!!!!!!"));
        v2.AddComment(new Comment("Kert", "Can't wait for you to drive through Rexburg!"));

        v3.AddComment(new Comment("Jared","Thanks as always Brother Godderidge"));
        v3.AddComment(new Comment("Phebe", "This was a great video! Well done!"));
        v3.AddComment(new Comment("Connor", "Thank you professor and thank you TA"));

        List<Video> videos = new List<Video>
        {
            v1, v2, v3
        };

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}