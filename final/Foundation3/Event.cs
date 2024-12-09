public class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private DateTime _date;
    private int _time;
    private string _addrress;

        public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _addrress;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public void SetTime(int time)
    {
        _time = time;
    }

    public void SetAddress(string addrress)
    {
        _addrress = addrress;
    }

    public Event(string eventType,string title, string description, DateTime date, int time, string addrress)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _addrress = addrress; 
    }

    public virtual void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date:MM/dd/yyyy}");
        Console.WriteLine($"Time: {_time} minutes");
        Console.WriteLine($"Address: {_addrress}");
    }

    public virtual void FullDetails()
    {
        StandardDetails();
    }

    public virtual void ShortDetails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date.ToString("MM/dd/yyyy")}");
    }
}