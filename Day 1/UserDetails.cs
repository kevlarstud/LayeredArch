using System;
public class User
{
   public static void Main()
   {
      Console.WriteLine("Enter the name");
	  string name=Console.ReadLine();
	  Console.WriteLine("Enter the Age");
	  int age=int.Parse(Console.ReadLine());
	  Console.WriteLine("Enter the Designation");
	  string des=Console.ReadLine();
	  Console.WriteLine("Enter the salary");
	  int sal=int.Parse(Console.ReadLine());
	  Console.WriteLine("Name:" +name +" "+ "Age:" +age +" "+ "Designation:"+des +" "+ "Salary:" +sal);
   
   
   }
}