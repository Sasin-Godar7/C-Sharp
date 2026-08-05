
//this keyword le current class ko object lai refer garxa.

using System;
class Employee
{
    
    string name;
    public Employee(string name)
    {
        this.name = name;
        
    }

    public void display()
    {
        Console.Write("the name is :::"+ this.name);
    }

    static void Main()
    {
        Employee e = new Employee("sasin");
        e.display();
    }
}