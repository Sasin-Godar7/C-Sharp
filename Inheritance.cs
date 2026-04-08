// using System;
// class Polygon
// {
//     public int dim1,dim2;
//     public void ReadDimension(int dim1,int dim2)
//     {
//         this.dim1=dim1;
//         this.dim2=dim2;
//     }
// }
// class Rectangle:Polygon
// {
//     public void AreaRe()
//     {
//         int area=dim1*dim2;
//         Console.WriteLine("Area of Rectangle is "+area);
//     }
// }
// class Triangle:Polygon
// {
//     public void AreaTri()
//     {
//         int area=dim1*dim2/2;
//         Console.WriteLine("Area of Triangle is "+area);
//     }
// }
// class Hier
// {
//     static void Main()
//     {
//         Triangle r=new Triangle();
//         r.ReadDimension(10,20);
//         r.AreaTri();
//         Rectangle t=new Rectangle();
//         t.ReadDimension(10,20);
//         t.AreaRe();
//     }
// }


// Multiple Inheritence

// using System;
// interface I1
// {
//     int CalculateArea();
//     int CalculatePerimeter();
// }
// class CA
// {
//     public int l,b;
//     public void ReadData(int l,int b)
//     {
//         this.l=l;
//         this.b=b;
//     }
// }
// class BB:CA,I1
// {
//     public int CalculateArea()
//     {
//         ReadData(10,20);
//         return l*b;
//     }
//     public int CalculatePerimeter()
//     {
//         ReadData(10,20);
//         return 2*(l+b);
//     }
// }
// class Inter
// {
//     static void Main()
//     {
//         BB b=new BB();
//         Console.WriteLine("Area is "+b.CalculateArea());
//         Console.WriteLine("Perimeter is "+b.CalculatePerimeter());
//     }
// }











//design a interface IBank with methods deposit() and withdraw() . create a class Account thta implements the interface and perform basic banking operations based on the user input.

using System;

interface IBank
{
    int Deposit();
    int Withdraw();
}

class CA
{
    public int amount = 900;

    public void ReadAmount(int amount)
    {
        this.amount = amount;
    }
}

class BB : CA, IBank
{
    public int Deposit()
    {
        int depositAmt = 100;
        amount += depositAmt;   
        return amount;
    }

    public int Withdraw()
    {
        int withdrawAmt = 50;
        amount -= withdrawAmt;  
        return amount;
    }
}

class Account
{
    static void Main()
    {
        BB b = new BB();

        Console.WriteLine("Initial Amount: " + b.amount);
        Console.WriteLine("After Deposit: " + b.Deposit());
        Console.WriteLine("After Withdraw: " + b.Withdraw());
    }
}