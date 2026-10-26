// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Enum and Struct - Question 1
// Question: Print all the days of the week from an enum

using System;

namespace EnumAndStruct;

public enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public static class Q1
{
    // This method prints each day of the week from the enum.
    public static void Run()
    {
        Console.WriteLine("The days of the week are:");

        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
    }
}
