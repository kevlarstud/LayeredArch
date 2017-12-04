using System;
using MathLib;
public class Calculator
{
          public static void Main()
          {
		  Console.WriteLine("Enter first number ");
		  int firstno= int.Parse(Console.ReadLine());
		  
		  Console.WriteLine("Enter ssecond number ");
		  int secondno= int.Parse(Console.ReadLine());
		  
          int result = MathClass.Add(firstno,secondno);		
          Console.WriteLine("Addition is:" +result);		  
          }		  
}