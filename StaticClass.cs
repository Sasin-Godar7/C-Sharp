// 1 static members of class

// using System;
// class MyCollage
// {
//     public static string collagename;
//     public static string address;

//     static MyCollage()
//     {
//         collagename = "Lumbini ict campus";
//         address = "Gidakot, Nawalpur";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(MyCollage.collagename);
//         Console.WriteLine(MyCollage.address);
        
//     }
// }






using System;
static class Author
{
    public static string Fname = "Sasin";
    public static string Lname = "Godar";
    public static string Tno = 39;

    public static void details()
    {
        Console.WriteLine("The details of author is : ");
    }
}

public class GFG
{
    static public void Main()
    {
        Author.details();
        Console.WriteLine("Author Fname:{0}",Author.Fname);
        Console.WriteLine("Author Lname:{0}",Author.Lname);
        Console.WriteLine("Author Fname:{0}",Author.Tno);
    }
}