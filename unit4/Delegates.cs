public delegate int MyDelegate(int x);
class DeleteTest
{
    static int MyMethod(int x)
    {
        return x*x;
    }
    static void Main(string[] args)
    {
        MyDelegate md = new MyDelegate(MyMethod);
        int res = md(5);
        Console.WriteLine("Result = "+res);
        Console.ReadKey();
    }
}