// using System;
// public class Animal
// {
//     public string color = "White";
// }

// public class Dog:Animal
// {
//     string color="black";
//     public void ShowColor()
//     {
//         Console.WriteLine(base.color);
//         Console.WriteLine(color);
//     }
// }


// public class TestBase
// {
//     public static void Main(string[] args)
//     {
//         Dog d = new Dog();
//         d.ShowColor();
//     }
// }





//derive class bata parent class access grna xa vane we use base keyword

using System;
class Base{
public virtual void test()
{
    Console.WriteLine("I am the inside base/ parent class");

}
}


class sub1 : Base
{
    public override void test()
    {
        base.test();
        Console.WriteLine("I am inside the derived class ;;");
    }
}

class BaseEx
{
    public static void Main(string[] args)
    {
        sub1 obj = new sub1();
        obj.test();
    }
}