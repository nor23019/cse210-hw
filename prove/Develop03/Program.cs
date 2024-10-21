using System;

class Program
{
    static void Main(string[] args)
    {
        // Scripture Reference used.
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, scriptureText);  // Creates a scripture object

        while (true) {
            Console.Clear();                                            //Clears the console
            scripture.DisplayScripture();                               //Displays the scripture
            
            Console.WriteLine("\nPress Enter to hide a few words or type 'quit' to exit.");
            string input = Console.ReadLine();                      
            
            if (input.ToLower() == "quit")                              //Quits if input is quit
                break;

            scripture.HideRandomWords();

            if (scripture.AllWordsHidden()) {
                Console.Clear();
                scripture.DisplayScripture();
                Console.WriteLine("\nAll words are hidden!");       //Ends the program if all words are hidden
                break;
            }
        }
    }
}
