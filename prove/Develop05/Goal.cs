public abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;
    public bool _isComplete;


    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

        public bool GetIsComplete()
    {
        return _isComplete;
    }

    protected void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public abstract void RecordProgress();
    public abstract string GetStringRepresentation();
    public abstract void Load(string data);

    public virtual void GoalStatus()
    {
        Console.WriteLine($"[ ] {_name}: {_description} ({_points} pts)");
    }
}