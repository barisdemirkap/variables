using System;

namespace operators
{
   class Program
   {
       static void Main(string[] args)
       {
           //atama ve islemli atama
           int x= 3;
           int y= 3 ;
           y=y+2 ;
            Console.WriteLine(y);
           y +=2;
            Console.WriteLine(y);
           y/=1 ;
           Console.WriteLine(y);
           x*=2 ;
           Console.WriteLine(x);

           //Mantiksal Operatorler
           // ||,&&, !

           bool isSuccess = true;
           bool isCompleted = false ;

           if(isSuccess&&isCompleted)
                Console.WriteLine("Perfect!!");
           if(isSuccess||isCompleted)
                Console.WriteLine("Great!!");
           if(isSuccess&& !isCompleted)
                Console.WriteLine("Fine!!");


                 

       } 


   }

}