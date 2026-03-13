
//------------multiplication table of given number----------------------------------

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any number:");
            int num= int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
int i;
for(i=1;i<=10;i++)
{
Console.WriteLine(num+ " x" + i + " =" +(num*i) );
  
}

        }
}