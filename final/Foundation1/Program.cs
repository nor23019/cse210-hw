using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Building a $30,000 LEGO Model!", "Brickcrafts", 1980);
        video1.AddComment("jensonverleden6780", "This guy is living every kid's dream");
        video1.AddComment("TravisTLK", "I don't know if it's doable, but I think it would be cool to cut a hole in the water to add a 3D sunken vessel you can peer down into.");
        video1.AddComment("1by1Brick", "The harbor build wrapping around the shoreline like that is incredibly satisfying!");
        videos.Add(video1);


        Video video2 = new Video("Lights Out TOP 8 - Cosmos (Inkling) Vs. WebbJP (Sheik) Smash Ultimate - SSBU", "VGBootCamp", 2000);
        video2.AddComment("LittleGreenBananas", "2019 matchup");
        video2.AddComment("Sethdaknowledgeseeker", "Cosmos is back to inkling. Thats rad af. 💯💯");
        video2.AddComment("Harocious", "BAM is a underrated commentator in this community. bro funny asf");
        videos.Add(video2);


        Video video3 = new Video("Jazz Night Soul-Jazz & Jazz-Funk Vinyl Set", "見本盤Mihon Reko", 2160);
        video3.AddComment("mariasth15", "i just knew it was going to be a banger when you started with the sample of didn't cha know");
        video3.AddComment("dangusmomangus3003", "you owe me a new neck, ever since i listened to this set my head hasn't stopped bobbing!");
        video3.AddComment("JeancarloBrocato", "Cole has  sampled that first track on his early mixtape, first time I'm listening to the OG!");
        videos.Add(video3);

        Video video4 = new Video("Red Bull", " F1 vs Rally vs Drift Car vs Truck: Ultimate Race", 600);
        video3.AddComment("redbull", "what should we race next? 🏁 😎");
        video3.AddComment("Nickworldindia", "Redbull: we also sell drinks");
        video3.AddComment("Locallybuiltauto", "Mclaren: we have a fast car Redbull: we also have a fast mclaren");
        videos.Add(video4);

        Console.WriteLine("YouTube Video Info:\n");
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}