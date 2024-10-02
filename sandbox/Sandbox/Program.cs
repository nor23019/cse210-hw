using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nurse");
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.handWear = "nitrile gloves";
        nurse.shoes = "orthopedic shoes";
        nurse.upperGarments = "scrubs";
        nurse.lowerGarments = "scrubs";
        nurse.accessory = "stethoscope";

        Console.WriteLine("Detective");
        Costume detective = new();
        detective.headWear = "fedora";
        detective.handWear = "leather";
        detective.shoes = "loafers";
        detective.upperGarments = "trenchcoat";
        detective.lowerGarments = "slacks";
        detective.accessory = "magnifying glass";

        Console.WriteLine("Cowbo");
        Costume rancher = new();
        rancher.headWear = "cowboy hat";
        rancher.handWear = "work";
        rancher.shoes = "boots";
        rancher.upperGarments = "vest";
        rancher.lowerGarments = "jeans";
        rancher.accessory = "revolver";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
        rancher.ShowWardrobe();
    }
}