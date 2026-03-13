
//------------Check palindrome  of given number----------------------------------

using System;
class program
{
static void Main() 
{
   Console.WriteLine("Enter the number to check palindrome :");
   int num = int.Parse(Console.ReadLine());
   int temp = num;
int rev=0,rem;
while(num!=0)
{
 rem = num%10;
rev = rev*10 + rem;
num/=10;
}
   if(temp == rev)
   {
     Console.WriteLine("Yes !! " + temp + " is Palindrome number");
    }
   else {
                   Console.WriteLine("Noo !! " + temp + " is not a Palindrome number");
    }
 }
}
