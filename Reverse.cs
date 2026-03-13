

//------------Reverse  of given number----------------------------------

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any number to reverse:");
            int num= int.Parse(Console.ReadLine());
            int og = num;
int rem,rev=0;
while(num!=0)
{
   rem = num%10;
  rev = rev * 10 + rem;
   num/=10;
}
Console.WriteLine("The reverse of "+ og+" is" +  rev);

        }
}
