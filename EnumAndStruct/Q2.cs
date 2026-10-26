// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Enum and Struct - Question 2
// Question: Create an array of 3 Person objects and display them

using System;

namespace EnumAndStruct;

public struct Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public static class Q2
{
    // This method creates 3 persons and prints their information.
    public static void Run()
    {
        Person[] people = new Person[3];

        people[0] = new Person("Ahmed", 20);
        people[1] = new Person("Sara", 25);
        people[2] = new Person("Ali", 30);

        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": " + people[i].Name + ", Age: " + people[i].Age);
        }
    }
}
