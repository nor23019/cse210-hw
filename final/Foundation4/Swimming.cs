public class Swimming : Activity
{
    private int _swimmingLaps;

    public Swimming(DateTime date, double duration, int swimmingLaps)
        : base(date, duration)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double Distance()
    {
        return _swimmingLaps * 50 / 1000;
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