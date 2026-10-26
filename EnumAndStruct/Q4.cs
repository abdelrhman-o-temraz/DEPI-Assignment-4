// Name: Abdelrhman Osama Hamed
// Group: SWD5_S4
// Assignment 4 - Enum and Struct - Question 4
// Question: Use a flags enum to add, remove, and check permissions

using System;

namespace EnumAndStruct;

[Flags]
public enum Permissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    Execute = 8
}

public static class Q4
{
    // This method shows how to add, remove, and check a permission using flags.
    public static void Run()
    {
        Permissions myPermissions = Permissions.Read | Permissions.Write;

        Console.WriteLine("Initial permissions: " + myPermissions);

        myPermissions = myPermissions | Permissions.Delete;
        Console.WriteLine("After adding Delete: " + myPermissions);

        myPermissions = myPermissions & ~Permissions.Write;
        Console.WriteLine("After removing Write: " + myPermissions);

        if ((myPermissions & Permissions.Delete) == Permissions.Delete)
        {
            Console.WriteLine("Delete permission exists.");
        }
        else
        {
            Console.WriteLine("Delete permission does not exist.");
        }
    }
}
