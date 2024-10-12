using System;
class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Entries to File");
            Console.WriteLine("4. Load Entries from File");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(response));
                    break;

                case "2":
                Console.WriteLine("");
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save entries: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter filename to load entries: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Exiting the Journal");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select again.");
                    break;
            }
        }
        while (running);
    }
}