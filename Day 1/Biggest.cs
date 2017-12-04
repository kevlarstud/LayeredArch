using System;
public class User
{
   public static void Main()
   {
      Console.WriteLine("Enter first number");
	  int fno=int.Parse(Console.ReadLine());
	  Console.WriteLine("Enter second number");
	  int sno=int.Parse(Console.ReadLine());
	  if(fno>sno)
	  {
	  Console.WriteLine(fno+ "is biggest");
	  }
	  else
	  {
	  Console.WriteLine(sno+ "is biggest");
	  }
	  
    }
}
