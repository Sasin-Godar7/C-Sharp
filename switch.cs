using System;

class Demo
{
    static void Main()
    {
        char grade;
        Console.WriteLine("Enter the grade(A/B/C/D/E)");
        grade = Convert.ToChar(Console.ReadLine().ToUpper());
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;
            case 'B':
                Console.WriteLine("Good");
                break;
            case 'C':
                Console.WriteLine("Fair");
                break;
            case 'D':
                Console.WriteLine("fail");
                break;
            default:
                Console.WriteLine("Invalid grade");
                break;
        }
    }
}