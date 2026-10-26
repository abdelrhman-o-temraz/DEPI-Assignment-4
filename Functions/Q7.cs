// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 7
// Question: Calculate the factorial of a number iteratively

using System;

namespace Functions;

public static class Q7
{
    // This method calculates the factorial of a number without using recursion.
    public static int Factorial(int number)
    {
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    public static void Run()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            return;
        }

        int result = Factorial(number);
        Console.WriteLine("The factorial of " + number + " is: " + result);
    }
}
