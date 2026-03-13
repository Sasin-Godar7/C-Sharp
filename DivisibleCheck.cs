//------------WAP to check number is divisble by 7 or 5 or not ----------------------------------

using System;
class program
{
static void Main() 
{
   Console.WriteLine("Enter the first number :");
   int num= int.Parse(Console.ReadLine());

     if(num%5==0 || num%7==0)
{
           Console.WriteLine("the number is divisible by 5 or 7");  
}
else{
   Console.WriteLine("the number is not divisible by 5 or 7");
}
 
    }
}