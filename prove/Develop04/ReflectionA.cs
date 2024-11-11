using System.Collections.Generic;
using System.Diagnostics;

class ReflectionA : Activity
{
    private static List<string> Prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    public void RunReflection()
    {
        DisplayWelcome("Reflection", "reflect on times in your life when you have shown strength and resilience");

        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        DisplayAnimationSpinner();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < time)
        {
            Console.WriteLine(Questions[random.Next(Questions.Count)]);
            DisplayAnimationSpinner();
            Thread.Sleep(1000);
            Console.ReadLine();
        }

        stopwatch.Stop();
        DisplayEnding();
        DisplayAnimationSpinner();
        Console.Clear();
    }
}