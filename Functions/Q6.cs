// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 6
// Question: Find the minimum and maximum of an array using reference parameters

using System;

namespace Functions;

public static class Q6
{
    // This method finds the minimum and maximum value in the array and sends them back using out parameters.
    public static void MinMaxArray(int[] numbers, out int min, out int max)
    {
        min = numbers[0];
        max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
    }

    public static void Run()
    {
        int[] numbers = { 12, 5, 8, 20, 1, 15 };

        MinMaxArray(numbers, out int minimum, out int maximum);

        Console.WriteLine("The array is: 12, 5, 8, 20, 1, 15");
        Console.WriteLine("Minimum value: " + minimum);
        Console.WriteLine("Maximum value: " + maximum);
    }
}
