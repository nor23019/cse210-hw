public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordProgress()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"You earned {_points} points! Progress: {_currentCount}/{_targetCount}");
            if (_currentCount == _targetCount)
            {
                _isComplete = true;
                Console.WriteLine($"Bonus! You earned {_bonus} additional points!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_bonus},{_targetCount},{_currentCount}";
    }

    public override void Load(string data)
    {
        var parts = data.Split(",");
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _bonus = int.Parse(parts[4]);
        _targetCount = int.Parse(parts[5]);
        _currentCount = int.Parse(parts[6]);
       
    }

    public override void GoalStatus()
    {
    Console.WriteLine($"{(_currentCount >= _targetCount ? "[X]" : "[ ]")} {_name}: {_description} ({_points} pts, {_currentCount}/{_targetCount}, Bonus: {_bonus} pts)");
    }

}