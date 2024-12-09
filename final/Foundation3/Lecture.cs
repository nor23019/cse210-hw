public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public Lecture(string title, string description, DateTime date, int time, string addrress, string speaker, int capacity) : base("Lecture", title, description, date, time, addrress)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

        public override void StandardDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    

}