using System;
class Program
{
    static int Add(int a , int b)
    {
        return a + b;
    }

    static int Add(int a , int b , int c)
    {
        return a+b+c;
    }

    static double Add(double a , double b)
    {
        return a+b;
    }

    static void Main()
    {
        Console.WriteLine("sum of 2 integers :" + Add(5,20));
        Console.WriteLine("sum of 3 integers :" + Add(5,20,9));
        Console.WriteLine("sum of 2 floats :" + Add(5.3,20.7));

    }
}


// method overrriding 
// virtual or abstract keyword must use in the base class for method ovverriden 

// using System;

// class Animal
// {
//     public virtual void Sound()
//     {
//         Console.WriteLine("Animal makes sound");
//     }
// }

// class Dog : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Dog barks");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Dog d = new Dog();

//         d.Sound();
//     }
// }

// output-- dog barks