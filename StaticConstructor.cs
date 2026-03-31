using System;

class user
{
    static user()

    {
        Console.WriteLine("This is a ststic const");
    }
    public user()
    {
        Console.WriteLine("i am default const ");
    }
}


class Program
{
    static void Main()
    {
        user obj1 = new user();
        user obj2 = new user();
        Console.WriteLine("\n press enter to exit :");
        Console.ReadLine();
    }
}



