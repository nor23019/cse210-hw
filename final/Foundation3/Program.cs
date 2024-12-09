class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture(
            "Tech Talk",
            "A lecture on AI advancements",
            new DateTime(2024, 12, 15),
            60,
            "123 Elm St, Springfield, IL",
            "Dr. Alice Johnson",
            100
        );

        Reception reception = new Reception(
            "Networking Event",
            "Meet industry professionals",
            new DateTime(2024, 12, 20),
            120,
            "456 Oak St, Rivertown, NY",
            "rsvp@example.com"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Park Picnic",
            "Enjoy a relaxing day outdoors",
            new DateTime(2024, 12, 25),
            180,
            "789 Pine St, Sunnyvale, CA",
            "Sunny, 75°F"
        );

        Console.WriteLine("Lecture Details:");
        lecture.FullDetails();
        Console.WriteLine(new string('-', 40));

        Console.WriteLine("Reception Details:");
        reception.FullDetails();
        Console.WriteLine(new string('-', 40));

        Console.WriteLine("Outdoor Gathering Details:");
        outdoorGathering.FullDetails();
        Console.WriteLine(new string('-', 40));
    }
}