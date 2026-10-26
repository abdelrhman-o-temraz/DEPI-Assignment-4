// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Enum and Struct - Question 7
// Question: Find the oldest person from 3 people

using System;

namespace EnumAndStruct;

public static class Q7
{
    // This method finds the oldest person among three persons.
    public static void Run()
    {
        Person[] people = new Person[3];

        for (int i = 0; i < people.Length; i++)
        {
            Console.Write("Enter name for person " + (i + 1) + ": ");
            string name = Console.ReadLine();

            Console.Write("Enter age for person " + (i + 1) + ": ");
            string ageInput = Console.ReadLine();

            if (!int.TryParse(ageInput, out int age))
            {
                Console.WriteLine("Invalid age. Please enter a valid integer.");
                i--;
                continue;
            }

            people[i] = new Person(name, age);
        }

        Person oldest = people[0];

        for (int i = 1; i < people.Length; i++)
        {
            if (people[i].Age > oldest.Age)
            {
                oldest = people[i];
            }
        }

        Console.WriteLine("The oldest person is: " + oldest.Name + ", Age: " + oldest.Age);
    }
}
