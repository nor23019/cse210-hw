public class Running : Activity
{
    private double _distance; 

    public Running(DateTime date, double duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return Distance() / GetDuration() * 60; 
    }

    public override double Pace()
    {
        return GetDuration() / Distance(); 
    }

}