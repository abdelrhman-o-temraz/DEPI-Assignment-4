// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Enum and Struct - Question 3
// Question: Match a season name to its months

using System;

namespace EnumAndStruct;

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public static class Q3
{
    // This method reads the season name and prints the months for that season.
    public static void Run()
    {
        Console.Write("Enter a season name: ");
        string seasonName = Console.ReadLine();

        if (seasonName == null)
        {
            seasonName = "";
        }

        switch (seasonName.Trim().ToLower())
        {
            case "spring":
                Console.WriteLine("Spring: March to May");
                break;
            case "summer":
                Console.WriteLine("Summer: June to August");
                break;
            case "autumn":
                Console.WriteLine("Autumn: September to November");
                break;
            case "winter":
                Console.WriteLine("Winter: December to February");
                break;
            default:
                Console.WriteLine("Invalid season name.");
                break;
        }
    }
}
