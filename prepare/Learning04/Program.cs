using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignemnt1 = new Assignment("Joseph Norales", "Multiplication");
        Console.WriteLine(assignemnt1.GetSummary());
        Console.WriteLine("");

        MathAssignment assignemnt2 = new MathAssignment("Ruben Norales", "Divisions", "3.3", "10-20");
        Console.WriteLine(assignemnt2.GetSummary());
        Console.WriteLine(assignemnt2.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment assignemnt3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignemnt3.GetSummary());
        Console.WriteLine(assignemnt3.GetWritingInformation());
    }
}