public class Reception : Event
{  
    private string _rsvp;

    public Reception(string title, string description, DateTime date, int time, string addrress, string rsvp) : base("Reception", title, description, date, time, addrress)
    {
        _rsvp = rsvp;
    }

    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"RSVP: {_rsvp}");
    }

}