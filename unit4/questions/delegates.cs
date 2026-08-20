
// what is delegate ? explain its use in c# language

//  delegate is an object that knows how to call a method or A delegate is a type-safe object that stores the reference (address) of a method. It allows a method to be called indirectly

// Uses of Delegate----- >>>

// Stores Method Reference
// Method ko address store garxa.
// Calls Method Dynamically
// Runtime ma kun method call garne bhanera decide garna milxa.
// Event Handling
// Button Click, Mouse Click jasta events handle garna use hunxa.
// Callback Methods
// Euta method sakiyepaxi arko method automatically call garna use hunxa.
// Code Reusability
// Code lai flexible ra reusable banauxa.\


// using System;

// public delegate int MyDelegate(int x);
// class DeleteTest
// {
//     static int MyMethod(int x)
//     {
//         return x * x;
//     }

//     static void Main()
//     {
//         MyDelegate md = new MyDelegate(MyMethod);
//         Console.WriteLine(md(5));

//         Console.ReadKey();
//     }
// }



// 3)))) explain multicasting delegate with suitable program

// A Multicasting Delegate is a delegate that stores the reference of multiple methods with the same return type and parameter list. When the delegate is invoked, all the methods are executed in the order they were added. It is commonly used in event handling and callback operations.

// Important Operators:

// += → Add a method to the delegate.
// -= → Remove a method from the delegate.

// using System;
// public delegate int NumChanger(int n);
// class TestDelegate
// {
//     static int num = 10;

//     public static int Addnum(int p )
//     {
//         num = num + p;
//         return num;
//     }

//     public static int Mulnum(int q)
//     {
//         num = num* q;
//         return num;
//     }

//     public static int getNum()
//     {
//        return num;
//     }

//     static void Main()
//     {
//         NumChanger nc; // empty delegate
//         NumChanger nc1 = new NumChanger(Addnum);
//         NumChanger nc2 = new NumChanger(Mulnum);

//         nc = nc1;   // nc vanni empty delaget le addnum vanni aauta method lai store garexa
//         nc += nc2;   // nc vanni le arko aauta method mulnum vanni pani store garyo 

//         // calling multicast
//         nc(5); // nc le duita methodstore garexa so call garepaxi step 1 addnum(5) so cal = 10 + 5 => num =15
//          //                                       automatically  step 2 cal = 15 * 5 =>num = 75

//         Console.WriteLine("value of num :{0}",getNum()); // it will show the current num that is 75
//         Console.ReadKey();
//     }
// }




// 4))) explain type compatibility of delegate with example

  //Type Compatibility means a delegate can point only to those methods whose return type and parameter list are the same as the delegate.         if not match then itwll show complie-time error

// using System;

// delegate int MyDelegate(int x);

// class Program
// {
//     static int Square(int n)
//     {
//         return n * n;
//     }

//     static void Main()
//     {
//         MyDelegate obj = new MyDelegate(Square);
      
//         Console.WriteLine(obj(5));
//     }
// }

// // error condition chai
// delegate int MyDelegate(int x);

// static void Show()
// {
//     Console.WriteLine("Hello");
// }

// Rules of Type Compatibility

// Return type must be the same.
// Number of parameters must be the same.
// Parameter types must be the same.
// Parameter order must also be the same.



// 5 )))) explain generic delegate types with example

   // Generic Delegate Types are predefined delegates in C# that can work with different data types without creating a new delegate.
   // types are actiion delegate and fimc delegate

//    1. Action
// Returns void.
// Can take 0 or more parameters.

// Example

// using System;

// class Program
// {
//     static void Show(string name)
//     {
//         Console.WriteLine(name);
//     }

//     static void Main()
//     {
//         Action<string> obj = Show;
//         obj("Sasin");
//     }
// } 
// output =============sasin

// 2. Func
// Returns a value.
// Last type is the return type.

// Example

// using System;

// class Program
// {
//     static int Square(int x)
//     {
//         return x * x;
//     }

//     static void Main()
//     {
//         Func<int, int> obj = Square;
//         Console.WriteLine(obj(5));
//     }
// }

// Output========25



// 6 ))) define event . how can we declare and invoke event ? explain with the help of suitable program

    //   An Event is a feature in C# that allows an object to notify other objects when a specific action occurs. Events are based on delegates. To use an event, first declare a delegate, then declare an event using the event keyword, attach a method with the += operator, and finally invoke the event. Events are commonly used in GUI applications for actions such as button clicks, mouse clicks, and key presses.

//      using System;
//      class Program
// {
//     public delegate void MyDelegate();
//     public event MyDelegate MyEvent;

//     public Program()
//     {
//         MyEvent += display;
//     }

//     static void display()
//     {
//         Console.WriteLine("method invoke succesfully");
//     }

//     public void start()
//     {
//         MyEvent();
//     }

//     static void Main()
//     {
//         Program p = new Program();
//         p.start();
//     }
// }






