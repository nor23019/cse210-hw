class Entry
{
    public string Content;                              //Stores the content of the entry
    public DateTime Timestamp;

    public Entry(string content)                        //Entry constructor for loading entries
    {
        Content = content;
        Timestamp = DateTime.Now;
    }

    public Entry(string content, DateTime timestamp)    //Entry constructor for creating entries
    {
        Content = content;
        Timestamp = timestamp;
    }

        public string DisplayEntry()                    //Method to display entries
    {
        return $"{Timestamp.ToString("yyyy-MM-dd HH:mm:ss")} - {Content}";
    }

}
