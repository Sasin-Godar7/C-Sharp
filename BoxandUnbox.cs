// boxing and unboxing it is a act of converting value-type instance to a refrence instance


// gettype and typeof operator

// get type is evaluated at runtume
// typeof is evaluated at compile time

// using System;
// public class Point{public int x,y;}

//     class  Test
//     {
//         static void Main()
//     {
//         Point p  = new Point();
//         Console.WriteLine(p.GetType().Name);
//         Console.WriteLine(typeof(Point).Name);
//         Console.WriteLine(p.x.GetType().Name);
//         Console.WriteLine(p.y.GetType().FullName);
//     }
        
//     }







// enumerator in c#

enum month
{
    jan,feb,mar,apr,may
}

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("The value of jan in month" + "Enum is "+(int)month.jan);  //0
        
        Console.WriteLine("The value of feb in month" + "Enum is "+(int)month.feb);//1
        
        Console.WriteLine("The value of mar in month" + "Enum is "+(int)month.may);//4
    }
}