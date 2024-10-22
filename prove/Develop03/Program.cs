using System;

class Program
{
    static void Main(string[] args)
    {
        //Creates a scripture reference object.
        ScriptureReference reference = new ScriptureReference("Daniel", 6, 22, 23); 
        string scriptureText = "My God hath sent his angel, and hath shut the lions' mouths, that they have not hurt me: forasmuch as before him innocency was found in me; and also before thee, O king, have I done no hurt. Then was the king exceedingly glad for him, and commanded that they should take Daniel up out of the den. So Daniel was taken up out of the den, and no manner of hurt was found upon him, because he believed in his God.";
        Scripture scripture = new Scripture(reference, scriptureText);  // Creates a scripture object.

        while (true) {
            Console.Clear();                                            //Clears the console.
            scripture.DisplayScripture();                               //Displays the scripture.
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();                      
            
            if (input.ToLower() == "quit"){                              //Quits if input is quit.
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWords();

            if (scripture.AllWordsHidden()) {
                Console.Clear();
                scripture.DisplayScripture();
                Console.WriteLine("\nYou did it!!");       //Ends the program if all words are hidden.
                break;
            }
        }
    }
}
