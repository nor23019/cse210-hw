using System.Diagnostics;
class WordGameA : Activity
{
    private static List<char> _alphabet = new()
    {
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
    };

    public void RunWordGameActivity()
    {
        DisplayWelcome("Word Game", "test your memory and typing skills by recalling letters");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Random random = new Random();
        while (stopwatch.Elapsed.TotalSeconds < time)
        {
            List<char> selectedLetters = new List<char>();
            for (int i = 0; i < 5; i++)
            {
                char randomLetter = _alphabet[random.Next(_alphabet.Count)];
                selectedLetters.Add(randomLetter);
            }

            Console.WriteLine("Memorize these letters: " + string.Join(" ", selectedLetters));
            DisplayAnimationSpinner();
            Console.Clear();

            Console.WriteLine("Enter the letters in order:");
            string userInput = Console.ReadLine()?.ToUpper();

            if (userInput == string.Join("", selectedLetters))
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct order was: " + string.Join(" ", selectedLetters));
            }
        }
        stopwatch.Stop();
        DisplayEnding();
        DisplayAnimationSpinner();
        Console.Clear();
    }
}

