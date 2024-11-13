using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new("Red", 3);
        Console.WriteLine($" Color: {square.GetColor()} \n Area: {square.GetArea()}");

        Rectangle rectangle = new("Blue", 4, 5);
        Console.WriteLine($" Color: {rectangle.GetColor()} \n Area: {rectangle.GetArea()}");
       
        Circle circle = new("Green", 6);
        Console.WriteLine($" Color: {circle.GetColor()} \n Area: {circle.GetArea()}");

    }
}