using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcomne to My Resume");
        
        Job job1 = new();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new();
        job2._jobTitle = "Senior Soft Engineer";
        job2._company = "Apple";
        job2._startYear = 2013;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Joseph Norales";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}