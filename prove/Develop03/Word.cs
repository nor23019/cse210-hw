class Word {
    private string Text;
    public bool IsHidden;

    public Word(string text) {              //Word constructor
        Text = text;
        IsHidden = false;
    }

    public void Hide() {                    //Hides the word
        IsHidden = true;
    }

    public override string ToString(){      //Returns the string to hide the word
    if (IsHidden)
    {
        return "____";
    }
    else
    {
        return Text;
    }
    }
}