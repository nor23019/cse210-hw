using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        List<int> numberList;
        numberList = new();

        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter something");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);
            
            if(input != 0)
            {
                numberList.Add(input);
            }

        }

        foreach (int item in numberList)
        {
            Console.WriteLine(item);
        }

    }
}