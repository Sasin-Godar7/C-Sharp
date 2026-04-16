// generic  classes----------------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// syntax : public class TestClass<Tr> { }
// each collection are found under System.collection.Generic.namespace 
// generic class
// ----------------------
// Collection <T>
// List<T>
// Queue<T>
// Stack<T>
// Dictionary<Tkey,ValueTask>






// using System.Collections.Generic;
// class Test<T>
// {
//     T[] t = new T[5];
//     int c=0;

//     public void addItem(T item)
//     {
//         if(c<5)
//         {
//             t[c] = item;
//             c++;
//         }
//         else
//         {
//             Console.WriteLine("Overflow exists");
//         }
//     }

//     public void display()
//     {
//         for(int i=0;i<c;i++)
//         {
//             Console.WriteLine("Item at index{0} is {1}",i,t[i]);
//         }
//     }
// }



// class GenericEg
// {
//     static void Main()
//     {
//         Test<int> obj = new Test<int>();
//         obj.addItem(20);
//         obj.addItem(30);
//         obj.addItem(40);
//         obj.addItem(50);
//         obj.addItem(60);

//         // obj.addItem(20);        overflow exists as no index 6

//         obj.display();
//         // Console.ReadKey();

//     }
// }







// Dictionary----------------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// using System.Collections.Generic;
// public  class Program
// {
//     static void Main(string[] args)
//     {
//         Dictionary<int,string> dobj = new Dictionary<int, string>(5);
//         dobj.Add(1,"Sasin");
//         dobj.Add(2,"Ashok");
//         dobj.Add(3,"prabin");
//         dobj.Add(4,"abin");
//         dobj.Add(5,"anuj");

//         for(int i=1;i<=dobj.Count;i++)
//         {
//             Console.WriteLine(dobj[i]);
//         }
//         Console.ReadKey();
//     }
// }



// Queue---------------------->>>>>>>>>>

// enqueue()-- to add
// dequeue()-- to remove
// peek()---from start like rewind

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Queue<string> queue1 = new Queue<string>();
//         queue1.Enqueue("mca");
//         queue1.Enqueue("bca");
//         queue1.Enqueue("csit");
//         queue1.Enqueue("bhm");
//         queue1.Enqueue("bim");

//          Console.WriteLine("Elements in queue are:");
//          foreach(string s in queue1)
//         {
//             Console.WriteLine(s);
//         }
//         queue1.Dequeue();
//         queue1.Dequeue();

//         Console.WriteLine("Elements in queue are :");
//         foreach(string s in queue1)
//         {
//             Console.WriteLine(s);
//         }

//     }
// }







// Stack--------------?>>>>>>>>>>>
// push()
// pop()

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Stack<string> stack1 = new Stack<string>();
//         stack1.Push("mca");
//         stack1.Push("bca");
//         stack1.Push("csit");
//         stack1.Push("bim");
//         stack1.Push("bhm");

//          Console.WriteLine("Elements in stack are:");
//          foreach(string s in stack1)
//         {
//             Console.WriteLine(s);
//         }
//         stack1.Pop();
//         stack1.Pop();

//         Console.WriteLine("Elements in stack are :");
//         foreach(string s in stack1)
//         {
//             Console.WriteLine(s);
//         }

//     }
// }




// List ----------------->>>>>>>>>>>
// add()
// remove()


// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> li = new List<int>();
//         li.Add(10);
//         li.Add(2);
//         li.Add(4);
//         li.Add(88);
//         li.Add(1);

//          Console.WriteLine("Elements in list are:");
//          foreach(int l in li)
//         {
//             Console.WriteLine(l);
//         }
//         li.Remove(2);
//         li.Sort();

//         Console.WriteLine("Elements in list are :");
//         foreach(int l in li)
//         {
//             Console.WriteLine(l);
//         }



//     }
// }







// ArrayList------------------------------------------------->>>>>>>>>>

// nongenric collection
// ArrayList al = new ArrayList();   // kun type ko ho vanera determine garna parena like <int>,<string>

// Add()
// Remove()
// RemoveAt(3)
// Clear()
// Sort()
// Insert(1,"SASIN")
// Count()
