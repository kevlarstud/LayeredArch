using System;
public class Add
{
    public static void Main()
	{
	 Console.WriteLine("Enter the number 1");
	 int n1= int.Parse(Console.ReadLine());
	 Console.WriteLine("Enter the number 2");
	 int n2=Convert.ToInt32(Console.ReadLine());
	 Console.WriteLine("The addition of two numbers are:"+(n1+n2) );
	}
}