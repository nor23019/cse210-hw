class ScriptureReference
{
    private string Book;
    private int Chapter;
    private int StartVerse;
    private int EndVerse;

    // Constructor for single verse
    public ScriptureReference(string book, int chapter, int verse) {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = verse;
    }

    // Constructor for multiple verses
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse) {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }
}