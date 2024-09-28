using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 50);

        int guess_num = -1;

        while (guess_num != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess_num = int.Parse(Console.ReadLine());

            if (magicNumber > guess_num)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess_num)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}