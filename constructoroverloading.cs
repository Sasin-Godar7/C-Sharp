using System;

class Employee
{
    public string Name;
     public int Age;
     public double Salary;

     //default constructor
     public Employee()
    {
        Name = "Unknown";
        Age = 0;
        Salary = 0.000;
    }

    // constructor with 2 parameters

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
        Salary = 0.0;
    }

    
    // constructor with 2 parameters

      public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void display()
    {
        Console.WriteLine($"Name : {Name} , Age :{Age}, Salary :{Salary}");
    }   
}



class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee("Sasin",21);
        Employee e3 = new Employee("Sasin",21,1900);

        e1.display();
        e2.display();
        e3.display();
    }
}