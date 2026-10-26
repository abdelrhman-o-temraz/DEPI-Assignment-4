// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 5
// Question: Check if a number is prime

using System;

namespace Functions;

public static class Q5
{
    // This method returns true if the number is prime, otherwise false.
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
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

        if (IsPrime(number))
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}
