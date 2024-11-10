// BreathingA.cs
class BreathingA : Activity
{
    public void RunBreathing()
    {
        DisplayWelcome("Breathing", "relax by focusing on your breathing");
        Console.Write("Get ready");
        DisplayAnimationSpinner();
        
        int elapsedTime = 0;
        while (elapsedTime < time)
        {
            
            Console.WriteLine("Breathe in");
            DisplayAnimationCounter();
            Console.WriteLine("");
            Console.WriteLine("Breathe out");
            DisplayAnimationCounter(); 
            Console.WriteLine("");
            elapsedTime += 8;
        }
        DisplayEnding();
        DisplayAnimationSpinner();
        Console.Clear();
    }
}