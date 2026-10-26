// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 2
// Question: Explain reference type passing with an array example

using System;

namespace Functions;

public static class Q2
{
    // This method changes the array content, so the original array is changed too.
    public static void ChangeArray(int[] numbers)
    {
        numbers[0] = 100;
        Console.WriteLine("Inside the method: " + numbers[0]);
    }

    public static void Run()
    {
        Console.WriteLine("Reference type passed by reference example");
        Console.WriteLine("------------------------------------------");

        int[] numbers = { 10, 20, 30 };
        Console.WriteLine("Before calling the method: " + numbers[0]);

        ChangeArray(numbers);

        Console.WriteLine("After calling the method: " + numbers[0]);
        Console.WriteLine("The array is changed because it is a reference type and points to the same data.");
    }
}
