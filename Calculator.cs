//------------basic calculation of given number----------------------------------
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string a = Console.ReadLine();  
        int num1 = int.Parse(a);

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

                 int sum = num1 + num2;
        Console.WriteLine("The sum is " + sum); 

              int diff = num1-num2;
     Console.WriteLine("The difference is " + diff);

     int mul = num1*num2;
     Console.WriteLine("The product is " + mul);

           int div = num1/num2;
     Console.WriteLine("The division  is " + div);

    }
}  
