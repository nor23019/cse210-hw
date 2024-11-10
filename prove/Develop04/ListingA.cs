using System.Diagnostics;

class ListingA : Activity
{
    private static readonly List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace recently?",
        "Who are some of your personal heroes?"
    };

    public void RunListingActivity()
    {
        DisplayWelcome("Listing", "reflect on the good things in your life by listing them");

        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        DisplayAnimationSpinner(); 

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int itemCount = 0;
        Console.WriteLine("Start listing items. Press Enter after each item:");

        while (stopwatch.Elapsed.TotalSeconds < time)
        {
            Console.ReadLine();
            itemCount++;
        }

        stopwatch.Stop();
        Console.WriteLine($"You listed {itemCount} items!");
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        DisplayEnding();
         DisplayAnimationSpinner();
        Console.Clear();
        
    }
}