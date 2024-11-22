using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool Running = true;

        do
        {
            goalManager.ListGoals();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    goalManager.CreateNewGoal();
                    break;

                case "2":
                    goalManager.ListGoals();
                    break;

                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    string saveFile = Console.ReadLine();
                    goalManager.SaveGoals(saveFile);
                    break;

                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string loadFile = Console.ReadLine();
                    goalManager.LoadGoals(loadFile);
                    break;

                case "5":
                    goalManager.RecordEvent();
                    break;

                case "6":
                    Running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select again.");
                    break;
            }
        } while (Running);
    }
}
