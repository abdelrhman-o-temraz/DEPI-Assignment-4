// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Functions - Question 0
// Question: Program menu for the Functions assignment

using System;

namespace Functions;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose a question from 1 to 8");
            Console.WriteLine("1. Value vs reference types (value)");
            Console.WriteLine("2. Value vs reference types (reference)");
            Console.WriteLine("3. Sum and subtraction");
            Console.WriteLine("4. Sum of digits");
            Console.WriteLine("5. Prime number check");
            Console.WriteLine("6. Minimum and maximum of array");
            Console.WriteLine("7. Factorial");
            Console.WriteLine("8. Change character");
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
                case 8:
                    Q8.Run();
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
