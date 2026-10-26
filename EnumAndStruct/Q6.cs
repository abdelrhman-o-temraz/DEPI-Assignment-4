// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Enum and Struct - Question 6
// Question: Calculate the distance between two points

using System;

namespace EnumAndStruct;

public struct Point
{
    public double X;
    public double Y;

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

public static class Q6
{
    // This method calculates the distance between two points.
    public static double Distance(Point p1, Point p2)
    {
        double xDifference = p2.X - p1.X;
        double yDifference = p2.Y - p1.Y;

        return Math.Sqrt((xDifference * xDifference) + (yDifference * yDifference));
    }

    public static void Run()
    {
        Console.Write("Enter X for point 1: ");
        string x1Input = Console.ReadLine();
        Console.Write("Enter Y for point 1: ");
        string y1Input = Console.ReadLine();
        Console.Write("Enter X for point 2: ");
        string x2Input = Console.ReadLine();
        Console.Write("Enter Y for point 2: ");
        string y2Input = Console.ReadLine();

        if (!double.TryParse(x1Input, out double x1) || !double.TryParse(y1Input, out double y1)
            || !double.TryParse(x2Input, out double x2) || !double.TryParse(y2Input, out double y2))
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
            return;
        }

        Point p1 = new Point(x1, y1);
        Point p2 = new Point(x2, y2);

        double result = Distance(p1, p2);
        Console.WriteLine("Distance between the points is: " + result);
    }
}
