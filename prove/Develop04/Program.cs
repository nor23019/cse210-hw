using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        do
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Game");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    BreathingA breathing = new BreathingA();
                    breathing.RunBreathing();
                    break;

                case "2":
                    Console.Clear();
                    ReflectionA reflection = new ReflectionA();
                    reflection.RunReflection();
                    break;                    

                case "3":
                    Console.Clear();
                    ListingA listing = new ListingA();
                    listing.RunListingActivity();
                    break;

                case "4":
                    Console.Clear();
                    WordGameA wordGame = new WordGameA();
                    wordGame.RunWordGameActivity();
                    break;

                case "5":
                    Console.Clear();
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select again.");
                    break;
            }
        } while (running);
    }
}