//wap to take 3 input from the user and find the greatest one using the nested if ..

using System;

    class Test
    {
        static void Main()
    {
        Console.WriteLine("Enter the first number :");
          int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number :");
          int b = int.Parse( Console.ReadLine());
        Console.WriteLine("Enter the third number :");
          int c =  int.Parse(Console.ReadLine());


          if(a>b)
        {
            if(a>c)
            {
                Console.WriteLine("greatest number is = "+a);
            }
            else
            {
                Console.WriteLine("greatest number is = "+c);
            }
        }

        else
        {
         if (b>c)
        {
            Console.WriteLine("greatest number is = "+b);
        }
            else
            {
                Console.WriteLine("greatest number is = "+c);
            }
        
    }

        
    }
    }
