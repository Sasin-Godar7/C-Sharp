using System;

public delegate int NumChanger(int n);

class TestDelegate
{
    static int n = 10;

    public static int AddNum(int p)
    {
        n += p;
        return n;
    }

    public static int MultNum(int q)
    {
        n *= q;
        return n;
    }

    public static int getNum()
    {
        return n;
    }

    public static void Main(string[] args)
    {
        // Creating delegate instances
        NumChanger nc1 = new NumChanger(AddNum);
        NumChanger nc2 = new NumChanger(MultNum);

        // Calling delegate methods
        nc1(25);
        Console.WriteLine("Value of Num: {0}", getNum());

        nc2(5);
        Console.WriteLine("Value of Num: {0}", getNum());

        Console.ReadKey();
    }
}