//------------WAP to check greatest among three number given by user----------------------------------

using System;
class program
{
static void Main() 
{
   Console.WriteLine("Enter the first number :");
   int num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the second number :");
   int num2 = int.Parse(Console.ReadLine());

         Console.WriteLine("Enter the third number :");
   int num3= int.Parse(Console.ReadLine());
      
      if(num1>=num2 && num1>num3)
{
   Console.WriteLine("The greater number is "+num1);
}
    else if(num2>=num1 && num2>num3)
{
           Console.WriteLine("The greater number is "+num2);  
}
    else if(num2==num1 && num2 ==num3 && num1==num3)
{
           Console.WriteLine("all are equall");  
}
else{
   Console.WriteLine("The greater number is "+num3);
}
 
    }
}