// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Enum and Struct - Question 0
// Question: Program menu for the Enum and Struct assignment

using System;

namespace EnumAndStruct;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose a question from 1 to 7");
            Console.WriteLine("1. Print all weekdays");
            Console.WriteLine("2. Person array");
            Console.WriteLine("3. Season months");
            Console.WriteLine("4. Permissions flags");
            Console.WriteLine("5. Check primary color");
            Console.WriteLine("6. Distance between points");
            Console.WriteLine("7. Oldest person");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid choice.");
                Console.WriteLine();
                continue;
            }

            switch (choice)
            {
                case 1:
                    Q1.Run();
                    break;
                case 2:
                    Q2.Run();
                    break;
                case 3:
                    Q3.Run();
                    break;
                case 4:
                    Q4.Run();
                    break;
                case 5:
                    Q5.Run();
                    break;
                case 6:
                    Q6.Run();
                    break;
                case 7:
                    Q7.Run();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
