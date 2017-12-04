using System;
public class Demo
{
            public static void Main()
              {
                  Console.WriteLine("Enter the starting element:");
				  int numb1=int.Parse(Console.ReadLine());
				  Console.WriteLine("Enter the length:");
				  int len=int.Parse(Console.ReadLine());
				  Console.WriteLine("Fibonacci Series:");
				  int n2=1;
				  for(int i =0;i<=len;i++)
				  {
				   int sum=numb1+n2;
				   numb1=n2;
				   n2=sum;
				   Console.WriteLine(sum);
				  }
			
              }
}