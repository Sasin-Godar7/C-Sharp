// using System;
// class para
// {
//     static void foo(int p)         // this is a parameter
//     {
//         p=p+1;
//         Console.WriteLine(p);
//     }

//     static void Main()
//     {
//        Console.WriteLine("Enter the  number:");
//         int num = int.Parse(Console.ReadLine());
//         foo(num);                    // this is a arguement
//     }
// }



// using System;
// class para
// {
//     static void foo(int p)         // this is a parameter
//     {
//         p=p+1;
//         Console.WriteLine(p);
//     }

//     static void Main()
//     {
//         int x = 8;
//         foo(x);
//         Console.WriteLine(x);
//     }
// }




// the ref modifier --------------------------------------------------

// using System;
// class para
// {
//     static void foo(ref int p)         // this is a parameter
//     {
//         p=p+1;
//         Console.WriteLine(p);
//     }

//     static void Main()
//     {
//         int x = 8;
//         foo( ref x);
//         Console.WriteLine(x);
//     }
// }










// the out modifier --------------------------------------------------

// using System;
// class para
// {
//     static void pass(int a , int b, out int x , out int y)         // this is a parameter
//     {
//         x = a +b;
//         y=b-a;
//     }

//     static void Main()
//     {
//         int x , y ;
//         pass(10,20,out x , out y);          //out catches the values and return it
//         Console.WriteLine(x);    
//         Console.WriteLine(y);
//     }
// }







// the params modifier --------------------------------------------------

// using System;
// class Test
// {
//     static int add(params int[] arr)    // this is a params parameter
//     {
//         int sum = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             sum += arr[i];
//         }
//         return sum;
//     }

//     static void Main()
//     {
//         int total = add(1, 2, 3, 4, 5);
//         Console.WriteLine(total);
//     }
// }





using System;
class Test
{
        static void Main()
    {
         Foo();
    }  

     static void Foo(int a = 10)
    {
        Console.WriteLine(a);
    }
}
    














