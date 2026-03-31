using System;
class chk
{
     public int a {get;set;}
     public int b{get; set;}
     public int sum
    {
        get{return a+b;}
    }    
}

class Test
{
    static void Main()
    {
        chk obj = new chk();
        obj.a=10;
        obj.b=5;

        Console.WriteLine("Sum of"+ obj.a+"and"+ obj.b+"="+obj.c);
    }
}