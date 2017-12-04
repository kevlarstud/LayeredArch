using System;
public class Demo
{
            public static void Main()
              {
                  Console.WriteLine("Enter the numbers");
				  int fno=int.Parse(Console.ReadLine());
	              Console.WriteLine("Enter second number");
                  int sno=int.Parse(Console.ReadLine());
				  int res=(fno>sno ? fno:sno); 
				  Console.WriteLine("Biggest number is" +res);
	  
				  
              }
}