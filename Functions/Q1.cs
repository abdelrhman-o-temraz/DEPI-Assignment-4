// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 1
// Question: Explain value type passing by value and by reference with a C# example

using System;

namespace Functions;

public static class Q1
{
    // This method shows that a value type is copied when passed by value.
    public static void ChangeValue(int number)
    {
        number = 50;
        Console.WriteLine("Inside the method: " + number);
    }

    public static void Run()
    {
        Console.WriteLine("Value type passed by value example");
        Console.WriteLine("------------------------------------");

        int number = 10;
        Console.WriteLine("Before calling the method: " + number);

        ChangeValue(number);

        Console.WriteLine("After calling the method: " + number);
        Console.WriteLine("The original value stays the same because a copy is sent to the method.");
    }
}
