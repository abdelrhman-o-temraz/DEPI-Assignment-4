// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 8
// Question: Change a character at a given position in a string

using System;

namespace Functions;

public static class Q8
{
    // This method changes the character in the string at the chosen position.
    public static string ChangeChar(string text, int position, char newChar)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        if (position < 0 || position >= text.Length)
        {
            Console.WriteLine("Invalid position.");
            return text;
        }

        char[] letters = text.ToCharArray();
        letters[position] = newChar;
        return new string(letters);
    }

    public static void Run()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        Console.Write("Enter the position to change: ");
        string positionInput = Console.ReadLine();

        Console.Write("Enter the new character: ");
        string newCharInput = Console.ReadLine();

        if (!int.TryParse(positionInput, out int position) || string.IsNullOrEmpty(newCharInput))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        char newChar = newCharInput[0];
        string result = ChangeChar(text, position, newChar);

        Console.WriteLine("New string: " + result);
    }
}
