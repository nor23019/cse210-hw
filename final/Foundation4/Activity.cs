public abstract class Activity
{
    private DateTime _date;
    private double _duration; 

    public DateTime GetDate()
    {
        return _date;
    }

    public double GetDuration()
    {
        return _duration;
    }

    protected Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public virtual string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} ({GetDuration():F1} min): Distance: {Distance():F2} km, Speed: {Speed():F2} km/h, Pace: {Pace():F2} min per km";
    }
}
