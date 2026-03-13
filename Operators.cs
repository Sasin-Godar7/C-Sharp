// ----------------WAP for the demonstration of conditional operator & miscellaneous operators-----------------

using System;
class Miscoperator
{
   static void Main()
{
      Console.WriteLine("Size of int: "+sizeof(int));
      Console.WriteLine("Size of double: "+sizeof(double));

//type of operator
  Type t = typeof(string);
 Console.WriteLine("Type of string: "+t);

// is a operator 
object num = 50;
if(num is int)
{
   Console.WriteLine("num is an integer");
}

//conditional / ternary operator ?
int a = 20,b=90;
int max = (a>b)? a:b;
Console.WriteLine("Maximum value is "+max);
}
}  
