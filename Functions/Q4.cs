// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 4
// Question: Sum of the digits of a given number

using System;

namespace Functions;

public static class Q4
{
    // This method calculates the sum of the digits of a number.
    public static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    public static void Run()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        int result = SumOfDigits(number);
        Console.WriteLine("The sum of the digits of the number " + number + " is: " + result);
    }
}
