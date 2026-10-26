// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Enum and Struct - Question 5
// Question: Check whether a color is a primary color

using System;

namespace EnumAndStruct;

public enum Colors
{
    Red,
    Green,
    Blue
}

public static class Q5
{
    // This method reads a color name and tells whether it is primary or not.
    public static void Run()
    {
        Console.Write("Enter a color name: ");
        string colorName = Console.ReadLine();

        if (colorName == null)
        {
            colorName = "";
        }

        switch (colorName.Trim().ToLower())
        {
            case "red":
            case "green":
            case "blue":
                Console.WriteLine(colorName + " is a primary color.");
                break;
            default:
                Console.WriteLine(colorName + " is not a primary color.");
                break;
        }
    }
}
