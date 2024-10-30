class Scripture
{
    private ScriptureReference Reference;
    private List<Word> Words;
    private Random random = new Random();

    public Scripture(ScriptureReference reference, string text) {
        Reference = reference;
        Words = new List<Word>();
        string[] wordsArray = text.Split(' ');

        foreach (string wordText in wordsArray)
        {
            Word word = new Word(wordText);
            Words.Add(word);
        }
    }

    public void DisplayScripture() {
        Console.WriteLine(Reference);
        foreach (var word in Words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords() {         // Hides random words
        int wordsToHide = 3; 
        List<Word> visibleWords = new List<Word>(); // creates a list object of visible words

        foreach (Word word in Words) {              // Adds any unhiden word to a list
            if (!word.IsHidden) {  
                visibleWords.Add(word);  
            }
        }

        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++) { // removes words that are hidden
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden() {   // Checks if any words in Words are hidden
    foreach (Word word in Words) {
        if (!word.IsHidden) {
            return false;
        }
    }
    return true;
    }
}