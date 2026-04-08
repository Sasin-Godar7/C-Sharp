//virtual method-------------------

// using System;
// class Vir
// {
//     public virtual void message()

//     {
//         Console.WriteLine("This is test ::::");
//     }
// }

// class Vir1 : Vir
// {
//     public override void message()
//     {
//         Console.WriteLine("This is test 1");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Vir1 obj = new Vir1();
//         obj.message();
//     }
// }





//unary operator overloading-------------------
// using System;

// class Complex
// {
//     private int x;
//     private int y;

//     // Default constructor
//     public Complex()
//     {
//         x = 0;
//         y = 0;
//     }

//     // Parameterized constructor
//     public Complex(int i, int j)
//     {
//         x = i;
//         y = j;
//     }

//     // Display method
//     public void ShowXY()
//     {
//         Console.WriteLine("{0} & {1}", x, y);
//     }

//     // Operator overloading (Unary minus)
//     public static Complex operator -(Complex c)
//     {
//         Complex temp = new Complex();
//         temp.x = -c.x;
//         temp.y = -c.y;
//         return temp;
//     }
// }

// class MyClient
// {
//     public static void Main()
//     {
//         Complex c1 = new Complex(10, 20);
//         c1.ShowXY();

//         Complex c2 = new Complex();
//         c2.ShowXY();

//         c2 = -c1;
//         c2.ShowXY();
//     }
// }




//Binaryy operator overloading-------------------
using System;
using System.Runtime.Intrinsics.Arm;

class Complex
{
    private int x;
    private int y;

    // Default constructor
    public Complex()
    {
        x = 0;
        y = 0;
    }

    // Parameterized constructor
    public Complex(int i, int j)
    {
        x = i;
        y = j;
    }

    // Display method
    public void ShowXY()
    {
        Console.WriteLine("{0} & {1}", x, y);
    }

    // Operator overloading (Unary minus)
    public static Complex operator +(Complex c1,Complex c2)
    {
        Complex temp = new Complex();
        temp.x = c1.x+c2.x;
        temp.y = c1.y+c2.y;
        return temp;
    }
}

class MyClient
{
    public static void Main()
    {
        Complex c1 = new Complex(10, 20);
        c1.ShowXY();

        Complex c2 = new Complex(20,30);

         Complex c3 = c1+c2;
       c3.ShowXY();
    }
}
