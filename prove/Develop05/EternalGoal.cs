public class EternalGoal : Goal
{
 
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {}
    public override void RecordProgress()
    {
        Console.WriteLine($"You earned {_points} points!");
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_name},{_description},{_points}";
    }

    public override void Load(string data)
    {
        var parts = data.Split(",");
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
    }

    public override void GoalStatus()
    {
        Console.WriteLine($"[∞] {_name}: {_description} {_points} pts per completion");
    }
}