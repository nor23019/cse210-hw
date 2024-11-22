
public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {}
    public override void RecordProgress()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"You earned {_points} points!");
        }
        else
        {
            Console.WriteLine("This goal was completed.");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }

    public override void Load(string data)
    {   
        var parts = data.Split(",");
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
    }

    public override void GoalStatus()
    {
        Console.WriteLine($"{(_isComplete ? "[X]" : "[  ]")} {_name}: {_description} ({_points} pts)");
    }

}