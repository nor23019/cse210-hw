public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, int time, string addrress, string weather) : base("Outdoor Gathering", title, description, date, time, addrress)
    {
        _weather = weather;
    }

    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
}