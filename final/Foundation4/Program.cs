using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new(new DateTime(2024, 12, 7), 60, 100); 
        Cycling cycling = new(new DateTime(2024, 12, 7), 60, 20.0); 
        Swimming swimming = new(new DateTime(2024, 12, 7), 45, 40); 

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('-', 40));
        }
    }
}