using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected int time;
    protected string activity;
    protected string activityDescription;

    public Activity(int time = 0)
    {
        this.time = time;
    }

    public void DisplayWelcome(string activity, string activityDescription)
    {
        this.activity = activity;
        this.activityDescription = activityDescription;
        Console.WriteLine($"Welcome to the {activity} Activity!\n");
        Console.WriteLine($"This activity will help you {activityDescription}.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine(); 
        this.time = int.Parse(input); // Corrected to assign to the class-level field
    }

    public void DisplayEnding()
    {
        Console.WriteLine($"\nYou have completed {time} seconds of the {activity} activity. Great job!");
    }

    protected void DisplayAnimationSpinner()
    {
        List<string> animationStrings = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
            "|"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(4);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

    protected void DisplayAnimationCounter()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.Write("\b");

    }
}
