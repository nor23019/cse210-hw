class Scripture
{
    private ScriptureReference Reference;
    private List<Word> Words;
    private Random random = new Random();

    public Scripture(ScriptureReference reference, string text) {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void DisplayScripture() {
        Console.WriteLine(Reference);
        foreach (var word in Words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords() {
        int wordsToHide = 3; 
        List<Word> visibleWords = Words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++) {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden() {
    foreach (Word word in Words) {
        if (!word.IsHidden) {
            return false;
        }
    }
    return true;
    }
}