//Constructor: A special method that is automatically called when an object is created.

//Destructor: A special method that is automatically called when an object is destroyed.

// constructor

// using System;

// class Program
// {
//     public Program()
//     {
//         Console.WriteLine("this is the example of the constructor!!!");
//     }

//     static void Main(string [] args)
//     {
//         Program p = new Program();
//     }
// }




    // destructor
    using System;

class Program
{
     ~ Program()
    {
        Console.WriteLine("this is the example of the destructor!!!");
    }

    static void Main(string [] args)
    {
        Program p = new Program();
    }
}

