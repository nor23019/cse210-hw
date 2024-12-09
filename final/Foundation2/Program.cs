using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nCurrent Orders:\n");

        Address address1 = new("789 Pine St", "Seattle", "WA", "USA");
        Customer customer1 = new("Alice Johnson", address1);
        Order order1 = new(customer1, new List<Product>
        {
            new("Smartphone", 301, 800.00, 1),
            new("Charger", 302, 20.00, 2)
        });

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine(new string('-', 40));

        Address address2 = new("123 Maple Ave", "Vancouver", "BC", "Canada");
        Customer customer2 = new("Robert Smith", address2);
        Order order2 = new(customer2, new List<Product>
        {
            new("Tablet", 401, 400.00, 1),
            new("Stylus Pen", 402, 30.00, 2),
            new("Protective Case", 403, 50.00, 1)
        });

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
        Console.WriteLine(new string('-', 40));


        Address address3 = new("567 Birch Blvd", "Sydney", "NSW", "Australia");
        Customer customer3 = new("Emily Brown", address3);
        Order order3 = new(customer3, new List<Product>
        {
            new("Camera", 501, 1500.00, 1),
            new("Tripod", 502, 200.00, 1),
            new("Memory Card", 503, 100.00, 2)
        });

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalCost()}");
        Console.WriteLine(new string('-', 40));
    }
}