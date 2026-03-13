//------------Value vs Refrence----------------------------------

using System;
class Test
{
         public int x ;
}
class program
{
static void Main()
{
     //value type example
int a = 10;
 int b = a;
b=20;
Console.WriteLine("Value type");
Console.WriteLine("a = "+a);
Console.WriteLine("b = "+b);

  //refrence type example
 Test t1 = new Test();
t1.x = 10;

Test t2 = t1;
t2.x = 20;
Console.WriteLine("Refrence Type");
Console.WriteLine("t1.x = "+t1.x);
Console.WriteLine("t2.x= "+t2.x);
}
}
