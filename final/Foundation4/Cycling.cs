public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return GetDuration() * _speed;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return GetDuration() / Distance();
    }

}