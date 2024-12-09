class Video
{
    public string _title;
    public string _author;
    public int _duration;
    private List<Comment> _comments;

    public Video(string title, string author ,int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(string author, string text)
    {
        _comments.Add(new Comment(author, text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
{
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Duration: {_duration} seconds");
    Console.WriteLine($"Number of Comments: {GetCommentCount()}");
    Console.WriteLine("Comments:");
    
    foreach (Comment comment in _comments)
    {
        Console.WriteLine($"- {comment._user}: {comment._text}");
    }
    Console.WriteLine();
}

}