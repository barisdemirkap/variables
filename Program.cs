using System;

namespace operators
{
   class Program
   {
       static void Main(string[] args)
       {    Console.WriteLine("***** atama ve islemli atama Operatorler *****");
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
            Console.WriteLine("***** Mantiksal Operatorler *****");
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

            Console.WriteLine("***** iliskisel operatoreler *****");
            //iliskisel operatoreler
            // <, >, <=, >=, ==, !=

            int a= 3;
            int b= 4 ;
            bool result = a<b ;
            Console.WriteLine(result);
            result = a>b;
            Console.WriteLine(result);
            result = a>=b;
            Console.WriteLine(result);
            result = a<=b;
            Console.WriteLine(result);
            result = a==b;
            Console.WriteLine(result);
            result = a!=b;
            Console.WriteLine(result);
            
            
            Console.WriteLine("***** Artirmetik Operatorler *****");
            // Artirmetik Operatorler
            // /, *, +, -  

            int number1 = 10 ;
            int number2 = 5;
            int result1 = number1/number2 ;

            Console.WriteLine(result1);

            result1= number1*number2 ;
            Console.WriteLine(result1);
            
            result1= number1+number2 ;
            Console.WriteLine(result1);
            
            result1= number1-number2 ;
            Console.WriteLine(result1);


        Console.ReadLine(); 



                 

       } 


   }

}