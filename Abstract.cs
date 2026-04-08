// abstract use bcz of multiple inheritance not supported and delclaration only
// this is create object of its own.....

/* abstract class=---------------------->>>>

using System;
abstract class men
{
    public int add(int a,int b)
    {
        return(a+b);
    }
}

class men1 : men
{
    public int mul(int a, int b)
    {
        return(a*b);
    }
}

class Test
{
    static void Main(string[] args)
    {
        men1 obj = new men1();
        int  a= obj.add(2,3);
        int  m= obj.add(2,3);
        Console.WriteLine("Result ={0}",a);
        Console.WriteLine("Result ={0}",m);
    }
}
*/


// abstract method=---------------------->>>>
