using System;
class ConsDes
{
    public ConsDes(string msg)
    {
        Console.WriteLine(msg);
    }
    public void Test()

    {
        Console.WriteLine("This is a simple method");
    }

    ~ ConsDes()
    {
        Console.WriteLine("This is a destructor :");
        Console.ReadKey();
    }
}

    class constructor
    {
        static void Main()

        {
            string m= "This is a constructor";
            ConsDes obj = new ConsDes(m);
            obj.Test();
            
        }    
    }
