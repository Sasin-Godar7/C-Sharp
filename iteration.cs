
//wap to print prime number upto 50 using for loop
//  using System;
//     class primecheck
//     {
//         static void Main()
//         {
//         int i,num;
      
//         for(num =2;num<=50;num++)
//         {
//             bool isprime = true;
//             for(i=2;i<num;i++)
//             {
//                 if(num%i==0)
//                 {
//                     isprime = false;
//                     break;
//                 }
//             }
//             if(isprime)
//             {
//                 Console.WriteLine(num);
//             }
//         }
        
        
//     }
//     }





//wap to print odd number upto 50 using while loop

 using System;
    class oddcheck()
    {
        static void Main()
        {
        int i=1;

        while(i<=50)
        {
            if(i%2!=0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
     }
    }
        
    
