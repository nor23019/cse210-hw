using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select an option: ");
        string input2 = Console.ReadLine();

        switch (input2)
        {
            case "1":
                Console.Write("Enter the name of the goal: ");
                string sGoalName = Console.ReadLine();
                Console.Write("Enter the description of the goal: ");
                string sGoalDescription = Console.ReadLine();
                Console.Write("Enter the points for completing the goal: ");
                if (int.TryParse(Console.ReadLine(), out int sGoalPoints))
                {
                    AddGoal(new SimpleGoal(sGoalName, sGoalDescription, sGoalPoints));
                }
                else
                {
                    Console.WriteLine("Invalid points. Returning to menu.");
                }
                break;

            case "2":
                Console.Write("Enter the name of the goal: ");
                string eGoalName = Console.ReadLine();
                Console.Write("Enter the description of the goal: ");
                string eGoalDescription = Console.ReadLine();
                Console.Write("Enter the points for recording the goal: ");
                if (int.TryParse(Console.ReadLine(), out int eGoalPoints))
                {
                    AddGoal(new EternalGoal(eGoalName, eGoalDescription, eGoalPoints));
                }
                else
                {
                    Console.WriteLine("Invalid points. Returning to menu.");
                }
                break;

            case "3":
                Console.Write("Enter the name of the goal: ");
                string cGoalName = Console.ReadLine();
                Console.Write("Enter the description of the goal: ");
                string cGoalDescription = Console.ReadLine();
                Console.Write("Enter the points for each completion: ");
                if (int.TryParse(Console.ReadLine(), out int cGoalPoints))
                {
                    Console.Write("Enter the number of times to complete the goal: ");
                    if (int.TryParse(Console.ReadLine(), out int cGoalTarget))
                    {
                        Console.Write("Enter the bonus points for completing the goal: ");
                        if (int.TryParse(Console.ReadLine(), out int cGoalBonus))
                        {
                            AddGoal(new ChecklistGoal(cGoalName, cGoalDescription, cGoalPoints, cGoalTarget, cGoalBonus));
                        }
                        else
                        {
                            Console.WriteLine("Invalid bonus points. Returning to menu.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid target count. Returning to menu.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid points. Returning to menu.");
                }
                break;

            default:
                Console.WriteLine("Invalid option. Returning to menu.");
                break;
        }
    }

    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine($"Total Points: {_totalPoints}\n");
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            goal.GoalStatus();
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _totalPoints = int.Parse(lines[0]);
            _goals.Clear();

            foreach (var line in lines[1..])
            {
                string[] parts = line.Split(",");
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    var sg = new SimpleGoal("", "", 0); 
                    sg.Load(line);
                    _goals.Add(sg);
                }
                else if (type == "EternalGoal")
                {
                    var eg = new EternalGoal("", "", 0); 
                    eg.Load(line);
                    _goals.Add(eg);
                }
                else if (type == "ChecklistGoal")
                {
                    var cg = new ChecklistGoal("", "", 0, 0, 0); 
                    cg.Load(line);
                    _goals.Add(cg);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Select the completed goal:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name}");
        }

        Console.Write("Enter the goal number: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            goalIndex -= 1;
            _goals[goalIndex].RecordProgress();
            _totalPoints += _goals[goalIndex]._points;
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}
