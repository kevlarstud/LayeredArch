using System;
public class Armstrong
{
            public static void Main()
              {
                  Console.WriteLine("Enter a number:");
				  int number=int.Parse(Console.ReadLine());
				  int originalNumber =  number;
                  int result=0;				      
	            while (originalNumber > 0)
               {
                     int remainder = originalNumber%10;
                     result =result + (remainder*remainder*remainder);
                     originalNumber =originalNumber/ 10;
                }
                 if(result==number)
                 Console.WriteLine("Armstrong Number");
	             else
	             Console.WriteLine("Not an Armstrong Number");	  
              }
}