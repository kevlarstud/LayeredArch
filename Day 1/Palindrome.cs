using System;
public class User
{
   public static void Main()
   {
      Console.WriteLine("Enter the string");
	  string a=Console.ReadLine();
	  string result="";
	  for(int i=a.Length-1; i>=0;--i)
	  {
	  result= result+a[i];
	  }
	  if(result==a)
	  {
	  Console.WriteLine("Palindrome");
	  }
	  else
	  {
	  Console.WriteLine("Not a Palindrome");
	  }
	  
	  
    }
}