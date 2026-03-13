// ----------------------------------------------------Array-------------------------------

/*Rectangular array --------------

using System;
class Rectangle
{
   static void Main(string[] args)
{  
   int[ , ] vals = new int[4,2]
{ 
    {2,3},
   {3,5},
  {9,99},
  {5 ,82}
};

for(int i=0;i<4;i++)
{
   Console.WriteLine("\n");
      for(int j=0;j<2;j++)
       {
         Console.WriteLine(vals[i , j]);
       
         }

}
Console.ReadKey();

  }
}
*/

//jagged array --------------

using System;
class Jagged
{
   static void Main(string[] args)
{  
    int [] [] jagged = new int [] [] 
     {
      new int[] {1,2},
      new int[] {1,2,3},
      new int[] {1,2,3,4}
    };

    foreach(int[] array in jagged)
      {
         foreach(int e in array)
         {
            Console.WriteLine(e + " ");
         }
         Console.Write("\n");
      }
         Console.ReadKey();

}
       

  }