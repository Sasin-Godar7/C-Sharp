using System;

class Student
{
    public int id,age;
    public string name,subject;
           
           public Student(int id, string name, int age, string subject)
    {
         this.id=id;
        this.name = name ;
        this.age= age;
        this.subject= subject;
    }

    public void display()
    {
        Console.WriteLine($"ID :{ id},Name :{name},age :{age}, Subject :{subject} ");
    }


    static void Main(string[] args)
    {
        Student st = new Student(1,"sasin",21,"dotnet");
        st.display();
        Console.ReadKey();
    }
}