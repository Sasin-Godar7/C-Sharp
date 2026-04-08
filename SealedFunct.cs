// using System;

// sealed class Test
// {
//     public void message()
//     {
//         Console.WriteLine("Running from sealed class ;;;;;");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Test obj = new Test();
//         obj.message(); 
//     }
// }

// class B:Test --------------------------------------------------'B': cannot derive from sealed type 'Test'
// {
//     static void Main(string[] args)
//     {
//         Test obj = new Test();
//         obj.message();
//     }
// }



//==============sealed method and properties

// class Base
// {
//     public virtual void test()
//     {
//         Console.WriteLine("this is the base class msggg");
//     } 
// }

// class sub1 : Base
// {
    
//     public sealed override void test()
//     {
//         Console.WriteLine("This is the sealed method msgg");
//     }
// }

// class sub2 : Base
// {
//     public void  override test()
//     {
//         Console.WriteLine("this will show and errorr");
//     }
// }