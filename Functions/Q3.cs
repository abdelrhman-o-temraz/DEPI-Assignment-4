// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 3
// Question: Function with two numbers and out parameters for sum and subtraction

using System;

namespace Functions;

public static class Q3
{
    // This method takes two numbers and returns the sum and subtraction using out parameters.
    public static void Calculate(int first, int second, out int sum, out int subtraction)
    {
        sum = first + second;
        subtraction = first - second;
    }

    public static void Run()
    {
        Console.Write("Enter the first number: ");
        string firstInput = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string secondInput = Console.ReadLine();

        if (!int.TryParse(firstInput, out int firstNumber) || !int.TryParse(secondInput, out int secondNumber))
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
            return;
        }

        Calculate(firstNumber, secondNumber, out int sum, out int subtraction);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Subtraction: " + subtraction);
    }
}
